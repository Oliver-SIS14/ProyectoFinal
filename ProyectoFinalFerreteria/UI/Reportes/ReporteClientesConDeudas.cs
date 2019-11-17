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
    public partial class ReporteClientesConDeudas : Form
    {
        public static List<Clientes> ListaClientes { get; set; }
        public ReporteClientesConDeudas(List<Clientes>clientes)
        {
            InitializeComponent();
            ListaClientes = clientes;
        }

        private void ReporteClientesConDeudas_Load(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            ClientesConDeudas listaf = new ClientesConDeudas();

            ListaClientes = repo.GetList(p => true);

            ListaClientes = ListaClientes.Where(c => c.Balance != 0).ToList();

            listaf.SetDataSource(ListaClientes);

            ClientesReportViewer.ReportSource = listaf;
            ClientesReportViewer.Refresh();
        }
    }
}
