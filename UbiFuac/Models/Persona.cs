using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Persona
    {
        private String id;
        private String tipoPersona;
        private String tipoDocumento;
        private String nombre;
        private String apellidos;
        private long vigencia;
        private long fechaNacimiento;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String TipoPersona
        {
            get { return tipoPersona; }
            set { tipoPersona = value; }
        }
        public String DipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public long Vigencia
        {
            get { return vigencia; }
            set { vigencia = value; }
        }
        public long FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
    }
}
