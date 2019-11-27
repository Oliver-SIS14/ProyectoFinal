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
    public class RepositorioBaseUsuariosTests
    {
        
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            bool paso = repo.Buscar(1)!=null;

            Assert.AreEqual(paso, true);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            var lista = repo.GetList(p => true);

            Assert.AreEqual(lista!=null, true);
        }

        [TestMethod()]
        public void GuardarTest()
        { 
            Usuario usuario = new Usuario();

            usuario.User = "Oliver";
            usuario.Tipo = 1;
            usuario.Contraseña = "2432";


            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            bool paso = repo.Guardar(usuario);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            bool paso = repo.Modificar(repo.Buscar(4));
            Assert.AreEqual(paso, true);
        }
    }
}