namespace HastaneSistemi
{
    partial class AdminPanel
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.textBoxDoktorAra = new System.Windows.Forms.TextBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelButonlar = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panelFiltre = new System.Windows.Forms.Panel();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.btnRandevular = new System.Windows.Forms.Button();
            this.btnHastalar = new System.Windows.Forms.Button();
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButonlar.SuspendLayout();
            this.panelFiltre.SuspendLayout();
            this.panelBaslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.Location = new System.Drawing.Point(3, 143);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.RowTemplate.Height = 24;
            this.dgvListe.Size = new System.Drawing.Size(933, 407);
            this.dgvListe.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(221, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(129, 55);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Doktor  Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(373, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 55);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Doktor Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // textBoxDoktorAra
            // 
            this.textBoxDoktorAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDoktorAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDoktorAra.Location = new System.Drawing.Point(17, 7);
            this.textBoxDoktorAra.Name = "textBoxDoktorAra";
            this.textBoxDoktorAra.Size = new System.Drawing.Size(171, 27);
            this.textBoxDoktorAra.TabIndex = 9;
            this.textBoxDoktorAra.TextChanged += new System.EventHandler(this.textBoxDoktorAra_TextChanged);
            this.textBoxDoktorAra.Enter += new System.EventHandler(this.textBoxDoktorAra_Enter);
            this.textBoxDoktorAra.Leave += new System.EventHandler(this.textBoxDoktorAra_Leave);
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxBrans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(17, 40);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(171, 28);
            this.comboBoxBrans.TabIndex = 10;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDuzenle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(523, 6);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(129, 55);
            this.btnDuzenle.TabIndex = 11;
            this.btnDuzenle.Text = "Doktor Profili Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(224, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(129, 74);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Tüm Doktorları Gör";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelButonlar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelFiltre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBaslik, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvListe, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 623);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panelButonlar
            // 
            this.panelButonlar.BackColor = System.Drawing.Color.AliceBlue;
            this.panelButonlar.Controls.Add(this.btnCikis);
            this.panelButonlar.Controls.Add(this.btnEkle);
            this.panelButonlar.Controls.Add(this.btnDuzenle);
            this.panelButonlar.Controls.Add(this.btnSil);
            this.panelButonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButonlar.Location = new System.Drawing.Point(0, 553);
            this.panelButonlar.Margin = new System.Windows.Forms.Padding(0);
            this.panelButonlar.Name = "panelButonlar";
            this.panelButonlar.Size = new System.Drawing.Size(939, 70);
            this.panelButonlar.TabIndex = 14;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCikis.BackColor = System.Drawing.Color.Silver;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(832, 7);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(84, 54);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panelFiltre
            // 
            this.panelFiltre.BackColor = System.Drawing.Color.AliceBlue;
            this.panelFiltre.Controls.Add(this.btnIstatistikler);
            this.panelFiltre.Controls.Add(this.btnRandevular);
            this.panelFiltre.Controls.Add(this.btnHastalar);
            this.panelFiltre.Controls.Add(this.textBoxDoktorAra);
            this.panelFiltre.Controls.Add(this.btnListele);
            this.panelFiltre.Controls.Add(this.comboBoxBrans);
            this.panelFiltre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiltre.Location = new System.Drawing.Point(0, 60);
            this.panelFiltre.Margin = new System.Windows.Forms.Padding(0);
            this.panelFiltre.Name = "panelFiltre";
            this.panelFiltre.Size = new System.Drawing.Size(939, 80);
            this.panelFiltre.TabIndex = 1;
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIstatistikler.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIstatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistikler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistikler.Location = new System.Drawing.Point(673, 17);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(129, 54);
            this.btnIstatistikler.TabIndex = 15;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = false;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // btnRandevular
            // 
            this.btnRandevular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRandevular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRandevular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevular.Location = new System.Drawing.Point(523, 17);
            this.btnRandevular.Name = "btnRandevular";
            this.btnRandevular.Size = new System.Drawing.Size(129, 54);
            this.btnRandevular.TabIndex = 14;
            this.btnRandevular.Text = "Randevuları Gör";
            this.btnRandevular.UseVisualStyleBackColor = false;
            this.btnRandevular.Click += new System.EventHandler(this.btnRandevular_Click);
            // 
            // btnHastalar
            // 
            this.btnHastalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHastalar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHastalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastalar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastalar.Location = new System.Drawing.Point(376, 16);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(129, 54);
            this.btnHastalar.TabIndex = 13;
            this.btnHastalar.Text = "Hastaları Gör";
            this.btnHastalar.UseVisualStyleBackColor = false;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.AliceBlue;
            this.panelBaslik.Controls.Add(this.labelBaslik);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelBaslik.Margin = new System.Windows.Forms.Padding(0);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(939, 60);
            this.panelBaslik.TabIndex = 14;
            // 
            // labelBaslik
            // 
            this.labelBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.BackColor = System.Drawing.Color.Transparent;
            this.labelBaslik.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslik.ForeColor = System.Drawing.Color.Navy;
            this.labelBaslik.Location = new System.Drawing.Point(229, 9);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(478, 45);
            this.labelBaslik.TabIndex = 15;
            this.labelBaslik.Text = "HASTANE YÖNETİM PANELİ";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelButonlar.ResumeLayout(false);
            this.panelFiltre.ResumeLayout(false);
            this.panelFiltre.PerformLayout();
            this.panelBaslik.ResumeLayout(false);
            this.panelBaslik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox textBoxDoktorAra;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFiltre;
        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Panel panelButonlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Button btnIstatistikler;
        private System.Windows.Forms.Button btnRandevular;
        private System.Windows.Forms.Button btnHastalar;
    }
}