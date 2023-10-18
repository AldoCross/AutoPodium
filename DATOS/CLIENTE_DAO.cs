using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;

using ENTIDAD;

namespace DATOS
{
    public class CLIENTE_DAO
    {
        CONEXION con = new CONEXION();




        public void Insert(CLIENTE_ENTIDAD cliente_entidad)
        {
            //try
            //{

                SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE VALUES (@IDCLIENTE,@NOMBRE,@DIRECCION,@CUIDAD,@TELEFONO)", con.con);

                cmd.CommandType = CommandType.Text;



                cmd.Parameters.Add("@IDCLIENTE", SqlDbType.VarChar, 50).Value = cliente_entidad.Idcliente;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50).Value = cliente_entidad.Nombre;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 50).Value = cliente_entidad.Direccion;



                cmd.Parameters.Add("@CUIDAD", SqlDbType.VarChar, 50).Value = cliente_entidad.Ciudad;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar, 50).Value = cliente_entidad.Telefono;
             


               



                con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();
            //}

            //catch (Exception ex)
            //{
            //    string error = "Error" + ex;

            //}


        }






        public void modificar(CLIENTE_ENTIDAD cliente_entidad)
        {
            try
            {



                SqlCommand cmd = new SqlCommand("UPDATE CLIENTE SET NOMBRE=@NOMBRE,DIRECCION=@DIRECCION,CUIDAD=@CUIDAD,TELEFONO=@TELEFONO WHERE IDCLIENTE=@IDCLIENTE", con.con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IDCLIENTE", SqlDbType.VarChar, 50).Value = cliente_entidad.Idcliente;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50).Value = cliente_entidad.Nombre;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 50).Value = cliente_entidad.Direccion;



                cmd.Parameters.Add("@CUIDAD", SqlDbType.VarChar, 50).Value = cliente_entidad.Ciudad;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar, 50).Value = cliente_entidad.Telefono;




                con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();



            }

            catch (Exception ex)
            {
                string error = "Error" + ex;

            }


        }






        public void eliminar(CLIENTE_ENTIDAD cliente_entidad)
        {
            try
            {



                SqlCommand cmd = new SqlCommand("DELETE  FROM  CLIENTE  WHERE  IDCLIENTE=@IDCLIENTE", con.con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@IDCLIENTE", SqlDbType.VarChar, 50).Value = cliente_entidad.Idcliente;
                con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();



            }

            catch (Exception ex)
            {
                string error = "Error" + ex;

            }


        }






        public DataTable LISTAR()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT       IDcliente as Cedula, Nombre, Direccion, Cuidad, Telefono FROM                 cliente", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }

        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT        IDcliente as Cedula, Nombre, Direccion, Cuidad, Telefono FROM            cliente  where  (NOMBRE Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }












    }
}
