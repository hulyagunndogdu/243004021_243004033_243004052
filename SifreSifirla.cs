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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneSistemi
{
    public partial class SifreSifirla : Form
    {
        public SifreSifirla()
        {
            InitializeComponent();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(
                "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;");

            if (string.IsNullOrWhiteSpace(textBoxKullanici.Text) ||
                string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxRol.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Türü Seçiniz!");
                return;
            }
            if (comboBoxRol.Text == "Hasta" && textBoxKullanici.Text.Length != 11)
            {
                MessageBox.Show("T.C. Kimlik Numarası 11 Haneli Olmalıdır!!");
                return;
            }

            try
            {
                baglanti.Open();

                string sorgu = "";

                if (comboBoxRol.Text == "Hasta")
                {
                    sorgu = "UPDATE Hastalar SET Sifre=@sifre WHERE TC=@kullanici";
                }
                else if (comboBoxRol.Text == "Doktor")
                {
                    sorgu = "UPDATE Doktorlar SET Sifre=@sifre WHERE SicilNo=@kullanici";
                }
                else if (comboBoxRol.Text == "Admin")
                {
                    sorgu = "UPDATE Adminler SET Sifre=@sifre WHERE KullaniciAdi=@kullanici";
                }

                SqlCommand cmd = new SqlCommand(sorgu, baglanti);

                cmd.Parameters.AddWithValue("@kullanici", textBoxKullanici.Text);
                cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);

                int sonuc = cmd.ExecuteNonQuery();

                if(sonuc > 0)
                {
                    MessageBox.Show("Şifre Güncellendi");

                    comboBoxRol.SelectedIndex = -1;
                    textBoxKullanici.Clear();
                    textBoxSifre.Clear();

                    Form1 frm = new Form1();
                    frm.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bilgiler Eşleşmedi!");
                }
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

        private void SifreSifirla_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnSifreGuncelle;

            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxRol.Items.Add("Hasta");
            comboBoxRol.Items.Add("Doktor");
            comboBoxRol.Items.Add("Admin");
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRol.Text == "Hasta")
            {
                labelTC.Text = "TC Kimlik No :";
                textBoxKullanici.MaxLength = 11;
            }
            else if(comboBoxRol.Text == "Doktor")
            {
                labelTC.Text = "Sicil No :";
                textBoxKullanici.MaxLength = 20;
            }
            else if (comboBoxRol.Text == "Admin")
            {
                labelTC.Text = "Kullanıcı Adı :";
                textBoxKullanici.MaxLength = 30;
            }
        }

        private void textBoxKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxRol.Text == "Hasta") 
            { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                { 
                    e.Handled = true; 
                } 
            }
        }
    }
}