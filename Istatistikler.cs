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
    public partial class Istatistikler : Form
    {
        SqlConnection baglanti = new SqlConnection(
          "Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;");

        public Istatistikler()
        {
            InitializeComponent();
        }

        void PanelOrtala()
        {
            panelIcerik.Left =
                (panelArkaPlan.Width - panelIcerik.Width) / 2;

            panelIcerik.Top =
                (panelArkaPlan.Height - panelIcerik.Height) / 2;
        }

        private void Istatistikler_Load(object sender, EventArgs e)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

			PanelOrtala();
            VerileriGetir();
        }

        private void Istatistikler_Resize(object sender, EventArgs e)
        {
            PanelOrtala();
        }

        void VerileriGetir()
        {
            lblDoktorSayi.Text = GetCount("SELECT COUNT(*) FROM Doktorlar");
            lblHastaSayi.Text = GetCount("SELECT COUNT(*) FROM Hastalar");
            lblRandevuSayi.Text = GetCount("SELECT COUNT(*) FROM Randevular");
            lblBransSayi.Text = GetCount("SELECT COUNT(DISTINCT Brans) FROM Doktorlar");

            lblBugunkuRandevu.Text = GetCount(
                "SELECT COUNT(*) FROM Randevular WHERE Tarih = CAST(GETDATE() AS DATE)");

            lblBuHaftakiRandevu.Text = GetCount(
                "SELECT COUNT(*) FROM Randevular WHERE Tarih >= DATEADD(DAY, -7, GETDATE())");

            lblKadinHastaSayi.Text = GetCount(
                "SELECT COUNT(*) FROM Hastalar WHERE Cinsiyet='Kadın'");

            lblErkekHastaSayi.Text = GetCount(
                "SELECT COUNT(*) FROM Hastalar WHERE Cinsiyet='Erkek'");
        }

        string GetCount(string query)
        {
            using (SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=HastaneDB;Trusted_Connection=True;"))
            {
                baglanti.Open();

                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    string result = cmd.ExecuteScalar()?.ToString();
                    return result ?? "0";
                }
            }
        }
    }
}