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
    public class VEHICULO_DAO
    {
        CONEXION con = new CONEXION();




        public void Insert(VEHICULO_ENTIDAD cliente_entidad)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO CARRO VALUES (@PLACA,@MARCA,@MODELO,@COLOR,@PRECIO,@FOTO)", con.con);

                cmd.CommandType = CommandType.Text;


                cmd.Parameters.Add("@PLACA", SqlDbType.VarChar, 50).Value = cliente_entidad.Id;
                cmd.Parameters.Add("@MARCA", SqlDbType.VarChar, 50).Value = cliente_entidad.Marca;
                cmd.Parameters.Add("@MODELO", SqlDbType.VarChar, 50).Value = cliente_entidad.Modelo;

                cmd.Parameters.Add("@COLOR", SqlDbType.NVarChar,50).Value = cliente_entidad.Color;
                cmd.Parameters.Add("@PRECIO", SqlDbType.Decimal).Value = cliente_entidad.Precio;


                cmd.Parameters.Add("@foto", SqlDbType.Image).Value = cliente_entidad.foto;







                con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();
            }

            catch (Exception ex)
            {
                string error = "Error" + ex;

            }


        }






        public void modificar(VEHICULO_ENTIDAD cliente_entidad)
        {
            try
            {



            SqlCommand cmd = new SqlCommand("UPDATE CARRO SET MARCA=@MARCA,MODELO=@MODELO,COLOR=@COLOR,PRECIO=@PRECIO,FOTO=@FOTO WHERE PLACA=@PLACA", con.con);

                cmd.CommandType = CommandType.Text;


                cmd.Parameters.Add("@PLACA", SqlDbType.VarChar, 50).Value = cliente_entidad.Id;
                cmd.Parameters.Add("@MARCA", SqlDbType.VarChar, 50).Value = cliente_entidad.Marca;
                cmd.Parameters.Add("@MODELO", SqlDbType.VarChar, 50).Value = cliente_entidad.Modelo;

                cmd.Parameters.Add("@COLOR", SqlDbType.NVarChar, 50).Value = cliente_entidad.Color;
                cmd.Parameters.Add("@PRECIO", SqlDbType.Decimal).Value = cliente_entidad.Precio;


                cmd.Parameters.Add("@foto", SqlDbType.Image).Value = cliente_entidad.foto;


                con.con.Open();

                cmd.ExecuteNonQuery();

                con.con.Close();



            }

            catch (Exception ex)
            {
                string error = "Error" + ex;

            }


        }






        public void eliminar(VEHICULO_ENTIDAD cliente_entidad)
        {
            try
            {



                SqlCommand cmd = new SqlCommand("DELETE  FROM  CARRO WHERE PLACA=@PLACA", con.con);

                cmd.CommandType = CommandType.Text;


                cmd.Parameters.Add("@PLACA", SqlDbType.VarChar, 50).Value = cliente_entidad.Id;



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


            SqlDataAdapter da = new SqlDataAdapter("SELECT        placa, marca, modelo, color, precio, foto FROM            carro", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }

        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT        placa, marca, modelo, color, precio, foto FROM            carro  where  (PLACA Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param" , Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }




        public DataTable BUSCARVEHICULO(String Nombres)
        {



            string query = "SELECT        carro.placa, carro.marca, carro.modelo, carro.color, carro.precio, seguro.precio AS seguro, carro.foto FROM            carro INNER JOIN  seguro ON carro.placa = seguro.placa  where  (CARRO.PLACA Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }


        public DataTable LISTARVEHICULO()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT        carro.placa, carro.marca, carro.modelo, carro.color, carro.precio, seguro.precio AS seguro, carro.foto FROM            carro INNER JOIN  seguro ON carro.placa = seguro.placa ", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }







    }
}