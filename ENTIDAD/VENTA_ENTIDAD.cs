using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class VENTA_ENTIDAD
    {

        private string _codigo;


        private double _precio_seguro;
        private DateTime _fecha;
        private double _precio_auto;
        private double _precio_final;

        private string _idcliente;
        private string _placa;
        private string idempleado;










        public VENTA_ENTIDAD()
        {
        }



        public string Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public double Precio_seguro
        {
            get
            {
                return _precio_seguro;
            }

            set
            {
                _precio_seguro = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public double Precio_auto
        {
            get
            {
                return _precio_auto;
            }

            set
            {
                _precio_auto = value;
            }
        }

        public double Precio_final
        {
            get
            {
                return _precio_final;
            }

            set
            {
                _precio_final = value;
            }
        }

        public string Idcliente
        {
            get
            {
                return _idcliente;
            }

            set
            {
                _idcliente = value;
            }
        }

        public string Placa
        {
            get
            {
                return _placa;
            }

            set
            {
                _placa = value;
            }
        }

        public string Idempleado
        {
            get
            {
                return idempleado;
            }

            set
            {
                idempleado = value;
            }
        }

        public VENTA_ENTIDAD(string ccodigo)
        {
            _codigo = ccodigo;
        }

       
    }
}
