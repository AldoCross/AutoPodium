using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using ENTIDAD;
using DATOS;
using System.Data;

namespace NEGOCIO
{
    public class VENDEDOR_NEG
    {


        VENDEDOR_DAO cliente_dao = new VENDEDOR_DAO();




        public void insert(VENDEDOR_ENTIDAD cliente_entidad)
        {



            cliente_dao.Insert(cliente_entidad);


        }





        public void modificar(VENDEDOR_ENTIDAD cliente_entidad)
        {



            cliente_dao.modificar(cliente_entidad);


        }




        public void eliminar(VENDEDOR_ENTIDAD cliente_entidad)
        {



            cliente_dao.eliminar(cliente_entidad);


        }







        public DataTable BUSCAR(String parametro)
        {

            return cliente_dao.BUSCAR(parametro);


        }

    }


}