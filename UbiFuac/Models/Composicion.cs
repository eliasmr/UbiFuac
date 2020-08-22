using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Composicion
    {

        private long id;
        private Dieta idDieta;
        private String alimento;
        private String calorias;
        private String regularidad;
        private String observacion;

        public long Id {
            get { return id; }
            set { id = value; }
        }
        public Dieta IdDieta
        {
            get { return idDieta; }
            set { idDieta = value; }
        }
        public String Alimento
        {
            get { return alimento; }
            set { alimento = value; }
        }
        public String Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }
        public String Regularidad
        {
            get { return regularidad; }
            set { regularidad = value; }
        }
        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}
