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
        public void DuplicadoTest()
        {
            Assert.Fail();
        }

    }
}