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
    public class FacturasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Facturas> db = new RepositorioBase<Facturas>();

            Facturas factura = new Facturas()
            {
                FacturaId = 1,
                ClienteId = 1,
                UsuarioId = 1,
                ProductoId = 1,
                Cantidad = 5,
                Total = 100,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Guardar(factura));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Facturas> db = new RepositorioBase<Facturas>();

            Facturas factura = new Facturas()
            {
                FacturaId = 1,
                ClienteId = 1,
                UsuarioId = 1,
                ProductoId = 2,
                Cantidad = 30,
                Total = 120,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(factura));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Facturas> db = new RepositorioBase<Facturas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Facturas> db = new RepositorioBase<Facturas>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Facturas> db = new RepositorioBase<Facturas>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            RepositorioBase<Facturas> db = new RepositorioBase<Facturas>();

            Facturas factura = new Facturas()
            {
                FacturaId = 1,
                ClienteId = 1,
                UsuarioId = 1,
                ProductoId = 2,
                Cantidad = 30,
                Total = 120,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Duplicado(p => true));
        }

    }
}