using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenAccionaIT.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ExamenAccionaIT.Models;

namespace ExamenAccionaIT.Controllers.Tests
{
    [TestClass()]
    public class AccionaITControllerTests
    {
        [TestMethod()]
        public void NombreProvinciasTest()
        {
            AccionaITController metodosController = new AccionaITController();
            string rta = metodosController.NombreProvincias();

            var cantidadProvincias = JsonConvert.DeserializeObject<List<Provincias>>(rta);

            Assert.AreEqual(cantidadProvincias.Count, 24);
        }
    }
}