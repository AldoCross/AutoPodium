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
    public partial class Frm_Vehiculo : Form
    {
        public Frm_Vehiculo()
        {
            InitializeComponent();
        }

        VEHICULO_ENTIDAD cliente_entidad = new VEHICULO_ENTIDAD();
        VEHICULO_NEG cliente_neg = new VEHICULO_NEG();



        private void listado()
        {


            DataTable dt = new DataTable();

            String dato = textBox1.Text;


            dt = cliente_neg.BUSCAR(dato);

            tblDatos.DataSource = dt;


        }

        private void limpiar()
        {

            pictureBox1.Visible = true;

            pictureBox2.Visible = false;
            txtcodigo.Text = "";
            txtmarca.Text = "";
            txtprecios.Text = "";
            txtmodelo.Text = "";
            txtcolor.Text = "";
            txtmarca.Text = "";

            textBox1.Text = "";

        }
        private void habilitar()
        {

            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;


        }
        private void desahabilitar()
        {

            Button2.Enabled = false;
            Button3.Enabled = true;
            Button4.Enabled = true;


        }
        private void Button2_Click(object sender, EventArgs e)
        {

            if (txtmarca.Text == "")
            {


                MessageBox.Show("Ingrese el Nombre  Marca", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtprecios.Text == "")
            {

                MessageBox.Show("Ingrese el Precio", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtcodigo.Text == "")
            {

                MessageBox.Show("Ingrese el Numero de Placa de Vehiculo", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            else
            {


                cliente_entidad.Id = txtcodigo.Text;
                cliente_entidad.Marca = txtmarca.Text;

                cliente_entidad.Modelo = txtmodelo.Text;

                cliente_entidad.Color = txtcolor.Text;
                cliente_entidad.Precio = Convert.ToDouble(txtprecios.Text);


                MemoryStream ms = new MemoryStream();

                this.pictureBox1.Image.Save(ms, this.pictureBox1.Image.RawFormat);


                cliente_entidad.foto = ms.GetBuffer();






                cliente_neg.insert(cliente_entidad);



                MessageBox.Show("Asido Insertado los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpiar();


                listado();
                pictureBox2.Visible = true;

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

                pictureBox2.Visible = true;

                return;



            }









            cliente_entidad.Id = txtcodigo.Text;


            cliente_neg.eliminar(cliente_entidad);


            habilitar();


            Button2.Enabled = true;
            listado();
            limpiar();
            pictureBox2.Visible = true;


        }


        private void Frm_Vehiculo_Load(object sender, EventArgs e)
        {
            listado();


            habilitar();

            Button2.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            habilitar();
            listado();
            Button2.Enabled = true;


            limpiar();


            pictureBox2.Visible = true;



        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (txtmarca.Text == "")
            {


                MessageBox.Show("Ingrese el Nombre de Medicamento ", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtmarca.Text == "")
            {

                MessageBox.Show("Ingrese el Nombre Medicamento", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



            else
            {



                cliente_entidad.Id = txtcodigo.Text;
                cliente_entidad.Marca = txtmarca.Text;

                cliente_entidad.Modelo = txtmodelo.Text;

                cliente_entidad.Color = txtcolor.Text;
                cliente_entidad.Precio = Convert.ToDouble(txtprecios.Text);


                MemoryStream ms = new MemoryStream();

                this.pictureBox1.Image.Save(ms, this.pictureBox1.Image.RawFormat);


                cliente_entidad.foto = ms.GetBuffer();





                cliente_neg.modificar(cliente_entidad);

                MessageBox.Show("Asido Modificado los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpiar();


                listado();
                pictureBox2.Visible = true;

                habilitar();

                Button2.Enabled = true;
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {

                Bitmap bmImagen;

                openFileDialog1.Filter = "jpeg (*.jpg,*.jpeg)|*.jpg;*.jpeg|gif (*.gif)|*.gif|bitmap   (*.bmp)|*.bmp";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string sNombre = openFileDialog1.FileName;

                    bmImagen = new Bitmap(sNombre);

                    pictureBox1.Image = bmImagen;

                    pictureBox1.Visible = true;

                    pictureBox2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listado();
        }

        private void tblDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                txtcodigo.Text = tblDatos.CurrentRow.Cells["placa"].Value.ToString();

                txtmarca.Text = tblDatos.CurrentRow.Cells["marca"].Value.ToString();
                txtmodelo.Text = tblDatos.CurrentRow.Cells["modelo"].Value.ToString();
                txtcolor.Text = tblDatos.CurrentRow.Cells["color"].Value.ToString();
                txtprecios.Text = tblDatos.CurrentRow.Cells["precio"].Value.ToString();
               


                Byte[] image = Encoding.ASCII.GetBytes(tblDatos.CurrentRow.Cells["FOTO"].Value.ToString());


                if (image == null)


                    pictureBox1.Image = null;


                else
                {


                    var DATA = (Byte[])(tblDatos.CurrentRow.Cells["FOTO"].Value);


                    var stream = new MemoryStream(DATA);



                    this.pictureBox1.Image = Image.FromStream(stream);

                    this.pictureBox1.Visible = true;



                    pictureBox1.Visible = true;

                    pictureBox2.Visible = false;

                    desahabilitar();


                    Button2.Enabled = false;

                }

            }

            catch (Exception)
            {


            }
        }

        private void tblDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
