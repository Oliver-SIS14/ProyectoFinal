using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Clientes  //Atributos correctos
    {
        [Key]
        public int Clienteid { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public decimal Balance { get; set; }
        public decimal LimiteCredito { get; set; }
        public string Email { get; set; }
        public int Usuarioid { get; set; }
        public Clientes()
        {
        }
    }
}
