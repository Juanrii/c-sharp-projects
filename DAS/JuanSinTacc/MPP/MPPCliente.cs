using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace MPP
{
    public class MPPCliente
    {
        #region Propiedades
        private Acceso _acceso;
        #endregion

        #region Constructor
        public MPPCliente()
        {
            _acceso = new Acceso();
        }
        #endregion

        public List<BECliente> Listar()
        {
            try
            {
                List<BECliente> lista = new List<BECliente>();

                string query = "SELECT Codigo, Nombre, Apellido, Telefono, Direccion FROM Cliente";

                DataSet ds = _acceso.Leer(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        BECliente cliente = LlenarCliente(fila);
                        lista.Add(cliente);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Baja(BECliente objBE)
        {
            try
            {
                string query = $"DELETE FROM Cliente WHERE Codigo = {objBE.Codigo}";
                return _acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Guardar(BECliente objBE)
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

        private string NuevoRegistro(BECliente cliente)
        {
            return $"INSERT INTO Cliente (Nombre, Apellido, Telefono, Direccion) VALUES ('{cliente.Nombre}', '{cliente.Apellido}', '{cliente.Telefono}', '{cliente.Direccion}')";
        }

        private string EditarRegistro(BECliente cliente)
        {
            return  $"UPDATE Cliente SET Nombre = '{cliente.Nombre}', Apellido = '{cliente.Apellido}', Telefono = '{cliente.Telefono}', Direccion = '{cliente.Direccion}' " +
                    $"WHERE Codigo = {cliente.Codigo}";
        }
        private BECliente LlenarCliente(DataRow fila)
        {
            BECliente cliente   = new BECliente();
            cliente.Codigo      = Convert.ToInt32(fila["Codigo"]);
            cliente.Nombre      = fila["Nombre"].ToString();
            cliente.Apellido    = fila["Apellido"].ToString();
            cliente.Telefono    = fila["Telefono"].ToString();
            cliente.Direccion   = fila["Direccion"].ToString();
            return cliente;
        }
    }
}
