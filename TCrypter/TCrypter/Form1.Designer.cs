namespace TCrypter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.keyBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.load_txt = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.encryption = new System.Windows.Forms.PictureBox();
            this.decryption = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.load_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 416);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(776, 20);
            this.keyBox.TabIndex = 0;
            this.keyBox.Text = "Key";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(385, 398);
            this.inputBox.TabIndex = 9;
            this.inputBox.Text = "Input";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(403, 12);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(385, 398);
            this.outputBox.TabIndex = 4;
            this.outputBox.Text = "Output";
            // 
            // load_txt
            // 
            this.load_txt.BackColor = System.Drawing.Color.Transparent;
            this.load_txt.Image = ((System.Drawing.Image)(resources.GetObject("load_txt.Image")));
            this.load_txt.Location = new System.Drawing.Point(12, 442);
            this.load_txt.Name = "load_txt";
            this.load_txt.Size = new System.Drawing.Size(119, 26);
            this.load_txt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.load_txt.TabIndex = 10;
            this.load_txt.TabStop = false;
            this.load_txt.Click += new System.EventHandler(this.load_txt_Click);
            this.load_txt.MouseLeave += new System.EventHandler(this.load_txt_MouseLeave);
            this.load_txt.MouseHover += new System.EventHandler(this.load_txt_MouseHover);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(137, 442);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(119, 26);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.save.TabIndex = 10;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseLeave += new System.EventHandler(this.save_MouseLeave);
            this.save.MouseHover += new System.EventHandler(this.save_MouseHover);
            // 
            // encryption
            // 
            this.encryption.BackColor = System.Drawing.Color.Transparent;
            this.encryption.Image = ((System.Drawing.Image)(resources.GetObject("encryption.Image")));
            this.encryption.Location = new System.Drawing.Point(337, 442);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(119, 26);
            this.encryption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.encryption.TabIndex = 10;
            this.encryption.TabStop = false;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            this.encryption.MouseLeave += new System.EventHandler(this.encryption_MouseLeave);
            this.encryption.MouseHover += new System.EventHandler(this.encryption_MouseHover);
            // 
            // decryption
            // 
            this.decryption.BackColor = System.Drawing.Color.Transparent;
            this.decryption.Image = ((System.Drawing.Image)(resources.GetObject("decryption.Image")));
            this.decryption.Location = new System.Drawing.Point(462, 442);
            this.decryption.Name = "decryption";
            this.decryption.Size = new System.Drawing.Size(119, 26);
            this.decryption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.decryption.TabIndex = 10;
            this.decryption.TabStop = false;
            this.decryption.Click += new System.EventHandler(this.decryption_Click);
            this.decryption.MouseLeave += new System.EventHandler(this.decryption_MouseLeave);
            this.decryption.MouseHover += new System.EventHandler(this.decryption_MouseHover);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(669, 442);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(119, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.close.TabIndex = 10;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.close);
            this.Controls.Add(this.decryption);
            this.Controls.Add(this.encryption);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load_txt);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.keyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "TCrypter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.load_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox keyBox;
        public System.Windows.Forms.RichTextBox inputBox;
        public System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.PictureBox load_txt;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox encryption;
        private System.Windows.Forms.PictureBox decryption;
        private System.Windows.Forms.PictureBox close;
    }
}

