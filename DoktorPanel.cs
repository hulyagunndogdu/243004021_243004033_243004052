using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneSistemi
{
    public partial class DoktorPanel : Form
    {
        SqlConnection baglanti = new SqlConnection(
         "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
        );

        int doktorID;
        public DoktorPanel(int id)
        {
            InitializeComponent();
            doktorID = id;
        }

        public DoktorPanel()
        {
            InitializeComponent();
        }

        private void DoktorPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dgvYorumlar.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvYorumlar.ReadOnly = true;

            dgvRandevular.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvRandevular.ReadOnly = true;

            dgvRandevular.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            dgvYorumlar.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            Listele();
            YorumlariListele();
            OrtalamaPuaniGetir();
        }

        void Listele()
        {
            SqlCommand guncelle = new SqlCommand(
             @"UPDATE Randevular 
              SET Durum='Geçmiş' 
              WHERE
              DATEADD(MINUTE, DATEDIFF(MINUTE, 0, Saat), CAST(Tarih AS DATETIME)) < GETDATE()
              AND Durum='Aktif'",
             baglanti
            );

            try 
            { 
                baglanti.Open();
                guncelle.ExecuteNonQuery();
            }
            finally
            {
                if(baglanti.State == ConnectionState.Open)
                baglanti.Close();
            }
            

            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT R.RandevuID,
                     H.Ad,
                     H.Soyad,
                     R.Tarih,
                     R.Saat,
                     R.Durum
             FROM Randevular R
                INNER JOIN Hastalar H ON R.HastaID = H.HastaID
                  WHERE R.DoktorID = @id",
                  baglanti
           );

            da.SelectCommand.Parameters.AddWithValue("@id", doktorID);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRandevular.DataSource = dt;

            dgvRandevular.Columns["RandevuID"].Visible = false;


            foreach (DataGridViewRow row in dgvRandevular.Rows)
            {
                if (row.Cells["Durum"].Value?.ToString() == "İptal")
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        void YorumlariListele()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT
                 h.Ad + ' ' + h.Soyad AS Hasta,

                 CASE
                 WHEN y.Puan = 1 THEN N'★'
                 WHEN y.Puan = 2 THEN N'★★'
                 WHEN y.Puan = 3 THEN N'★★★'
                 WHEN y.Puan = 4 THEN N'★★★★'
                 ELSE N'★★★★★'
                 END AS Puan,

                 y.YorumMetni,
                 y.Tarih

                 FROM Yorumlar y

                 INNER JOIN Hastalar h
                 ON y.HastaID = h.HastaID

                 WHERE y.DoktorID = @id

                 ORDER BY y.Tarih DESC",
                baglanti);

            da.SelectCommand.Parameters.AddWithValue("@id", doktorID);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvYorumlar.DataSource = dt;

            dgvYorumlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYorumlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvYorumlar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (dgvYorumlar.Columns["YorumMetni"] != null)
            {
                dgvYorumlar.Columns["YorumMetni"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dgvYorumlar.ReadOnly = true;
            dgvYorumlar.AllowUserToAddRows = false;
        }

        void OrtalamaPuaniGetir()
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand(
              "SELECT AVG(CAST(Puan AS FLOAT)) FROM Yorumlar WHERE DoktorID=@id",
            baglanti);

            cmd.Parameters.AddWithValue("@id", doktorID);

            object sonuc = cmd.ExecuteScalar();

            if (sonuc != null && sonuc != DBNull.Value)
            {
                double ortalama = Convert.ToDouble(sonuc);

                lblOrtalamaPuan.Text = "Ortalama Puan: " + ortalama.ToString("0.0") + " ★";
            }
            else
            {
                lblOrtalamaPuan.Text = "Henüz yorum yok.";
            }

            baglanti.Close();
        }

        private void btnRandevuIptal_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen Bir Randevu Seçin!");
                return;
            }
            
            int randevuID = Convert.ToInt32(dgvRandevular.CurrentRow.Cells["RandevuID"].Value);

            string durum = dgvRandevular.CurrentRow.Cells["Durum"].Value?.ToString();

            if (durum == "İptal")
            {
                MessageBox.Show("Bu randevu zaten iptal edilmiş.");
                return;
            }

            if (durum == "Tamamlandı")
            {
                MessageBox.Show("Tamamlanmış randevu iptal edilemez!");
                return;
            }

            DateTime tarih = Convert.ToDateTime(
                dgvRandevular.CurrentRow.Cells["Tarih"].Value);

            TimeSpan saat = TimeSpan.Parse(
                dgvRandevular.CurrentRow.Cells["Saat"].Value.ToString());

            DateTime randevuZamani = tarih.Add(saat);

            if (randevuZamani < DateTime.Now)
            {
                MessageBox.Show("Geçmiş randevu iptal edilemez!");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Randevu iptal edilsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (cevap == DialogResult.No)
                return;

            baglanti.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Randevular SET Durum='İptal' WHERE RandevuID=@id",
                baglanti);

            cmd.Parameters.AddWithValue("@id", randevuID);
            cmd.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Randevu iptal edildi.");

            Listele();
            dgvRandevular.ClearSelection();
            dgvRandevular.Refresh();

        }

        private void DoktorPanel_Resize(object sender, EventArgs e)
        {
            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            panel2.Top = (this.ClientSize.Height - panel2.Height) / 2;
        }

        private void btnRandevuTamamla_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin!");
                return;
            }

            int RandevuID = Convert.ToInt32(
                dgvRandevular.CurrentRow.Cells["RandevuID"].Value);

            string durum = dgvRandevular.CurrentRow.Cells["Durum"].Value.ToString();

            if (durum == "Tamamlandı")
            {
                MessageBox.Show("Bu randevu zaten tamamlanmış!");
                return;
            }

            if (durum == "İptal")
            {
                MessageBox.Show("İptal edilmiş randevu tamamlanamaz!");
                return;
            }

            if (dgvRandevular.CurrentRow.Cells["Tarih"].Value == null ||
                dgvRandevular.CurrentRow.Cells["Saat"].Value == null ||
                dgvRandevular.CurrentRow.Cells["Tarih"].Value == DBNull.Value ||
                dgvRandevular.CurrentRow.Cells["Saat"].Value == DBNull.Value)
            {
                MessageBox.Show("Randevu tarih/saat bilgisi eksik!");
                return;
            }

            DateTime tarih = Convert.ToDateTime(
                dgvRandevular.CurrentRow.Cells["Tarih"].Value);

            TimeSpan saat = (TimeSpan)
                dgvRandevular.CurrentRow.Cells["Saat"].Value;

            DateTime randevuZamani = tarih.Add(saat);

            if (randevuZamani > DateTime.Now) 
            {
                MessageBox.Show("Gelecek randevu tamamlanamaz!");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Randevu tamamlandı olarak işaretlensin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cevap == DialogResult.No)
                return;

            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Randevular
                      SET Durum = 'Tamamlandı'
                      WHERE RandevuID = @id",
                    baglanti
                );

                cmd.Parameters.AddWithValue("@id", RandevuID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            Listele();
        }
    }
}