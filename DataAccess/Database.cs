using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class Database
    {
        private readonly SqlConnection _connection; // Los atributos que son de solo lectura solo pueden ser inicializados o asignados desde un constructor para evitar ser sobreescritos en un método.
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string _connectionString;

        public SqlDataReader Reader
        {
            get { return _reader; }
        }

        public Database()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["docker"].ToString();
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = query;
        }

        public void SetProcedure(string sp)
        {
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.CommandText = sp;
        }

        public void SetParameter(string key, object value)
        {
            if (value != null)
            {
                _command.Parameters.AddWithValue(key, value);
            }
        }

        public void ExecuteRead()
        {
            _command.Connection = _connection;

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open) // Necesario para mantener la conección abierta para usar TransactionScoope 
                {
                    _connection.Open();
                }
                _reader = _command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Parameters.Clear();
            }
        }

        public Int32 ExecuteScalar()
        {
            Int32 result;
            _command.Connection = _connection;

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open) // Necesario para mantener la conección abierta para usar TransactionScoope 
                {
                    _connection.Open();
                }
                result = (Int32)_command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Parameters.Clear();
            }
            return result;
        }

        public void ExecuteAction()
        {
            _command.Connection = _connection;

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open) // Necesario para mantener la conección abierta para usar TransactionScoope 
                {
                    _connection.Open();
                }
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Parameters.Clear();
            }
        }

        public void CloseConnection()
        {
            _reader?.Close(); // El operador ? comprueba que el atributo _reader no sea NULL, y de ser así ejecuta el método Close().
            _connection.Close();
        }
    }
}
