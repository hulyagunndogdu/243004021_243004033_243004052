namespace HastaneSistemi
{
    partial class HastaPanel
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
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.btnAktif = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.btnRandevuİptal = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.BackgroundColor = System.Drawing.Color.White;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Location = new System.Drawing.Point(0, 151);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.RowHeadersWidth = 51;
            this.dgvRandevular.RowTemplate.Height = 24;
            this.dgvRandevular.Size = new System.Drawing.Size(887, 274);
            this.dgvRandevular.TabIndex = 10;
            // 
            // btnAktif
            // 
            this.btnAktif.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktif.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktif.Location = new System.Drawing.Point(34, 78);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(218, 45);
            this.btnAktif.TabIndex = 11;
            this.btnAktif.Text = "Aktif  Randevularım";
            this.btnAktif.UseVisualStyleBackColor = false;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.DarkGray;
            this.btnGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmis.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmis.Location = new System.Drawing.Point(271, 78);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(253, 45);
            this.btnGecmis.TabIndex = 12;
            this.btnGecmis.Text = "Geçmiş  Randevularım";
            this.btnGecmis.UseVisualStyleBackColor = false;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // btnRandevuİptal
            // 
            this.btnRandevuİptal.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRandevuİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuİptal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuİptal.Location = new System.Drawing.Point(544, 78);
            this.btnRandevuİptal.Name = "btnRandevuİptal";
            this.btnRandevuİptal.Size = new System.Drawing.Size(218, 45);
            this.btnRandevuİptal.TabIndex = 13;
            this.btnRandevuİptal.Text = "Randevuyu İptal Et";
            this.btnRandevuİptal.UseVisualStyleBackColor = false;
            this.btnRandevuİptal.Click += new System.EventHandler(this.btnRandevuİptal_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.Location = new System.Drawing.Point(166, 460);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(475, 49);
            this.btnRandevuAl.TabIndex = 14;
            this.btnRandevuAl.Text = "Hastaneden Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnHastanedenRandevu_Click);
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.BackColor = System.Drawing.Color.LightGray;
            this.btnYorumYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYorumYap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYorumYap.Location = new System.Drawing.Point(749, 460);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(94, 72);
            this.btnYorumYap.TabIndex = 15;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = false;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.btnAktif);
            this.panel1.Controls.Add(this.btnYorumYap);
            this.panel1.Controls.Add(this.btnGecmis);
            this.panel1.Controls.Add(this.btnRandevuAl);
            this.panel1.Controls.Add(this.btnRandevuİptal);
            this.panel1.Controls.Add(this.dgvRandevular);
            this.panel1.Location = new System.Drawing.Point(57, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 560);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 608);
            this.panel2.TabIndex = 17;
            // 
            // HastaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 608);
            this.Controls.Add(this.panel2);
            this.Name = "HastaPanel";
            this.Text = "HastaPanel";
            this.Load += new System.EventHandler(this.HastaPanel_Load);
            this.Resize += new System.EventHandler(this.HastaPanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Button btnRandevuİptal;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnYorumYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}