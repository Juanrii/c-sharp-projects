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
    public partial class FormInformes : Form
    {
        private BLLVenta _bllVenta;

        public FormInformes()
        {
            InitializeComponent();
            _bllVenta = new BLLVenta();
            dgvDetalleVenta.DataSource = null;
            //dgvDetalleVenta.DataSource = _bllVenta.Listar();

            inputClientes.DataSource = null;
            inputClientes.DataSource = new BLLCliente().Listar();

            AplicarConfigColumnas();

            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Subtotal", "Subtotal");


            dgvMasVendidos.Columns.Add("Producto", "Producto");
            dgvMasVendidos.Columns.Add("Vendidos", "Vendidos");

            // seccion stock
            radioBtnCeliacos.Checked = true;
            inputCantidad.Items.Clear();
            inputCantidad.DataSource = Enum.GetValues(typeof(BEProducto.Cantidad));
            dgvStock.Columns.Add("Codigo", "Codigo");
            dgvStock.Columns.Add("Nombre", "Nombre");
            dgvStock.Columns.Add("Stock", "Stock");
            dgvStock.Columns.Add("Cantidad", "Cantidad");

            // seccion ventas label
            labelRealizadas.Text = "Realizadas: " + _bllVenta.ObtenerVentasRealizadas().ToString();
            labelTotalVendido.Text = "Total Vendido: $" + _bllVenta.ObtenerVentaTotal().ToString();
        }

        private void AplicarConfigColumnas()
        {
            dgvDetalleVenta.Columns["Cliente"].Visible = false;
            dgvDetalleVenta.Columns["Codigo"].DisplayIndex = 0;
            dgvDetalleVenta.Columns["Fecha"].DisplayIndex = 1;
            dgvDetalleVenta.Columns["Monto"].DisplayIndex = 2;
        }

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetalleVenta.Rows.Count <= 0)
                    throw new Exception("No existen ventas para el cliente seleccionado.");

                BEVenta venta = (BEVenta)dgvDetalleVenta.CurrentRow.DataBoundItem;
                AplicarConfigDgvProductos(venta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void AplicarConfigDgvProductos(BEVenta venta)
        {
            dgvProductos.Rows.Clear();
            foreach (BEProducto p in venta.ListaProductos)
            {
                dgvProductos.Rows.Add(p.Nombre, p.CantidadUni, p.Precio, p.ObtenerPrecioXCantidad());
            }
            labelTotal.Text = "Total: $" + venta.Monto.ToString();
        }

        

        private void inputClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            labelTotal.Text = "Total: $";

            BECliente clienteSeleccionado = (BECliente)inputClientes.SelectedItem;
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = _bllVenta.ListarPorCliente(clienteSeleccionado);
            AplicarConfigColumnas();
        }

        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            dgvMasVendidos.Rows.Clear();
            foreach (BEProducto p in _bllVenta.ListarMasVendidos())
            {
                dgvMasVendidos.Rows.Add(p.Nombre, p.CantidadUni);
            }
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStock.Rows.Clear();

                int stock = Convert.ToInt32(inputStock.Text);

                if (radioBtnCeliacos.Checked)
                {
                    BECeliaco producto = new BECeliaco();
                    producto.Stock = stock;
                    producto.cantidad = (BEProducto.Cantidad)inputCantidad.SelectedItem;
                    BLLCeliaco bllCeliaco = new BLLCeliaco();
                    foreach (BEProducto p in bllCeliaco.ObtenerStocks(producto))
                    {
                        dgvStock.Rows.Add(p.Codigo, p.Nombre, p.Stock, p.cantidad);
                    }
                }
                else
                {
                    BEVegano producto = new BEVegano();
                    producto.Stock = stock;
                    producto.cantidad = (BEProducto.Cantidad)inputCantidad.SelectedItem;
                    BLLVegano bllVegano = new BLLVegano();
                    foreach (BEProducto p in bllVegano.ObtenerStocks(producto))
                    {
                        dgvStock.Rows.Add(p.Codigo, p.Nombre, p.Stock, p.cantidad);
                    }
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
