using ProyectoFinalFerreteria.UI.Consultas;
using ProyectoFinalFerreteria.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFerreteria
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroFacturacion();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroCliente();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroArticulos();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaVentas();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaClientes();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaProducto();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
