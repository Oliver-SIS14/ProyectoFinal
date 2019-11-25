using ProyectoFinalFerreteria.BLL;
using ProyectoFinalFerreteria.Entidades;
using ProyectoFinalFerreteria.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFerreteria.UI.Consultas
{
    public partial class ConsultaClientes : Form
    {
        private List<Clientes> ListaClient;
        private Expression<Func<Clientes, bool>> filtro;

        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {

            var Listado = new List<Clientes>();
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        Listado = repo.GetList(p => true);
                        break;
                    case 1: //id
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Clienteid == id);
                        break;
                    case 2://Nombre
                        Listado = repo.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Apellido
                        Listado = repo.GetList(p => p.Apellidos.Contains(CriterioTextBox.Text));
                        break;
                    case 4://Codigo
                        Listado = repo.GetList(p => p.Codigo.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
            {
                Listado = repo.GetList(p => true);
            }
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = Listado;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {


            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        filtro = p => true;
                        break;
                    case 1: //Articuloid
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Clienteid == id;
                        //  ListaArt = repo.GetList(p => p.Articuloid == id);
                        break;
                    case 2://Codigo
                        filtro = x => x.Apellidos.Contains(CriterioTextBox.Text);
                        //    ListaArt = repo.GetList(p => p.Codigo.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Marca
                        filtro = x => x.Cedula.Contains(CriterioTextBox.Text);
                        //      ListaArt = repo.GetList(p => p.Marca.Contains(CriterioTextBox.Text));
                        break;
                    case 4://Nombre
                        filtro = x => x.Email.Contains(CriterioTextBox.Text);
                        //  ListaArt = repo.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                    case 5://Telefono
                        filtro = x => x.Telefono.Contains(CriterioTextBox.Text);
                        break;
                    case 6:
                        filtro = x => x.Celular.Contains(CriterioTextBox.Text);
                        break;
                }

            }
            else
            {
                filtro = x => true;
            }
            ListaClient = repo.GetList(filtro);
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = ListaClient;

            if (ListaClient.Count == 0)
            {
                MessageBox.Show("No hay articulos para imprimir");
                return;
            }

            ReporteClientesConDeudas reporte = new ReporteClientesConDeudas(ListaClient);
            reporte.ShowDialog();
        }
    }
}
