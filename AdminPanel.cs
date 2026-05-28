using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneSistemi
{
    public partial class AdminPanel : Form
    {
        SqlConnection baglanti = new SqlConnection(
         "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
    );
        public AdminPanel()
        {
            InitializeComponent();
        }

        string aktifTablo = "Doktorlar";
        void Listele()
        { 
            string query = "";

            if(aktifTablo == "Doktorlar")
            {
                query = "SELECT * FROM Doktorlar WHERE Durum = 'Aktif'";

                if(!string.IsNullOrWhiteSpace(textBoxDoktorAra.Text) && textBoxDoktorAra.Text != "Doktor ara...")
                {
                    query += " AND (Ad LIKE @ara OR Soyad LIKE @ara)";
                }

                if(comboBoxBrans.SelectedIndex > 0)
                {
                    query += " AND Brans = @brans";
                }
            }
            else if (aktifTablo == "Hastalar")
            {
                query = "SELECT * FROM Hastalar";
            }
            else if (aktifTablo == "Randevular")
            {
                query = @"SELECT 
                          RandevuID,
                          HastaID,
                          DoktorID,
                          Tarih,
                          Saat,
                          DATEADD(MINUTE, DATEDIFF(MINUTE, 0, Saat), CAST(Tarih AS DATETIME)) AS RandevuZamani,
                          Durum
                       FROM Randevular";
            }
            SqlCommand cmd = new SqlCommand(query, baglanti);

            if(query.Contains("@ara"))
              cmd.Parameters.AddWithValue("@ara","%" + textBoxDoktorAra.Text + "%");

            if (query.Contains("@brans"))
                cmd.Parameters.AddWithValue("@brans", comboBoxBrans.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvListe.DataSource = dt;

            if (dt.Columns.Contains("Ad"))
                dgvListe.Columns["Ad"].HeaderText = "Ad";

            if (dt.Columns.Contains("Soyad"))
                dgvListe.Columns["Soyad"].HeaderText = "Soyad";

            if (dt.Columns.Contains("DoktorID"))
                dgvListe.Columns["DoktorID"].Visible = false;

            if (dt.Columns.Contains("HastaID"))
                dgvListe.Columns["HastaID"].Visible = false;

            if (dt.Columns.Contains("RandevuID"))
                dgvListe.Columns["RandevuID"].Visible = false;
        }

        void ResetUI()
        { 
            if (aktifTablo == "Doktorlar")
            { 
                textBoxDoktorAra.Text = "Doktor ara...";
                textBoxDoktorAra.ForeColor = Color.Gray;
                comboBoxBrans.SelectedIndex = 0;
            }
            else
            {
                textBoxDoktorAra.Text = "";
                comboBoxBrans.SelectedIndex = 0;
            }
        }

        private void textBoxDoktorAra_Enter(object sender, EventArgs e)
        {
            if (textBoxDoktorAra.Text == "Doktor ara...")
            {
                textBoxDoktorAra.Text = "";
                textBoxDoktorAra.ForeColor = Color.Black;
            }
        }

        private void textBoxDoktorAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDoktorAra.Text))
            {
                textBoxDoktorAra.Text = "Doktor ara...";
                textBoxDoktorAra.ForeColor = Color.Gray;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dgvListe.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvListe.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvListe.MultiSelect = false;

            dgvListe.ReadOnly = true;

            textBoxDoktorAra.ForeColor = Color.Gray;

            BranslariYukle();

            aktifTablo = "Doktorlar";

            ResetUI();
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle frm = new DoktorEkle();
            frm.ShowDialog();

            aktifTablo = "Doktorlar";

            BranslariYukle();
            ResetUI();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (aktifTablo != "Doktorlar") return;
            if (dgvListe.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvListe.CurrentRow.Cells["DoktorID"].Value);

            DialogResult cevap = MessageBox.Show(
                 "Doktor silinsin mi?",
                 "Uyarı",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
            );

            if (cevap == DialogResult.No)
                return;

            try 
            {
                baglanti.Open();

                SqlCommand kontrol = new SqlCommand(
                    @"SELECT COUNT(*)
                    FROM Randevular
                    WHERE DoktorID=@id
                    AND Durum = 'Aktif'",
                    baglanti
                );

                kontrol.Parameters.AddWithValue("@id", id);

                int aktifRandevu = (int)kontrol.ExecuteScalar();

                if( aktifRandevu > 0 )
                {
                    MessageBox.Show("Bu doktora ait aktif randevular bulunduğu için silinemez!");
                    baglanti.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Doktorlar SET Durum='Pasif' WHERE DoktorID=@id",
                    baglanti
                );

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Doktor silindi!");
            }
            catch(Exception ex )
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            Listele();
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aktifTablo != "Doktorlar") return;
            Listele();
        }

        private void textBoxDoktorAra_TextChanged(object sender, EventArgs e)
        {
            if (aktifTablo != "Doktorlar") return;

            if (textBoxDoktorAra.Text != "Doktor ara...")
            {
                Listele();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            aktifTablo = "Doktorlar";

            ResetUI();
            Listele();
        }

        void BranslariYukle()
        {
            comboBoxBrans.Items.Clear();
            comboBoxBrans.Items.Add("Branşlar");

            SqlCommand cmd = new SqlCommand(
             "SELECT DISTINCT Brans FROM Doktorlar ORDER BY Brans",
              baglanti
            );

            baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxBrans.Items.Add(dr["Brans"].ToString());
            }

            baglanti.Close();

            comboBoxBrans.SelectedIndex= 0;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (aktifTablo != "Doktorlar") return;

            if (dgvListe.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dgvListe.CurrentRow.Cells["DoktorID"].Value);

            DoktorProfiliDuzenle frm = new DoktorProfiliDuzenle(id);
            frm.ShowDialog();

            Listele();
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            aktifTablo = "Hastalar";

            ResetUI();
            Listele();
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            aktifTablo = "Randevular";

            ResetUI();
            Listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            Istatistikler istatistik = new Istatistikler();
            istatistik.Show();
        }
    }
}