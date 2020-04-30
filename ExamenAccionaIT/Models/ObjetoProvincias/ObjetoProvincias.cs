using System.Collections.Generic;

namespace ExamenAccionaIT.Models.ObjetoProvincias
{ 
   public class ObjetoProvincias
    {
        public int Cantidad { get; set; }
        public int Inicio { get; set; }
        public Parametros parametros { get; set; }
        public List<Provincias> provincias { get; set; }
        public int total { get; set; }
    }
}