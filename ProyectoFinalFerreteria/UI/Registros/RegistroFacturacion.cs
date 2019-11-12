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
    public partial class RegistroFacturacion : Form
    {
        public List<DetalleArticulo> detalle { get; set; }
        public RegistroFacturacion()
        {
            InitializeComponent();
            this.detalle = new List<DetalleArticulo>();
        }

        private void TipoFacturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoFacturaComboBox.SelectedIndex == 0)
                ClienteGroupBox.Enabled = false;
            else
                ClienteGroupBox.Enabled = true;
        }

        public void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.detalle;
        }

        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            ClienteComboBox.Text = string.Empty;
            IDClienteNumericUpDown.Value = 0;
            TipoFacturaComboBox.SelectedIndex = 1;
            FechaDateTimePicker.Value = DateTime.Now;
            TelefonoTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            SubTotalTextBox.Text = string.Empty;
            DescuentosTextBox.Text = string.Empty;
            ITBISTextBox.Text = string.Empty;
            TotalGeneralTextBox.Text = string.Empty;
            CantidadArticulosTextBox.Text = string.Empty;

            this.detalle = new List<DetalleArticulo>();

            CargarGrid();
        }

        public Factura LlenarClase()
        {
            Factura factura = new Factura();

            factura.TipoFactura = TipoFacturaComboBox.Text;
            factura.Facturaid = Convert.ToInt32(IDNumericUpDown.Value);
            factura.SubTotal = Convert.ToDecimal(SubTotalTextBox.Text);
            factura.Fecha = FechaDateTimePicker.Value.Date;
            factura.ITBIS = Convert.ToDecimal(ITBISTextBox.Text);
            factura.CantidadArticulos = Convert.ToInt32(CantidadArticulosTextBox.Text);
            factura.TotalGeneral = Convert.ToDecimal(TotalGeneralTextBox.Text);
            factura.Descuentos = Convert.ToDecimal(DescuentosTextBox.Text);

            if(ClienteGroupBox.Enabled == true)
            {
                factura.NombreCliente = ClienteComboBox.Text;
                factura.TelefonoCliente = TelefonoTextBox.Text;
                factura.DireccionCliente = DireccionTextBox.Text;
                factura.Clienteid = Convert.ToInt32(IDClienteNumericUpDown.Value);
            }
            else
            {
                factura.NombreCliente = "-";
                factura.TelefonoCliente = "-";
                factura.DireccionCliente = "-";
                factura.Clienteid = 0;
            }

            factura.Articulos = this.detalle;

            CargarGrid();
            return factura;
        }

        public void LlenarCampo(Factura factura)
        {
            IDNumericUpDown.Value = factura.Facturaid;
            TipoFacturaComboBox.Text = factura.TipoFactura;
            FechaDateTimePicker.Value = factura.Fecha.Date;
            ClienteComboBox.Text = factura.NombreCliente;
            IDClienteNumericUpDown.Value = factura.Clienteid;
            DireccionTextBox.Text = factura.DireccionCliente;
            TelefonoTextBox.Text = factura.TelefonoCliente;
            SubTotalTextBox.Text = factura.SubTotal.ToString();
            ITBISTextBox.Text = factura.ITBIS.ToString();
            DescuentosTextBox.Text = factura.Descuentos.ToString();
            TotalGeneralTextBox.Text = factura.TotalGeneral.ToString();
            CantidadArticulosTextBox.Text = factura.CantidadArticulos.ToString();

            DetalleDataGridView.DataSource = this.detalle;
            CargarGrid();
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Factura> repo = new RepositorioBase<Factura>();
            Factura factura = repo.Buscar((int)IDNumericUpDown.Value);
            return factura != null;
        }

        public bool VerificarLimiteCredito()
        {
            bool paso = true;
            RepositorioBase<Cliente> repo = new RepositorioBase<Cliente>();

            if (IDClienteNumericUpDown.Value != 0)
            {
                if (ExisteEnLaBaseDeDatos())
                {
                    Cliente cliente = repo.Buscar((int)IDClienteNumericUpDown.Value);
                    if (cliente.LimiteCredito == 0)
                    {
                        MyErrorProvider.SetError(ClienteComboBox, "Excedio su limite de credito");
                        ClienteComboBox.Focus();
                        paso = false;
                    }
                    else if (cliente.LimiteCredito != 0)
                    {
                        if (cliente.LimiteCredito - Convert.ToDecimal(TotalGeneralTextBox) < 0)
                        {
                            MyErrorProvider.SetError(ClienteComboBox, "Excedio su limite de credito");
                            ClienteComboBox.Focus();
                            paso = false;
                        }
                    }
                }
            }
            return paso;
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            RepositorioBase<Cliente> repo = new RepositorioBase<Cliente>();

            if (ClienteGroupBox.Enabled == true && string.IsNullOrWhiteSpace(ClienteComboBox.Text))
            {
                MyErrorProvider.SetError(ClienteComboBox, "Seleccione un cliente");
                ClienteComboBox.Focus();
                paso = false;
            }

            if (!VerificarLimiteCredito())
            {
                paso = false;
            }

            if(this.detalle.Count == 0)
            {
                MyErrorProvider.SetError(AgregarAlGridButton, "Debe agregar articulos a la factura");
                AgregarAlGridButton.Focus();
                paso = false;
            }
            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Factura> repo = new RepositorioBase<Factura>();
            Factura factura = new Factura();

            if (!Validar())
                return;

            factura = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(factura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar", "Facturacion no registrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repo.Modificar(factura);
            }

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Factura> repo = new RepositorioBase<Factura>();
            Factura factura = repo.Buscar(id);

            Limpiar();

            if (factura == null)
            {
                MessageBox.Show("Factura no encontrada","Fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(factura);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Factura> repo = new RepositorioBase<Factura>();

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
        public void LlenarGroupBoxCliente(Cliente cliente)
        {
            IDClienteNumericUpDown.Value = cliente.Clienteid;
            ClienteComboBox.Text = cliente.Nombre + " " + cliente.Apellido;
        }
        public void LimpiarGroupBoxCliente()
        {
            IDClienteNumericUpDown.Value = 0;
            ClienteComboBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
        }
        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDClienteNumericUpDown.Text, out id);
            Cliente cliente = new Cliente();
            RepositorioBase<Cliente> repo = new RepositorioBase<Cliente>();

            cliente = repo.Buscar(id);
            LimpiarGroupBoxCliente();

            if(cliente == null)
            {
                MessageBox.Show("Cliente no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGroupBoxCliente(cliente);
            }

        }

        private void AgregarAlGridButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.detalle = (List<DetalleArticulo>)DetalleDataGridView.DataSource;

            this.detalle.Add(

                new DetalleArticulo(
                    id: 0,
                    facturaid: Convert.ToInt32(IDNumericUpDown.Value),
                    descripcion: DescripcionComboBox.Text,
                    cantidad: Convert.ToDecimal(CantidadNumericUpDown.Value),
                    unidad: UnidadComboBox.Text,
                    precioUnitario: Convert.ToDecimal(PrecioUnitarioTextBox.Text),
                    importe: Convert.ToDecimal(PrecioUnitarioTextBox.Text) * Convert.ToDecimal(CantidadNumericUpDown.Value)
                    )
                );

            CargarGrid();

            DescripcionComboBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
            UnidadComboBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;

            decimal SubTotal = 0, ITBIS = 0, TotalGeneral = 0;

            foreach (var item in this.detalle)
            {
                SubTotal += item.Importe;
                ITBIS += item.Importe * (decimal)0.18;
                TotalGeneral += SubTotal + ITBIS - Convert.ToDecimal(DescuentosTextBox.Text);    
            }
            SubTotalTextBox.Text = SubTotal.ToString();
            ITBISTextBox.Text = ITBIS.ToString();
            TotalGeneralTextBox.Text = TotalGeneral.ToString();
            CantidadArticulosTextBox.Text = Convert.ToString(this.detalle.Count);

            CargarGrid();
        }

        private void AgregarClienteButton_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroCliente();
            formulario.ShowDialog();
        }

        private void BuscarArticuloButton_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroArticulos();
            formulario.ShowDialog();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(DetalleDataGridView.CurrentRow != null && DetalleDataGridView.Rows.Count > 0)
            {
                detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);

                CargarGrid();
            }
            decimal SubTotal = 0, ITBIS = 0, TotalGeneral = 0;

            foreach (var item in this.detalle)
            {
                SubTotal += item.Importe;
                ITBIS += item.Importe * (decimal)0.18;
                TotalGeneral += SubTotal + ITBIS - Convert.ToDecimal(DescuentosTextBox.Text);
            }
            SubTotalTextBox.Text = SubTotal.ToString();
            ITBISTextBox.Text = ITBIS.ToString();
            TotalGeneralTextBox.Text = TotalGeneral.ToString();
            CantidadArticulosTextBox.Text = Convert.ToString(this.detalle.Count);

        }

        private void RegistroFacturacion_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
