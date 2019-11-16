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

        public bool Modificar(Facturas factura, int id)
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

            return base.Modificar(factura);
        }
    }
}
