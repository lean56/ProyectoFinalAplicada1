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
    public class EntradaProductosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<EntradaProductos> db = new RepositorioBase<EntradaProductos>();

            EntradaProductos entrada = new EntradaProductos()
            {
                EntradaId =1,
                ProductoId = 1,
                Cantidad = 50,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Guardar(entrada));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<EntradaProductos> db = new RepositorioBase<EntradaProductos>();

            EntradaProductos entrada = new EntradaProductos()
            {
                EntradaId = 1,
                ProductoId = 1,
                Cantidad = 100,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(entrada));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<EntradaProductos> db = new RepositorioBase<EntradaProductos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<EntradaProductos> db = new RepositorioBase<EntradaProductos>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<EntradaProductos> db = new RepositorioBase<EntradaProductos>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            RepositorioBase<EntradaProductos> db = new RepositorioBase<EntradaProductos>();

            EntradaProductos entrada = new EntradaProductos()
            {
                EntradaId = 1,
                ProductoId = 1,
                Cantidad = 100,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Duplicado(p => true));
        }
    }
}