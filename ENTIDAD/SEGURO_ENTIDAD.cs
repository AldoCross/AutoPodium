using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{

    public class SEGURO_ENTIDAD
    {



        private int idseguro;
        private DateTime fecha;
        private Decimal precio;
        private string placa;

        public int Idseguro
        {
            get
            {
                return idseguro;
            }

            set
            {
                idseguro = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

      

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}
