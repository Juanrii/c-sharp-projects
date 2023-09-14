using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPVenta
    {
        private Acceso _acceso;

        public MPPVenta()
        {
            _acceso = new Acceso();
        }

        public bool Guardar(BEVenta venta)
        {
            try
            {
                string query = $"INSERT INTO Venta (Cliente, Monto, Fecha) VALUES ({venta.Cliente.Codigo}, {venta.Monto}, '{venta.Fecha}')";
                bool ventaCreada = _acceso.ExecuteNonQuery(query);

                if (ventaCreada)
                {
                    int ventaCodigo = ObtenerUltimoIngresado();

                    foreach (BEProducto producto in venta.ListaProductos)
                        GuardarDetalleVenta(ventaCodigo, producto);
                }
                return ventaCreada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool GuardarDetalleVenta(int ventaCodigo, BEProducto producto)
        {
            try
            {
                string query = $"INSERT INTO DetalleVenta (Venta, Producto, CantProducto, PrecioUnitario, Subtotal) " +
                    $"VALUES ({ventaCodigo}, {producto.Codigo}, {producto.ObtenerCantidad()}, {producto.Precio}, {producto.ObtenerPrecioXCantidad()})";
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObtenerUltimoIngresado()
        {
            try
            {
                string query = "SELECT ISNULL(MAX(Codigo), 0) FROM Venta";
                return _acceso.ObtenerScalar(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
