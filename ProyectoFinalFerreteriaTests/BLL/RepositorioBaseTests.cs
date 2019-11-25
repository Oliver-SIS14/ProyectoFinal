using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalFerreteria.BLL;
using ProyectoFinalFerreteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.AreEqual(true,true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            paso = repo.Buscar(1) != null;
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.AreEqual(true,true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            paso = repo.Eliminar(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            var Lista = repo.GetList(p => true);
            paso = Lista != null;
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            usuario.User = "Juan";
            usuario.Contraseña = "5678";
            usuario.Tipo = 0;

            paso = repo.Guardar(usuario);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            Usuario usuario = repo.Buscar(1);

            paso = repo.Modificar(usuario);

            Assert.AreEqual(paso, true);
        }
    }
}