using System;
using System.Collections.Generic;
using System.Text;

namespace UbiFuac.Models
{
    class Usuario
    {
        private String id;
        private Persona idPersona;
        private String user;
        private String password;
        private String rol;
        private long vigencia;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public Persona IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        public String User
        {
            get { return user; }
            set { user = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public long Vigencia
        {
            get { return vigencia; }
            set { vigencia = value; }
        }
    }
}
