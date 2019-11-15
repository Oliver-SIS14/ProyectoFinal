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
    public partial class ConsultaProducto : Form
    {
        public ConsultaProducto()
        {
            InitializeComponent();
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
                        Listado = repo.GetList(p => p.Articuloid == id);
                        break;
                    case 2://Codigo
                        Listado = repo.GetList(p => p.Codigo.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Marca
                        Listado = repo.GetList(p => p.Marca.Contains(CriterioTextBox.Text));
                        break;
                    case 4://Nombre
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
    }
}
