
namespace PoS
{
    partial class sistema_de_reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMasVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMenosVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorConMasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorConMenosVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cortesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoMasVendidoToolStripMenuItem,
            this.productoMenosVendidoToolStripMenuItem,
            this.vendedorConMasVentasToolStripMenuItem,
            this.vendedorConMenosVentasToolStripMenuItem,
            this.ventasPorDiaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // productoMasVendidoToolStripMenuItem
            // 
            this.productoMasVendidoToolStripMenuItem.Name = "productoMasVendidoToolStripMenuItem";
            this.productoMasVendidoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.productoMasVendidoToolStripMenuItem.Text = "Producto mas vendido";
            this.productoMasVendidoToolStripMenuItem.Click += new System.EventHandler(this.productoMasVendidoToolStripMenuItem_Click);
            // 
            // productoMenosVendidoToolStripMenuItem
            // 
            this.productoMenosVendidoToolStripMenuItem.Name = "productoMenosVendidoToolStripMenuItem";
            this.productoMenosVendidoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.productoMenosVendidoToolStripMenuItem.Text = "Producto menos vendido";
            this.productoMenosVendidoToolStripMenuItem.Click += new System.EventHandler(this.productoMenosVendidoToolStripMenuItem_Click);
            // 
            // vendedorConMasVentasToolStripMenuItem
            // 
            this.vendedorConMasVentasToolStripMenuItem.Name = "vendedorConMasVentasToolStripMenuItem";
            this.vendedorConMasVentasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.vendedorConMasVentasToolStripMenuItem.Text = "vendedor con mas ventas";
            this.vendedorConMasVentasToolStripMenuItem.Click += new System.EventHandler(this.vendedorConMasVentasToolStripMenuItem_Click);
            // 
            // vendedorConMenosVentasToolStripMenuItem
            // 
            this.vendedorConMenosVentasToolStripMenuItem.Name = "vendedorConMenosVentasToolStripMenuItem";
            this.vendedorConMenosVentasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.vendedorConMenosVentasToolStripMenuItem.Text = "Vendedor con menos ventas";
            this.vendedorConMenosVentasToolStripMenuItem.Click += new System.EventHandler(this.vendedorConMenosVentasToolStripMenuItem_Click);
            // 
            // ventasPorDiaToolStripMenuItem
            // 
            this.ventasPorDiaToolStripMenuItem.Name = "ventasPorDiaToolStripMenuItem";
            this.ventasPorDiaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ventasPorDiaToolStripMenuItem.Text = "ventas por dia";
            this.ventasPorDiaToolStripMenuItem.Click += new System.EventHandler(this.ventasPorDiaToolStripMenuItem_Click);
            // 
            // cortesToolStripMenuItem
            // 
            this.cortesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corteXToolStripMenuItem,
            this.corteZToolStripMenuItem});
            this.cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            this.cortesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.cortesToolStripMenuItem.Text = "Cortes";
            // 
            // corteXToolStripMenuItem
            // 
            this.corteXToolStripMenuItem.Name = "corteXToolStripMenuItem";
            this.corteXToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.corteXToolStripMenuItem.Text = "Corte x";
            // 
            // corteZToolStripMenuItem
            // 
            this.corteZToolStripMenuItem.Name = "corteZToolStripMenuItem";
            this.corteZToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.corteZToolStripMenuItem.Text = "Corte z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvendo al sistema de reporte";
            // 
            // sistema_de_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "sistema_de_reportes";
            this.Text = "sistema_de_reportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMasVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMenosVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorConMasVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorConMenosVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteZToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}