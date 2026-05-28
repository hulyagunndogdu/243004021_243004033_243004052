using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(
            "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
        );

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(170, 255, 255, 255);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string resimYolu = Path.Combine(
                Application.StartupPath,
                "Images",
                "beysehirdevlethastanesi.jpg"
            );

            if (File.Exists(resimYolu))
            {
                this.BackgroundImage = Image.FromFile(resimYolu);
                this.BackgroundImageLayout = ImageLayout.Stretch;

            }

            this.WindowState = FormWindowState.Maximized;

			Directory.CreateDirectory(Application.StartupPath + "\\Images\\Doktorlar\\");

            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AcceptButton = btnGiris;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string rol = comboBoxRol.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(comboBoxRol.Text))
                {
                    MessageBox.Show("Lütfen Kullanıcı Türü Seçiniz!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxKullanici.Text) ||
                         string.IsNullOrWhiteSpace(textBoxSifre.Text))
                {
                    MessageBox.Show("Lütfen İstenen Bilgileri Doldurunuz!");
                    return;
                }

                baglanti.Open();

                if (rol == "Hasta")
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT HastaID FROM Hastalar WHERE TC=@k AND Sifre=@s", baglanti);

                    cmd.Parameters.AddWithValue("@k", textBoxKullanici.Text);
                    cmd.Parameters.AddWithValue("@s", textBoxSifre.Text);

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != null)
                    {
                        int hastaId = Convert.ToInt32(sonuc);

                        HastaPanel hp = new HastaPanel(hastaId);
                        hp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı hasta bilgisi!");
                    }
                }

                else if (rol == "Doktor")
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT DoktorID FROM Doktorlar WHERE SicilNo=@k AND Sifre=@s", baglanti);

                    cmd.Parameters.AddWithValue("@k", textBoxKullanici.Text);
                    cmd.Parameters.AddWithValue("@s", textBoxSifre.Text);

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != null)
                    {
                        int doktorId = Convert.ToInt32(sonuc);

                        DoktorPanel dp = new DoktorPanel(doktorId);
                        dp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı doktor bilgisi!");
                    }
                }

                else if (rol == "Admin")
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT AdminID FROM Adminler WHERE KullaniciAdi=@k AND Sifre=@s", baglanti);

                    cmd.Parameters.AddWithValue("@k", textBoxKullanici.Text);
                    cmd.Parameters.AddWithValue("@s", textBoxSifre.Text);

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != null)
                    {
                        int adminId = Convert.ToInt32(sonuc);

                        AdminPanel ap = new AdminPanel();
                        ap.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı admin bilgisi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if(baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        private void buttonKayitAc_Click(object sender, EventArgs e)
        {
            KayitForm k = new KayitForm();
            k.Show();
            this.Hide();
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRol.Text == "Hasta")
            {
                label1.Text = "T.C. Kimlik No: ";

                buttonKayitAc.Visible = true;
            }
            else if(comboBoxRol.Text == "Doktor")
            {
                label1.Text = "Sicil No: ";

                buttonKayitAc.Visible = false;
            }
            else if(comboBoxRol.Text == "Admin")
            {
                label1.Text = "Kullanıcı Adı: ";

                buttonKayitAc.Visible = false;
            }
        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreSifirla sifre = new SifreSifirla();
            sifre.Show();
        }
    }
}