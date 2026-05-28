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
using System.IO;

namespace HastaneSistemi
{
    public partial class DoktorEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(
         "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
        );

        public DoktorEkle()
        {
            InitializeComponent();
        }

        string picturePath = "";
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string kaynakDosya = ofd.FileName;

                string dosyaAdi =
                    Guid.NewGuid().ToString() +
                    Path.GetExtension(kaynakDosya);

                string hedefKlasor =
                    Application.StartupPath + @"\Images\Doktorlar\";

                if (!Directory.Exists(hedefKlasor))
                {
                    Directory.CreateDirectory(hedefKlasor);
                }

                string hedefDosya =
                    Path.Combine(hedefKlasor, dosyaAdi);

                File.Copy(kaynakDosya, hedefDosya, true);

                picturePath = dosyaAdi;

                pictureDoktor.Image = 
                    Image.FromFile(hedefDosya);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(textBoxAd.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoyad.Text)||
                string.IsNullOrWhiteSpace(textBoxSifre.Text) ||
                string.IsNullOrWhiteSpace(comboBoxBrans.Text) ||
                string.IsNullOrWhiteSpace(textBoxSicilNo.Text)
            )
            { 
                MessageBox.Show("Zorunlu alanları doldurunuz!");
                return;
            } 

            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                  "INSERT INTO Doktorlar (Ad, Soyad, Brans, Sifre, Cinsiyet, DogumTarihi, MezunOkul, Fotograf, SicilNo, BaslamaTarihi) " +
                  "VALUES (@a,@s,@b,@p,@c,@d,@e,@f,@sicil,@baslama)",
                  baglanti
                );

                cmd.Parameters.AddWithValue("@a", textBoxAd.Text);
                cmd.Parameters.AddWithValue("@s", textBoxSoyad.Text);
                cmd.Parameters.AddWithValue("@b", comboBoxBrans.Text);
                cmd.Parameters.AddWithValue("@p", textBoxSifre.Text);
                cmd.Parameters.AddWithValue("@c", comboBoxCinsiyet.Text);
                cmd.Parameters.AddWithValue("@d", DoktorDogumTarihi.Value);
                cmd.Parameters.AddWithValue("@e", textBoxEgitim.Text);
                cmd.Parameters.Add("@sicil", SqlDbType.NVarChar).Value = textBoxSicilNo.Text.Trim();
                cmd.Parameters.AddWithValue("@baslama", dtpBaslamaTarihi.Value.Date);


                if (string.IsNullOrEmpty(picturePath))
                {
                    cmd.Parameters.AddWithValue("@f", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@f", picturePath);
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show("Doktor eklendi");
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                { 
                MessageBox.Show("Bu Sicil Numarası Başka Bir Doktora Ait!");
                }
                else
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            finally
            {
                baglanti.Close();
            }

            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxSifre.Clear();
            textBoxEgitim.Clear();
            textBoxSicilNo.Clear();

            comboBoxCinsiyet.SelectedIndex = -1;
            comboBoxBrans.SelectedIndex = -1;

            pictureDoktor.Image = null;
            picturePath = "";
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

			DoktorDogumTarihi.Format = DateTimePickerFormat.Custom;
            DoktorDogumTarihi.CustomFormat = "dd.MM.yyyy";
            dtpBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            dtpBaslamaTarihi.CustomFormat = "dd.MM.yyyy";

            string varsayilanResim =
                     Application.StartupPath +
                     @"\Images\doktor_avatar.jpeg";

            if (File.Exists(varsayilanResim))
            {
                pictureDoktor.Image =
                    Image.FromFile(varsayilanResim);
            }

            DoktorDogumTarihi.MaxDate = DateTime.Today;

            pictureDoktor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDoktor.BackColor = Color.LightGray;

            comboBoxCinsiyet.Items.AddRange(new string[] { "Kadın", "Erkek" });

            comboBoxBrans.Items.Clear();

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

        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
             "SELECT DISTINCT Brans FROM Doktorlar ORDER BY Brans",
              baglanti
            );
        }

        private void DoktorEkle_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}