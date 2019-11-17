using ProyectoFinalFerreteria.BLL;
using ProyectoFinalFerreteria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFerreteria.UI.Reportes
{
    public partial class ReporteArticulosPocoStock : Form
    {
        public static List<Articulos> ListaArticulos { get; set; }
        public ReporteArticulosPocoStock(List<Articulos>articulos)
        {
            InitializeComponent();
            ListaArticulos = articulos;
        }

        private void ReporteArticulosPocoStock_Load(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            ReporteArticulosAgotados listaf = new ReporteArticulosAgotados();

            ListaArticulos = repo.GetList(p => true);

            ListaArticulos = ListaArticulos.Where(c => c.Inventario <= 5).ToList();

            listaf.SetDataSource(ListaArticulos);

            ArticulosReportViewer.ReportSource = listaf;
            ArticulosReportViewer.Refresh();
        }
    }
}
