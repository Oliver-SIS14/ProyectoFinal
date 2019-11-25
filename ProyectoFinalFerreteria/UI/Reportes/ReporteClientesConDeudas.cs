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
        public List<Clientes> ListaClientes { get; set; }
        public ReporteClientesConDeudas(List<Clientes>clientes)
        {
            InitializeComponent();
            this.ListaClientes = clientes;
        }

        private void ReporteClientesConDeudas_Load(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            ClientesConDeuda listaf = new ClientesConDeuda();

            listaf.SetDataSource(ListaClientes);
            
            ClientesReportViewer.ReportSource = listaf;
            ClientesReportViewer.Refresh();
        }
    }
}
