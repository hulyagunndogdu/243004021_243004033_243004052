namespace HastaneSistemi
{
    partial class Form1
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
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.textBoxKullanici = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKayitAc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxRol.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Hasta",
            "Doktor",
            "Admin"});
            this.comboBoxRol.Location = new System.Drawing.Point(366, 174);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 33);
            this.comboBoxRol.TabIndex = 0;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiris.Location = new System.Drawing.Point(366, 357);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 48);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // textBoxKullanici
            // 
            this.textBoxKullanici.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxKullanici.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullanici.Location = new System.Drawing.Point(366, 231);
            this.textBoxKullanici.Name = "textBoxKullanici";
            this.textBoxKullanici.Size = new System.Drawing.Size(121, 31);
            this.textBoxKullanici.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(366, 287);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(121, 31);
            this.textBoxSifre.TabIndex = 4;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(212, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // buttonKayitAc
            // 
            this.buttonKayitAc.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonKayitAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayitAc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitAc.ForeColor = System.Drawing.Color.White;
            this.buttonKayitAc.Location = new System.Drawing.Point(217, 357);
            this.buttonKayitAc.Name = "buttonKayitAc";
            this.buttonKayitAc.Size = new System.Drawing.Size(121, 50);
            this.buttonKayitAc.TabIndex = 7;
            this.buttonKayitAc.Text = "Kayıt Ol";
            this.buttonKayitAc.UseVisualStyleBackColor = false;
            this.buttonKayitAc.Click += new System.EventHandler(this.buttonKayitAc_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.linkSifremiUnuttum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxRol);
            this.panel1.Controls.Add(this.buttonKayitAc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.textBoxSifre);
            this.panel1.Controls.Add(this.textBoxKullanici);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(178, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 490);
            this.panel1.TabIndex = 8;
            // 
            // linkSifremiUnuttum
            // 
            this.linkSifremiUnuttum.AutoSize = true;
            this.linkSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.linkSifremiUnuttum.Location = new System.Drawing.Point(317, 436);
            this.linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            this.linkSifremiUnuttum.Size = new System.Drawing.Size(99, 16);
            this.linkSifremiUnuttum.TabIndex = 12;
            this.linkSifremiUnuttum.TabStop = true;
            this.linkSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifremiUnuttum_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(231, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "RANDEVU SİSTEMİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(212, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kullanıcı Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(157, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "BEYŞEHİR DEVLET HASTANESİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 646);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox textBoxKullanici;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKayitAc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkSifremiUnuttum;
    }
}

