using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;
using TCrypter.Properties;
using System.Runtime.InteropServices;

namespace TCrypter
{
    public partial class Form1 : Form
    {
        static string PasswordHash = "";
        static string SaltKey = "adf30f92fjfpw2adf30f92fjfpw2f39a";
        static string VIKey = "adf30f92fjfpw2ad";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputBox.Text = "Input";
            outputBox.Text = "Output";
            keyBox.Text = "Encryption Key";
        }

        //Simple Methode zum bewegen des Fensters ohne den Rahmen
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        private void load_txt_MouseHover(object sender, EventArgs e)
        {
            load_txt.Image = Resources.load_a;
        }

        private void load_txt_MouseLeave(object sender, EventArgs e)
        {
            load_txt.Image = Resources.load_b;
        }

        private void load_txt_Click(object sender, EventArgs e)
        {
            Stream txtStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((txtStream = openFileDialog.OpenFile()) != null)
                {
                    String strfile = openFileDialog.FileName;
                    inputBox.Text = File.ReadAllText(strfile, Encoding.Default);
                }
            }
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.Image = Resources.close_a;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Resources.close_b;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_MouseHover(object sender, EventArgs e)
        {
            save.Image = Resources.save_a;
        }

        private void save_MouseLeave(object sender, EventArgs e)
        {
            save.Image = Resources.save_b;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(outputBox.Text);
                }
            }
        }

        private void encryption_MouseHover(object sender, EventArgs e)
        {
            encryption.Image = Resources.encrypt_a;
        }

        private void encryption_MouseLeave(object sender, EventArgs e)
        {
            encryption.Image = Resources.encrypt_b;
        }

        private void encryption_Click(object sender, EventArgs e)
        {
            PasswordHash = keyBox.Text;
            outputBox.Text = Encrypt(inputBox.Text);
        }

        private void decryption_MouseHover(object sender, EventArgs e)
        {
            decryption.Image = Resources.decrypt_a;
        }

        private void decryption_MouseLeave(object sender, EventArgs e)
        {
            decryption.Image = Resources.decrypt_b;
        }

        private void decryption_Click(object sender, EventArgs e)
        {
            PasswordHash = keyBox.Text;
            outputBox.Text = Decrypt(inputBox.Text);
        }
    }
}

