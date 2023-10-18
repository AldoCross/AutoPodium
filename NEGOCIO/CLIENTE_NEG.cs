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
   public  class CLIENTE_NEG
    {


CLIENTE_DAO cliente_dao = new CLIENTE_DAO();




        public void insert(CLIENTE_ENTIDAD cliente_entidad)
        {



            cliente_dao.Insert(cliente_entidad);


        }





        public void modificar(CLIENTE_ENTIDAD cliente_entidad)
        {



            cliente_dao.modificar(cliente_entidad);


        }




        public void eliminar(CLIENTE_ENTIDAD cliente_entidad)
        {



            cliente_dao.eliminar(cliente_entidad);


        }







        public DataTable BUSCAR(String parametro)
        {

            return cliente_dao.BUSCAR(parametro);


        }

 }


    }