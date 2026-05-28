namespace HastaneSistemi
{
    partial class DoktorEkle
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
            this.DoktorDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.pictureDoktor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEgitim = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSicilNo = new System.Windows.Forms.TextBox();
            this.lblBaslamaTarihi = new System.Windows.Forms.Label();
            this.dtpBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoktor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoktorDogumTarihi
            // 
            this.DoktorDogumTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorDogumTarihi.Location = new System.Drawing.Point(224, 355);
            this.DoktorDogumTarihi.Name = "DoktorDogumTarihi";
            this.DoktorDogumTarihi.Size = new System.Drawing.Size(191, 30);
            this.DoktorDogumTarihi.TabIndex = 0;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(300, 102);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(191, 30);
            this.textBoxAd.TabIndex = 3;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(300, 142);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(191, 30);
            this.textBoxSoyad.TabIndex = 4;
            // 
            // pictureDoktor
            // 
            this.pictureDoktor.Location = new System.Drawing.Point(46, 97);
            this.pictureDoktor.Name = "pictureDoktor";
            this.pictureDoktor.Size = new System.Drawing.Size(120, 150);
            this.pictureDoktor.TabIndex = 5;
            this.pictureDoktor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Soyad  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(210, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "*Branş  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "*Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(204, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cinsiyet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(37, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Eğitim :";
            // 
            // textBoxEgitim
            // 
            this.textBoxEgitim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEgitim.Location = new System.Drawing.Point(224, 472);
            this.textBoxEgitim.Name = "textBoxEgitim";
            this.textBoxEgitim.Size = new System.Drawing.Size(191, 30);
            this.textBoxEgitim.TabIndex = 14;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(224, 395);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(191, 30);
            this.textBoxSifre.TabIndex = 16;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(208, 596);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 57);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimSec.ForeColor = System.Drawing.Color.Black;
            this.btnResimSec.Location = new System.Drawing.Point(41, 253);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(125, 37);
            this.btnResimSec.TabIndex = 18;
            this.btnResimSec.Text = "Fotoğraf Seç";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(300, 222);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(191, 31);
            this.comboBoxBrans.TabIndex = 19;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(300, 182);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(191, 31);
            this.comboBoxCinsiyet.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(41, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(419, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "* ile belirtilen alanların doldurulması zorunludur.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(33, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "*Sicil No :";
            // 
            // textBoxSicilNo
            // 
            this.textBoxSicilNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSicilNo.Location = new System.Drawing.Point(224, 308);
            this.textBoxSicilNo.Name = "textBoxSicilNo";
            this.textBoxSicilNo.Size = new System.Drawing.Size(191, 30);
            this.textBoxSicilNo.TabIndex = 23;
            // 
            // lblBaslamaTarihi
            // 
            this.lblBaslamaTarihi.AutoSize = true;
            this.lblBaslamaTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslamaTarihi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslamaTarihi.Location = new System.Drawing.Point(37, 435);
            this.lblBaslamaTarihi.Name = "lblBaslamaTarihi";
            this.lblBaslamaTarihi.Size = new System.Drawing.Size(166, 23);
            this.lblBaslamaTarihi.TabIndex = 24;
            this.lblBaslamaTarihi.Text = "Mesleğe Başlangıç :";
            // 
            // dtpBaslamaTarihi
            // 
            this.dtpBaslamaTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslamaTarihi.Location = new System.Drawing.Point(224, 431);
            this.dtpBaslamaTarihi.Name = "dtpBaslamaTarihi";
            this.dtpBaslamaTarihi.Size = new System.Drawing.Size(191, 30);
            this.dtpBaslamaTarihi.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureDoktor);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpBaslamaTarihi);
            this.panel1.Controls.Add(this.btnResimSec);
            this.panel1.Controls.Add(this.textBoxEgitim);
            this.panel1.Controls.Add(this.lblBaslamaTarihi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSicilNo);
            this.panel1.Controls.Add(this.textBoxAd);
            this.panel1.Controls.Add(this.textBoxSifre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSoyad);
            this.panel1.Controls.Add(this.comboBoxBrans);
            this.panel1.Controls.Add(this.comboBoxCinsiyet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DoktorDogumTarihi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(194, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 662);
            this.panel1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(131, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 50);
            this.label12.TabIndex = 26;
            this.label12.Text = "DOKTOR EKLE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 677);
            this.panel2.TabIndex = 26;
            // 
            // DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 677);
            this.Controls.Add(this.panel2);
            this.Name = "DoktorEkle";
            this.Text = "DoktorEkle";
            this.Load += new System.EventHandler(this.DoktorEkle_Load);
            this.Resize += new System.EventHandler(this.DoktorEkle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoktor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DoktorDogumTarihi;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.PictureBox pictureDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEgitim;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSicilNo;
        private System.Windows.Forms.Label lblBaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslamaTarihi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
    }
}