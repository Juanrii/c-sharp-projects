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
    public partial class FormVenta : Form
    {
        private BLLVenta _bllVenta;
        private BLLCliente _bllCliente;
        private BLLCeliaco _bllCeliaco;
        private List<BEProducto> _listaProd;
        private decimal _total = 0;

        private BEVenta _venta;

        public FormVenta()
        {
            InitializeComponent();
            _bllVenta = new BLLVenta();
            _bllCliente = new BLLCliente();
            _bllCeliaco = new BLLCeliaco();
            _listaProd = new List<BEProducto>();
            _venta = new BEVenta();

            inputCliente.Items.Clear();
            inputCliente.DisplayMember = "Nombre";
            inputCliente.ValueMember = "Codigo";
            foreach (BECliente c in _bllCliente.Listar())
                inputCliente.Items.Add(c);

            ObtenerProductos();


            dgvVentaProducto.Columns.Add("Producto", "Producto");
            dgvVentaProducto.Columns.Add("Cantidad", "Cantidad");
            dgvVentaProducto.Columns.Add("Precio", "Precio");
            dgvVentaProducto.Columns.Add("Total", "Total");

        }

        private void ObtenerProductos()
        {
            inputProducto.Items.Clear();
            inputProducto.DisplayMember = "Nombre";
            inputProducto.ValueMember = "Codigo";
            foreach (BECeliaco p in _bllCeliaco.Listar())
                inputProducto.Items.Add(p);
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Desea confirmar la venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    _venta.Monto = _total;
                    bool guardado = _bllVenta.Guardar(_venta);

                    if (guardado)
                    {
                        inputCliente.Enabled = true;
                        inputTotal.Text = "";
                        inputPrecio.Text = "";
                        inputStock.Text = "";
                        _total = 0;
                        dgvVentaProducto.Rows.Clear();
                        ObtenerProductos();
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                BEProducto producto = (BEProducto)inputProducto.SelectedItem;
                producto.SetCantidad(Convert.ToInt32(inputCantidad.Value));

                BECliente cliente = (BECliente)inputCliente.SelectedItem;
                
                _venta.ListaProductos.Add(producto);
                _venta.Cliente = cliente;

                inputCliente.Enabled = false;

                dgvVentaProducto.Rows.Add(producto.Nombre, producto.ObtenerCantidad(), producto.Precio, producto.ObtenerPrecioXCantidad());

                _total += producto.ObtenerPrecioXCantidad();

                inputTotal.Text = _total.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void inputProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BEProducto p = (BEProducto)inputProducto.SelectedItem;
                inputPrecio.Text = Convert.ToString(p.Precio);
                inputStock.Text = Convert.ToString(p.Stock);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void inputCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (inputStock.Text != "")
            {
                int stock = Convert.ToInt32(inputStock.Text);
                if ((int)inputCantidad.Value > stock)
                {
                    MessageBox.Show("No hay stock suficiente.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputCantidad.Value = stock;
                }
            }
        }
    }
}
