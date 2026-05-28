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
    public partial class DoktorProfiliDuzenle : Form
    {
        int doktorID;
        public DoktorProfiliDuzenle(int id)
        {
            InitializeComponent();
            doktorID = id;
        }

        private void DoktorProfiliDuzenle_Load(object sender, EventArgs e)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

			comboBoxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            DoktorDogumTarihi.Format = DateTimePickerFormat.Custom;
            DoktorDogumTarihi.CustomFormat = "dd.MM.yyyy";
            dtpBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            dtpBaslamaTarihi.CustomFormat = "dd.MM.yyyy";

            pictureBoxDoktor.BorderStyle =
            BorderStyle.FixedSingle;

            pictureBoxDoktor.SizeMode =
                PictureBoxSizeMode.Zoom;

            pictureBoxDoktor.BackColor =
                Color.WhiteSmoke;

            comboBoxCinsiyet.Items.Clear();

            comboBoxCinsiyet.Items.Add("Kadın");
            comboBoxCinsiyet.Items.Add("Erkek");

            BranslariYukle();

            SqlConnection baglanti = new SqlConnection(
                "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
            );

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Doktorlar WHERE DoktorID=@id",
                baglanti
            );

            cmd.Parameters.AddWithValue("@id", doktorID);

            baglanti.Open();
            
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBoxAd.Text = dr["Ad"].ToString();
                textBoxSoyad.Text = dr["Soyad"].ToString();
                comboBoxCinsiyet.Text = dr["Cinsiyet"].ToString();
                comboBoxBrans.Text = dr["Brans"].ToString();
                textBoxSicilNo.Text = dr["SicilNo"].ToString();
                DoktorDogumTarihi.Value = Convert.ToDateTime(dr["DogumTarihi"]);
                textBoxSifre.Text = dr["Sifre"].ToString();
                if (dr["BaslamaTarihi"] != DBNull.Value)
                {
                    dtpBaslamaTarihi.Value = Convert.ToDateTime(dr["BaslamaTarihi"]);
                }
                textBoxEgitim.Text = dr["MezunOkul"].ToString();
                fotoYolu = dr["Fotograf"] == DBNull.Value
                    ? ""
                    : dr["Fotograf"].ToString();

                if (!string.IsNullOrEmpty(fotoYolu))
                {
                    string yol = Path.Combine(Application.StartupPath, 
                       "Images",
                       "Doktorlar",
                       fotoYolu
                    );

                    if (File.Exists(yol))
                    {
                        pictureBoxDoktor.Image = Image.FromFile(yol);
                    }
                }
                else
                {
                    string varsayilan = Path.Combine(
                        Application.StartupPath,
                        @"Images\doktor_avatar.jpeg"
                    );

                    if (File.Exists(varsayilan))
                    {
                        pictureBoxDoktor.Image = Image.FromFile(varsayilan);
                    }
                }
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(
                "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
            );

            SqlCommand cmd = new SqlCommand(
                "UPDATE Doktorlar SET " +
                "Ad=@ad, " +
                "Soyad=@soyad, " +
                "Cinsiyet=@cinsiyet, " +
                "Brans=@brans, " +
                "SicilNo=@sicil, " +
                "DogumTarihi=@dogum, " +
                "Sifre=@sifre, " +
                "BaslamaTarihi=@baslama, " +
                "MezunOkul=@egitim, " +
                "Fotograf=@foto " +
                "WHERE DoktorID=@id",
                baglanti
            );

            cmd.Parameters.AddWithValue(
                "@ad",
                textBoxAd.Text);

            cmd.Parameters.AddWithValue(
                "@soyad",
                textBoxSoyad.Text);

            cmd.Parameters.AddWithValue(
                "@cinsiyet",
                comboBoxCinsiyet.Text);

            cmd.Parameters.AddWithValue(
                "@brans",
                comboBoxBrans.Text);

            cmd.Parameters.AddWithValue(
                "@sicil",
                textBoxSicilNo.Text);

            cmd.Parameters.AddWithValue(
                "@dogum",
                DoktorDogumTarihi.Value);

            cmd.Parameters.AddWithValue(
                "@sifre",
                textBoxSifre.Text);

            cmd.Parameters.AddWithValue(
                "@baslama",
                dtpBaslamaTarihi.Value.Date);

            cmd.Parameters.AddWithValue(
                "@egitim",
                textBoxEgitim.Text);

            cmd.Parameters.AddWithValue(
                "@id",
                doktorID);

            cmd.Parameters.AddWithValue(
                "@foto",
                fotoYolu);

            baglanti.Open();

            cmd.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show(
                "Doktor bilgileri güncellendi!"
            );

            this.Close();
        }

        string fotoYolu = "";
        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter ="Resim Dosyaları|*.jpg;*.png;*.jpeg";

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

                string hedefDosya = Path.Combine(hedefKlasor, dosyaAdi);

                File.Copy(kaynakDosya,hedefDosya,true);

                fotoYolu = dosyaAdi;

                pictureBoxDoktor.Image =
                    Image.FromFile(hedefDosya);
            }
        }

        void BranslariYukle()
        {
            comboBoxBrans.Items.Clear();

            SqlConnection baglanti = new SqlConnection(
                "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
            );

            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT Brans FROM Doktorlar",
                baglanti
            );

            baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxBrans.Items.Add(
                    dr["Brans"].ToString()
                );
            }

            baglanti.Close();
        }

        private void DoktorProfiliDuzenle_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}