using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection _connection = new SqlConnection("...");

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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
            return dataSet;
        }

        public bool ExecuteNonQuery(string query)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = _connection;
                command.CommandText = query;

                int res = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
        }

    }
}
