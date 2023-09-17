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
        private BLLProducto _bllProducto;
        private List<BEProducto> _listaProd;
        private decimal _total = 0;

        private BEVenta _venta;

        public FormVenta()
        {
            InitializeComponent();
            _bllVenta = new BLLVenta();
            _bllCliente = new BLLCliente();
            //_bllProducto = new BLLProducto();
            _listaProd = new List<BEProducto>();
            _venta = new BEVenta();

            inputCliente.Items.Clear();
            inputCliente.DisplayMember = "Nombre";
            inputCliente.ValueMember = "Codigo";
            foreach (BECliente c in _bllCliente.Listar())
                inputCliente.Items.Add(c);

            inputProducto.Items.Clear();
            inputProducto.DisplayMember = "Nombre";
            inputProducto.ValueMember = "Codigo";
            //foreach (BEProducto p in _bllProducto.Listar())
            //    inputProducto.Items.Add(p);


            dgvVentaProducto.Columns.Add("Producto", "Producto");
            dgvVentaProducto.Columns.Add("Cantidad", "Cantidad");
            dgvVentaProducto.Columns.Add("Precio", "Precio");
            dgvVentaProducto.Columns.Add("Total", "Total");

        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                _bllVenta.Guardar(_venta);

                inputCliente.Enabled = true;
                inputTotal.Text = "";
                _total = 0;
                dgvVentaProducto.Rows.Clear();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
