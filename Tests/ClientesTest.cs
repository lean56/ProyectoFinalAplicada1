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
    public class ClientesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Clientes cliente = new Clientes()
            {
                ClienteId = 1,
                Nombres = "P1",
                Cedula = "001",
                Direccion = "sfm",
                Telefono = "809",
                Celular = "829",
                Email = "P1@",
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Guardar(cliente));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Clientes cliente = new Clientes()
            {
                ClienteId = 1,
                Nombres = "Prueba",
                Cedula = "001-0020345-6",
                Direccion = "SFM",
                Telefono = "809-588-0943",
                Celular = "829-923-4443",
                Email = "Prueba@gmail.com",
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(cliente));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Clientes cliente = new Clientes()
            {
                ClienteId = 1,
                Nombres = "Prueba",
                Cedula = "001-0020345-6",
                Direccion = "SFM",
                Telefono = "809-588-0943",
                Celular = "829-923-4443",
                Email = "Prueba@gmail.com",
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Duplicado(p => true));
        }
    }
}