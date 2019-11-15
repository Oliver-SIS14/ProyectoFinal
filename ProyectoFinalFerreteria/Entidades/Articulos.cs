using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Articulos  //Atributos correctos
    {
        [Key]
        public int Articuloid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Unidad { get; set; }
        public int Inventario { get; set; }
        public Articulos()
        {
        }
    }
}
