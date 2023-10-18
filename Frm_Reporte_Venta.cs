using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using DATOS;
using NEGOCIO;
using ENTIDAD;
namespace Proyecto
{
    // codigo para generar el reporte de ventas
    public partial class Frm_Reporte_Venta : Form
    {
        //conexion prueba (borrar en caso de ser necesario)
        static string ConexionString = " server= localhost ; database= BD_VENTA_AUTO ; integrated security= true ";
        public SqlConnection con = new SqlConnection(ConexionString);
        //borrar hasta aqui

        VENTA_DAO cliente_entidad = new VENTA_DAO();
        VENTA_NEG cliente_neg = new VENTA_NEG();

        public Frm_Reporte_Venta()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese el Numero Venta ", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string x = textBox1.Text;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                dt = cliente_neg.BUSCAR(x);
                Frm_Reporteinformeventa reportar = new Frm_Reporteinformeventa();
                reportar.SetDataSource(dt);
                crystalReportViewer1.ReportSource = reportar;
            }
        }

        private void Frm_Reporte_Venta_Load(object sender, EventArgs e)
        {

        }
    }
}