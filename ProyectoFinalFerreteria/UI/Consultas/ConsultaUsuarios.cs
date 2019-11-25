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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            var Listado = new List<Usuario>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        Listado = repo.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.IdUsuario == id);
                        break;
                    case 2:
                        int id2 = Convert.ToInt32(CriterioTextBox.Text);
                        Listado = repo.GetList(p => p.Tipo == id2);
                        break;
                }
            }
            else
            {
                Listado = repo.GetList(p => true);
            }

            UsuariosDataGridView.DataSource = null;
            UsuariosDataGridView.DataSource = Listado;
        }
    }
}
