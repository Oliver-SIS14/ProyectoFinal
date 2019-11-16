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
        public bool guardar(Clientes cliente,int id)
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();

            Facturas factura = repo.Buscar(id);

            cliente.Balance += factura.TotalGeneral;
            cliente.LimiteCredito -= factura.TotalGeneral;

            return base.Guardar(cliente);
        }
    }
}
