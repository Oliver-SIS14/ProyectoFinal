using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public struct Deposito
    {
        public string NombreCliente;
        public DateTime Fecha;
        public decimal Monto;
    }

    public class Cliente
    {
        public int Clienteid { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Codigo { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Balance { get; set; }
        public decimal LimiteCredito { get; set; }
        public virtual List<Deposito> Depositos { get; set; }

        public Cliente()
        {
        }
    }
}
