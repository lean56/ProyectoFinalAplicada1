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
    public class ProductoTest
    {
     
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos producto = new Productos()
            {
                ProductoId = 1,
                Descripcion = "Prueba",
                Costo = 50,
                Precio = 100,
                Ganancia = 50,
                FechaCreacion = DateTime.Now,
                Inventario = 0
            };

            Assert.IsTrue(db.Guardar(producto));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos producto = new Productos()
            {
                ProductoId = 1,
                Descripcion = "Prueba 1",
                Costo = 30,
                Precio = 100,
                Ganancia = 70,
                FechaCreacion = DateTime.Now,
                Inventario = 0
            };

            Assert.IsTrue(db.Modificar(producto));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos producto = new Productos()
            {
                ProductoId = 1,
                Descripcion = "Prueba 1",
                Costo = 30,
                Precio = 100,
                Ganancia = 70,
                FechaCreacion = DateTime.Now,
                Inventario = 0
            };

            Assert.IsTrue(db.Duplicado(p=> true));
        }
    }
}