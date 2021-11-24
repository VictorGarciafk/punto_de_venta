using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class ProductoVendido : Form
    {
        public ProductoVendido(String query2, String titulo)
        {
            InitializeComponent();
            label2.Location = new Point(this.Width / 3, 0);
            panel1.Location = new Point(0, label2.Location.Y + label2.Height + 20);
            panel1.Width = this.Width;
            panel1.Height = this.Height - label2.Height - 20;
            dataGridView1.Columns[0].Width = 260;
            dataGridView1.Columns[1].Width = 260;
            dataGridView1.Columns[2].Width = 260;
            pVendido(query2, titulo);
        }

        public void pVendido(String query, String titulo)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_precios; SSL mode=none");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            label2.Text = titulo;
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
        }

        private void masVendido_Load(object sender, EventArgs e)
        {
            
        }
    }
}
