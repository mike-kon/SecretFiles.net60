namespace SecretFiles
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnKeyGen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.EdFileName = new System.Windows.Forms.TextBox();
            this.EdPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCryptPub = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDecryptSecret = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdMethod = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnExportPublicKey = new System.Windows.Forms.Button();
            this.BtnCert = new System.Windows.Forms.Button();
            this.EdCertificate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKeyGen
            // 
            this.BtnKeyGen.Location = new System.Drawing.Point(15, 14);
            this.BtnKeyGen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnKeyGen.Name = "BtnKeyGen";
            this.BtnKeyGen.Size = new System.Drawing.Size(240, 27);
            this.BtnKeyGen.TabIndex = 0;
            this.BtnKeyGen.Text = "Сгенерировать пару secret/pub";
            this.BtnKeyGen.UseVisualStyleBackColor = true;
            this.BtnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnOpenFile);
            this.groupBox1.Controls.Add(this.EdFileName);
            this.groupBox1.Location = new System.Drawing.Point(15, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(565, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenFile.Location = new System.Drawing.Point(525, 20);
            this.BtnOpenFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(33, 27);
            this.BtnOpenFile.TabIndex = 1;
            this.BtnOpenFile.Text = "...";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // EdFileName
            // 
            this.EdFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdFileName.Location = new System.Drawing.Point(8, 23);
            this.EdFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdFileName.Name = "EdFileName";
            this.EdFileName.Size = new System.Drawing.Size(509, 23);
            this.EdFileName.TabIndex = 0;
            // 
            // EdPassword
            // 
            this.EdPassword.Location = new System.Drawing.Point(66, 58);
            this.EdPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdPassword.Name = "EdPassword";
            this.EdPassword.PasswordChar = '*';
            this.EdPassword.Size = new System.Drawing.Size(171, 23);
            this.EdPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnCryptPub);
            this.groupBox2.Location = new System.Drawing.Point(13, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(569, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шифрование";
            // 
            // BtnCryptPub
            // 
            this.BtnCryptPub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCryptPub.Location = new System.Drawing.Point(8, 30);
            this.BtnCryptPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCryptPub.Name = "BtnCryptPub";
            this.BtnCryptPub.Size = new System.Drawing.Size(554, 27);
            this.BtnCryptPub.TabIndex = 0;
            this.BtnCryptPub.Text = "Зашифровать";
            this.BtnCryptPub.UseVisualStyleBackColor = true;
            this.BtnCryptPub.Click += new System.EventHandler(this.BtnCryptPub_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BtnDecryptSecret);
            this.groupBox3.Location = new System.Drawing.Point(14, 312);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(566, 67);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дешифрация";
            // 
            // BtnDecryptSecret
            // 
            this.BtnDecryptSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDecryptSecret.Location = new System.Drawing.Point(7, 22);
            this.BtnDecryptSecret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDecryptSecret.Name = "BtnDecryptSecret";
            this.BtnDecryptSecret.Size = new System.Drawing.Size(551, 27);
            this.BtnDecryptSecret.TabIndex = 0;
            this.BtnDecryptSecret.Text = "Дешифровать";
            this.BtnDecryptSecret.UseVisualStyleBackColor = true;
            this.BtnDecryptSecret.Click += new System.EventHandler(this.BtnDecryptSecret_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.EdLog);
            this.groupBox4.Location = new System.Drawing.Point(15, 385);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(570, 275);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Лог";
            // 
            // EdLog
            // 
            this.EdLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdLog.Location = new System.Drawing.Point(4, 19);
            this.EdLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdLog.Size = new System.Drawing.Size(562, 253);
            this.EdLog.TabIndex = 0;
            this.EdLog.WordWrap = false;
            // 
            // EdMethod
            // 
            this.EdMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdMethod.Items.Add("X509Certificate2 (selfsigned)");
            this.EdMethod.Location = new System.Drawing.Point(392, 17);
            this.EdMethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdMethod.Name = "EdMethod";
            this.EdMethod.Size = new System.Drawing.Size(186, 23);
            this.EdMethod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Метод шифрации";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnExportPublicKey);
            this.groupBox5.Controls.Add(this.EdPassword);
            this.groupBox5.Controls.Add(this.BtnCert);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.EdCertificate);
            this.groupBox5.Location = new System.Drawing.Point(18, 58);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(565, 92);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Файл с ключем";
            // 
            // BtnExportPublicKey
            // 
            this.BtnExportPublicKey.Location = new System.Drawing.Point(282, 54);
            this.BtnExportPublicKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExportPublicKey.Name = "BtnExportPublicKey";
            this.BtnExportPublicKey.Size = new System.Drawing.Size(170, 27);
            this.BtnExportPublicKey.TabIndex = 4;
            this.BtnExportPublicKey.Text = "Выгрузка Сертификата";
            this.BtnExportPublicKey.UseVisualStyleBackColor = true;
            this.BtnExportPublicKey.Click += new System.EventHandler(this.BtnExportPublicKey_Click);
            // 
            // BtnCert
            // 
            this.BtnCert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCert.Location = new System.Drawing.Point(525, 20);
            this.BtnCert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCert.Name = "BtnCert";
            this.BtnCert.Size = new System.Drawing.Size(31, 27);
            this.BtnCert.TabIndex = 1;
            this.BtnCert.Text = "...";
            this.BtnCert.UseVisualStyleBackColor = true;
            this.BtnCert.Click += new System.EventHandler(this.BtnCert_Click);
            // 
            // EdCertificate
            // 
            this.EdCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdCertificate.Location = new System.Drawing.Point(10, 22);
            this.EdCertificate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdCertificate.Name = "EdCertificate";
            this.EdCertificate.Size = new System.Drawing.Size(507, 23);
            this.EdCertificate.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 674);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdMethod);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnKeyGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ассинхронный ключ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKeyGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.TextBox EdFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCryptPub;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDecryptSecret;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown EdMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCert;
        private System.Windows.Forms.TextBox EdCertificate;
        private System.Windows.Forms.Button BtnExportPublicKey;
    }
}

