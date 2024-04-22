using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Database
    {
        // ATTRIBUTES

        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string _connectionString;

        // PROPERTIES

        public SqlDataReader Reader { get { return _reader; } }

        // CONSTRUCT

        public Database()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["mac"].ToString();
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
        }

        // METHODS

        public void setQuery(string query)
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = query;
        }

        public void setParameter(string key, object value)
        {
            _command.Parameters.AddWithValue(key, value);
        }

        public void executeReader()
        {
            _command.Connection = _connection;

            try
            {
                _connection.Open();
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

        public void executeAction()
        {
            _command.Connection = _connection;

            try
            {
                _connection.Open();
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

        public void closeConnection()
        {
            if (_reader != null)
            {
                _reader.Close();
            }

            _connection.Close();
        }
    }
}
