using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Dominio
    {
        private String id;
        private String nombre;
        private long vigencia;

        public String Id {
            get { return id; }
            set { id = value;  }
        }
        public String Nombre {
            get { return nombre; }
            set { nombre = value; }
        } 
        public long Vigencia {
            get { return vigencia; }
            set { vigencia = value;  }
        }

        internal ListaDominio ListaDominio
        {
            get => default;
            set
            {
            }
        }

        internal Ejercicios Ejercicios
        {
            get => default;
            set
            {
            }
        }
    }
}
