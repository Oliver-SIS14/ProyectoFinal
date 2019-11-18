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
    public partial class ReporteImprimirFactura : Form
    {
        public static List<Articulos> ListaArticulos2{ get; set; }
        public ReporteImprimirFactura(List<Articulos>articulos)
        {
            InitializeComponent();
            ListaArticulos2 = articulos;
        }

        private void FacturaReportViewer_Load(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            ReporteFactura listaf = new ReporteFactura();

            ListaArticulos2 = repo.GetList(p => true);

            listaf.SetDataSource(ListaArticulos2);

            FacturaReportViewer.ReportSource = listaf;
            FacturaReportViewer.Refresh();
        }
    }
}
