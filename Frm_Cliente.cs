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
    public partial class Frm_Cliente : Form
    {
        public Frm_Cliente()
        {
            InitializeComponent();
        }



        CLIENTE_ENTIDAD cliente_entidad = new CLIENTE_ENTIDAD();
        CLIENTE_NEG cliente_neg = new CLIENTE_NEG();



        private void listado()
        {


            DataTable dt = new DataTable();

            String dato = textBox1.Text;


            dt = cliente_neg.BUSCAR(dato);

            tblDatos.DataSource = dt;


        }

        int i = 1;
        int grilla;




        private void limpiar()
        {
            textBox1.Text = "";
            txtcodigo.Text = "";
            txtnombres.Text = "";
            txtdireccion.Text = "";
           txtciudad.Text = "";
            txttelefono.Text = "";

        }

        private void habilitar()
        {

            btneliminar.Enabled = false;
            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;


        }
        private void desahabilitar()
        {

            btneliminar.Enabled = true;
            btnguardar.Enabled = false;
            btnmodificar.Enabled = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text == "")
            {


                MessageBox.Show("Debe Seleccionar", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtnombres.Text == "")
            {

                MessageBox.Show("Debe Seleccionar", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



            else
            {





                cliente_entidad.Idcliente = txtcodigo.Text;

                cliente_entidad.Nombre = txtnombres.Text;
                cliente_entidad.Direccion = txtdireccion.Text;

                cliente_entidad.Ciudad = txtciudad.Text;
                cliente_entidad.Telefono = txttelefono.Text;
              



       

                cliente_neg.modificar(cliente_entidad);

                MessageBox.Show("Asido Modificado los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpiar();


                listado();


                habilitar();

                btnguardar.Enabled = true;

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombres.Text == "")
            {


                MessageBox.Show("Ingrese el Nombres ", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            else if (txtcodigo.Text == "")
            {

                MessageBox.Show("Ingrese la Cedula", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           



            else
            {









                cliente_entidad.Idcliente = txtcodigo.Text;

                cliente_entidad.Nombre = txtnombres.Text;
                cliente_entidad.Direccion = txtdireccion.Text;

                cliente_entidad.Ciudad = txtciudad.Text;
                cliente_entidad.Telefono = txttelefono.Text;








                cliente_neg.insert(cliente_entidad);


                MessageBox.Show("Asido Insertado los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();


                listado();
               
                habilitar();

                btnguardar.Enabled = true;




            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            habilitar();
            listado();



            limpiar();


       
            btnguardar.Enabled = true;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {





            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el Registro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {






                habilitar();


                btnguardar.Enabled = true;
                listado();
                limpiar();


                return;



            }









            //cliente_entidad.Idpaciente = txtcodigo.Text;


            cliente_neg.eliminar(cliente_entidad);


            habilitar();


            btnguardar.Enabled = true;
            listado();
            limpiar();
      


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listado();
        }

        private void tblDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                grilla = tblDatos.CurrentRow.Index;

                txtcodigo.Text = tblDatos[0, grilla].Value.ToString();

                txtnombres.Text = tblDatos[1, grilla].Value.ToString();

                txtdireccion.Text = tblDatos[2, grilla].Value.ToString();

                txtciudad.Text = tblDatos[3, grilla].Value.ToString();


                txttelefono.Text = tblDatos[4, grilla].Value.ToString();



                desahabilitar();



            }
            catch (Exception)
            {
            }
        }

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            listado();


            habilitar();

            btnguardar.Enabled = true;
        }
    }
}
