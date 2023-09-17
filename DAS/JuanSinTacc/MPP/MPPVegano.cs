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

        public List<BEProducto> Listar()
        {
            try
            {
                List<BEProducto> lista = new List<BEProducto>();

                string query = $"SELECT p.Codigo, p.Nombre, p.Precio FROM Producto p";

                DataSet ds = _acceso.Leer(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        BEVegano producto = new BEVegano();
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

        public bool Guardar(BEProducto objBE)
        {
            try
            {
                string query = objBE.Codigo == 0 ? NuevoRegistro(objBE) : EditarRegistro(objBE);
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string EditarRegistro(BEProducto objBE)
        {
            return $"UPDATE Producto SET Nombre = '{objBE.Nombre}', Precio = {objBE.Precio}" +
                $"WHERE Codigo = {objBE.Codigo}";
        }

        private string NuevoRegistro(BEProducto objBE)
        {
            return $"INSERT INTO Producto (Nombre, Precio) VALUES('{objBE.Nombre}', {objBE.Precio})";
        }
    }
}
