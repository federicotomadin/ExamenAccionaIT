using ExamenAccionaIT.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenAccionaIT.Models
{
    public class Persona
    {
        protected IValidaciones validaciones;

        public string user { set; get; }
        public string clave { set; get; }

        public Persona() { }

        public Persona(IValidaciones _validaciones, string _user, string _clave)
        {
            this.validaciones = _validaciones;
            this.user = _user;
            this.clave = _clave;
        }

        public bool ValidarUsuarioLogin()
        {
            return this.validaciones.ValidarUsuarioLogin(this.user, this.clave);
        }

      


    }
}