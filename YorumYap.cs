using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi
{
    public partial class YorumYap : Form
    {
        SqlConnection baglanti = new SqlConnection(
          "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;");

        int HastaID;
        public YorumYap(int gelenHastaID)
        {
            InitializeComponent();
            HastaID = gelenHastaID;
        }

        private void YorumYap_Load(object sender, EventArgs e)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

			baglanti.Open();

            SqlCommand cmd = new SqlCommand(
                @"SELECT DISTINCT d.DoktorID,
                  d.Ad + ' ' + d.Soyad AS DoktorAd
                  FROM Randevular r
                  INNER JOIN Doktorlar d
                  ON r.DoktorID = d.DoktorID
                  WHERE r.HastaID = @hastaID
                  AND r.Durum = 'Tamamlandı'
                  AND r.DoktorID NOT IN
                  (  
                      SELECT DoktorID 
                      FROM Yorumlar
                      WHERE HastaID = @hastaID
                  )",
                baglanti);

            cmd.Parameters.AddWithValue("@hastaID", HastaID);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            comboBoxDoktor.DataSource = dt;
            comboBoxDoktor.DisplayMember = "DoktorAd";
            comboBoxDoktor.ValueMember = "DoktorID";
            comboBoxPuan.SelectedIndex = -1;

            baglanti.Close();
        }

        private void btnYorumGonder_Click(object sender, EventArgs e)
        {
            if (comboBoxDoktor.SelectedValue == null)
            {
                MessageBox.Show("Lütfen doktor seçiniz!");
                return;
            }

            if (comboBoxPuan.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen puan seçiniz!");
                return;
            }

            try
            {
                baglanti.Open();

                SqlCommand kontrol = new SqlCommand(
                    @"SELECT COUNT(*)
                   FROM Yorumlar
                   WHERE DoktorID=@doktor
                   AND HastaID=@hasta",
                    baglanti
                );

                kontrol.Parameters.AddWithValue("@doktor", comboBoxDoktor.SelectedValue);
                kontrol.Parameters.AddWithValue("@hasta", HastaID);

                int varMi = (int)kontrol.ExecuteScalar();

                if (varMi > 0)
                {
                    MessageBox.Show("Aynı doktora birden fazla kez yorum yapamazsınız!");
                    baglanti.Close();
                    return;
                }

                if (string.IsNullOrWhiteSpace(richTextBoxYorum.Text))
                {
                    MessageBox.Show("Boş Yorum Metni Gönderilemez!");
                    baglanti.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Yorumlar (DoktorID, HastaID, YorumMetni, Puan, Tarih)
                     VALUES (@doktor, @hasta, @yorum, @puan, @tarih)",
                baglanti);

                int doktorId = Convert.ToInt32(comboBoxDoktor.SelectedValue);

                cmd.Parameters.AddWithValue("@doktor", doktorId);
                cmd.Parameters.AddWithValue("@hasta", HastaID);
                cmd.Parameters.AddWithValue("@yorum", richTextBoxYorum.Text);
                int puan = comboBoxPuan.SelectedIndex + 1;
                cmd.Parameters.AddWithValue("@puan", puan);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Yorum Gönderildi");

                richTextBoxYorum.Clear();
                comboBoxPuan.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally 
            { 
                baglanti.Close(); 
            }
        }

        private void YorumYap_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}