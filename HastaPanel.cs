using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneSistemi
{
    public partial class HastaPanel : Form
    {
        int hastaID;

        SqlConnection baglanti = new SqlConnection(
            "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
        );

        public HastaPanel(int id)
        {
            InitializeComponent();
            hastaID = id;
        }

        private void HastaPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            SqlCommand cmd = new SqlCommand(
                @"UPDATE Randevular
                  SET Durum = 'Tamamlandı'
                  WHERE
                  Tarih < CAST(GETDATE() AS DATE)
                  AND Durum = 'Aktif'",
                baglanti
            );

            baglanti.Open();

            cmd.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT 
                R.RandevuID,
                D.Ad,
                D.Soyad,
                D.Brans,
                R.Tarih,
                R.Saat,
                R.Durum
              FROM Randevular R
              INNER JOIN Doktorlar D
              ON R.DoktorID = D.DoktorID
              WHERE R.HastaID=@h
              AND R.Tarih >= CAST(GETDATE() AS DATE)
              AND R.Durum='Aktif'",
              baglanti);

            da.SelectCommand.Parameters.AddWithValue("@h", hastaID);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvRandevular.DataSource = dt;

            dgvRandevular.Columns["RandevuID"].Visible = false;
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT 
               R.RandevuID,
               D.Ad,
               D.Soyad,
               D.Brans,
               R.Tarih,
               R.Saat,
               R.Durum
               FROM Randevular R
               INNER JOIN Doktorlar D ON R.DoktorID = D.DoktorID
               WHERE R.HastaID=@h
               AND R.Durum = 'Tamamlandı'",
              baglanti);

            da.SelectCommand.Parameters.AddWithValue("@h", hastaID);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvRandevular.DataSource = dt;
        }

        private void btnRandevuİptal_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen randevu seçin!");
                return;
            }

            string durum = dgvRandevular.CurrentRow.Cells["Durum"].Value.ToString();

            if (durum == "Tamamlandı")
            {
                MessageBox.Show(
                    "Geçmiş randevular iptal edilemez!"
                );

                return;
            }

            DialogResult sonuc = MessageBox.Show(
                "Randevuyu iptal etmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo
            );

            if (sonuc == DialogResult.No)
                return;

            int randevuID = Convert.ToInt32(
                dgvRandevular.CurrentRow.Cells["RandevuID"].Value
            );

            SqlCommand cmd = new SqlCommand(
                "UPDATE Randevular SET Durum='İptal' WHERE RandevuID=@id",
                baglanti
            );

            cmd.Parameters.AddWithValue("@id", randevuID);

            baglanti.Open();

            cmd.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Randevu iptal edildi!");

            btnAktif_Click(null, null);
        }

        private void btnHastanedenRandevu_Click(object sender, EventArgs e)
        {
            RandevuAlForm rf = new RandevuAlForm(hastaID);
            rf.Show();
        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            YorumYap frm = new YorumYap(hastaID);
            frm.Show();
        }

        private void HastaPanel_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}