using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAccionaIT.Servicios
{
    public interface IValidaciones
    {
        bool ValidarUsuarioLogin(string user, string clave);
    }
}
