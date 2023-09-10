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
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GuardarDetalleVenta(BEVenta venta, BEProducto producto)
        {
            try
            {
                venta.Codigo = ObtenerUltimoIngresado();

                string query = $"INSERT INTO DetalleVenta (Venta, Producto, CantProducto, PrecioUnitario, Subtotal) " +
                    $"VALUES ({venta.Codigo}, {producto.Codigo}, {producto.ObtenerCantidad()}, {producto.Precio}, {producto.ObtenerPrecioXCantidad()})";
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
