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

namespace Restaurant
{
    public partial class raporForm : Form
    {
        public raporForm()
        {
            InitializeComponent();
            RaporlariYukle();
        }

        private void RaporlariYukle()
        {
            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Toplam Ciro
                string ciroQuery = "SELECT ISNULL(SUM(Tutar), 0) FROM Odemeler";
                SqlCommand cmdCiro = new SqlCommand(ciroQuery, conn);
                decimal toplamCiro = (decimal)cmdCiro.ExecuteScalar();
                lblEarning.Text = toplamCiro.ToString("C2"); // Örn: ₺1.250,00

                // 2. Toplam Satılan Ürün Sayısı
                string urunAdetQuery = "SELECT ISNULL(SUM(Adet), 0) FROM SiparisDetaylari";
                SqlCommand cmdAdet = new SqlCommand(urunAdetQuery, conn);
                int toplamAdet = Convert.ToInt32(cmdAdet.ExecuteScalar());
                lblProductSell.Text = toplamAdet.ToString();

                // 3. En Çok Satan Ürün (1 tane)
                string mostSellingQuery = @"
            SELECT TOP 1 u.UrunAdi, SUM(sd.Adet) AS ToplamSatis
            FROM SiparisDetaylari sd
            INNER JOIN Urunler u ON u.UrunID = sd.UrunID
            GROUP BY u.UrunAdi
            ORDER BY ToplamSatis DESC";
                SqlCommand cmdMost = new SqlCommand(mostSellingQuery, conn);
                SqlDataReader reader = cmdMost.ExecuteReader();

                if (reader.Read())
                    lblMostSelling.Text = reader["UrunAdi"].ToString();
                else
                    lblMostSelling.Text = "Henüz yok";
                reader.Close();

                // 4. Tüm Siparişleri Listele
                string siparisQuery = @"
            SELECT s.SiparisID, m.MasaAdi, u.AdSoyad AS Garson, s.TarihSaat, 
                   ur.UrunAdi, sd.Adet, sd.ToplamTutar
            FROM Siparisler s
            INNER JOIN Kullanicilar u ON u.KullaniciID = s.KullaniciID
            INNER JOIN Masalar m ON m.MasaID = s.MasaID
            INNER JOIN SiparisDetaylari sd ON sd.SiparisID = s.SiparisID
            INNER JOIN Urunler ur ON ur.UrunID = sd.UrunID
            ORDER BY s.TarihSaat DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(siparisQuery, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProducts.DataSource = dt;
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

    }
}
