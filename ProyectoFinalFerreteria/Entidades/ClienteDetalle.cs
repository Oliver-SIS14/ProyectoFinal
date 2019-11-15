using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class ClienteDetalle
    {
        [Key]
        public int Id { get; set; }
        public int Clienteid { get; set; }
        public int Facturaid { get; set; }
        public decimal Monto { get; set; }

        public ClienteDetalle()
        {
        }
    }
}
