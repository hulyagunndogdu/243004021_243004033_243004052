namespace HastaneSistemi
{
    partial class YorumYap
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
            this.btnYorumGonder = new System.Windows.Forms.Button();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxYorum = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPuan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYorumGonder
            // 
            this.btnYorumGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYorumGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYorumGonder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYorumGonder.Location = new System.Drawing.Point(261, 435);
            this.btnYorumGonder.Name = "btnYorumGonder";
            this.btnYorumGonder.Size = new System.Drawing.Size(121, 38);
            this.btnYorumGonder.TabIndex = 0;
            this.btnYorumGonder.Text = "Gönder";
            this.btnYorumGonder.UseVisualStyleBackColor = false;
            this.btnYorumGonder.Click += new System.EventHandler(this.btnYorumGonder_Click);
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(261, 110);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(121, 31);
            this.comboBoxDoktor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doktor Seç :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yorum :";
            // 
            // richTextBoxYorum
            // 
            this.richTextBoxYorum.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxYorum.Location = new System.Drawing.Point(261, 232);
            this.richTextBoxYorum.Name = "richTextBoxYorum";
            this.richTextBoxYorum.Size = new System.Drawing.Size(404, 182);
            this.richTextBoxYorum.TabIndex = 6;
            this.richTextBoxYorum.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxPuan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBoxYorum);
            this.panel1.Controls.Add(this.comboBoxDoktor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnYorumGonder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(256, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 500);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label4.Location = new System.Drawing.Point(270, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "YORUM YAP";
            // 
            // comboBoxPuan
            // 
            this.comboBoxPuan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPuan.FormattingEnabled = true;
            this.comboBoxPuan.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★",
            "★★★★★"});
            this.comboBoxPuan.Location = new System.Drawing.Point(261, 159);
            this.comboBoxPuan.Name = "comboBoxPuan";
            this.comboBoxPuan.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPuan.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puan :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 665);
            this.panel2.TabIndex = 8;
            // 
            // YorumYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 665);
            this.Controls.Add(this.panel2);
            this.Name = "YorumYap";
            this.Text = "YorumYap";
            this.Load += new System.EventHandler(this.YorumYap_Load);
            this.Resize += new System.EventHandler(this.YorumYap_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYorumGonder;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxYorum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}