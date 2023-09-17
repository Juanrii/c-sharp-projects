using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormProducto : Form
    {
        private BLLCeliaco _bllCeliaco;
        private BLLVegano _bllVegano;

        public FormProducto()
        {
            InitializeComponent();
            _bllCeliaco = new BLLCeliaco();
            _bllVegano  = new BLLVegano();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            radioBtnCeliacos.Checked = true;

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _bllCeliaco.Listar();

            // Orden columnas del dgv
            dgvProductos.Columns["Codigo"].DisplayIndex   = 0;
            dgvProductos.Columns["Nombre"].DisplayIndex   = 1;
            dgvProductos.Columns["Precio"].DisplayIndex   = 2;
            dgvProductos.Columns["Stock"].DisplayIndex    = 3;
            dgvProductos.Columns["Cantidad"].DisplayIndex = 4;

            MostrarMesajeRequerido(false);
            LlenarDropDown();
            LimpiarCampos();
        }

        private void LlenarDropDown()
        {
            inputProducto.Items.Clear();
            inputProducto.DisplayMember = "Nombre";
            inputProducto.ValueMember   = "Codigo";
            inputProducto.Items.Add("Celiaco");
            inputProducto.Items.Add("Vegano");
            inputProducto.SelectedItem = "Celiaco";

            inputCantidad.Items.Clear();
            inputCantidad.DataSource = Enum.GetValues(typeof(BEProducto.Cantidad));
        }

        private void MostrarMesajeRequerido(bool mostrar = true)
        {
            if (mostrar)
            {
                campoRequerido1.Show();
                campoRequerido2.Show();
            }
            else
            {
                campoRequerido1.Hide();
                campoRequerido2.Hide();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposInvalidos())
                {
                    MostrarMesajeRequerido(true);
                    throw new Exception("Campos incorrectos. Vuelva a ingresarlos por favor.");
                }

                bool guardado;

                if (inputProducto.Text == "Celiaco")
                {
                    BECeliaco producto = new BECeliaco()
                    {
                        Nombre = inputNombre.Text,
                        Precio = Convert.ToDecimal(inputPrecio.Text),
                        cantidad = (BEProducto.Cantidad)inputCantidad.SelectedItem,
                        Stock = Convert.ToInt32(inputStock.Value)
                    };

                    guardado = _bllCeliaco.Guardar(producto);

                    if (guardado)
                    {
                        LimpiarCampos();
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = _bllCeliaco.Listar();
                        MostrarMesajeRequerido(false);
                        // Orden columnas del dgv
                        dgvProductos.Columns["Codigo"].DisplayIndex = 0;
                        dgvProductos.Columns["Nombre"].DisplayIndex = 1;
                        dgvProductos.Columns["Precio"].DisplayIndex = 2;
                        dgvProductos.Columns["Stock"].DisplayIndex = 3;
                        dgvProductos.Columns["Cantidad"].DisplayIndex = 4;
                    }
                }
                else if (inputProducto.Text == "Vegano")
                {
                    BEVegano producto = new BEVegano()
                    {
                        Nombre = inputNombre.Text,
                        Precio = Convert.ToDecimal(inputPrecio.Text),
                        cantidad = (BEProducto.Cantidad)inputCantidad.SelectedItem,
                        Stock = Convert.ToInt32(inputStock.Value),
                        Huevo = 0
                    };

                    guardado = _bllVegano.Guardar(producto);

                    if (guardado)
                    {
                        LimpiarCampos();
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = _bllVegano.Listar();
                        MostrarMesajeRequerido(false);
                        // Orden columnas del dgv
                        dgvProductos.Columns["Codigo"].DisplayIndex = 0;
                        dgvProductos.Columns["Nombre"].DisplayIndex = 1;
                        dgvProductos.Columns["Precio"].DisplayIndex = 2;
                        dgvProductos.Columns["Stock"].DisplayIndex = 3;
                        dgvProductos.Columns["Cantidad"].DisplayIndex = 4;
                        dgvProductos.Columns["Huevo"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void LimpiarCampos()
        {
            inputNombre.Text = "";
            inputPrecio.Text = "";
        }

        private BEProducto ObtenerProducto()
        {
            try
            {
                if (CamposInvalidos())
                {
                    MostrarMesajeRequerido(true);
                    throw new Exception("Campos incorrectos. Vuelva a ingresarlos por favor.");
                }

                BEProducto producto = null;

                if (inputProducto.Text == "Celiaco")
                {
                    producto = new BECeliaco()
                    {
                        Nombre = inputNombre.Text,
                        Precio = Convert.ToDecimal(inputPrecio.Text),
                        cantidad = (BEProducto.Cantidad)inputCantidad.SelectedItem,
                        Stock  = Convert.ToInt32(inputStock.Value)
                    };
                }
                else if (inputProducto.Text == "Vegano")
                {
                    producto = new BEVegano()
                    {
                        Nombre = inputNombre.Text,
                        Precio = Convert.ToDecimal(inputPrecio.Text),
                        cantidad = (BEProducto.Cantidad)inputCantidad.SelectedItem,
                        Stock = Convert.ToInt32(inputStock.Value)
                    };
                }

                return producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(inputNombre.Text.Trim())
                || String.IsNullOrEmpty(inputPrecio.Text.Trim())
                || inputProducto.SelectedIndex == -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposInvalidos())
                {
                    MostrarMesajeRequerido(true);
                    throw new Exception("Campos incorrectos.Vuelva a ingresarlos por favor.");
                }

                BEProducto p = (BEProducto)dgvProductos.CurrentRow.DataBoundItem;
                p.Nombre = inputNombre.Text;
                p.Precio = Convert.ToDecimal(inputPrecio.Text);

                //bool guardado = _bllProducto.Guardar(p);

                //if (guardado)
                //{
                //    dgvProductos.DataSource = null;
                //    //dgvProductos.DataSource = _bllProducto.Listar();
                //    LimpiarCampos();
                //    MostrarMesajeRequerido(false);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                BEProducto p = (BEProducto)dgvProductos.CurrentRow.DataBoundItem;
                inputNombre.Text = p.Nombre;
                inputPrecio.Text = p.Precio.ToString();
            } else
            {
                inputNombre.Text = "";
                inputPrecio.Text = "";
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BEProducto p = (BEProducto)dgvProductos.CurrentRow.DataBoundItem;

                DialogResult res = MessageBox.Show($"Esta seguro que desea eliminar el producto {p.Nombre}?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    //bool eliminado = _bllProducto.Baja(p);

                    //if (eliminado)
                    //{
                    //    dgvProductos.DataSource = null;
                    //    //dgvProductos.DataSource = _bllProducto.Listar();
                    //    LimpiarCampos();
                    //    MostrarMesajeRequerido(false);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioBtnCeliacos_CheckedChanged(object sender, EventArgs e)
        {
            // Se listan todos los productos
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _bllCeliaco.Listar();
            // Orden columnas del dgv
            dgvProductos.Columns["Codigo"].DisplayIndex = 0;
            dgvProductos.Columns["Nombre"].DisplayIndex = 1;
            dgvProductos.Columns["Precio"].DisplayIndex = 2;
            dgvProductos.Columns["Stock"].DisplayIndex = 3;
            dgvProductos.Columns["Cantidad"].DisplayIndex = 4;
        }

        private void radioBtnVeganos_CheckedChanged(object sender, EventArgs e)
        {
            // Solo los que no contienen huevo
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _bllVegano.Listar();
            // Orden columnas del dgv
            dgvProductos.Columns["Codigo"].DisplayIndex = 0;
            dgvProductos.Columns["Nombre"].DisplayIndex = 1;
            dgvProductos.Columns["Precio"].DisplayIndex = 2;
            dgvProductos.Columns["Stock"].DisplayIndex = 3;
            dgvProductos.Columns["Cantidad"].DisplayIndex = 4;
            dgvProductos.Columns["Huevo"].Visible = false;
        }
    }
}
