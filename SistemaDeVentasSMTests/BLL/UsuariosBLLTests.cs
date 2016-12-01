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
    public class UsuariosBLLTests
    {
        Usuarios us = new Usuarios();
        [TestMethod()]
        public void InsertarTest()
        {
           
            Assert.IsTrue(UsuariosBLL.Insertar(us));
        }

        [TestMethod()]
        public void BuscarTest()
        {
         
            Assert.IsNull(UsuariosBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(UsuariosBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaNombreUsuarioTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetListaNombreUsuario("adolfo").Count > 0);
        }

        [TestMethod()]
        public void GetListaIdUsuariosTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetListaIdUsuarios(1).Count > 0);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetLista().Count >0);

        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(UsuariosBLL.GetLista().Count > 0);
        }

       

        [TestMethod()]
        public void getContraseñaTest()
        {
            
            Assert.IsNotNull(UsuariosBLL.getContraseña("1234").Count > 0);
        }
    }
}