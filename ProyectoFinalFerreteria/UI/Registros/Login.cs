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
    public partial class Login : Form
    {
        public static int Usuarioid { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();
            
            var Lista = repo.GetList(c => true);

            UsuarioComboBox.DataSource = Lista;
            UsuarioComboBox.ValueMember = "IdUsuario";
            UsuarioComboBox.DisplayMember = "User";
            string id = UsuarioComboBox.SelectedValue.ToString();

            Usuario user = repo.Buscar(Convert.ToInt32(id));
            if(user.Tipo == 0)
            {
                RegistrarseButton.Enabled = false;
            }
            else
            {
                RegistrarseButton.Enabled = true;
            }*/
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repo2 = new RepositorioBase<Usuario>();

            var Lista2 = repo2.GetList(p => true);
            if(Lista2.Count == 0)
            {
                Usuario u = new Usuario();

                u.Contraseña = "1234";
                u.User = "Admin";
                u.Tipo = 1;
                repo2.Guardar(u);
            }

            RegistrarseButton.Enabled = false;

            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            var Lista = repo.GetList(c => true);

            UsuarioComboBox.DataSource = Lista;
            UsuarioComboBox.ValueMember = "IdUsuario";
            UsuarioComboBox.DisplayMember = "User";
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            var lista = repo.GetList(p => true);
            int id = Convert.ToInt32(UsuarioComboBox.SelectedValue.ToString());

            Usuario usuario = repo.Buscar(id);


            if (usuario.Contraseña == ContraseñaTextBox.Text)
            { 
                Form formulario = new MainForm();
                formulario.Show();
                Usuarioid = id;
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta","Fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }

        private void RegistrarseButton_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroUsuario();
            formulario.Show();
        }

        private void RegistrarseButton_TextChanged(object sender, EventArgs e)
        {
        }

        private void RegistrarseButton_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repo = new RepositorioBase<Usuario>();

            var lista = repo.GetList(p => true);
            int id = Convert.ToInt32(UsuarioComboBox.SelectedValue.ToString());

            Usuario usuario = repo.Buscar(id);


            if (usuario.Contraseña == ContraseñaTextBox.Text)
            {
                RegistrarseButton.Enabled = true;
            }
            else
            {
                RegistrarseButton.Enabled = false;
            }
        }

        private void UsuarioComboBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
