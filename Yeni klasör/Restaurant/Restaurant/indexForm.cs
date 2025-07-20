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
    public partial class indexForm : Form
    {
        public indexForm()
        {
            InitializeComponent();
            int bosMasaSayisi = GetBosMasaSayisi();
            lblTables.Text = $"Boş Masa Sayısı: {bosMasaSayisi}";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            var log = new raporForm();
            log.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            var product = new productsForm();
            product.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            var table = new tablesForm();
            table.Show();
        }

        private int GetBosMasaSayisi()
        {
            int count = 0;
            string connectionString = "Data Source=BATUHAN;Initial Catalog=Restaurant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sorgu = "SELECT COUNT(*) FROM Masalar WHERE Durum = 0";

                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    count = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return count;
        }
    }
}
