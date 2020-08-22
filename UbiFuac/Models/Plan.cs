using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Plan
    {
        private String id;
        private String tipoPlan;
        private Persona idPersona;
        private long fechaInicio;
        private long fechaFinalizacion;
        private long vigencia;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String TipoPlan
        {
            get { return tipoPlan; }
            set { tipoPlan = value; }
        }
        public Persona IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        public long FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public long FechaFinalizacion
        {
            get { return fechaFinalizacion; }
            set { fechaFinalizacion = value; }
        }
        public long Vigencia
        {
            get { return vigencia; }
            set { Vigencia = value; }
        }

        internal Usuario Usuario
        {
            get => default;
            set
            {
            }
        }

        internal Dieta Dieta
        {
            get => default;
            set
            {
            }
        }
    }
}
