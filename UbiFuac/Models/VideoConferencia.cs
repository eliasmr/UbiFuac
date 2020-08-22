using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class VideoConferencia
    {
        private long id;
        private Plan idPlan;
        private long entrenadorId;
        private String tematica;
        private long fecha;
        private long hora;

        public long Id {
            get { return id; }
            set { id = value;  }
        }
        public Plan IdPlan
        {
            get { return idPlan; }
            set { idPlan = value; }
        }
        public long EntrenadorId
        {
            get { return entrenadorId; }
            set { entrenadorId = value; }
        }
        public String Tematica
        {
            get { return tematica; }
            set { tematica = value; }
        }
        public long Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public long Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        internal Rutina Rutina
        {
            get => default;
            set
            {
            }
        }

        internal Rutina Rutina1
        {
            get => default;
            set
            {
            }
        }
    }
}
