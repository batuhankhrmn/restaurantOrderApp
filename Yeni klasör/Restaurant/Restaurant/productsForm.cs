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
    public partial class productsForm : Form
    {
        public productsForm()
        {
            InitializeComponent();
            YukleMenu();
        }

        private void YukleMenu()
        {
            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sorgu = @"
            SELECT 
                u.UrunAdi AS [Ürün], 
                k.KategoriAdi AS [Kategori], 
                u.Fiyat AS [Fiyat (₺)], 
                u.Stok AS [Stok]
            FROM Urunler u
            INNER JOIN Kategoriler k ON u.KategoriID = k.KategoriID";

                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProducts.DataSource = dt;

                // Opsiyonel: otomatik genişlik, başlık vs.
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProducts.ReadOnly = true;
            }
        }

    }
}
