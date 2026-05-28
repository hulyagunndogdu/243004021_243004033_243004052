namespace HastaneSistemi
{
    partial class DoktorPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRandevuTamamla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandevuIptal = new System.Windows.Forms.Button();
            this.lblOrtalamaPuan = new System.Windows.Forms.Label();
            this.dgvYorumlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Location = new System.Drawing.Point(13, 184);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.RowHeadersWidth = 51;
            this.dgvRandevular.RowTemplate.Height = 24;
            this.dgvRandevular.Size = new System.Drawing.Size(758, 194);
            this.dgvRandevular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(308, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Yorumları";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 677);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.btnRandevuTamamla);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRandevuIptal);
            this.panel2.Controls.Add(this.dgvRandevular);
            this.panel2.Controls.Add(this.lblOrtalamaPuan);
            this.panel2.Controls.Add(this.dgvYorumlar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(54, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 653);
            this.panel2.TabIndex = 4;
            // 
            // btnRandevuTamamla
            // 
            this.btnRandevuTamamla.BackColor = System.Drawing.Color.Plum;
            this.btnRandevuTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuTamamla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuTamamla.Location = new System.Drawing.Point(795, 197);
            this.btnRandevuTamamla.Name = "btnRandevuTamamla";
            this.btnRandevuTamamla.Size = new System.Drawing.Size(139, 69);
            this.btnRandevuTamamla.TabIndex = 3;
            this.btnRandevuTamamla.Text = "Randevuyu Tamamla";
            this.btnRandevuTamamla.UseVisualStyleBackColor = false;
            this.btnRandevuTamamla.Click += new System.EventHandler(this.btnRandevuTamamla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(235, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "DOKTOR KONTROL PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(330, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Randevular";
            // 
            // btnRandevuIptal
            // 
            this.btnRandevuIptal.BackColor = System.Drawing.Color.Salmon;
            this.btnRandevuIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuIptal.Location = new System.Drawing.Point(795, 290);
            this.btnRandevuIptal.Name = "btnRandevuIptal";
            this.btnRandevuIptal.Size = new System.Drawing.Size(139, 69);
            this.btnRandevuIptal.TabIndex = 5;
            this.btnRandevuIptal.Text = "Randevuyu İptal Et";
            this.btnRandevuIptal.UseVisualStyleBackColor = false;
            this.btnRandevuIptal.Click += new System.EventHandler(this.btnRandevuIptal_Click);
            // 
            // lblOrtalamaPuan
            // 
            this.lblOrtalamaPuan.AutoSize = true;
            this.lblOrtalamaPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblOrtalamaPuan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalamaPuan.Location = new System.Drawing.Point(643, 418);
            this.lblOrtalamaPuan.Name = "lblOrtalamaPuan";
            this.lblOrtalamaPuan.Size = new System.Drawing.Size(111, 20);
            this.lblOrtalamaPuan.TabIndex = 3;
            this.lblOrtalamaPuan.Text = "Ortalama Puan";
            // 
            // dgvYorumlar
            // 
            this.dgvYorumlar.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvYorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYorumlar.Location = new System.Drawing.Point(13, 455);
            this.dgvYorumlar.Name = "dgvYorumlar";
            this.dgvYorumlar.RowHeadersWidth = 51;
            this.dgvYorumlar.RowTemplate.Height = 24;
            this.dgvYorumlar.Size = new System.Drawing.Size(758, 175);
            this.dgvYorumlar.TabIndex = 2;
            // 
            // DoktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 677);
            this.Controls.Add(this.panel1);
            this.Name = "DoktorPanel";
            this.Text = "DoktorPanel";
            this.Load += new System.EventHandler(this.DoktorPanel_Load);
            this.Resize += new System.EventHandler(this.DoktorPanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvYorumlar;
        private System.Windows.Forms.Label lblOrtalamaPuan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRandevuIptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRandevuTamamla;
    }
}