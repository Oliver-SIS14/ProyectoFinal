using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        public int Tipo { get; set; }
        public Usuario()
        {

        }
    }
}
