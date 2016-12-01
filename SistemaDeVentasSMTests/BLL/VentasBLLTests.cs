using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeVentas.BLL;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.BLL.Tests
{
    [TestClass()]
    public class VentasBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Ventas v = new Ventas();

            Assert.IsTrue(VentasBLL.Insertar(v));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Ventas v = new Ventas();

            Assert.IsNotNull(VentasBLL.Insertar(v));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(VentasBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsNull(VentasBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(VentasBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(VentasBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaCodigoTest()
        {
            Assert.IsNotNull(VentasBLL.GetListaCodigo("232").Count > 0);
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(VentasBLL.GetListaFecha(DateTime.Today));

        }

        [TestMethod()]
        public void GetListaFechaTest1()
        {
            Assert.IsNotNull(VentasBLL.GetListaFecha(DateTime.Today));
            ;
        }
    }
}