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
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            CodigoMaskedTextBox.Text = string.Empty;
            ArticuloTextBox.Text = string.Empty;
            UnidadComboBox.Text = string.Empty;
            MarcaTextBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            InventarioNumericUpDown.Value = 0;
        }
        public Articulos LlenarClase()
        {
            Articulos articulo = new Articulos();

            articulo.Articuloid = Convert.ToInt32(IDNumericUpDown.Value);
            articulo.Unidad = UnidadComboBox.Text;
            articulo.PrecioUnitario = PrecioNumericUpDown.Value;
            articulo.Inventario = Convert.ToInt32(InventarioNumericUpDown.Value);
            articulo.Codigo = CodigoMaskedTextBox.Text;
            articulo.Marca = MarcaTextBox.Text;
            articulo.Descripcion = ArticuloTextBox.Text;

            return articulo;
        }
        public void LlenarCampo(Articulos articulo)
        {
            IDNumericUpDown.Value = articulo.Articuloid;
            ArticuloTextBox.Text = articulo.Descripcion;
            UnidadComboBox.Text = articulo.Unidad;
            PrecioNumericUpDown.Value = articulo.PrecioUnitario;
            InventarioNumericUpDown.Value = articulo.Inventario; 
            CodigoMaskedTextBox.Text = articulo.Codigo;
            MarcaTextBox.Text = articulo.Marca;
        }

        public bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ArticuloTextBox.Text))
            {
                MyErrorProvider.SetError(ArticuloTextBox, "Debe insertar almenos un articulo.");
                ArticuloTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CodigoMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CodigoMaskedTextBox, "Debe asignarle un codigo.");
                CodigoMaskedTextBox.Focus();
                paso = false;
            }

            if (PrecioNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "Debe asignarle un precio valido.");
                PrecioNumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UnidadComboBox.Text))
            {
                MyErrorProvider.SetError(UnidadComboBox, "Debe agregarle una medida.");
                UnidadComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            Articulos articulo = repo.Buscar((int)IDNumericUpDown.Value);
            return articulo != null;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            Articulos articulo = new Articulos();

            if (!Validar())
                return;

            articulo = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(articulo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar", "Producto no registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repo.Modificar(articulo);
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
            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();
            Articulos articulo = repo.Buscar(id);

            Limpiar();

            if (articulo == null)
            {
                MessageBox.Show("Articulo no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(articulo);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id = 0;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Articulos> repo = new RepositorioBase<Articulos>();


            var Resultado = MessageBox.Show("Esta seguro que desea eliminar este Articulo", "Ferreteria Nelson", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
