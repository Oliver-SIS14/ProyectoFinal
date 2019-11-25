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
    public class RepositorioClienteTests
    {
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioCliente repo = new RepositorioCliente();
            Clientes cliente = new Clientes();
            cliente.Nombres = "Mario";
            cliente.Apellidos = "Perez";
            cliente.Direccion = "Nagua";
            cliente.Celular = "82034923942";
            cliente.Telefono = "2934820342342";
            cliente.LimiteCredito = 900;
            cliente.Email = "slkdjflkasdjf";
            cliente.Usuarioid = 1;
            cliente.Balance = 90;

            bool paso;

            repo.Guardar(cliente);

            paso = repo.Eliminar(2);
            Assert.AreEqual(paso, true);
        }
    }
}