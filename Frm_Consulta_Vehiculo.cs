using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ENTIDAD;
using NEGOCIO;
namespace Proyecto
{
    public partial class Frm_Consulta_Vehiculo : Form
    {


        VEHICULO_ENTIDAD cliente_entidad = new VEHICULO_ENTIDAD();
        VEHICULO_NEG cliente_neg = new VEHICULO_NEG();

        public Frm_Consulta_Vehiculo()
        {
            InitializeComponent();
        }
        private void listado()
        {


            DataTable dt = new DataTable();

            String dato = textBox1.Text;


            dt = cliente_neg.BUSCARVEHICULO(dato);

            tblDatos.DataSource = dt;


        }
        private void Frm_Consulta_Vehiculo_Load(object sender, EventArgs e)
        {
            listado();
        }

        private void tblDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblDatos.Rows.Count == 0)
            {

                return;

            }

            else
            {

                DialogResult = DialogResult.OK;

                Close();


                // SELECCIONAR EL DATAGRIDVIEW Y LUEGO EN SU PROPIEDAD MODIFIES CAMBIAR A  -> PUBLIC  <- PARA QUE RECONOSCA AL OTRO FORMULARIO 

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listado();
        }

        private void tblDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
