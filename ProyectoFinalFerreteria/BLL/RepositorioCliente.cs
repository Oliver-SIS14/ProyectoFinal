using ProyectoFinalFerreteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.BLL
{
    public class RepositorioCliente : RepositorioBase<Clientes>
    {
        public override bool Eliminar(int id)
        {
            RepositorioBase<Facturas> repof = new RepositorioBase<Facturas>();

            var Lista = repof.GetList(p => true);

            foreach (var item in Lista)
            {
                if (item.Clienteid == id)
                    repof.Eliminar(item.Facturaid);
            }
            return base.Eliminar(id);
        }
    }
}
