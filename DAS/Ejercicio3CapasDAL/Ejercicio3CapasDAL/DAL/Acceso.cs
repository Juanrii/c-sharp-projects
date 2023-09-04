using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class Acceso
    {
        SqlConnection _connection = new SqlConnection("Data Source=.;Initial Catalog=Ejercicio3;Integrated Security=True");
    
    
        public void Abrir()
        {
            _connection = new SqlConnection();
            _connection.Open();
        }

        public void Cerrar()
        {
            _connection.Close();
            _connection.Dispose();
            _connection = null;
            GC.Collect();
        }

        public DataSet Leer(string query)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(dataSet);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
            return dataSet;
        }


    
    
    }
}
