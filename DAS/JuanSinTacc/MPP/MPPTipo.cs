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
    public class MPPTipo
    {
        #region Propiedades
        private Acceso _acceso;
        #endregion

        #region Constructor
        public MPPTipo()
        {
            _acceso = new Acceso();
        }
        #endregion

        public List<BETipo> Listar()
        {
            try
            {
                List<BETipo> lista = new List<BETipo>();

                string query = "SELECT Codigo, Nombre FROM Tipo";

                DataSet ds = _acceso.Leer(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        BETipo tipo = new BETipo();
                        tipo.Codigo = Convert.ToInt32(fila["Codigo"]);
                        tipo.Nombre = fila["Nombre"].ToString();
                        lista.Add(tipo);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Guardar(BETipo objBE)
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

        private string EditarRegistro(BETipo objBE)
        {
            return $"UPDATE Tipo SET Nombre = '{objBE.Nombre}' WHERE Codigo = {objBE.Codigo}";
        }

        private string NuevoRegistro(BETipo objBE)
        {
            return $"INSERT INTO Tipo (Nombre) VALUES('{objBE.Nombre}')";

        }
    }
}
