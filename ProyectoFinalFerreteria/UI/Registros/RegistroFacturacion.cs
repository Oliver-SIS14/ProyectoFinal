﻿using ProyectoFinalFerreteria.BLL;
using ProyectoFinalFerreteria.Entidades;
using ProyectoFinalFerreteria.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFerreteria.UI.Registros
{
    public partial class RegistroFacturacion : Form
    {
        Validacion v = new Validacion();
        public List<FacturaDetalle> detalle { get; set; }
        public RegistroFacturacion()
        {
            InitializeComponent();
            this.detalle = new List<FacturaDetalle>();
        }

        private void TipoFacturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LlenarComboBoxArticulo()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            var Lista = repo.GetList(p => true);

            DescripcionComboBox.DataSource = Lista;
            DescripcionComboBox.ValueMember = "Articuloid";
            DescripcionComboBox.DisplayMember = "Descripcion";   
        }

        public void LlenarComboBoxCliente()
        {
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();
            var Lista = repo.GetList(p => true);

            ClienteComboBox.DataSource = Lista;
            ClienteComboBox.ValueMember = "Clienteid";
            ClienteComboBox.DisplayMember = "Nombres";
        }

        public void CargarGrid(List<FacturaDetalle>detalle)
        {
 
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            RepositorioBase<FacturaDetalle> repo2 = new RepositorioBase<FacturaDetalle>();

            var Listado = repo.GetList(c => true);
            
                foreach (var item2 in detalle)
                {
                    Articulos articulo = repo.Buscar(item2.Articuloid);

                    DetalleDataGridView.Rows.Add(articulo.Articuloid, articulo.Descripcion, item2.Cantidad, articulo.Unidad, articulo.PrecioUnitario, item2.Cantidad * articulo.PrecioUnitario);
                }

        }

        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            ClienteComboBox.Text = string.Empty;
            TipoFacturaComboBox.SelectedIndex = 1;
            FechaDateTimePicker.Value = DateTime.Now;
            SubTotalTextBox.Text = string.Empty;
            DescuentosTextBox.Text = string.Empty;
            ITBISTextBox.Text = string.Empty;
            ComentariosRichTextBox.Text = string.Empty;
            TotalGeneralTextBox.Text = string.Empty;
            CantidadArticulosTextBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
            CantidadNumericUpDown.Refresh();
            UnidadTextBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            UsuarioTextBox.Text = string.Empty;

            this.detalle = new List<FacturaDetalle>();

            DetalleDataGridView.Rows.Clear();
        }

        public Facturas LlenarClase()
        {
            Facturas factura = new Facturas();

            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            factura.TipoFactura = TipoFacturaComboBox.Text;
            factura.Facturaid = Convert.ToInt32(IDNumericUpDown.Value);
            factura.Clienteid = Convert.ToInt32(ClienteComboBox.SelectedValue.ToString());
            factura.Fecha = FechaDateTimePicker.Value.Date;
            factura.ITBIS = Convert.ToDecimal(ITBISTextBox.Text);
            factura.CantidadArticulos = Convert.ToInt32(CantidadArticulosTextBox.Text);
            factura.TotalGeneral = Convert.ToDecimal(TotalGeneralTextBox.Text);
            if (string.IsNullOrWhiteSpace(ComentariosRichTextBox.Text))
                factura.Comentarios = " ";
            else
                factura.Comentarios = ComentariosRichTextBox.Text;

            if (string.IsNullOrWhiteSpace(DescuentosTextBox.Text))
                factura.Descuentos = 0;
            else
                factura.Descuentos = Convert.ToDecimal(DescuentosTextBox.Text);

            Clientes cliente = repo.Buscar(factura.Clienteid);

            if(cliente!=null)
            factura.Balance = cliente.Balance;
            factura.Articulos = this.detalle;
            if (string.IsNullOrWhiteSpace(SubTotalTextBox.Text))
                factura.SubTotal = 0;
            else
                factura.SubTotal = Convert.ToDecimal(SubTotalTextBox.Text);

            factura.Usuarioid = Login.Usuarioid;

            CargarGrid(this.detalle);
            return factura;
        }

        public void LlenarCampo(Facturas factura)
        {
            IDNumericUpDown.Value = factura.Facturaid;
            TipoFacturaComboBox.Text = factura.TipoFactura;
            FechaDateTimePicker.Value = factura.Fecha.Date;
            ITBISTextBox.Text = factura.ITBIS.ToString();
            DescuentosTextBox.Text = factura.Descuentos.ToString();
            TotalGeneralTextBox.Text = factura.TotalGeneral.ToString();
            CantidadArticulosTextBox.Text = factura.CantidadArticulos.ToString();
            BalanceTextBox.Text = factura.Balance.ToString();
            ComentariosRichTextBox.Text = factura.Comentarios;
            SubTotalTextBox.Text = factura.SubTotal.ToString();
            
            RepositorioBase<Usuario> repou = new RepositorioBase<Usuario>();

            Usuario usuario = repou.Buscar(Login.Usuarioid);
            UsuarioTextBox.Text = usuario.User;

            CargarGrid(factura.Articulos);

            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            decimal SubTotal = 0, ITBIS = 0, TotalGeneral = 0;

            foreach (var item in factura.Articulos)
            {
                Articulos articulo = repo.Buscar(item.Articuloid);

                SubTotal += (articulo.PrecioUnitario * item.Cantidad);
                ITBIS = (SubTotal * (decimal)0.18);
                TotalGeneral = SubTotal + ITBIS;
            }
            SubTotalTextBox.Text = SubTotal.ToString();
            ITBISTextBox.Text = ITBIS.ToString();
            TotalGeneralTextBox.Text = TotalGeneral.ToString();
            ComentariosRichTextBox.Clear();
            ComentariosRichTextBox.Text = Convert.ToString(factura.Articulos.Count);

        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            Facturas factura = repo.Buscar((int)IDNumericUpDown.Value);
            return factura != null;

        }

        public bool VerificarLimiteCredito()
        {
            bool paso = true;
            string Id = ClienteComboBox.SelectedValue.ToString();

            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            Clientes cliente = repo.Buscar(Convert.ToInt32(Id));

            if(cliente.LimiteCredito == 0)
            {
                cliente.LimiteCredito = 5000;
                MessageBox.Show("El cliente ha excedido su limite de credito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = false;
            }

            if(cliente.LimiteCredito - Convert.ToDecimal(TotalGeneralTextBox.Text) < 0)
            {
                MessageBox.Show("El cliente ha excedido su limite de credito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = false;
            }

            return paso;
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            RepositorioBase<Clientes> repo = new RepositorioBase<Clientes>();

            if (string.IsNullOrWhiteSpace(ClienteComboBox.Text))
            {
                MyErrorProvider.SetError(ClienteComboBox, "Agregue un cliente");
                AgregarClienteButton.Focus();
                paso = false;
            }

            if(this.detalle.Count == 0)
            {
                MyErrorProvider.SetError(AgregarAlGridButton, "Debe agregar articulos a la factura");
                AgregarAlGridButton.Focus();
                paso = false;
            }

            if (!VerificarLimiteCredito())
            {
                MyErrorProvider.SetError(ClienteComboBox, "El cliente ha excedido su limite de credito");
                ClienteComboBox.Focus();
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
            RepositorioFactura repof = new RepositorioFactura();

            Facturas factura = new Facturas();

            if (!Validar())
                return;

            factura = LlenarClase();

            int Id = Convert.ToInt32(ClienteComboBox.SelectedValue.ToString());


            if (IDNumericUpDown.Value == 0)
                paso = repof.Guardar(factura,Id);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar", "Facturacion no registrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repof.Modificar(factura);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            Facturas factura = repo.Buscar(id);

            Limpiar();

            if (factura == null)
            {
                MessageBox.Show("Factura no encontrada","Fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(factura);
                DetalleDataGridView.Rows.Clear();
                CargarGrid(factura.Articulos);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            RepositorioFactura repof = new RepositorioFactura();

            int id2 = Convert.ToInt32(ClienteComboBox.SelectedValue.ToString());
            Limpiar();
            var Resultado = MessageBox.Show("Esta seguro que desea eliminar este Articulo", "Ferreteria Nelson", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Limpiar();
            if (Resultado == DialogResult.Yes)
            {
                if (repo.Buscar(id) != null)
                {
                    if (repof.Eliminar(id, id2, this.detalle))
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

        private void AgregarAlGridButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            if (DetalleDataGridView.DataSource != null)
                this.detalle = (List<FacturaDetalle>)DetalleDataGridView.DataSource;
                
            string Id = DescripcionComboBox.SelectedValue.ToString();

            this.detalle.Add(

                new FacturaDetalle(
                    id: 0,
                    facturaid: Convert.ToInt32(IDNumericUpDown.Value),
                    articuloid: Convert.ToInt32(Id),
                    cantidad: Convert.ToDecimal(CantidadNumericUpDown.Value)
                    )
                );

            DetalleDataGridView.Rows.Clear();
            CargarGrid(this.detalle);

            DescripcionComboBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
            
            decimal SubTotal = 0, ITBIS = 0, TotalGeneral = 0;

            CantidadArticulosTextBox.Text = this.detalle.Count.ToString();
            if (string.IsNullOrWhiteSpace(SubTotalTextBox.Text))
                SubTotalTextBox.Text = "0";
            if (string.IsNullOrWhiteSpace(ITBISTextBox.Text))
                ITBISTextBox.Text = "0";
            if (string.IsNullOrWhiteSpace(TotalGeneralTextBox.Text))
                TotalGeneralTextBox.Text = "0";

            foreach (var item in this.detalle)
            {
                Articulos articulo = repo.Buscar(item.Articuloid);

                SubTotal = Convert.ToDecimal(SubTotalTextBox.Text) + (articulo.PrecioUnitario * item.Cantidad);
                ITBIS = (SubTotal *(decimal)0.18);
                TotalGeneral = SubTotal + ITBIS;
            }

            SubTotalTextBox.Text = SubTotal.ToString();
            ITBISTextBox.Text = ITBIS.ToString();
            TotalGeneralTextBox.Text = TotalGeneral.ToString();

        }

        private void AgregarClienteButton_Click(object sender, EventArgs e)
        {
            LlenarComboBoxCliente();
            Form formulario = new RegistroCliente();
            formulario.ShowDialog();

            LlenarComboBoxCliente();
        }

        private void BuscarArticuloButton_Click(object sender, EventArgs e)
        {
            LlenarComboBoxArticulo();
            Form formulario = new RegistroArticulos();
            formulario.ShowDialog();

            LlenarComboBoxArticulo();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();

            //CargarGrid(this.detalle);
            if (DetalleDataGridView.CurrentRow != null && DetalleDataGridView.Rows.Count > 0)
            {
                detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                DetalleDataGridView.Rows.Clear();
                CargarGrid(detalle);
            }
            decimal SubTotal = 0, ITBIS = 0, TotalGeneral = 0;

            foreach (var item in this.detalle)
            {
                Articulos articulo = repo.Buscar(item.Articuloid);

                SubTotal += (articulo.PrecioUnitario * item.Cantidad);
                ITBIS = (SubTotal * (decimal)0.18);
                TotalGeneral = SubTotal + ITBIS;
            }
            SubTotalTextBox.Text = SubTotal.ToString();
            ITBISTextBox.Text = ITBIS.ToString();
            TotalGeneralTextBox.Text = TotalGeneral.ToString();
            CantidadArticulosTextBox.Text = Convert.ToString(this.detalle.Count);

        }
        public int RetornaId()
        {
            int Id = Convert.ToInt32(ClienteComboBox.SelectedValue.ToString());
            return Id;
        }

        private void RegistroFacturacion_Load(object sender, EventArgs e)
        {
            Limpiar();
            LlenarComboBoxArticulo();
            LlenarComboBoxCliente();
            DetalleDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            RepositorioBase<Usuario> repou = new RepositorioBase<Usuario>();

            Usuario usuario = repou.Buscar(Login.Usuarioid);
            UsuarioTextBox.Text = usuario.User;

            CargarGrid(this.detalle);
        }


        private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> repo2 = new RepositorioBase<Articulos>();
            RepositorioBase<Clientes> repo3 = new RepositorioBase<Clientes>();

            string Id = DescripcionComboBox.SelectedValue.ToString();
            string Id2 = ClienteComboBox.SelectedValue.ToString();

                Articulos articulo = repo2.Buscar(Convert.ToInt32(Id));
                Clientes cliente = repo3.Buscar(Convert.ToInt32(Id2));

                BalanceTextBox.Text = cliente.Balance.ToString();
                PrecioUnitarioTextBox.Text = articulo.PrecioUnitario.ToString();
                UnidadTextBox.Text = articulo.Unidad.ToString();
                CantidadNumericUpDown.Maximum = articulo.Inventario;
                ImporteTextBox.Text = (articulo.PrecioUnitario * ((decimal)CantidadNumericUpDown.Value)).ToString();
        }

        private void DescripcionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            BalanceTextBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            RepositorioFactura repo3 = new RepositorioFactura();
            var Lista2 = repo3.GetList(p => true);
            Form formulario = new ReporteVentasDiarias(Lista2);
            formulario.Show();           
        }

        private void DescuentosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void ClienteComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
////            BalanceTextBox.Text = ClienteComboBox.SelectedValue.ToString();
        }
    }
}
