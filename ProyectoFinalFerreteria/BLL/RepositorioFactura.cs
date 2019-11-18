using ProyectoFinalFerreteria.Entidades;
using ProyectoFinalFerreteria.UI.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFerreteria.BLL
{
    class RepositorioFactura : RepositorioBase<Facturas>
    {
        public bool Eliminar(int id,int IdCliente)
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            RepositorioBase<Facturas> repof = new RepositorioBase<Facturas>();

            Facturas factura = repof.Buscar(id);
            Clientes cliente = repo.Buscar(IdCliente);
            cliente.Balance -= factura.TotalGeneral;

            repo.Modificar(cliente);
            return base.Eliminar(id);

        }
        public bool Guardar(Facturas factura,int id) //Guarda la factura y se la asigna al cliente correspondiente
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            RepositorioBase<Articulos> repo2 = new RepositorioBase<Articulos>();

            var Listado = repo.GetList(p => true);

            Clientes cliente = repo.Buscar(id);
            
            cliente.Balance += factura.TotalGeneral;
            cliente.LimiteCredito -= factura.TotalGeneral;

            repo.Modificar(cliente); //Afecta el balance


            foreach (var item in factura.Articulos)
            {
                Articulos articulo = repo2.Buscar(item.Articuloid);
                articulo.Inventario -= (int)item.Cantidad;
                repo2.Modificar(articulo); //Afecta el inventario
            }

            return base.Guardar(factura);
        }

        public override bool Modificar(Facturas factura)
        {
            
            foreach (var item in factura.Articulos)
            {
                var articulo = contexto.Articulos.Find(item.Articuloid);

                if (item.Id == 0)
                {
                    contexto.Entry(item).State = System.Data.Entity.EntityState.Added;
                    if (articulo != null)
                        articulo.Inventario -= (int)item.Cantidad;
                }
                else
                    contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }

            return base.Modificar(factura);
        }

        
    }
}
