using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Menu_Principal : Form
    {
        public Frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void stockInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Vehiculo abrir = new Frm_Vehiculo();

            abrir.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir del Sistema Venta Vehiculos ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

                return;



            }

            this.Dispose();
            this.Hide();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Venta abrir = new Frm_Venta();

            abrir.Show();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cliente abrir = new Frm_Cliente();

            abrir.Show();
        }

        private void Frm_Menu_Principal_Load(object sender, EventArgs e)
        {






        }

        private void consultaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registroServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Seguro abrir = new Frm_Seguro();

            abrir.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void reporteDeTratamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Reporte_Venta abrir = new Frm_Reporte_Venta();

            abrir.Show();
        }

        private void reporteDeConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Seguro_Vehiculos  abrir = new Frm_Reporte_Seguro_Vehiculos();

            abrir.Show();


        }

        private void registrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Vendedor abrir = new Frm_Vendedor();

            abrir.Show();

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Reporte_Venta abrir = new Frm_Reporte_Venta();

            abrir.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
