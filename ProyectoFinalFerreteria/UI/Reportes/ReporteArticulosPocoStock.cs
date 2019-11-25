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
        public List<Articulos> ListaArticulos { get; set; }
        public ReporteArticulosPocoStock(List<Articulos>articulos)
        {
            this.ListaArticulos = articulos;
            InitializeComponent();
        }

        private void ReporteArticulosPocoStock_Load(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            ReporteArticulosAgotados listaf = new ReporteArticulosAgotados();

            listaf.SetDataSource(ListaArticulos);

            ArticulosReportViewer.ReportSource = listaf;
            ArticulosReportViewer.Refresh();
        }
    }
}
