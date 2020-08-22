using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Ejercicios
    {
        private long id;
        private Rutina idRutina;
        private String tipoEjercicio;
        private String repeticiones;
        private String series;
        private String numeroEjercicio;

        public long Id {
            get { return id; }
            set { id = value; }
        }
        public Rutina IdRutina
        {
            get { return idRutina; }
            set { idRutina = value; }
        }
        public String TipoEjercicio
        {
            get { return tipoEjercicio; }
            set { tipoEjercicio = value; }
        }
        public String Repeticiones
        {
            get { return repeticiones; }
            set { repeticiones = value; }
        }
        public String Series
        {
            get { return series; }
            set { series = value; }
        }
        public String NumeroEjercicio
        {
            get { return numeroEjercicio; }
            set { numeroEjercicio = value; }
        }

    }
}
