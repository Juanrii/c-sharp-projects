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
        private SqlConnection _connection = new SqlConnection(@"Data Source=JUANIGNACIO634E\SQLEXPRESS;Initial Catalog=JuanSinTacc;Integrated Security=True");

        private SqlCommand _command;

        private SqlTransaction _tx;

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

                _tx = _connection.BeginTransaction();
            
                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;
                _command.Transaction = _tx;

                int filasAfectadas = _command.ExecuteNonQuery();

                _tx.Commit();

                return true;
            }
            catch (SqlException ex)
            {
                _tx.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                _tx.Rollback();
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
        }

        public int ObtenerScalar(string query)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                int res = Convert.ToInt32(_command.ExecuteScalar());
                _connection.Close();

                return res;
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
        }
    }
}
