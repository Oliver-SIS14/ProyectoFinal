using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Cobro
    {
        public int Cobroid { get; set; }
        public int Clienteid { get; set; } //Nombre, Apellido, Balance, LimiteCredito, Deposito
        public decimal LimiteCredito { get; set; }
        public int Usuarioid { get; set; }
        public DateTime Fecha { get; set; }
        public Cobro()
        {
        }
    }
}
