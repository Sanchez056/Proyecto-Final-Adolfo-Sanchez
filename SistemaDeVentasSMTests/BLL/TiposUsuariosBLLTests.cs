using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class TiposUsuariosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            TipoUsuarios t = new TipoUsuarios();

            Assert.IsTrue(TiposUsuariosBLL.Insertars(t));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(TiposUsuariosBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(TiposUsuariosBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(TiposUsuariosBLL.GetLista().Count > 0);
        }
    }
}