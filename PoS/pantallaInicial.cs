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
    public partial class pantallaInicial : Form
    {
        public pantallaInicial()
        {
            InitializeComponent();
            pictureBox1.Location = new Point((this.Width / 2) + pictureBox1.Width / 2);
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            
        }

        String nombre = "";
        String apellidoP = "";
        String apellidoM = "";

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM usuarios WHERE nombre = '"+ User.Text + "' and pass = '" + Contraseña.Text + "'";

            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_precios; SSL mode=none");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            PuntoDeVenta PV = new PuntoDeVenta();

            if (mySqlDataReader.Read())
            {
                nombre = mySqlDataReader.GetString(1);
                apellidoP = mySqlDataReader.GetString(2);
                apellidoM = mySqlDataReader.GetString(3);
                PV.trabajador_actual(nombre, apellidoP, apellidoM);
                MessageBox.Show("Bienvenid@ " + nombre);
                this.Hide();
                PV.ShowDialog();

                this.Show();
                //Application.Run(new pantallaInicial());
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, intentalo de nuevo");
            }
            mySqlConnection.Close();
            
        }
    }
}
