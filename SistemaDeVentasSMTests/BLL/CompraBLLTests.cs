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
    public class CompraBLLTests
    {
        Compras c = new Compras();
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(CompraBLL.Insertar(c));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.IsTrue(CompraBLL.Insertar(c));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(CompraBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsNull(CompraBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(CompraBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(CompraBLL.GetLista(1).Count > 0);
        }

        [TestMethod()]
        public void GetListaCodigoTest()
        {
            Assert.IsNotNull(CompraBLL.GetListaCodigo("232").Count > 0);
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(CompraBLL.GetListaFecha(DateTime.Today));
        }

        [TestMethod()]
        public void GetListaFechaTest1()
        {
            Assert.IsNotNull(CompraBLL.GetListaFecha(DateTime.Today));
        }
    }
}