using ExamenAccionaIT.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenAccionaIT.Models
{
    public class Usuario: IValidaciones
    {

        public Usuario() { }

        public bool ValidarUsuarioLogin(string user, string clave)
        {
            if (user == "admin" && clave == "123456")
            {
                return true;
            }
            else {
                return false;
                }       
        }
    }
}