namespace Proyecto
{
    partial class Frm_Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeTratamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedorToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.serviciosReparacionToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendedorToolStripMenuItem.Image")));
            this.vendedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(144, 52);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // registrarVendedorToolStripMenuItem
            // 
            this.registrarVendedorToolStripMenuItem.Name = "registrarVendedorToolStripMenuItem";
            this.registrarVendedorToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.registrarVendedorToolStripMenuItem.Text = "Registrar Vendedor";
            this.registrarVendedorToolStripMenuItem.Click += new System.EventHandler(this.registrarVendedorToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(117, 52);
            this.registroToolStripMenuItem.Text = "Clientes";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroClienteToolStripMenuItem.Image")));
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.registroClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockInventarioToolStripMenuItem});
            this.inventariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventariosToolStripMenuItem.Image")));
            this.inventariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(122, 52);
            this.inventariosToolStripMenuItem.Text = "Vehiculo";
            this.inventariosToolStripMenuItem.Click += new System.EventHandler(this.inventariosToolStripMenuItem_Click);
            // 
            // stockInventarioToolStripMenuItem
            // 
            this.stockInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockInventarioToolStripMenuItem.Image")));
            this.stockInventarioToolStripMenuItem.Name = "stockInventarioToolStripMenuItem";
            this.stockInventarioToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.stockInventarioToolStripMenuItem.Text = "Registrar Vehiculo";
            this.stockInventarioToolStripMenuItem.Click += new System.EventHandler(this.stockInventarioToolStripMenuItem_Click);
            // 
            // serviciosReparacionToolStripMenuItem
            // 
            this.serviciosReparacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroServicioToolStripMenuItem});
            this.serviciosReparacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviciosReparacionToolStripMenuItem.Image")));
            this.serviciosReparacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.serviciosReparacionToolStripMenuItem.Name = "serviciosReparacionToolStripMenuItem";
            this.serviciosReparacionToolStripMenuItem.Size = new System.Drawing.Size(111, 52);
            this.serviciosReparacionToolStripMenuItem.Text = "Seguro";
            // 
            // registroServicioToolStripMenuItem
            // 
            this.registroServicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroServicioToolStripMenuItem.Image")));
            this.registroServicioToolStripMenuItem.Name = "registroServicioToolStripMenuItem";
            this.registroServicioToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.registroServicioToolStripMenuItem.Text = "Registrar Seguro";
            this.registroServicioToolStripMenuItem.Click += new System.EventHandler(this.registroServicioToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.comprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasToolStripMenuItem.Image")));
            this.comprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(108, 52);
            this.comprasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarCompraToolStripMenuItem.Image")));
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.registrarCompraToolStripMenuItem.Text = "Generar Venta";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeConsultaToolStripMenuItem,
            this.reporteDeTratamientoToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(124, 52);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeConsultaToolStripMenuItem
            // 
            this.reporteDeConsultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeConsultaToolStripMenuItem.Image")));
            this.reporteDeConsultaToolStripMenuItem.Name = "reporteDeConsultaToolStripMenuItem";
            this.reporteDeConsultaToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.reporteDeConsultaToolStripMenuItem.Text = "Reporte de Seguro";
            this.reporteDeConsultaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeConsultaToolStripMenuItem_Click);
            // 
            // reporteDeTratamientoToolStripMenuItem
            // 
            this.reporteDeTratamientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeTratamientoToolStripMenuItem.Image")));
            this.reporteDeTratamientoToolStripMenuItem.Name = "reporteDeTratamientoToolStripMenuItem";
            this.reporteDeTratamientoToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.reporteDeTratamientoToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeTratamientoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeTratamientoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(89, 52);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarToolStripMenuItem.Image")));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(307, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 112);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Venta Vehiculo\r\n ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Venta Vehiculos";
            this.Load += new System.EventHandler(this.Frm_Menu_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeTratamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendedorToolStripMenuItem;
    }
}