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
    public partial class ConsultaVentas : Form
    {
        private List<Facturas> ListaFact;
        public Expression<Func<Facturas,bool>> filtro { get; set; }
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Facturas>();
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        Listado = repo.GetList(p => true);
                        break;
                    case 1: //Facturaid
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Facturaid == id);
                        break;
                    case 2://Monto
                        decimal monto = Convert.ToDecimal(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.TotalGeneral == monto);
                        break;
                    case 3: //Cliente
                        int idCliente = Convert.ToInt32(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Clienteid == idCliente);
                        break;
                }

                Listado = Listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                Listado = repo.GetList(p => true);
            }

            VentasDataGridView.DataSource = null;
            VentasDataGridView.DataSource = Listado;
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        filtro = x => true;
                        break;
                    case 1: //Articuloid
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Facturaid == id && (x.Fecha >= DesdeDateTimePicker.Value && x.Fecha <= HastaDateTimePicker.Value);
                        //  ListaArt = repo.GetList(p => p.Articuloid == id);
                        break;
                    case 2://Codigo
                        decimal Tg = Convert.ToDecimal(CriterioTextBox.Text);
                        filtro = x => (x.TotalGeneral == Tg) && (x.Fecha >= DesdeDateTimePicker.Value && x.Fecha <= HastaDateTimePicker.Value);
                        //    ListaArt = repo.GetList(p => p.Codigo.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Marca
                        int clienteid = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => (x.Clienteid == clienteid) && (x.Fecha >= DesdeDateTimePicker.Value && x.Fecha <= HastaDateTimePicker.Value);
                        //      ListaArt = repo.GetList(p => p.Marca.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
            {
                filtro = x => true;
            }
            ListaFact = repo.GetList(filtro);
            VentasDataGridView.DataSource = null;
            VentasDataGridView.DataSource = ListaFact;

            if (ListaFact.Count == 0)
            {
                MessageBox.Show("No hay articulos para imprimir");
                return;
            }


            ReporteVentasDiarias reporte = new ReporteVentasDiarias(ListaFact);
            reporte.ShowDialog();
        }
    }
}
