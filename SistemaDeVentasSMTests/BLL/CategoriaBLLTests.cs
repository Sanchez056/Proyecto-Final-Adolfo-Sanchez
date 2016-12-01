using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeVentas.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.BLL.Tests
{
    [TestClass()]
    public class CategoriaBLLTests
    {
        Categorias a = new Categorias();
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsNotNull(CategoriaBLL.Insertar(a));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(CategoriaBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsNull(CategoriaBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(CategoriaBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(CategoriaBLL.GetLista(1).Count > 0);
        }

        [TestMethod()]
        public void GetListaDescripcionTest()
        {
            Assert.IsNotNull(CategoriaBLL.GetListaDescripcion("Piezas").Count > 0);
        }
    }
}