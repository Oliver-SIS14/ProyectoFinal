using ProyectoFinalFerreteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.BLL
{
    class RepositorioFactura : RepositorioBase<Facturas>
    {
        public bool Guardar(Facturas factura,int id) //Guarda la factura y se la asigna al cliente correspondiente
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            var Listado = repo.GetList(p => true);

            Clientes cliente = repo.Buscar(id);
            
            cliente.Balance += factura.TotalGeneral;
            repo.Modificar(cliente);

            return base.Guardar(factura);
        }
    }
}
