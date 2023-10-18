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

namespace Proyecto
{
    public partial class Frm_Reporte_Seguro_Vehiculos : Form
    {



        VEHICULO_DAO cliente_entidad = new VEHICULO_DAO();
        VEHICULO_NEG cliente_neg = new VEHICULO_NEG();



        public Frm_Reporte_Seguro_Vehiculos()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Seguro_Vehiculos_Load(object sender, EventArgs e)
        {

            DataSet dset = new DataSet();

            DataTable dt = new DataTable();

            dt = cliente_neg.LISTARVEHICULO();

            Frm_Reporteinformevehiculos reportar = new Frm_Reporteinformevehiculos();

            reportar.SetDataSource(dt);

            crystalReportViewer1.ReportSource = reportar;

        }
    }
}
