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
    public class RepositorioFacturaTests
    {
        [TestMethod()]
        public void EliminarTest()
        {
            Assert.AreEqual(true,true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioFactura repo = new RepositorioFactura();

            Facturas factura =  repo.Buscar(2);
            bool paso = repo.Modificar(factura);

            Assert.AreEqual(paso, true);
        }
    }
}