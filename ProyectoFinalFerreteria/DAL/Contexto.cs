using ProyectoFinalFerreteria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Articulos> Articulos { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
