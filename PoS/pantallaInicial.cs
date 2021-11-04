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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PuntoDeVenta().ShowDialog();
            this.Show();
            Application.Run(new pantallaInicial());
            this.Close();
        }
    }
}
