using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Articulo
    {
        public int Articuloid { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Codigo { get; set; }
        public string Unidad { get; set; }
        public decimal Precio { get; set; }
        public int Inventario { get; set; }
        public Articulo()
        {
        }
    }
}
