using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Factura
    {
        public int Facturaid { get; set; }//Llave primaria 
        public int Clienteid { get; set; }//Llave foranea Cliente
        public string TipoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal ITBIS { get; set; }
        public decimal TotalGeneral { get; set; }
        public int CantidadArticulos { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public List<DetalleArticulo> Articulos { get; set; }

        public Factura()
        {
        }
    }
}
