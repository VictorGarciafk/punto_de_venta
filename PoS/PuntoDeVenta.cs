using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoS
{
    public partial class PuntoDeVenta : Form
    {
        private double total = 0.0;
        public PuntoDeVenta()
        {
            InitializeComponent();
        }
        double pago = 0;
        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = 250;
            pictureBox1.Height = this.Height / 6;
            pictureBox2.Width = 250;
            pictureBox2.Height = this.Height / 6;
            Billete50.Width = Billete100.Width = Billete200.Width =Billete500.Width = 150;
            Billete50.Height = Billete100.Height = Billete200.Height = Billete500.Height = 75;
            pictureBox1.Location = new Point(this.Width - pictureBox1.Width - 10, 10);
            panel1.Location = new Point(40 + (this.Width / 6) * 4, (this.Height / 6) + 20);
            panel1.Height = (this.Height / 6) * 4;
            panel1.Width = (this.Width / 8) * 2 - 10;
            Billete50.Location = new Point(panel1.Location.X, this.Height - textBox1.Location.Y);
            Billete100.Location = new Point(panel1.Location.X + Billete50.Width, this.Height - textBox1.Location.Y);
            Billete200.Location = new Point(panel1.Location.X + Billete50.Width + Billete100.Width, this.Height - textBox1.Location.Y);
            Billete500.Location = new Point(panel1.Location.X + Billete50.Width + Billete100.Width + Billete200.Width, this.Height - textBox1.Location.Y);


            label1.Location = new Point(this.Width / 2 - label1.Width / 2, 0);
            pictureBox2.Location = new Point(10, 10);
            label3.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            label3.Location = new Point(this.Width / 2 - label3.Width / 2, label1.Height + label1.Height);
            dataGridView1.Location = new Point(20, (this.Height / 6) + 20);
            dataGridView1.Width = (this.Width / 6) * 4;
            dataGridView1.Height = (this.Height / 6) * 4;
            dataGridView1.Columns[0].Width = dataGridView1.Width * 20 / 100;
            dataGridView1.Columns[1].Width = dataGridView1.Width * 40 / 100;
            dataGridView1.Columns[2].Width = dataGridView1.Width * 20 / 100;
            dataGridView1.Columns[3].Width = dataGridView1.Width * 20 / 100;
            dataGridView1.RowTemplate.Height = 60;
            textBox1.Location = new Point(20, dataGridView1.Height + textBox1.Height + this.Height / 6);
            textBox1.Width = dataGridView1.Width;
            label4.Location = new Point(20, 20);
            label2.Location = new Point(20, label4.Location.Y + label4.Height + 20);
            label5.Location = new Point(20, label2.Location.Y + label5.Height + 20);
            dataGridView1.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            label2.Visible = false;
            label5.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Visible = false;
            label5.Visible = false;
            
            if (e.KeyChar == 98 && dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.CurrentRow.Index;
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) > 1)
                {
                    dataGridView1.CurrentRow.Cells[0].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) - 1;
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }

                CalcularTotal();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                String query = "SELECT * FROM productos WHERE producto_codigo =" + textBox1.Text;
                String datosComparar;
                Boolean nuevaEntrada = true;
                

                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_precios; SSL mode=none");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.HasRows)
                    {
                        mySqlDataReader.Read();
                        if (dataGridView1.Rows.Count != 0)
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                datosComparar = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                if (mySqlDataReader.GetString(1) == datosComparar)
                                {
                                    int cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()) + 1;
                                    decimal precio = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    decimal total = cantidad * precio;
                                    dataGridView1.Rows[i].Cells[0].Value = cantidad;
                                    dataGridView1.Rows[i].Cells[3].Value = total;
                                    nuevaEntrada = false;
                                }
                            }

                            if (nuevaEntrada == true)
                            {
                                dataGridView1.Rows.Add(1, mySqlDataReader.GetString(1), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)));
                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(1, mySqlDataReader.GetString(1), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)));
                        }

                        CalcularTotal();
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if ((e.KeyChar == 'P' || e.KeyChar == 'p') && !String.IsNullOrEmpty(textBox1.Text))
            {
                e.Handled = true;
                pago = Convert.ToDouble(textBox1.Text);
                pagar(pago);   
            }
            // Abrir nuevo winform vacio
            if (e.KeyChar == 'N' || e.KeyChar == 'n')
            {
                var n = new PuntoDeVenta();
                n.Show();
                this.Hide();
            }
            // Cerrar winforms y termina la app
            if (e.KeyChar == 27)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void CalcularTotal()
        {
            total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Double.Parse(dataGridView1[3, i].Value.ToString());
            }
            label4.Text = "Total: " + String.Format("{0:0.00}", total);

        }
        private void pagar(Double pago)
        {
            
            if (pago < total)
            {
                MessageBox.Show("Monto insuficiente");
                textBox1.Clear();
                textBox1.Focus();
                label2.Visible = true;
                label5.Visible = true;
            }
            else
            {
                label2.Text = $"Pagó con: " + pago;
                label5.Text = $"Cambio: {Math.Round(pago - total, 2)}";
                dataGridView1.Rows.Clear();
                textBox1.Clear();
                textBox1.Focus();
                label2.Visible = true;
                label5.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Billete100_Click(object sender, EventArgs e)
        {
            pago = 100;
            pagar(pago);
            pago = 0;
        }

        private void Billete50_Click(object sender, EventArgs e)
        {
            pago = 50;
            pagar(pago);
            pago = 0;
        }

        private void Billete200_Click(object sender, EventArgs e)
        {
            pago = 200;
            pagar(pago);
            pago = 0;
        }

        private void Billete500_Click(object sender, EventArgs e)
        {
            pago = 500;
            pagar(pago);
            pago = 0;
        }
    }
}
