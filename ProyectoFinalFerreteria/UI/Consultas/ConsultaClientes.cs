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

namespace ProyectoFinalFerreteria.UI.Consultas
{
    public partial class ConsultaClientes : Form
    {
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
                    case 1: //Facturaid
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Clienteid == id);
                        break;
                    case 2://Monto
                        Listado = repo.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Cliente
                        Listado = repo.GetList(p => p.Apellidos.Contains(CriterioTextBox.Text));
                        break;
                    case 4://IdCliente
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
    }
}
