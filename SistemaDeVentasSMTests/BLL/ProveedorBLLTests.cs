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
    public class ProveedorBLLTests
    {
        Proveedores p = new Proveedores();
        [TestMethod()]
        public void InsertrTest()
        {
            Assert.IsNotNull (ProveedorBLL.Insertar(p));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(ProveedorBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ProveedorBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(ProveedorBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(ProveedorBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaNombreProveedorTest()
        {
            Assert.IsTrue(ProveedorBLL.GetListaNombreProveedor("JOSE").Count > 0);
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(ProveedorBLL.GetListaFecha(DateTime.Today));
        }

        [TestMethod()]
        public void GetListaFechaTest1()
        {
            Assert.IsNotNull(ProveedorBLL.GetListaFecha(DateTime.Today));
        }
    }
}