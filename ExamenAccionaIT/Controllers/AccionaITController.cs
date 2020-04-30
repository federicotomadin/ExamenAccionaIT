using ExamenAccionaIT.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using ExamenAccionaIT.Models.ObjetoProvincias;

namespace ExamenAccionaIT.Controllers
{
    public class AccionaITController:Controller
    {
       
        public ActionResult Login([FromBody] Persona pers)
        {

            Persona persona = new Persona(new Usuario(), pers.user, pers.clave);

            if (persona.ValidarUsuarioLogin())
            {
                return Content("Se logueo bien");
            }
            else 
            {
                return Content("ERROR Loguin");
            }
          
        }
        
        [System.Web.Http.HttpGet]
        public string NombreProvincias()
        {
            ObjetoProvincias listaProvincias = new ObjetoProvincias();
            listaProvincias.provincias = new List<Provincias>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                  
                    using (HttpResponseMessage response =  client.GetAsync("https://apis.datos.gob.ar/georef/api/provincias").Result)
                    {

                        using (HttpContent content = response.Content)
                        {
                         
                            var arrayCompleto = JsonConvert.DeserializeObject<ObjetoProvincias>(content.ReadAsStringAsync().Result);


                            foreach(var item in arrayCompleto.provincias)
                            {

                                listaProvincias.provincias.Add(item);

                            }
                        }
                    
                    }            
                }
            }
            catch (Exception e)
            {

                throw e; //aca logueo errores. 
              
            }

            return JsonConvert.SerializeObject(listaProvincias.provincias);
        }
    }
}