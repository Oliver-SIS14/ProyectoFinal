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
    public class RepositorioBaseArticuloTests
    {

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            bool paso = repo.Buscar(1)!=null;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            bool paso = repo.Eliminar(3);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            bool paso = repo.GetList(p => true)!=null;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            Articulos art = new Articulos();

            art.Codigo = "202343";
            art.Descripcion = "Varilla";
            art.Marca = "Truper";
            art.Inventario = 45000;
            art.PrecioUnitario = 5400;
            art.Unidad = "Quintales";
            art.Usuarioid = 1;

            bool paso = repo.Guardar(art);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            bool paso = repo.Modificar(repo.Buscar(1));

            Assert.AreEqual(paso, true);
        }
    }
}