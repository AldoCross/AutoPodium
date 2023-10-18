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
    public class VEHICULO_NEG
    {
        VEHICULO_DAO cliente_dao = new VEHICULO_DAO();




        public void insert(VEHICULO_ENTIDAD cliente_entidad)
        {



            cliente_dao.Insert(cliente_entidad);


        }





        public void modificar(VEHICULO_ENTIDAD cliente_entidad)
        {



            cliente_dao.modificar(cliente_entidad);


        }




        public void eliminar(VEHICULO_ENTIDAD cliente_entidad)
        {



            cliente_dao.eliminar(cliente_entidad);


        }









        public DataTable LISTAR()
        {



            return cliente_dao.LISTAR();


        }

        public DataTable LISTARVEHICULO()
        {



            return cliente_dao.LISTARVEHICULO();


        }


        public DataTable BUSCAR(String parametro)
        {

            return cliente_dao.BUSCAR(parametro);

        }



        public DataTable BUSCARVEHICULO(String parametro)
        {

            return cliente_dao.BUSCARVEHICULO(parametro);

        }



    }
}
