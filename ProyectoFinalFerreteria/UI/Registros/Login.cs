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

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
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
    }
}
