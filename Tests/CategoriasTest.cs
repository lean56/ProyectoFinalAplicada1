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
    public class CategoriasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias()
            {
                CategoriaId = 1,
                Nombre = "p"
            };

            Assert.IsTrue(db.Guardar(categoria));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias()
            {
                CategoriaId = 1,
                Nombre = "Prueba1",
            };

            Assert.IsTrue(db.Modificar(categoria));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias()
            {
                CategoriaId = 1,
                Nombre = "Prueba1"
            };

            Assert.IsTrue(db.Duplicado(p => true));
        }
    }
}