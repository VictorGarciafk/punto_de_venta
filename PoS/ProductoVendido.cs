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
        public ProductoVendido(String query2)
        {
            InitializeComponent();
            pVendido(query2);
        }

        public void pVendido(String query)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_precios; SSL mode=none");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            label1.Text = "";
            while (reader.Read())
            {
                label1.Text += (reader["id_producto"].ToString() + "-" + reader["nombre_producto"].ToString() + "-" + reader["cantidad"].ToString());
            }
        }

        private void masVendido_Load(object sender, EventArgs e)
        {
            
        }
    }
}
