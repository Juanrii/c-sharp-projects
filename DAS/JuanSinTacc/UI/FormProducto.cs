using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

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

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _bllCeliaco.Listar();

            MostrarMesajeRequerido(false);
            LlenarDropDown();
        }

        private void LlenarDropDown()
        {
            inputProducto.Items.Clear();
            inputProducto.DisplayMember = "Nombre";
            inputProducto.ValueMember   = "Codigo";
            inputProducto.Items.Add("Celiaco");
            inputProducto.Items.Add("Vegano");
        }

        private void MostrarMesajeRequerido(bool mostrar = true)
        {
            if (mostrar)
            {
                campoRequerido1.Show();
                campoRequerido2.Show();
                campoRequerido3.Show();
            }
            else
            {
                campoRequerido1.Hide();
                campoRequerido2.Hide();
                campoRequerido3.Hide();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEProducto producto = ObtenerProducto();

                if (producto is null) return;

                bool guardado = producto is BECeliaco ? _bllCeliaco.Guardar(producto) : _bllVegano.Guardar(producto);

                if (guardado)
                {
                    LimpiarCampos();
                    //dgvProductos.DataSource = null;
                    //dgvProductos.DataSource = _bllProducto.Listar();
                    MostrarMesajeRequerido(false);
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
            inputProducto.SelectedIndex = -1;
        }

        private BEProducto ObtenerProducto()
        {
            try
            {
                if (CamposInvalidos())
                {
                    MostrarMesajeRequerido(true);
                    throw new Exception("Campos incorrectos.Vuelva a ingresarlos por favor.");
                }

                BEProducto producto = null;

                if (inputProducto.Text == "Celiaco")
                {
                    producto = new BECeliaco()
                    {
                        Nombre = inputNombre.Text,
                        Precio = Convert.ToDecimal(inputPrecio.Text)
                    };
                }
                else if (inputProducto.Text == "Vegano")
                {
                    producto = new BEVegano()
                    {
                        Nombre = inputNombre.Text,
                        Precio = Convert.ToDecimal(inputPrecio.Text)
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
            BEProducto p = (BEProducto)dgvProductos.CurrentRow.DataBoundItem;
            inputNombre.Text = p.Nombre;
            inputPrecio.Text = p.Precio.ToString();
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
    }
}
