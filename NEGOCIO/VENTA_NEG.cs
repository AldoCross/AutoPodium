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
   public  class VENTA_NEG
   {

       VENTA_DAO cliente_dao = new VENTA_DAO();

       public void insert(VENTA_ENTIDAD cliente_entidad)
       {
            cliente_dao.Insert(cliente_entidad);
       }

       public void insertdetalle(VENTA_ENTIDAD cliente_entidad)
       {
           cliente_dao.Insertdetalle(cliente_entidad);
       }


       public DataTable LISTAR()
       {
           return cliente_dao.LISTAR();
       }

        public DataTable LISTARVENDEDOR()
        {
            return cliente_dao.LISTARVENDEDOR();
        }

       public DataTable BUSCAR(String parametro)
       {

           return cliente_dao.BUSCAR(parametro);
       }

       //AUTOGENERAR CODIGO

       public List<VENTA_ENTIDAD> UltimoEmp()
       {
           VENTA_DAO cd = new VENTA_DAO();
           return cd.UltimoCod();
       }
   }
}
