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
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Clientes c = new Clientes();

            Assert.IsNotNull(ClientesBLL.Insertar(c));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(ClientesBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ClientesBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(ClientesBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(ClientesBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaNombreClienteTest()
        {
            Assert.IsNotNull(ClientesBLL.GetListaNombreCliente("Adolfo").Count > 0);
        }

       
       

        [TestMethod()]
        public void GetListaSexoTest()
        {
            Assert.IsTrue(ClientesBLL.GetListaSexo("M").Count > 0);
        }

        [TestMethod()]
        public void GetListaCedulaTest()
        {
            Assert.IsNotNull(ClientesBLL.GetListaCedula("323232323").Count > 0);
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(ClientesBLL.GetListaFecha(DateTime.Today));
        }

        [TestMethod()]
        public void GetListaFechaTest1()
        {
            Assert.IsNotNull(ClientesBLL.GetListaFecha(DateTime.Today));

        }
    }
}