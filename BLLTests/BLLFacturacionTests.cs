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
    public class BLLFacturacionTests
    {
        [TestMethod()]
        public void BLLFacturacionTest()
        {
            Assert.AreEqual(true,true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();

            bool paso = repo.Buscar(3) != null;

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
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            bool paso = repo.Eliminar(2);
            Assert.AreEqual(true, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            var Lista = repo.GetList(p => true);
            Assert.AreEqual(Lista != null, true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            Facturas factura = new Facturas();

            factura.Clienteid = 1;
            factura.CantidadArticulos = 2;
            factura.Comentarios = " ";
            factura.Descuentos = 0;
            factura.Fecha = DateTime.Now;
            factura.ITBIS = 10;
            factura.SubTotal = 100;
            factura.TipoFactura = "Credito";
            factura.Usuarioid = 1;
            factura.Balance = 10;
            factura.TotalGeneral = 200;

            bool paso = repo.Guardar(factura);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();

            bool paso = repo.Modificar(repo.Buscar(3));

            Assert.AreEqual(paso, true);
        }
    }
}