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
    public partial class KayitForm : Form
    {
        SqlConnection baglanti = new SqlConnection(
          "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
        );
        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(textBoxAd.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoyad.Text) ||
                string.IsNullOrWhiteSpace(textBoxTC.Text) ||
                string.IsNullOrWhiteSpace(textBoxSifre.Text) ||
                string.IsNullOrWhiteSpace(comboBoxCinsiyet.Text)
            )
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                return;
            }

            if (textBoxTC.Text.Length != 11)
            {
                MessageBox.Show("T.C. Kimlik Numarası 11 Haneli Olmalıdır!!");
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Hastalar (Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi) VALUES (@a,@s,@t,@p,@cinsiyet,@dogum)",
                    baglanti
                );

                cmd.Parameters.AddWithValue("@a", textBoxAd.Text);
                cmd.Parameters.AddWithValue("@s", textBoxSoyad.Text);
                cmd.Parameters.AddWithValue("@t", textBoxTC.Text);
                cmd.Parameters.AddWithValue("@p", textBoxSifre.Text);
                cmd.Parameters .AddWithValue("@cinsiyet", comboBoxCinsiyet.Text);
                cmd.Parameters.AddWithValue("@dogum", HastaDogumTarihi.Value.Date);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt başarıyla oluşturuldu!");

                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxTC.Clear();
                textBoxSifre.Clear();
                comboBoxCinsiyet.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Bu Kimlik Numarasına Ait Bir Kayıt Zaten Mevcut!");
                }
                else 
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnGiriseDon_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

			comboBoxCinsiyet.Items.Add("Kadın");
            comboBoxCinsiyet.Items.Add("Erkek");

            comboBoxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KayitForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}