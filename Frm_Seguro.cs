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
    public partial class Frm_Seguro : Form
    {
        public Frm_Seguro()
        {
            InitializeComponent();
        }


        SEGURO_ENTIDAD cliente_entidad = new SEGURO_ENTIDAD();
        SEGURO_NEG cliente_neg = new SEGURO_NEG();



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
            txtprecio.Text = "";
            cboplaca.Text = "";
          
        }

        private void habilitar()
        {

            Button3.Enabled = false;
            Button2.Enabled = true;
            Button4.Enabled = false;


        }
        private void desahabilitar()
        {

            Button3.Enabled = true;
            Button2.Enabled = false;
            Button4.Enabled = true;
        }
        private void vehiculo()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTAR();

            cboplaca.DataSource = dt;


            this.cboplaca.DisplayMember = "placa";
            this.cboplaca.ValueMember = "placa";

        }
        private void Frm_Seguro_Load(object sender, EventArgs e)
        {
            vehiculo();

            listado();


            habilitar();

            Button2.Enabled = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            habilitar();
            listado();



            limpiar();



            Button2.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text == "")
            {


                MessageBox.Show("Debe Seleccionar", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtprecio.Text == "")
            {

                MessageBox.Show("Debe Seleccionar", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



            else
            {





                cliente_entidad.Idseguro = Convert.ToInt32(txtcodigo.Text);
                cliente_entidad.Fecha = Convert.ToDateTime(txtfecha.Text);

                cliente_entidad.Precio = Convert.ToDecimal(txtprecio.Text);

                cliente_entidad.Placa = cboplaca.SelectedValue.ToString();






                cliente_neg.modificar(cliente_entidad);

                MessageBox.Show("Asido Modificado los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpiar();


                listado();


                habilitar();

                Button2.Enabled = true;

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {


            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el Registro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {






                habilitar();


                Button2.Enabled = true;
                listado();
                limpiar();


                return;



            }







            cliente_entidad.Idseguro = Convert.ToInt32(txtcodigo.Text);
      


            cliente_neg.eliminar(cliente_entidad);


            habilitar();


            Button2.Enabled = true;
            listado();
            limpiar();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tblDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                grilla = tblDatos.CurrentRow.Index;

                txtcodigo.Text = tblDatos[0, grilla].Value.ToString();


                cboplaca.Text = tblDatos[1, grilla].Value.ToString();

                txtprecio.Text = tblDatos[2, grilla].Value.ToString();

           

                txtfecha.Text = tblDatos[3, grilla].Value.ToString();

                desahabilitar();



            }
            catch (Exception)
            {
            }

            desahabilitar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listado();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtprecio.Text == "")
            {


                MessageBox.Show("Ingrese el Precio ", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            else if (cboplaca.Text == "")
            {

                MessageBox.Show("Debe Seleccionar Numero de Placa Vehiculo", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }




            else
            {








                cliente_entidad.Fecha = Convert.ToDateTime(txtfecha.Text);

                cliente_entidad.Precio =Convert.ToDecimal(txtprecio.Text);

                cliente_entidad.Placa = cboplaca.SelectedValue.ToString();






                cliente_neg.insert(cliente_entidad);


                MessageBox.Show("Asido Insertado los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();


                listado();

                habilitar();

                Button2.Enabled = true;

















            }
    }

        private void tblDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
