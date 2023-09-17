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

                string query = $"SELECT p.Codigo, p.Nombre, p.Precio FROM Producto p";

                DataSet ds = _acceso.Leer(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        BECeliaco producto = new BECeliaco();
                        producto.Codigo = Convert.ToInt32(fila["Codigo"]);
                        producto.Nombre = fila["Nombre"].ToString();
                        producto.Precio = Convert.ToDecimal(fila["Precio"]);
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

        private string EditarRegistro(BEProducto producto)
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
