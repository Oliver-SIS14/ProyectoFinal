using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class DetalleArticulo
    {
        public int Id { get; set; }
        public int Facturaid { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        
        public DetalleArticulo()
        {
        }

        public DetalleArticulo(int id, int facturaid, string descripcion, decimal cantidad, string unidad, decimal precioUnitario, decimal importe)
        {
            Id = id;
            Facturaid = facturaid;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Unidad = unidad;
            Precio = precioUnitario;
            Importe = importe;
        }
    }
}
