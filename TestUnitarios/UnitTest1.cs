using System;
using ExamenAccionaIT.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenAccionaIT.Controllers;

namespace TestUnitarios
{
    [TestClass]
    public class TestsMetodos
    {
        [TestMethod]
        public void ValidarUsuarioLoginTest()
        {
           Usuario user = new Usuario();

           var login =  user.ValidarUsuarioLogin("admin", "123456");

           Assert.AreEqual(login, true);
        }


        [TestMethod]
        public void LoginTest()
        {
            Usuario user = new Usuario();
            Persona per = new Persona();
            string resultado = "";

            if (user.ValidarUsuarioLogin("admin", "123456"))
            {
                resultado = "Se logueo bien";
            }
            else
            {
                resultado = "ERROR Loguin";
            }

            Assert.AreEqual(resultado, "Se logueo bien");
        }
    }
}
