using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class ListaDominio
    {
        private String id;
        private Dominio idDominio;
        private String nombre;
        private long vigencia;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long Vigencia
        {
            get { return vigencia; }
            set { vigencia = value; }
        }

        public Dominio IdDominio
        {
            get { return IdDominio; }
            set { IdDominio = value; }
        }

        internal Plan Plan
        {
            get => default;
            set
            {
            }
        }

        internal Persona Persona
        {
            get => default;
            set
            {
            }
        }
    }
}
