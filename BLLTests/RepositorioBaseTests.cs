using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
     
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios()
            {
                UsuarioId = 1,
                Nombre = "Prueba",
                NivelUsuario = "admin",
                Usuario = "p1",
                Clave = "1234",
                FechaIngreso = DateTime.Now
            };

            Assert.IsTrue(db.Guardar(usuario));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            Assert.Fail();
        }
    }
}