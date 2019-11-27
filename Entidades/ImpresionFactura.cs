using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class ImpresionFactura
    {
        [Key]
        public int IdImpresion { get; set; }
        public int Facturaid { get; set; }
        public int Articuloid { get; set; }
        public string Descripcion { get; set; }
        public decimal cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Importe { get; set; }
        public decimal TotalGeneral { get; set; }
        public decimal Balance { get; set; }
        public string Comentarios { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }

        public ImpresionFactura()
        {
        }
    }
}
