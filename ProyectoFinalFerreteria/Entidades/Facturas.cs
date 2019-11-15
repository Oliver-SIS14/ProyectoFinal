using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Facturas //Atributos correctos
    {
        [Key]
        public int Facturaid { get; set; } 
        public int Clienteid { get; set; }
        public string TipoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Descuentos { get; set; }
        public decimal ITBIS { get; set; }
        public decimal TotalGeneral { get; set; }
        public int CantidadArticulos { get; set; }
        public decimal Balance { get; set; }
        public virtual List<FacturaDetalle> Articulos { get; set; }

        public Facturas()
        {
        }
    }
}
