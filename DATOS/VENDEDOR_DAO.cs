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
    public class VENDEDOR_DAO
    {
        CONEXION con = new CONEXION();

        public void Insert(VENDEDOR_ENTIDAD cliente_entidad)
        {
            try
            {
                // Verificar si el ID del empleado ya existe en la base de datos
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM VENDEDOR WHERE IDEMPLEADO = @IDEMPLEADO", con.con);
                checkCmd.Parameters.AddWithValue("@IDEMPLEADO", cliente_entidad.Idcliente);
                con.con.Open();
                int empleadoExistente = (int)checkCmd.ExecuteScalar();
                con.con.Close();

                if (empleadoExistente > 0)
                {
                    // El ID del empleado ya existe, muestra un mensaje de error o realiza alguna acción apropiada.
                    MessageBox.Show("El ID del empleado ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // El ID del empleado no existe, procedemos a realizar la inserción
                    SqlCommand cmd = new SqlCommand("INSERT INTO VENDEDOR VALUES (@IDEMPLEADO, @NOMBRE, @DIRECCION, @CUIDAD, @TELEFONO, @SUELDO)", con.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@IDEMPLEADO", SqlDbType.VarChar, 50).Value = cliente_entidad.Idcliente;
                    cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50).Value = cliente_entidad.Nombre;
                    cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 50).Value = cliente_entidad.Direccion;
                    cmd.Parameters.Add("@CUIDAD", SqlDbType.VarChar, 50).Value = cliente_entidad.Ciudad;
                    cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar, 50).Value = cliente_entidad.Telefono;
                    cmd.Parameters.Add("@SUELDO", SqlDbType.Decimal).Value = cliente_entidad.Sueldo;

                    con.con.Open();
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                }
            }
            catch (Exception ex)
            {
                string error = "Error" + ex;
            }
        }

        public void modificar(VENDEDOR_ENTIDAD cliente_entidad)
        {
            //try
            //{
                SqlCommand cmd = new SqlCommand("UPDATE VENDEDOR SET NOMBRE=@NOMBRE,DIRECCION=@DIRECCION,CUIDAD=@CUIDAD,TELEFONO=@TELEFONO,SUELDO=@SUELDO WHERE IDEMPLEADO=@IDVENDEDOR", con.con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@IDVENDEDOR", SqlDbType.VarChar, 50).Value = cliente_entidad.Idcliente;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50).Value = cliente_entidad.Nombre;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 50).Value = cliente_entidad.Direccion;

                cmd.Parameters.Add("@CUIDAD", SqlDbType.VarChar, 50).Value = cliente_entidad.Ciudad;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar, 50).Value = cliente_entidad.Telefono;
                cmd.Parameters.Add("@SUELDO", SqlDbType.Decimal).Value = cliente_entidad.Sueldo;

                con.con.Open();
                cmd.ExecuteNonQuery();
                con.con.Close();
            //}

            //catch (Exception ex)
            //{
            //    string error = "Error" + ex;

            //}
        }

        public void eliminar(VENDEDOR_ENTIDAD cliente_entidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE  FROM  VENDEDOR WHERE  IDEMPLEADO=@IDEMPLEADO", con.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IDEMPLEADO", SqlDbType.VarChar, 50).Value = cliente_entidad.Idcliente;
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT        IDempleado as Cedula, nombre, direccion, cuidad, telefono, sueldo FROM            vendedor", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable BUSCAR(String Nombres)
        {
            string query = "SELECT        IDempleado as Cedula , nombre, direccion, cuidad, telefono, sueldo FROM            vendedor  where  (NOMBRE Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", Nombres);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}