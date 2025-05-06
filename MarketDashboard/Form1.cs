using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;


namespace MarketDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTicker.Items.Clear(); // clear it once

            string connStr = "Server=localhost\\SQLEXPRESS;Database=MarketData;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT Ticker FROM MarketPrices", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                HashSet<string> seen = new HashSet<string>();

                while (reader.Read())
                {
                    string ticker = reader["Ticker"].ToString().Trim().ToUpper();
                    if (!seen.Contains(ticker))
                    {
                        comboBoxTicker.Items.Add(ticker);
                        seen.Add(ticker);
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=MarketData;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (comboBoxTicker.SelectedItem != null)
                {
                    query = "SELECT * FROM MarketPrices WHERE Ticker = '" + comboBoxTicker.SelectedItem.ToString() + "'";
                }
                else
                {
                    query = "SELECT * FROM MarketPrices";
                }


                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                // Calculate KPIs
                if (dt.Rows.Count > 0)
                {
                    double avgPrice = Convert.ToDouble(dt.Compute("AVG(Price)", ""));
                    int totalVolume = Convert.ToInt32(dt.Compute("SUM(Volume)", ""));

                    labelAvgPrice.Text = "Average Price: $" + avgPrice.ToString("F2");
                    labelTotalVolume.Text = "Total Volume: " + totalVolume.ToString();
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
