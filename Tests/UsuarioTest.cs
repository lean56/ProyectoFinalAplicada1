using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuarioTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios()
            {
                UsuarioId = 1,
                Nombre = "Prueba",
                NivelUsuario = "Admin",
                Usuario = "p1",
                Clave = "123",
                FechaIngreso = DateTime.Now
            };

            Assert.IsTrue(db.Guardar(usuario));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios()
            {
                UsuarioId = 1,
                Nombre = "Prueba",
                NivelUsuario = "user",
                Usuario = "p1",
                Clave = "123",
                FechaIngreso = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(usuario));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios()
            {
                UsuarioId = 1,
                Nombre = "Prueba",
                NivelUsuario = "user",
                Usuario = "p1",
                Clave = "123",
                FechaIngreso = DateTime.Now
            };

            Assert.IsTrue(db.Duplicado(p => true));
        }


    }
}