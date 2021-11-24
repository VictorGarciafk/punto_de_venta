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
    public partial class sistema_de_reportes : Form
    {
        public sistema_de_reportes()
        {
            InitializeComponent();
            
        }

        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String titulo = "Producto mas vendido";
            String query = "SELECT ventas_detalle.id_producto, nombre_producto,COUNT(ventas_detalle.id_producto) as cantidad FROM productos INNER JOIN ventas_detalle USING (id_producto) GROUP BY ventas_detalle.id_producto HAVING cantidad = (SELECT COUNT(ventas_detalle.id_producto) FROM ventas_detalle INNER JOIN productos USING (id_producto) GROUP BY ventas_detalle.id_producto ORDER BY COUNT(ventas_detalle.id_producto) DESC LIMIT 1) ORDER BY cantidad;";
            new ProductoVendido(query, titulo).ShowDialog();
            query = "";
            titulo = "";
        }

        private void productoMenosVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String titulo = "Producto menos vendido";
            String query = "SELECT ventas_detalle.id_producto, nombre_producto,COUNT(ventas_detalle.id_producto) as cantidad FROM productos INNER JOIN ventas_detalle USING (id_producto) GROUP BY ventas_detalle.id_producto HAVING cantidad = (SELECT COUNT(ventas_detalle.id_producto) FROM ventas_detalle INNER JOIN productos USING (id_producto) GROUP BY ventas_detalle.id_producto ORDER BY COUNT(ventas_detalle.id_producto) LIMIT 1) ORDER BY cantidad;";
            new ProductoVendido(query, titulo).ShowDialog();
            query = "";
            titulo = "";
        }

        private void vendedorConMasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String titulo = "Vendedor con mas ventas";
            String query = "SELECT nombre, apellido_paterno , apellido_materno, COUNT(numero_empleado) AS numero_ventas FROM `usuarios` INNER JOIN ventas ON numero_empleado = operadorVenta WHERE permisoUsuario = 1 GROUP BY numero_empleado HAVING numero_ventas = (SELECT COUNT(ventas.operadorVenta) FROM ventas INNER JOIN usuarios ON numero_empleado = operadorVenta GROUP BY ventas.operadorVenta ORDER BY COUNT(ventas.operadorVenta) DESC LIMIT 1) ORDER BY numero_ventas;";
            new ventasUsuario(query, titulo).ShowDialog();
            query = "";
            titulo = "";
        }

        private void vendedorConMenosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String titulo = "Vendedor con menos ventas";
            String query = "SELECT nombre, apellido_paterno , apellido_materno, COUNT(numero_empleado) AS numero_ventas FROM `usuarios` INNER JOIN ventas ON numero_empleado = operadorVenta WHERE permisoUsuario = 1 GROUP BY numero_empleado HAVING numero_ventas = (SELECT COUNT(ventas.operadorVenta) FROM ventas INNER JOIN usuarios ON numero_empleado = operadorVenta GROUP BY ventas.operadorVenta ORDER BY COUNT(ventas.operadorVenta) LIMIT 1) ORDER BY numero_ventas;";
            new ventasUsuario(query, titulo).ShowDialog();
            query = "";
            titulo = "";
        }

        private void ventasPorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String query = "select DAY(fechaventa) as dia, MONTH(fechaventa) as mes, YEAR(fechaventa) as anio, count(*) as ventas from ventas group by dia order by fechaventa;";
            new ventaDia(query).ShowDialog();
            query = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
