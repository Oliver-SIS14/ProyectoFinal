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
    public partial class ConsultaProducto : Form
    {
        private List<Articulos> ListaArt;
        private Expression<Func<Articulos, bool>> filtro;

        public ConsultaProducto()
        {
            InitializeComponent();
            this.ListaArt = new List<Articulos>();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {

            var Listado = new List<Articulos>();
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        Listado = repo.GetList(p => true);
                        break;
                    case 1: //Articuloid
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Articuloid == id;
                        Listado = repo.GetList(p => p.Articuloid == id);
                        break;
                    case 2://Codigo
                        filtro = x => x.Codigo.Contains(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Codigo.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Marca
                        filtro = x => x.Marca.Contains(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Marca.Contains(CriterioTextBox.Text));
                        break;
                    case 4://Nombre
                        filtro = x => x.Descripcion.Contains(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
            {
                Listado = repo.GetList(p => true);
            }
            ProductoDataGridView.DataSource = null;
            ProductoDataGridView.DataSource = Listado;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        filtro = p => true;
                        break;
                    case 1: //Articuloid
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Articuloid == id;
                        //  ListaArt = repo.GetList(p => p.Articuloid == id);
                        break;
                    case 2://Codigo
                        filtro = x => x.Codigo.Contains(CriterioTextBox.Text);
                        //    ListaArt = repo.GetList(p => p.Codigo.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Marca
                        filtro = x => x.Marca.Contains(CriterioTextBox.Text);
                        //      ListaArt = repo.GetList(p => p.Marca.Contains(CriterioTextBox.Text));
                        break;
                    case 4://Nombre
                        filtro = x => x.Descripcion.Contains(CriterioTextBox.Text);
                        //  ListaArt = repo.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
            {
                filtro = x => true;
            }
            ListaArt = repo.GetList(filtro);
            ProductoDataGridView.DataSource = null;
            ProductoDataGridView.DataSource = ListaArt;

            if (ListaArt.Count == 0)
            {
                MessageBox.Show("No hay articulos para imprimir");
                return;
            }


            ReporteArticulosPocoStock reporte = new ReporteArticulosPocoStock(ListaArt);
            reporte.ShowDialog();
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
        }
    }
}
