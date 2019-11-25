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
    public partial class RegistroCobro : Form
    {
        public RegistroCobro()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            IDClienteNumericUpDown.Value = 0;
            BalanceTextBox.Text = string.Empty;
            DepositoTextBox.Text = string.Empty;
            LimiteCreditoTextBox.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
        }

        public Cobro LlenarClase()
        {
            Cobro cobro = new Cobro();
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            cobro.Cobroid = Convert.ToInt32(IDNumericUpDown.Value);
            cobro.Clienteid = Convert.ToInt32(IDClienteNumericUpDown.Value);
            Clientes cliente = repo.Buscar(Convert.ToInt32(IDClienteNumericUpDown.Value));
            if (string.IsNullOrWhiteSpace(BalanceTextBox.Text))
                BalanceTextBox.Text = "0";

            if (string.IsNullOrWhiteSpace(DepositoTextBox.Text))
                DepositoTextBox.Text = "0";

            cliente.LimiteCredito = Convert.ToDecimal(LimiteCreditoTextBox.Text) - Convert.ToDecimal(BalanceTextBox.Text) + Convert.ToDecimal(DepositoTextBox.Text);
            cliente.Balance = Convert.ToDecimal(BalanceTextBox.Text) - Convert.ToDecimal(DepositoTextBox.Text);
            repo.Modificar(cliente);
            //   
            cobro.Fecha = FechaDateTimePicker.Value;
            cobro.Usuarioid = Login.Usuarioid;
            return cobro;
        }

        public void LlenarCampo(Cobro cobro)
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            IDNumericUpDown.Value = cobro.Cobroid;
            IDClienteNumericUpDown.Value = cobro.Clienteid;

            Clientes cliente = repo.Buscar(cobro.Clienteid);

            BalanceTextBox.Text = cliente.Balance.ToString();
            LimiteCreditoTextBox.Text = cliente.LimiteCredito.ToString();

            RepositorioBase<Usuario> repou = new RepositorioBase<Usuario>();

            Usuario usuario = repou.Buscar(Login.Usuarioid);
            UsuarioTextBox.Text = usuario.User;
            FechaDateTimePicker.Value = cobro.Fecha;
        }
        public bool validar()
        {
            bool paso = true;
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            if(IDClienteNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IDClienteNumericUpDown,"Debe especificar el id del cliente");
                paso = false;
                IDClienteNumericUpDown.Focus();
            }
            if (string.IsNullOrWhiteSpace(DepositoTextBox.Text))
            {
                DepositoTextBox.Text = "0";
            }
            if (repo.Buscar(Convert.ToInt32(IDClienteNumericUpDown.Value)) == null)
            {
                MyErrorProvider.SetError(IDClienteNumericUpDown, "El cliente introducido no esta registrado");
                paso = false;
                IDClienteNumericUpDown.Focus();
            }
            if (string.IsNullOrWhiteSpace(LimiteCreditoTextBox.Text))
            {
                MyErrorProvider.SetError(LimiteCreditoTextBox, "Debe agregarle un limite de credito");
                paso = false;
                LimiteCreditoTextBox.Focus();
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cobro> repo = new RepositorioBase<Cobro>();
            Cobro cobro = repo.Buscar((int)IDNumericUpDown.Value);
            return cobro != null;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Cobro> repo = new RepositorioBase<Cobro>();

            if (!validar())
                return;

            Cobro cobro = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(cobro);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado en la base de datos");
                    return;
                }
                paso = repo.Guardar(cobro);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Cobro> repo = new RepositorioBase<Cobro>();
            Cobro cobro = repo.Buscar(id);

            Limpiar();

            if(cobro == null)
            {
                MessageBox.Show("No encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(cobro);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Cobro> repo = new RepositorioBase<Cobro>();

            Limpiar();

            if(repo.Buscar(id)!= null)
            {
                if (repo.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void RegistroCobro_Load(object sender, EventArgs e)
        {

            RepositorioBase<Usuario> repou = new RepositorioBase<Usuario>();

            Usuario usuario = repou.Buscar(Login.Usuarioid);
            UsuarioTextBox.Text = usuario.User;
        }

        private void BalanceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BalanceTextBox.Text) || BalanceTextBox.Text == "0,00")
            {
                DepositoTextBox.Text = "0,00";
                DepositoTextBox.ReadOnly = true;
            }
            else
            {
                DepositoTextBox.ReadOnly = false;
            }
        }

        private void IDClienteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            if((int)IDClienteNumericUpDown.Value != 0)
            {
            int id = (int)IDClienteNumericUpDown.Value;

            Clientes cliente = repo.Buscar(id);

            BalanceTextBox.Text = cliente.Balance.ToString();

            if (string.IsNullOrWhiteSpace(DepositoTextBox.Text))
            {
                DepositoTextBox.Text = "0";
            }

            if (cliente.LimiteCredito == 0)
                LimiteCreditoTextBox.Text = "0";
            else
                LimiteCreditoTextBox.Text = cliente.LimiteCredito.ToString();

            }

        }
    }
}
