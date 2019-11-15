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
    public partial class ConsultaVentas : Form
    {
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
    }
}
