using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;

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
                    {
                        GuardarDetalleVenta(ventaCodigo, producto);
                        ActualizarStock(producto);
                    }
                }


                return ventaCreada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObtenerVentasRealizadas()
        {
            try
            {
                string query = $"SELECT COUNT(*) AS Ventas FROM Venta";
                return _acceso.ObtenerScalar(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal ObtenerVentaTotal()
        {
            try
            {
                decimal ventaTotal = 0;
                string query = $"SELECT SUM(Monto) AS VentaTotal FROM Venta";
                DataTable table = _acceso.Leer(query);
                if (table.Rows.Count == 1)
                {
                    ventaTotal = Convert.ToDecimal(table.Rows[0]["VentaTotal"]);
                }
                return ventaTotal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BEProducto> ListarMasVendidos()
        {
            try
            {
                List<BEProducto> lista = new List<BEProducto>();

                string query = $"SELECT P.Nombre AS NombreProducto, SUM(DV.CantProducto) AS TotalVendido, P.Huevo AS EsCeliaco FROM DetalleVenta AS DV " +
                    $"INNER JOIN Producto AS P ON DV.Producto = P.Codigo " +
                    $"GROUP BY P.Nombre, P.Huevo " +
                    $"ORDER BY TotalVendido DESC";

                DataTable table = _acceso.Leer(query);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        if (Convert.ToInt32(fila["EsCeliaco"]) == 1)
                        {
                            BECeliaco p = new BECeliaco();
                            p.Nombre = fila["NombreProducto"].ToString();
                            p.CantidadUni = (Convert.ToInt32(fila["TotalVendido"]));
                            lista.Add(p);

                        }
                        else
                        {
                            BEVegano p = new BEVegano();
                            p.Nombre = fila["NombreProducto"].ToString();
                            p.CantidadUni = (Convert.ToInt32(fila["TotalVendido"]));
                            p.Huevo = 0;
                            lista.Add(p);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BEVenta> ListarPorCliente(BECliente cliente)
        {
            try
            {
                List<BEVenta> lista = new List<BEVenta>();

                string query = $"SELECT Codigo, Monto, Fecha FROM Venta WHERE Cliente = {cliente.Codigo}";
                DataTable table = _acceso.Leer(query);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEVenta venta = new BEVenta();
                        venta.Codigo = Convert.ToInt32(fila["Codigo"]);
                        venta.Monto = Convert.ToDecimal(fila["Monto"]);
                        venta.Fecha = Convert.ToDateTime(fila["Fecha"]);

                        List<BEProducto> productos = new List<BEProducto>();
                        query = $"SELECT p.Codigo, p.Nombre, p.Huevo, p.Precio, dv.CantProducto FROM DetalleVenta dv INNER JOIN Producto p ON p.Codigo = dv.Producto WHERE dv.Venta = {venta.Codigo}";
                        DataTable tableProducto = _acceso.Leer(query);

                        if (tableProducto.Rows.Count > 0)
                        {
                            foreach (DataRow f in tableProducto.Rows)
                            {
                                if (Convert.ToInt32(f["Huevo"]) == 1)
                                {
                                    BECeliaco p = new BECeliaco();
                                    p.Codigo = Convert.ToInt32(f["Codigo"]);
                                    p.Nombre = Convert.ToString(f["Nombre"]);
                                    p.Precio = Convert.ToDecimal(f["Precio"]);
                                    p.CantidadUni = (Convert.ToInt32(f["CantProducto"]));
                                    productos.Add(p);
                                }
                                else
                                {
                                    BEVegano p = new BEVegano();
                                    p.Codigo = Convert.ToInt32(f["Codigo"]);
                                    p.Nombre = Convert.ToString(f["Nombre"]);
                                    p.Precio = Convert.ToDecimal(f["Precio"]);
                                    p.CantidadUni = (Convert.ToInt32(f["CantProducto"]));
                                    p.Huevo = 0;
                                    productos.Add(p);
                                }
                            }

                        }
                        venta.ListaProductos = productos;
                        lista.Add(venta);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BEVenta> Listar()
        {
            try
            {
                List<BEVenta> lista = new List<BEVenta>();

                string query = $"SELECT v.Codigo, v.Cliente, v.Monto, c.Nombre as NombreCliente, c.Apellido as ApellidoCliente FROM Venta v INNER JOIN Cliente c ON c.Codigo = v.Cliente";
                DataTable table = _acceso.Leer(query);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEVenta venta = new BEVenta();
                        venta.Codigo = Convert.ToInt32(fila["Codigo"]);
                        BECliente cliente = new BECliente();
                        cliente.Nombre = Convert.ToString(fila["NombreCliente"]);
                        cliente.Apellido = Convert.ToString(fila["ApellidoCliente"]);
                        venta.Cliente = cliente;

                        // Productos
                        List<BEProducto> productos = new List<BEProducto>();
                        string queryProductos = $"SELECT dv.Producto, p.Codigo, p.Nombre, p.Huevo, dv.CantProducto, dv.Subtotal FROM DetalleVenta dv INNER JOIN Producto p ON p.Codigo = dv.Producto WHERE dv.Venta = {venta.Codigo}";
                        DataTable tableProductos = _acceso.Leer(queryProductos);

                        decimal monto = 0; 

                        if (tableProductos.Rows.Count > 0)
                        {
                            foreach (DataRow f in tableProductos.Rows)
                            {
                                if (Convert.ToInt32(f["Huevo"]) == 1)
                                {
                                    BECeliaco p = new BECeliaco();
                                    p.Codigo = Convert.ToInt32(f["Codigo"]);
                                    p.Nombre = Convert.ToString(f["Nombre"]);
                                    monto += Convert.ToDecimal(f["Subtotal"]);
                                    productos.Add(p);
                                }
                                else
                                {
                                    BEVegano p = new BEVegano();
                                    p.Codigo = Convert.ToInt32(f["Codigo"]);
                                    p.Nombre = Convert.ToString(f["Nombre"]);
                                    p.Huevo = 0;
                                    monto += Convert.ToDecimal(f["Subtotal"]);
                                    productos.Add(p);
                                }
                            }
                        }
                        venta.Monto = monto;
                        venta.ListaProductos = productos;
                        lista.Add(venta);
                    }
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ActualizarStock(BEProducto producto)
        {
            try
            {
                string query = $"UPDATE Producto SET Stock = Stock - {producto.CantidadUni} WHERE Codigo = {producto.Codigo}";
                _acceso.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GuardarDetalleVenta(int ventaCodigo, BEProducto producto)
        {
            try
            {
                string query = $"INSERT INTO DetalleVenta (Venta, Producto, CantProducto, PrecioUnitario, Subtotal) " +
                    $"VALUES ({ventaCodigo}, {producto.Codigo}, {producto.CantidadUni}, {producto.Precio}, {producto.ObtenerPrecioXCantidad()})";
                _acceso.ExecuteNonQuery(query);
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
