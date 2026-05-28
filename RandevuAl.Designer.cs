namespace HastaneSistemi
{
    partial class RandevuAlForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPoliklinik = new System.Windows.Forms.ComboBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.panelSaat = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblEgitim = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.panelDoktor = new System.Windows.Forms.Panel();
            this.lblBaslamaTarihi = new System.Windows.Forms.Label();
            this.pictureDoktor = new System.Windows.Forms.PictureBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.dgvYorumlar = new System.Windows.Forms.DataGridView();
            this.lblPuan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHastaPaneleDon = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDoktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Poliklinik:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Doktor:";
            // 
            // comboBoxPoliklinik
            // 
            this.comboBoxPoliklinik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPoliklinik.FormattingEnabled = true;
            this.comboBoxPoliklinik.Location = new System.Drawing.Point(121, 33);
            this.comboBoxPoliklinik.Name = "comboBoxPoliklinik";
            this.comboBoxPoliklinik.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPoliklinik.TabIndex = 2;
            this.comboBoxPoliklinik.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoliklinik_SelectedIndexChanged);
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(121, 76);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(121, 31);
            this.comboBoxDoktor.TabIndex = 3;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // panelSaat
            // 
            this.panelSaat.AutoScroll = true;
            this.panelSaat.BackColor = System.Drawing.Color.White;
            this.panelSaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaat.Location = new System.Drawing.Point(32, 119);
            this.panelSaat.Name = "panelSaat";
            this.panelSaat.Size = new System.Drawing.Size(493, 397);
            this.panelSaat.TabIndex = 4;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(135, 15);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(79, 20);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(135, 55);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(53, 20);
            this.lblBrans.TabIndex = 6;
            this.lblBrans.Text = "Branş:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(135, 95);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(68, 20);
            this.lblCinsiyet.TabIndex = 7;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblEgitim
            // 
            this.lblEgitim.AutoSize = true;
            this.lblEgitim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgitim.Location = new System.Drawing.Point(20, 150);
            this.lblEgitim.Name = "lblEgitim";
            this.lblEgitim.Size = new System.Drawing.Size(58, 20);
            this.lblEgitim.TabIndex = 8;
            this.lblEgitim.Text = "Eğitim:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(20, 235);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(108, 20);
            this.lblDogumTarihi.TabIndex = 10;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevuAl.Location = new System.Drawing.Point(32, 544);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(192, 55);
            this.btnRandevuAl.TabIndex = 11;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // panelDoktor
            // 
            this.panelDoktor.BackColor = System.Drawing.Color.White;
            this.panelDoktor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDoktor.Controls.Add(this.lblBaslamaTarihi);
            this.panelDoktor.Controls.Add(this.pictureDoktor);
            this.panelDoktor.Controls.Add(this.lblAdSoyad);
            this.panelDoktor.Controls.Add(this.lblDogumTarihi);
            this.panelDoktor.Controls.Add(this.lblBrans);
            this.panelDoktor.Controls.Add(this.lblCinsiyet);
            this.panelDoktor.Controls.Add(this.lblEgitim);
            this.panelDoktor.Location = new System.Drawing.Point(599, 65);
            this.panelDoktor.Name = "panelDoktor";
            this.panelDoktor.Size = new System.Drawing.Size(402, 284);
            this.panelDoktor.TabIndex = 12;
            this.panelDoktor.Visible = false;
            // 
            // lblBaslamaTarihi
            // 
            this.lblBaslamaTarihi.AutoSize = true;
            this.lblBaslamaTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslamaTarihi.Location = new System.Drawing.Point(21, 195);
            this.lblBaslamaTarihi.Name = "lblBaslamaTarihi";
            this.lblBaslamaTarihi.Size = new System.Drawing.Size(145, 20);
            this.lblBaslamaTarihi.TabIndex = 16;
            this.lblBaslamaTarihi.Text = "Mesleğe Başlangıç :";
            // 
            // pictureDoktor
            // 
            this.pictureDoktor.Location = new System.Drawing.Point(16, 12);
            this.pictureDoktor.Name = "pictureDoktor";
            this.pictureDoktor.Size = new System.Drawing.Size(102, 116);
            this.pictureDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDoktor.TabIndex = 13;
            this.pictureDoktor.TabStop = false;
            // 
            // tarih
            // 
            this.tarih.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(262, 54);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(263, 30);
            this.tarih.TabIndex = 13;
            this.tarih.ValueChanged += new System.EventHandler(this.tarih_ValueChanged);
            // 
            // dgvYorumlar
            // 
            this.dgvYorumlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvYorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYorumlar.Location = new System.Drawing.Point(599, 389);
            this.dgvYorumlar.MultiSelect = false;
            this.dgvYorumlar.Name = "dgvYorumlar";
            this.dgvYorumlar.RowHeadersVisible = false;
            this.dgvYorumlar.RowHeadersWidth = 51;
            this.dgvYorumlar.RowTemplate.Height = 24;
            this.dgvYorumlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYorumlar.Size = new System.Drawing.Size(402, 225);
            this.dgvYorumlar.TabIndex = 14;
            this.dgvYorumlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYorumlar_CellContentClick);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(602, 361);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(76, 25);
            this.lblPuan.TabIndex = 15;
            this.lblPuan.Text = "lblPuan";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.btnHastaPaneleDon);
            this.panel1.Controls.Add(this.panelDoktor);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblPuan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panelSaat);
            this.panel1.Controls.Add(this.dgvYorumlar);
            this.panel1.Controls.Add(this.comboBoxPoliklinik);
            this.panel1.Controls.Add(this.tarih);
            this.panel1.Controls.Add(this.btnRandevuAl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBoxDoktor);
            this.panel1.Location = new System.Drawing.Point(95, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 650);
            this.panel1.TabIndex = 16;
            // 
            // btnHastaPaneleDon
            // 
            this.btnHastaPaneleDon.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHastaPaneleDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaPaneleDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaPaneleDon.Location = new System.Drawing.Point(249, 544);
            this.btnHastaPaneleDon.Name = "btnHastaPaneleDon";
            this.btnHastaPaneleDon.Size = new System.Drawing.Size(192, 55);
            this.btnHastaPaneleDon.TabIndex = 16;
            this.btnHastaPaneleDon.Text = "Hasta Panele Dön";
            this.btnHastaPaneleDon.UseVisualStyleBackColor = false;
            this.btnHastaPaneleDon.Click += new System.EventHandler(this.btnHastaPaneleDon_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(571, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 596);
            this.panel4.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(93, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "LÜTFEN DOKTOR SEÇİNİZ.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(416, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "PROFİL VE YORUMLAR BURADA GÖZÜKECEK.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1720, 692);
            this.panel3.TabIndex = 14;
            // 
            // RandevuAlForm
            // 
            this.ClientSize = new System.Drawing.Size(1720, 692);
            this.Controls.Add(this.panel3);
            this.Name = "RandevuAlForm";
            this.Load += new System.EventHandler(this.RandevuAlForm_Load);
            this.Resize += new System.EventHandler(this.RandevuAlForm_Resize);
            this.panelDoktor.ResumeLayout(false);
            this.panelDoktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelSaatler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxPoliklinik;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Panel panelSaat;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblEgitim;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Panel panelDoktor;
        private System.Windows.Forms.PictureBox pictureDoktor;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.DataGridView dgvYorumlar;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBaslamaTarihi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHastaPaneleDon;
    }
}