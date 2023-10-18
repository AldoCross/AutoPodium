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
    public class SEGURO_NEG
    {
        SEGURO_DAO cliente_dao = new SEGURO_DAO();




        public void insert(SEGURO_ENTIDAD cliente_entidad)
        {



            cliente_dao.Insert(cliente_entidad);


        }





        public void modificar(SEGURO_ENTIDAD cliente_entidad)
        {



            cliente_dao.modificar(cliente_entidad);


        }




        public void eliminar(SEGURO_ENTIDAD cliente_entidad)
        {



            cliente_dao.eliminar(cliente_entidad);


        }




        public DataTable LISTAR()
        {



            return cliente_dao.LISTAR();


        }



        public DataTable BUSCAR(String parametro)
        {

            return cliente_dao.BUSCAR(parametro);

        }





    }
}
