namespace HastaneSistemi
{
    partial class SifreSifirla
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
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullanici = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSifreGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreGuncelle.Location = new System.Drawing.Point(322, 373);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(179, 60);
            this.btnSifreGuncelle.TabIndex = 0;
            this.btnSifreGuncelle.Text = "Şifremi Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = false;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(322, 285);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(179, 34);
            this.textBoxSifre.TabIndex = 1;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // textBoxKullanici
            // 
            this.textBoxKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullanici.Location = new System.Drawing.Point(322, 212);
            this.textBoxKullanici.MaxLength = 11;
            this.textBoxKullanici.Name = "textBoxKullanici";
            this.textBoxKullanici.Size = new System.Drawing.Size(179, 34);
            this.textBoxKullanici.TabIndex = 2;
            this.textBoxKullanici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKullanici_KeyPress);
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.BackColor = System.Drawing.Color.Transparent;
            this.labelTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.Location = new System.Drawing.Point(145, 215);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(155, 28);
            this.labelTC.TabIndex = 3;
            this.labelTC.Text = "T.C. Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(145, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(197, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "ŞİFRE SIFIRLAMA";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(322, 146);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(179, 36);
            this.comboBoxRol.TabIndex = 6;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(145, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kullanıcı Türü :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSifreGuncelle);
            this.panel1.Controls.Add(this.textBoxSifre);
            this.panel1.Controls.Add(this.textBoxKullanici);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxRol);
            this.panel1.Controls.Add(this.labelTC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(163, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 640);
            this.panel2.TabIndex = 9;
            // 
            // SifreSifirla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 640);
            this.Controls.Add(this.panel2);
            this.Name = "SifreSifirla";
            this.Text = "SifreSifirla";
            this.Load += new System.EventHandler(this.SifreSifirla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullanici;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}