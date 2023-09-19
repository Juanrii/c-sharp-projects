using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BE;


namespace MPP
{
    public class MPPCeliaco
    {
        #region Propiedades
        private Acceso _acceso;
        #endregion

        #region Constructor
        public MPPCeliaco()
        {
            _acceso = new Acceso();
        }
        #endregion

        public List<BECeliaco> Listar()
        {
            try
            {
                List<BECeliaco> lista = new List<BECeliaco>();

                string query = $"SELECT p.Codigo, p.Nombre, p.Precio, p.Stock, p.Cantidad FROM Producto p";

                DataTable table = _acceso.Leer(query);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BECeliaco producto = new BECeliaco();
                        producto.Codigo = Convert.ToInt32(fila["Codigo"]);
                        producto.Nombre = fila["Nombre"].ToString();
                        producto.Precio = Convert.ToDecimal(fila["Precio"]);
                        producto.Stock = Convert.ToInt32(fila["Stock"]);
                        producto.cantidad = (BEProducto.Cantidad)fila["Cantidad"];
                        lista.Add(producto);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<BEProducto> ListarTodo()
        {
            try
            {
                List<BEProducto> lista = new List<BEProducto>();

                string query = $"SELECT p.Codigo, p.Nombre, p.Precio, p.Stock, p.Cantidad, p.Huevo AS EsCeliaco FROM Producto p";

                DataTable table = _acceso.Leer(query);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        if (Convert.ToInt32(fila["EsCeliaco"]) == 1)
                        {
                            BECeliaco producto = new BECeliaco();
                            producto.Codigo = Convert.ToInt32(fila["Codigo"]);
                            producto.Nombre = fila["Nombre"].ToString();
                            producto.Precio = Convert.ToDecimal(fila["Precio"]);
                            producto.Stock = Convert.ToInt32(fila["Stock"]);
                            producto.cantidad = (BEProducto.Cantidad)fila["Cantidad"];
                            lista.Add(producto);
                        }
                        else
                        {
                            BEVegano producto = new BEVegano();
                            producto.Codigo = Convert.ToInt32(fila["Codigo"]);
                            producto.Nombre = fila["Nombre"].ToString();
                            producto.Precio = Convert.ToDecimal(fila["Precio"]);
                            producto.Stock = Convert.ToInt32(fila["Stock"]);
                            producto.cantidad = (BEProducto.Cantidad)fila["Cantidad"];
                            producto.Huevo = 0;
                            lista.Add(producto);
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

        public List<BECeliaco> ObtenerStocks(BECeliaco producto)
        {
            try
            {
                List<BECeliaco> lista = new List<BECeliaco>();

                string query = $"SELECT p.Codigo, p.Nombre, p.Stock, p.Cantidad FROM Producto p WHERE Stock <= {producto.Stock} AND p.Huevo = 1 AND p.Cantidad = {Convert.ToInt32(producto.cantidad)}";

                DataTable table = _acceso.Leer(query);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BECeliaco p = new BECeliaco();
                        p.Codigo = Convert.ToInt32(fila["Codigo"]);
                        p.Nombre = fila["Nombre"].ToString();
                        p.Stock = Convert.ToInt32(fila["Stock"]);
                        p.cantidad = (BEProducto.Cantidad)fila["Cantidad"];
                        lista.Add(p);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Baja(BEProducto producto)
        {
            try
            {
                string query = $"DELETE FROM Producto WHERE Codigo = {producto.Codigo}";
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Guardar(BECeliaco producto)
        {
            try
            {
                string query = producto.Codigo == 0 ? NuevoRegistro(producto) : EditarRegistro(producto);
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string EditarRegistro(BECeliaco producto)
        {
            return $"UPDATE Producto SET Nombre = '{producto.Nombre}', Precio = {producto.Precio}, Stock = {producto.Stock}, Cantidad = {Convert.ToInt32(producto.cantidad)}" +
                $"WHERE Codigo = {producto.Codigo}";
        }

        private string NuevoRegistro(BECeliaco producto)
        {
            return $"INSERT INTO Producto (Nombre, Precio, Stock, Cantidad) VALUES('{producto.Nombre}', {producto.Precio}, {producto.Stock}, {Convert.ToInt32(producto.cantidad)})";
        }
    }
}
