using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace DATOS
{
    public class CONEXION
    {
        //Linea original     
        //public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString());

        //prueba de conexion liena nueva
        static string ConexionString = " server= localhost ; database= BD_VENTA_AUTO ; integrated security= true ";
        public SqlConnection con = new SqlConnection(ConexionString);
    }
}