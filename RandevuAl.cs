using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HastaneSistemi
{
    public partial class RandevuAlForm : Form
    {
        int hastaID;
        int seciliDoktorID;
        string seciliSaat = "";

        SqlConnection baglanti = new SqlConnection(
            "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"
        );

        public RandevuAlForm(int id)
        {
            InitializeComponent();
            hastaID = id;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void RandevuAlForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            RandevuAlForm_Resize(null, null);

            panel4.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            lblPuan.Visible = false;
            dgvYorumlar.Visible = false;
            panelDoktor.Visible = false;

            comboBoxPoliklinik.Items.Clear();

            tarih.MinDate = DateTime.Today;

            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT Brans FROM Doktorlar",
                baglanti
            );

            baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxPoliklinik.Items.Add(dr["Brans"].ToString());
            }

            baglanti.Close();

            SaatButonlariniOlustur();
            SaatleriGuncelle();
        }

        void YorumlariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT
                 Y.YorumMetni,
                 Y.Puan,
                 Y.Tarih,
                 H.Ad + ' ' + H.Soyad AS Hasta
                FROM Yorumlar Y
                INNER JOIN Hastalar H ON Y.HastaID = H.HastaID
                WHERE Y.DoktorID = @d
                ORDER BY Y.Tarih DESC",
                baglanti
            );

            da.SelectCommand.Parameters.AddWithValue("@d", seciliDoktorID);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvYorumlar.DataSource = dt;

            SqlCommand cmd = new SqlCommand(
               @"SELECT AVG(CAST(Puan AS FLOAT))
                 FROM Yorumlar
                 WHERE DoktorID=@d",
               baglanti
            );

            cmd.Parameters.AddWithValue("@d", seciliDoktorID);

            baglanti.Open();

            object sonuc = cmd.ExecuteScalar();

            baglanti.Close();

            if (sonuc != DBNull.Value)
            {
                lblPuan.Text = "⭐ " + Convert.ToDouble(sonuc).ToString("0.0") + " / 5";
            }
            else
            {
                lblPuan.Text = "Henüz puan yok";
            }




            dgvYorumlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYorumlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvYorumlar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (dgvYorumlar.Columns["YorumMetni"] != null)
            {
                dgvYorumlar.Columns["YorumMetni"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dgvYorumlar.ReadOnly = true;
            dgvYorumlar.AllowUserToAddRows = false;

            if (dgvYorumlar.Columns["YorumMetni"] != null)
            {
                dgvYorumlar.Columns["YorumMetni"].HeaderText = "Yorum";
            }
            if (dgvYorumlar.Columns["Puan"] != null)
            {
                dgvYorumlar.Columns["Puan"].HeaderText = "Puan";
            }
            if (dgvYorumlar.Columns["Tarih"] != null) 
            { 
            dgvYorumlar.Columns["Tarih"].HeaderText = "Tarih";
            }
            if (dgvYorumlar.Columns["Hasta"] != null)
            {
                dgvYorumlar.Columns["Hasta"].HeaderText = "Hasta";
            }

            dgvYorumlar.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;
        }

        void SaatButonlariniOlustur()
        {
            panelSaat.Controls.Clear();

            DateTime baslangic = DateTime.Today.AddHours(8);
            DateTime bitis = DateTime.Today.AddHours(16);

            int x = 10;
            int y = 10;

            while (baslangic < bitis)
            {
                if (baslangic.Hour == 12)
                {
                    baslangic = baslangic.AddHours(1);
                    continue;
                }

                Button btn = new Button();
                btn.Width = 70;
                btn.Height = 30;

                string saat = baslangic.ToString("HH:mm");

                btn.Text = saat;
                btn.Tag = saat;

                btn.Left = x;
                btn.Top = y;

                btn.Click += SaatTiklandi;

                btn.MouseEnter += (s, e) =>
                {
                  Button b = (Button)s;
                  b.BackColor = Color.LightBlue;
                };

                btn.MouseLeave += (s, e) =>
                {
                  SaatleriGuncelle();
                };

                panelSaat.Controls.Add(btn);

                x += 75;

                if (x > panelSaat.Width - 80)
                {
                    x = 10;
                    y += 35;
                }

                baslangic = baslangic.AddMinutes(10);
            }
        }

        void SaatTiklandi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            foreach (Control c in panelSaat.Controls)
            {
                if (c is Button b && b.Enabled)
                {
                    b.BackColor = Color.LightGreen;
                }
            }
            
            btn.BackColor = Color.DodgerBlue;

            seciliSaat = btn.Tag.ToString();
        }

        void SaatleriGuncelle()
        {
            foreach (Control c in panelSaat.Controls)
            {
                if (c is Button btn && btn.Tag != null)
                {
                    string saat = btn.Tag.ToString();

                    bool dolu = SaatDoluMu(saat);

                    if (saat == seciliSaat)
                    {
                        btn.BackColor = Color.DodgerBlue;
                    }
                    else
                    {
                        btn.BackColor = dolu
                            ? Color.Gray
                            : Color.LightGreen;
                    }

                    btn.ForeColor = dolu
                        ? Color.DarkGray
                        : Color.Black;

                    btn.Enabled = !dolu;

                }
            }
        }

        bool SaatDoluMu(string saat)
        {
            if (tarih.Value.Date == DateTime.Today)
            {
                TimeSpan secilenSaat = TimeSpan.Parse(saat);

                if (secilenSaat <= DateTime.Now.TimeOfDay)
                {
                    return true;
                }
            }

            SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*) FROM Randevular WHERE 
                DoktorID=@d
                AND Tarih=@t
                AND Saat=@s
                AND Durum='Aktif'",
                baglanti
            );

            cmd.Parameters.AddWithValue("@d", seciliDoktorID);
            cmd.Parameters.AddWithValue("@t", tarih.Value.Date);
            cmd.Parameters.AddWithValue("@s", TimeSpan.Parse(saat));

            int sonuc = 0;

            try
            {
               baglanti.Open();

               sonuc = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

            return sonuc > 0;
        }

        private void comboBoxPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();

            SqlCommand cmd = new SqlCommand(
                @"SELECT Ad, Soyad, DoktorID
                 FROM Doktorlar 
                 WHERE Brans=@b
                 AND Durum='Aktif'",
                baglanti
            );

            cmd.Parameters.AddWithValue(
                "@b",
                comboBoxPoliklinik.Text
            );

            baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxDoktor.Items.Add(
                    new ComboboxItem
                    {
                        Text = dr["Ad"] + " " + dr["Soyad"],
                        Value = dr["DoktorID"]
                    }
                );
            }
            baglanti.Close();
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoktor.SelectedItem == null)
                return;

            ComboboxItem item = (ComboboxItem)comboBoxDoktor.SelectedItem;
            seciliDoktorID = Convert.ToInt32(item.Value);

            panel4.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            lblPuan.Visible = true;
            dgvYorumlar.Visible = true;
            panelDoktor.Visible = true;

            seciliSaat = "";

            YorumlariGetir();
            SaatleriGuncelle();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Doktorlar WHERE DoktorID=@id",
                baglanti
            );

            cmd.Parameters.AddWithValue("@id", seciliDoktorID);

            baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblAdSoyad.Text =
                    "Ad Soyad: " +
                    dr["Ad"] + " " +
                    dr["Soyad"];

                lblBrans.Text =
                    "Branş: " + dr["Brans"];

                lblEgitim.Text =
                    "Eğitim: " + dr["MezunOkul"].ToString();

                if (dr["BaslamaTarihi"] != DBNull.Value)
                {
                    lblBaslamaTarihi.Text =
                        "Mesleğe Başlangıç: " +
                        Convert.ToDateTime(dr["BaslamaTarihi"]).ToString("dd.MM.yyyy");
                }
                else
                {
                    lblBaslamaTarihi.Text = "Mesleğe Başlangıç: Belirtilmemiş";
                }
                    string varsayilanResim = Path.Combine(
                         Application.StartupPath,
                         "Images",
                         "Doktorlar",
                         "doktor_avatar.jpeg"
                    );

                if (dr["Fotograf"] != DBNull.Value)
                {
                    string yol = Path.Combine(
                        Application.StartupPath,
                        "Images",
                        "Doktorlar",
                        dr["Fotograf"].ToString()
                    );

                    if (File.Exists(yol))
                    {
                        using (var img = Image.FromFile(yol))
                        {
                            pictureDoktor.Image = new Bitmap(img);
                        }
                    }
                    else
                    {
                        pictureDoktor.Image = new Bitmap(varsayilanResim);
                    }
                }
                else
                {
                    pictureDoktor.Image = new Bitmap(varsayilanResim);
                }

                lblCinsiyet.Text =
                    "Cinsiyet: " + dr["Cinsiyet"].ToString();

                lblDogumTarihi.Text =
                    "Doğum Tarihi: " +
                    Convert.ToDateTime(dr["DogumTarihi"])
                    .ToString("dd.MM.yyyy");
            }
            baglanti.Close();
        }
        

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (seciliDoktorID == 0 ||
                string.IsNullOrEmpty(seciliSaat))
            {
                MessageBox.Show(
                    "Lütfen seçimleri tamamlayın!"
                );
                return;
            }

            SqlCommand kontrol = new SqlCommand(
             @"SELECT COUNT(*) 
              FROM Randevular
              WHERE HastaID=@h
              AND DoktorID=@d
              AND Tarih >= CAST(GETDATE() AS DATE)
              AND Durum <> 'İptal'",
              baglanti
            );

            kontrol.Parameters.AddWithValue("@h", hastaID);
            kontrol.Parameters.AddWithValue("@d", seciliDoktorID);

            baglanti.Open();

            int varMi = (int)kontrol.ExecuteScalar();

            baglanti.Close();

            if (varMi > 0)
            {
                MessageBox.Show(
                    "Bu doktordan zaten aktif randevunuz var!"
                );
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Randevular (HastaID, DoktorID, Tarih, Saat, Durum) VALUES (@h,@d,@t,@s,'Aktif')",
                baglanti
            );

            cmd.Parameters.AddWithValue("@h", hastaID);
            cmd.Parameters.AddWithValue("@d", seciliDoktorID);
            cmd.Parameters.AddWithValue("@t", tarih.Value.Date);
            cmd.Parameters.AddWithValue("@s", TimeSpan.Parse(seciliSaat));

            try
            {
                baglanti.Open();

                cmd.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Randevunuz başarıyla oluşturuldu.\nSağlıklı günler dileriz.",
                                 "Beyşehir Devlet Hastanesi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);

                if(baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

            seciliSaat = "";
            SaatleriGuncelle();

            foreach (Control c in panelSaat.Controls)
            {
                if (c is Button b && b.Enabled)
                {
                    b.BackColor = Color.LightGreen;
                }
            }
            SaatleriGuncelle();
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {
            SaatleriGuncelle();
        }

        private void RandevuAlForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void dgvYorumlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHastaPaneleDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHastaPaneleDon_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}