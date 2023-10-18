using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using ENTIDAD;
using System.Data;

namespace DATOS
{
  public   class VENTA_DAO
    {


        CONEXION con = new CONEXION();


      // CABECERA GUARDAR

        public void Insert(VENTA_ENTIDAD cliente_entidad)
        {
            //try
            //{

                SqlCommand cmd = new SqlCommand("INSERT INTO VENTA VALUES (@idventa,@PRECIOSEGURO,@FECHACOMPRA,@PRECIOAUTO,@preciofinal,@IDCLIENTE,@PLACA,@IDEMPLEADO)", con.con);

                cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add("@IDVENTA", SqlDbType.VarChar, 50).Value = cliente_entidad.Codigo;

            cmd.Parameters.Add("@PRECIOSEGURO", SqlDbType.VarChar, 50).Value = cliente_entidad.Precio_seguro;



                cmd.Parameters.Add("@FECHACOMPRA", SqlDbType.Date).Value = cliente_entidad.Fecha;


                cmd.Parameters.Add("@PRECIOAUTO", SqlDbType.Decimal).Value = cliente_entidad.Precio_auto;


                cmd.Parameters.Add("@PRECIOFINAL", SqlDbType.Decimal).Value = cliente_entidad.Precio_final;


                cmd.Parameters.Add("@IDCLIENTE", SqlDbType.VarChar).Value = cliente_entidad.Idcliente;


                cmd.Parameters.Add("@PLACA", SqlDbType.VarChar).Value = cliente_entidad.Placa;

            cmd.Parameters.Add("@IDEMPLEADO", SqlDbType.VarChar).Value = cliente_entidad.Idempleado;



            con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();
            //}

            //catch (Exception ex)
            //{
            //    string error = "Error" + ex;

            //}


        }


      // DETALLE GUARDAR
        public void Insertdetalle(VENTA_ENTIDAD cliente_entidad)
        {
          


        }

      // LISTADO USUARIO

        public DataTable LISTAR()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT  idusuario,usuario from usuario ", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }
        public DataTable LISTARVENDEDOR()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT  idempleado,nombre from vendedor ", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }
        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT        venta.IDventa, venta.fechacompra, venta.placa, carro.marca, carro.modelo, carro.color, venta.precioauto, venta.IDcliente, cliente.nombre, cliente.direccion, cliente.cuidad, cliente.telefono, venta.precioseguro, venta.preciofinal, vendedor.nombre AS vendedor FROM            venta INNER JOIN  carro ON venta.placa = carro.placa INNER JOIN  cliente ON venta.IDcliente = cliente.IDcliente INNER JOIN  vendedor ON venta.IDempleado = vendedor.IDempleado   where  (idventa  Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }

      // AUTOGENERAR CODIGO  

        public string contador;

        public List<VENTA_ENTIDAD> UltimoCod()
        {
            //using (var cn = new SqlConnection(con.con))
            //{



            SqlCommand sqlcmd = new SqlCommand("select count(IDVENTA),max (IDVENTA) from VENTA", con.con);
                sqlcmd.CommandType = CommandType.Text;
                con.con.Open();
                SqlDataReader PaTable = sqlcmd.ExecuteReader();




                List<VENTA_ENTIDAD> Coleccion = new List<VENTA_ENTIDAD>();




                while (PaTable.Read())
                {
                    this.contador = Convert.ToString(PaTable.GetInt32(0));
                    if (contador == "0")
                    {



                        Coleccion.Add(new VENTA_ENTIDAD(PaTable.GetInt32(0).ToString()));



                    }
                    else
                    {



                        Coleccion.Add(new VENTA_ENTIDAD(PaTable.GetString(1)));


                    }
                }
                return Coleccion;


            }
        //}



    }
}
