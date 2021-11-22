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
    public partial class ventasUsuario : Form
    {
        public ventasUsuario(String query2)
        {
            InitializeComponent();
            uVendido(query2);
        }

        public void uVendido(String query)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_precios; SSL mode=none");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            label1.Text = "";
            while (reader.Read())
            {
                label1.Text += (reader["nombre"].ToString() + " " + reader["apellido_paterno"].ToString() + " " + reader["apellido_materno"].ToString() + "-" + reader["numero_ventas"].ToString());
            }
        }
    }
}
