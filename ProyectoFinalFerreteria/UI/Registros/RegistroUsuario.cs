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

namespace ProyectoFinalFerreteria.UI.Registros
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            UsuarioTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
            TipoComboBox.SelectedIndex = 0;
        }
        public Usuario LlenarClase()
        {
            Usuario usuario = new Usuario();

            usuario.IdUsuario = Convert.ToInt32(IDNumericUpDown.Value);
            usuario.User = UsuarioTextBox.Text;
            usuario.Contraseña = ContraseñaTextBox.Text;
            usuario.Tipo = TipoComboBox.SelectedIndex;

            return usuario;
        }

        public void LlenarCampo(Usuario usuario)
        {
            IDNumericUpDown.Value = usuario.IdUsuario;
            UsuarioTextBox.Text = usuario.User;
            ContraseñaTextBox.Text = usuario.Contraseña;
            TipoComboBox.SelectedIndex = usuario.Tipo;
        }

        public bool validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo usuario no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "El campo constraseña no puede estar vacio");
                ContraseñaTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            Usuario usuario = repo.Buscar((int)IDNumericUpDown.Value);
            return usuario != null;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();

            if (!validar())
                return;

            usuario = LlenarClase();

            if(IDNumericUpDown.Value == 0)
            {
                paso = repo.Guardar(usuario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                paso = repo.Modificar(usuario);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            Limpiar();

            if (repo.Buscar(id)!=null)
            {
                if (repo.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("No encontrado", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            Usuario usuario  = repo.Buscar(id);

            Limpiar();

            if(usuario == null)
            {
                MessageBox.Show("No encontrado", "Fallo");
            }
            else
            {
                LlenarCampo(usuario);
            }

        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            Usuario u = new Usuario();

            u.Contraseña = "1234";
            u.User = "Admin";
            u.Tipo = 1;

            repo.Guardar(u);
        }
    }
}
