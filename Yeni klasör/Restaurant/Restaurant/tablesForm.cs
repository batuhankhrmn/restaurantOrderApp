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
    public partial class tablesForm : Form
    {
        public tablesForm()
        {
            InitializeComponent();
            AyarlaListView();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string masaAdi = lblTable.Text.Trim();
            string urunAdi = txtOrder.Text.Trim();

            if (string.IsNullOrEmpty(masaAdi) || string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Lütfen masa seçin ve sipariş girin.");
                return;
            }

            SiparisEkle(masaAdi, urunAdi);
            txtOrder.Clear();
            YükleSiparisler(masaAdi);
        }

        private void Bahce1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Giris1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Ana1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Ana2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Ana3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Bahce6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Giris2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Giris3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Giris4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Ana4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Ana5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void Ana6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblTable.Text = btn.Text;
            YükleSiparisler(btn.Text);
        }

        private void SiparisEkle(string masaAdi, string urunAdi)
        {
            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";
            int masaID, siparisID;
            decimal fiyat;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Masa ID
                SqlCommand cmdMasa = new SqlCommand("SELECT MasaID FROM Masalar WHERE MasaAdi = @masaAdi", conn);
                cmdMasa.Parameters.AddWithValue("@masaAdi", masaAdi);
                masaID = (int)cmdMasa.ExecuteScalar();

                // 2. Ürün ID ve fiyat
                SqlCommand cmdUrun = new SqlCommand("SELECT UrunID, Fiyat FROM Urunler WHERE UrunAdi = @urunAdi", conn);
                cmdUrun.Parameters.AddWithValue("@urunAdi", urunAdi);
                SqlDataReader reader = cmdUrun.ExecuteReader();

                int urunID;
                if (reader.Read())
                {
                    urunID = (int)reader["UrunID"];
                    fiyat = (decimal)reader["Fiyat"];
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Bu ürün veritabanında bulunamadı.");
                    return;
                }
                reader.Close();

                // 3. Açık sipariş kontrolü
                SqlCommand cmdSiparisKontrol = new SqlCommand("SELECT SiparisID FROM Siparisler WHERE MasaID = @masaID AND Durum = 'Açık'", conn);
                cmdSiparisKontrol.Parameters.AddWithValue("@masaID", masaID);
                object result = cmdSiparisKontrol.ExecuteScalar();

                if (result != null)
                {
                    siparisID = (int)result;
                }
                else
                {
                    // Yeni sipariş oluştur
                    SqlCommand cmdYeniSiparis = new SqlCommand("INSERT INTO Siparisler (MasaID, KullaniciID, TarihSaat, Durum) OUTPUT INSERTED.SiparisID VALUES (@masaID, 1, GETDATE(), 'Açık')", conn);
                    cmdYeniSiparis.Parameters.AddWithValue("@masaID", masaID);
                    siparisID = (int)cmdYeniSiparis.ExecuteScalar();

                    // Masayı dolu yap
                    SqlCommand cmdMasaGuncelle = new SqlCommand("UPDATE Masalar SET Durum = 1 WHERE MasaID = @masaID", conn);
                    cmdMasaGuncelle.Parameters.AddWithValue("@masaID", masaID);
                    cmdMasaGuncelle.ExecuteNonQuery();
                }

                // 4. Sipariş detayına ekle
                SqlCommand cmdDetay = new SqlCommand("INSERT INTO SiparisDetaylari (SiparisID, UrunID, Adet, ToplamTutar) VALUES (@siparisID, @urunID, 1, @toplam)", conn);
                cmdDetay.Parameters.AddWithValue("@siparisID", siparisID);
                cmdDetay.Parameters.AddWithValue("@urunID", urunID);
                cmdDetay.Parameters.AddWithValue("@toplam", fiyat);
                cmdDetay.ExecuteNonQuery();
            }
        }

        private void YükleSiparisler(string masaAdi)
        {
            lvOrders.Items.Clear();
            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sorgu = @"
            SELECT sd.Adet, u.UrunAdi, sd.ToplamTutar
            FROM Masalar m
            JOIN Siparisler s ON m.MasaID = s.MasaID
            JOIN SiparisDetaylari sd ON s.SiparisID = sd.SiparisID
            JOIN Urunler u ON sd.UrunID = u.UrunID
            WHERE m.MasaAdi = @masaAdi AND s.Durum = 'Açık'
        ";

                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@masaAdi", masaAdi);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Adet"].ToString());
                    item.SubItems.Add(reader["UrunAdi"].ToString());
                    item.SubItems.Add(((decimal)reader["ToplamTutar"]).ToString("C"));
                    lvOrders.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void AyarlaListView()
        {
            lvOrders.View = View.Details;
            lvOrders.FullRowSelect = true;
            lvOrders.GridLines = true;

            lvOrders.Columns.Clear();
            lvOrders.Columns.Add("Adet", 50);
            lvOrders.Columns.Add("Ürün", 120);
            lvOrders.Columns.Add("Tutar", 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masaAdi = lblTable.Text.Trim();

            if (string.IsNullOrEmpty(masaAdi))
            {
                MessageBox.Show("Önce bir masa seçin.");
                return;
            }

            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Masa ID'yi al
                SqlCommand cmdMasa = new SqlCommand("SELECT MasaID FROM Masalar WHERE MasaAdi = @masaAdi", conn);
                cmdMasa.Parameters.AddWithValue("@masaAdi", masaAdi);
                object masaIDobj = cmdMasa.ExecuteScalar();

                if (masaIDobj == null)
                {
                    MessageBox.Show("Masa veritabanında bulunamadı.");
                    return;
                }

                int masaID = (int)masaIDobj;

                // O masaya ait açık siparişleri al
                SqlCommand cmdSiparisler = new SqlCommand("SELECT SiparisID FROM Siparisler WHERE MasaID = @masaID AND Durum = 'Açık'", conn);
                cmdSiparisler.Parameters.AddWithValue("@masaID", masaID);

                SqlDataReader reader = cmdSiparisler.ExecuteReader();

                List<int> siparisIDs = new List<int>();

                while (reader.Read())
                {
                    siparisIDs.Add((int)reader["SiparisID"]);
                }
                reader.Close();

                if (siparisIDs.Count == 0)
                {
                    MessageBox.Show("Bu masa için açık sipariş bulunmamaktadır.");
                    return;
                }

                // Sipariş detaylarını ve siparişleri sil
                foreach (int siparisID in siparisIDs)
                {
                    // Detayları sil
                    SqlCommand cmdDetaySil = new SqlCommand("DELETE FROM SiparisDetaylari WHERE SiparisID = @siparisID", conn);
                    cmdDetaySil.Parameters.AddWithValue("@siparisID", siparisID);
                    cmdDetaySil.ExecuteNonQuery();

                    // Siparişi sil
                    SqlCommand cmdSiparisSil = new SqlCommand("DELETE FROM Siparisler WHERE SiparisID = @siparisID", conn);
                    cmdSiparisSil.Parameters.AddWithValue("@siparisID", siparisID);
                    cmdSiparisSil.ExecuteNonQuery();
                }

                // Masayı boş yap (Durum = 0)
                SqlCommand cmdMasaGuncelle = new SqlCommand("UPDATE Masalar SET Durum = 0 WHERE MasaID = @masaID", conn);
                cmdMasaGuncelle.Parameters.AddWithValue("@masaID", masaID);
                cmdMasaGuncelle.ExecuteNonQuery();

                MessageBox.Show($"{masaAdi} masası temizlendi.");

                // ListView'u temizle
                lvOrders.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTable.Text))
            {
                MessageBox.Show("Önce bir masa seçin.");
                return;
            }

            string masaAdi = lblTable.Text;
            int masaID, siparisID;
            decimal toplamTutar = 0;

            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Masa ID al
                SqlCommand cmdMasa = new SqlCommand("SELECT MasaID FROM Masalar WHERE MasaAdi = @masaAdi", conn);
                cmdMasa.Parameters.AddWithValue("@masaAdi", masaAdi);
                object masaIDobj = cmdMasa.ExecuteScalar();

                if (masaIDobj == null)
                {
                    MessageBox.Show("Masa bulunamadı.");
                    return;
                }
                masaID = (int)masaIDobj;

                // Açık sipariş ID al
                SqlCommand cmdSiparis = new SqlCommand("SELECT SiparisID FROM Siparisler WHERE MasaID = @masaID AND Durum = 'Açık'", conn);
                cmdSiparis.Parameters.AddWithValue("@masaID", masaID);
                object siparisIDobj = cmdSiparis.ExecuteScalar();

                if (siparisIDobj == null)
                {
                    MessageBox.Show("Bu masaya ait açık sipariş bulunamadı.");
                    return;
                }
                siparisID = (int)siparisIDobj;

                // Toplam tutarı hesapla
                SqlCommand cmdToplam = new SqlCommand("SELECT SUM(ToplamTutar) FROM SiparisDetaylari WHERE SiparisID = @siparisID", conn);
                cmdToplam.Parameters.AddWithValue("@siparisID", siparisID);
                object toplamObj = cmdToplam.ExecuteScalar();

                if (toplamObj != DBNull.Value && toplamObj != null)
                {
                    toplamTutar = Convert.ToDecimal(toplamObj);
                }
            }

            // PayForm’u aç, bilgileri gönder
            payForm payForm = new payForm(masaID, siparisID, masaAdi, toplamTutar);
            payForm.ShowDialog();
            this.Close();
        }
    }
}
