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
    public partial class Frm_Venta : Form
    {
        public Frm_Venta()
        {
            InitializeComponent();
        }



        VENTA_ENTIDAD cliente_entidad = new VENTA_ENTIDAD();


        VENTA_NEG cliente_neg = new VENTA_NEG();






        int grilla;




        private void limpiar()
        {
            txttratamiento.Text = "";

            txtcliente.Text = "";

            txtcedula.Text = "";
            txttelefono.Text = "";
            txtprecio.Text = "";
            txttotal.Text = "";
            txtseguro.Text = "";
            txttotal.Text = "";
            txtplaca.Text = "";
            txtmodelo.Text = "";
            cbovendedor.Text = "";
            txtprecio.Text = "";
            txtcliente.Text = "";
            txtcolor.Text = "";
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;

            txtprecio.Text = "";

            txtdireccion.Text = "";
            txtplaca.Text = "";
           
            txttelefono.Text = "";

            txttelefono.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (txtprecio.Text == "")
            {


                MessageBox.Show("Ingrese el Precio", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            else if (txtprecio.Text == "")
            {

                MessageBox.Show("Ingrese el Precio", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtcliente.Text == "")
            {

                MessageBox.Show("Debe Consultar Cliente ", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtdireccion.Text == "")
            {

                MessageBox.Show("Ingrese la Direccion ", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (cbovendedor.Text == "")
            {

                MessageBox.Show("Debe Seleccionar el Vendedor de Vehiculo", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            else if (txttotal.Text == "")
            {

                MessageBox.Show("Debe Calcular el Total", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {



                cliente_entidad.Codigo = txttratamiento.Text;

                cliente_entidad.Precio_seguro = Convert.ToDouble(txtseguro.Text);

                cliente_entidad.Fecha = Convert.ToDateTime(txtfecha.Text);

                cliente_entidad.Precio_auto= Convert.ToDouble(txtprecio.Text);

                cliente_entidad.Precio_final = Convert.ToDouble(txttotal.Text);
                cliente_entidad.Idcliente = txtcedula.Text;


                cliente_entidad.Placa = txtplaca.Text;

                cliente_entidad.Idempleado = cbovendedor.SelectedValue.ToString();


                cliente_neg.insert(cliente_entidad);



                limpiar();
                Ultimo();
            
                MessageBox.Show("Asido Generado la Venta Vehicular", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void Ultimo()
        {
            VENTA_NEG cnper = new VENTA_NEG();


            List<VENTA_ENTIDAD> per = cnper.UltimoEmp();


            foreach (VENTA_ENTIDAD ma in per)
            {
                int codigo = 0;
                codigo = Convert.ToInt32(ma.Codigo);
                codigo = codigo + 1;
                if (codigo < 10)
                {
                    ma.Codigo = "000" + codigo.ToString();
                }
                if (codigo < 100 && codigo > 9)
                {
                    ma.Codigo = "00" + codigo.ToString();
                }
                if (codigo < 1000 && codigo > 99)
                {
                    ma.Codigo = "0" + codigo.ToString();
                }
                txttratamiento.Text = ma.Codigo;
            }
        }
        private void vendedor()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARVENDEDOR();

            cbovendedor.DataSource = dt;


            this.cbovendedor.DisplayMember = "nombre";
            this.cbovendedor.ValueMember = "idempleado";

        }
        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            vendedor();
                
                btncalcular.Enabled = false;

            Ultimo();
            cbovendedor.Text = "";

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btncalcular.Enabled = true;

            Frm_Consulta_Vehiculo f1 = new Frm_Consulta_Vehiculo();

            f1.ShowDialog();

            try
            {

                if (f1.DialogResult == DialogResult.OK)
                {


                    //  RECOJER DATOS DEL OTRO FORMULARIO DEL CONTROL DATAGRIDVIEW  LLAMADO  TBLDATOS

                    txtplaca.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[0].Value.ToString();
                    txtmodelo.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[1].Value.ToString();

                    txtcolor.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[2].Value.ToString();

                    txtprecio.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[4].Value.ToString();
                    txtseguro.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[5].Value.ToString();



                    var DATA = (Byte[])(f1.tblDatos.CurrentRow.Cells["FOTO"].Value);


                    var stream = new MemoryStream(DATA);



                    this.pictureBox1.Image = Image.FromStream(stream);

                    this.pictureBox1.Visible = true;

                    btncalcular.Enabled = true;

                }

            }

            catch (Exception)
            {


            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            limpiar();
            Ultimo();

            pictureBox2.Visible = true;
            pictureBox1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {



            Frm_Consulta_Cliente f1 = new Frm_Consulta_Cliente();

            f1.ShowDialog();

            try
            {

                if (f1.DialogResult == DialogResult.OK)
                {


                    //  RECOJER DATOS DEL OTRO FORMULARIO DEL CONTROL DATAGRIDVIEW  LLAMADO  TBLDATOS

                    txtcedula.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[0].Value.ToString();
                    txtcliente.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[1].Value.ToString();

                    txtdireccion.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[2].Value.ToString();




                    txttelefono.Text = f1.tblDatos.Rows[f1.tblDatos.CurrentRow.Index].Cells[4].Value.ToString();
                  




                }





            }

            catch (Exception)
            {


            }

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double precio, cantidad, subtotal;


            precio = Convert.ToDouble(txtprecio.Text);

            cantidad = Convert.ToDouble(txtseguro.Text);

            subtotal = precio + cantidad;

  
            txttotal.Text= subtotal.ToString("##,#0.000");



            }

            catch (Exception)
            {


            }





        }
    }
}
