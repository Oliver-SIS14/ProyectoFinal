using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class FacturaDetalle //Atributos correctos
    {
        [Key]
        public int Id { get; set; }
        public int Facturaid { get; set; }
        public int Articuloid { get; set; }
        public decimal Cantidad { get; set; }
        
        public FacturaDetalle()
        {
        }

        public FacturaDetalle(int id, int facturaid,int articuloid, decimal cantidad)
        {
            Id = id;
            Facturaid = facturaid;
            Articuloid = articuloid;
            Cantidad = cantidad;
        }
    }
}
