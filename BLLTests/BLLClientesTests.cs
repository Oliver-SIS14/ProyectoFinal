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
    public class RepositorioBaseClientesTests
    {

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            bool paso = repo.Buscar(1)!=null;

            Assert.AreEqual(true, paso);

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            bool paso = repo.Eliminar(4);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            bool paso = repo.GetList(p=>true) != null;

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Clientes cliente = new Clientes();

            cliente.Nombres = "juan";
            cliente.Apellidos = "Perez";
            cliente.Cedula = "ewfdsdf";
            cliente.Celular = "2dfsdfsdf";
            cliente.Codigo = "3453";
            cliente.Direccion = "castillo";
            cliente.Email = "fermin";
            cliente.LimiteCredito = 9;
            cliente.Balance = 8;

            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            bool paso = repo.Guardar(cliente);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            bool paso = repo.Modificar(repo.Buscar(1));

            Assert.AreEqual(paso, true);
        }
    }
}