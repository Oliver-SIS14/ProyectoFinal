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
    public partial class RegistroCliente : Form
    {
        public List<Facturas>Cdetalle { get; set; }
        public RegistroCliente()
        {
            InitializeComponent();
            this.Cdetalle = new List<Facturas>();
        }
        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            CodigoMaskedTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            DepositoTextBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            LimiteCreditoTextBox.Text = string.Empty;

            this.Cdetalle = new List<Facturas>();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public Clientes LlenarClase()
        {
            Clientes cliente = new Clientes();

            cliente.Clienteid = Convert.ToInt32(IDNumericUpDown.Value);
            cliente.Nombres = NombreTextBox.Text;
            cliente.Apellidos = ApellidoTextBox.Text;
            cliente.Codigo = CodigoMaskedTextBox.Text;
            cliente.Cedula = CedulaMaskedTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            if (string.IsNullOrWhiteSpace(BalanceTextBox.Text))
                BalanceTextBox.Text = "0";
            cliente.Balance = Convert.ToDecimal(BalanceTextBox.Text);
            cliente.Telefono = TelefonoMaskedTextBox.Text;
            cliente.Celular = CelularMaskedTextBox.Text;
            cliente.LimiteCredito = Convert.ToDecimal(LimiteCreditoTextBox.Text);


            return cliente;
        }

        public void LlenarCampo(Clientes cliente)
        {
            IDNumericUpDown.Value = cliente.Clienteid;
            NombreTextBox.Text = cliente.Nombres;
            ApellidoTextBox.Text = cliente.Apellidos;
            CodigoMaskedTextBox.Text = cliente.Codigo;
            CedulaMaskedTextBox.Text = cliente.Cedula;
            CelularMaskedTextBox.Text = cliente.Celular;
            DireccionTextBox.Text = cliente.Direccion;
            EmailTextBox.Text = cliente.Email;
            BalanceTextBox.Text = cliente.Balance.ToString();
            TelefonoMaskedTextBox.Text = cliente.Telefono;
            LimiteCreditoTextBox.Text = cliente.LimiteCredito.ToString();
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                MyErrorProvider.SetError(ApellidoTextBox, "El campo apellido no puede estar vacio");
                ApellidoTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo direccion no puede estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "El campo telefono no puede estar vacio");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            Clientes cliente = repo.Buscar((int)IDNumericUpDown.Value);
            return cliente!=null;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            RepositorioCliente repoc = new RepositorioCliente();
            Clientes cliente = new Clientes();

            
            if (!Validar())
                return;

            cliente = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(cliente);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar", "Cliente no registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repo.Modificar(cliente);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            Clientes cliente = repo.Buscar(id);

            Limpiar();

            if (cliente == null)
            {
                MessageBox.Show("Articulo no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(cliente);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            MyErrorProvider.Clear();

            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            

            var Resultado = MessageBox.Show("Esta seguro que desea eliminar este cliente", "Ferreteria Nelson", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Limpiar();
            if (Resultado == DialogResult.Yes)
            {
                if (repo.Buscar(id) != null)
                {
                    if (repo.Eliminar(id))
                        MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar este registro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
