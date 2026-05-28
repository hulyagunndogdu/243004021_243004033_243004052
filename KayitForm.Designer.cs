namespace HastaneSistemi
{
    partial class KayitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnGiriseDon = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HastaDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(173, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(173, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre :";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(328, 422);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(121, 51);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnGiriseDon
            // 
            this.btnGiriseDon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGiriseDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiriseDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriseDon.Location = new System.Drawing.Point(584, 422);
            this.btnGiriseDon.Name = "btnGiriseDon";
            this.btnGiriseDon.Size = new System.Drawing.Size(130, 51);
            this.btnGiriseDon.TabIndex = 6;
            this.btnGiriseDon.Text = "Girişe Dön";
            this.btnGiriseDon.UseVisualStyleBackColor = false;
            this.btnGiriseDon.Click += new System.EventHandler(this.btnGiriseDon_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(328, 355);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(180, 31);
            this.textBoxSifre.TabIndex = 5;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTC.Location = new System.Drawing.Point(328, 305);
            this.textBoxTC.MaxLength = 11;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(180, 31);
            this.textBoxTC.TabIndex = 5;
            this.textBoxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTC_KeyPress);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(328, 155);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(180, 31);
            this.textBoxSoyad.TabIndex = 4;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(328, 105);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(180, 31);
            this.textBoxAd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(173, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cinsiyet :";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(328, 205);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(180, 33);
            this.comboBoxCinsiyet.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(171, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // HastaDogumTarihi
            // 
            this.HastaDogumTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaDogumTarihi.Location = new System.Drawing.Point(328, 255);
            this.HastaDogumTarihi.Name = "HastaDogumTarihi";
            this.HastaDogumTarihi.Size = new System.Drawing.Size(266, 31);
            this.HastaDogumTarihi.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnGiriseDon);
            this.panel1.Controls.Add(this.btnKayit);
            this.panel1.Controls.Add(this.HastaDogumTarihi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSifre);
            this.panel1.Controls.Add(this.comboBoxCinsiyet);
            this.panel1.Controls.Add(this.textBoxTC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxSoyad);
            this.panel1.Controls.Add(this.textBoxAd);
            this.panel1.Location = new System.Drawing.Point(139, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 490);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(273, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 46);
            this.label7.TabIndex = 12;
            this.label7.Text = "HASTA KAYIT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 685);
            this.panel2.TabIndex = 12;
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 685);
            this.Controls.Add(this.panel2);
            this.Name = "KayitForm";
            this.Text = "KayitForm";
            this.Load += new System.EventHandler(this.KayitForm_Load);
            this.Resize += new System.EventHandler(this.KayitForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGiriseDon;
        private System.Windows.Forms.DateTimePicker HastaDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}