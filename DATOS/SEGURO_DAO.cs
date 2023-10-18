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
    public class SEGURO_DAO
    {
        CONEXION con = new CONEXION();




        public void Insert(SEGURO_ENTIDAD cliente_entidad)
        {
        //    try
        //    {

                SqlCommand cmd = new SqlCommand("INSERT INTO SEGURO VALUES (@fecha,@precio,@placa)", con.con);

                cmd.CommandType = CommandType.Text;



                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = cliente_entidad.Fecha;

                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = cliente_entidad.Precio;
                cmd.Parameters.Add("@placa", SqlDbType.VarChar, 50).Value = cliente_entidad.Placa;

    





                con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();
            //}

            //catch (Exception ex)
            //{
            //    string error = "Error" + ex;

            //}


        }






        public void modificar(SEGURO_ENTIDAD cliente_entidad)
        {
            //try
            //{



                SqlCommand cmd = new SqlCommand("UPDATE  seguro set  fecha=@fecha,precio=@precio,placa=@placa WHERE idseguro=@idseguro", con.con);

                cmd.CommandType = CommandType.Text;


                cmd.Parameters.Add("@idseguro", SqlDbType.VarChar, 50).Value = cliente_entidad.Idseguro;


            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = cliente_entidad.Fecha;

            cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = cliente_entidad.Precio;
            cmd.Parameters.Add("@placa", SqlDbType.VarChar, 50).Value = cliente_entidad.Placa;


            con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();



            //}

            //catch (Exception ex)
            //{
            //    string error = "Error" + ex;

            //}


        }






        public void eliminar(SEGURO_ENTIDAD cliente_entidad)
        {
            try
            {



                SqlCommand cmd = new SqlCommand("DELETE  FROM  seguro WHERE IDseguro=@IDseguro", con.con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@idseguro", SqlDbType.VarChar, 50).Value = cliente_entidad.Idseguro;
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


            SqlDataAdapter da = new SqlDataAdapter("SELECT        placa FROM            carro", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }


        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT seguro.IDseguro, carro.placa, seguro.precio, seguro.fecha FROM            carro INNER JOIN seguro ON carro.placa = seguro.placa where  (carro.placa Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }












    }
}
