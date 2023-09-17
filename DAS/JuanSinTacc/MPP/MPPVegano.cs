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
    public class MPPVegano
    {
        #region Propiedades
        private Acceso _acceso;
        #endregion

        #region Constructor
        public MPPVegano()
        {
            _acceso = new Acceso();
        }
        #endregion

        public List<BEVegano> Listar()
        {
            try
            {
                List<BEVegano> lista = new List<BEVegano>();

                string query = $"SELECT p.Codigo, p.Nombre, p.Precio, p.Stock, p.Cantidad FROM Producto p WHERE Huevo = 0";

                DataSet ds = _acceso.Leer(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        BEVegano producto = new BEVegano();
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

        public bool Baja(BEProducto objBE)
        {
            try
            {
                string query = $"DELETE FROM Producto WHERE Codigo = {objBE.Codigo}";
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Guardar(BEVegano producto)
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

        private string EditarRegistro(BEVegano producto)
        {
            return $"UPDATE Producto SET Nombre = '{producto.Nombre}', Precio = {producto.Precio}" +
                $"WHERE Codigo = {producto.Codigo}";
        }

        private string NuevoRegistro(BEVegano producto)
        {
            return $"INSERT INTO Producto (Nombre, Precio, Stock, Cantidad, Huevo) " +
                $"VALUES('{producto.Nombre}', {producto.Precio}, {producto.Stock}, {Convert.ToInt32(producto.cantidad)}, {producto.Huevo})";
        }
    }
}
