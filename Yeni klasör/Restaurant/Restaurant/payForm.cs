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
    public partial class payForm : Form
    {
        private int masaID;
        private int siparisID;
        private string masaAdi;
        private decimal toplamTutar;
        public payForm(int masaID, int siparisID, string masaAdi, decimal toplamTutar)
        {
            InitializeComponent();

            this.masaID = masaID;
            this.siparisID = siparisID;
            this.masaAdi = masaAdi;
            this.toplamTutar = toplamTutar;

            lblMasaAdi.Text = masaAdi;
            lblToplamTutar.Text = toplamTutar.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Sipariş detaylarını sil
                SqlCommand cmdDetaySil = new SqlCommand("DELETE FROM SiparisDetaylari WHERE SiparisID = @siparisID", conn);
                cmdDetaySil.Parameters.AddWithValue("@siparisID", siparisID);
                cmdDetaySil.ExecuteNonQuery();

                // 2. Siparişi sil
                SqlCommand cmdSiparisSil = new SqlCommand("DELETE FROM Siparisler WHERE SiparisID = @siparisID", conn);
                cmdSiparisSil.Parameters.AddWithValue("@siparisID", siparisID);
                cmdSiparisSil.ExecuteNonQuery();

                // 3. Masayı boş yap (Durum = 0)
                SqlCommand cmdMasaGuncelle = new SqlCommand("UPDATE Masalar SET Durum = 0 WHERE MasaID = @masaID", conn);
                cmdMasaGuncelle.Parameters.AddWithValue("@masaID", masaID);
                cmdMasaGuncelle.ExecuteNonQuery();
            }

            MessageBox.Show("Ödeme alınmıştır.");

            this.Close();
            var table = new tablesForm();
            table.Show();
        }
    }
}
