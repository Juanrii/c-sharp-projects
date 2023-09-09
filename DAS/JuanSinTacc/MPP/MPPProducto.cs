using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;


namespace MPP
{
    public class MPPProducto
    {
        #region Propiedades
        private Acceso _acceso;
        #endregion

        #region Constructor
        public MPPProducto()
        {
            _acceso = new Acceso();
        }
        #endregion

        public List<BEProducto> Listar()
        {
            try
            {
                List<BEProducto> lista = new List<BEProducto>();

                string query = $"SELECT p.Codigo, p.Nombre, p.Precio, t.Codigo as TipoCodigo, t.Nombre as Tipo from Producto p " +
                    $"INNER JOIN Tipo t ON t.Codigo = p.Tipo";

                DataSet ds = _acceso.Leer(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        BEProducto producto = new BEProducto();
                        producto.Codigo = Convert.ToInt32(fila["Codigo"]);
                        producto.Nombre = fila["Nombre"].ToString();
                        producto.Precio = Convert.ToDecimal(fila["Precio"]);
                        producto.Tipo = new BETipo()
                        {
                            Codigo = Convert.ToInt32(fila["TipoCodigo"]),
                            Nombre = fila["Tipo"].ToString()
                        };
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
            return $"UPDATE Producto SET Nombre = '{objBE.Nombre}', Precio = {objBE.Precio}, Tipo = {objBE.Tipo.Codigo} " +
                $"WHERE Codigo = {objBE.Codigo}";
        }

        private string NuevoRegistro(BEProducto objBE)
        {
            return $"INSERT INTO Producto (Nombre, Precio, Tipo) VALUES('{objBE.Nombre}', {objBE.Precio}, {objBE.Tipo.Codigo})";
        }
    }
}
