using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Rutina
    {
        private long id;
        private Plan idPlan;
        private long dia;
        private String calorias;
        private long vigencia;

        public long Id {
            get { return id; }
            set { id = value; }
        }
        public Plan IdPlan
        {
            get { return idPlan; }
            set { idPlan = value; }
        }
        public long Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public String Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }
        public long Vigencia
        {
            get { return vigencia; }
            set { vigencia = value; }
        }

        internal Ejercicios Ejercicios
        {
            get => default;
            set
            {
            }
        }

        internal VideoConferencia VideoConferencia
        {
            get => default;
            set
            {
            }
        }
    }
}
