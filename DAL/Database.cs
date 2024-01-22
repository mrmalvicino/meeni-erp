using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;

namespace DAL
{
    public class Database
    {
        // ATTRIBUTES

        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        // PROPERTIES

        public SqlDataReader Reader { get { return _reader; } }

        // CONSTRUCT

        public Database()
        {
            _connection = new SqlConnection("server=BANGHO\\SQLEXPRESS; database=meeni_erp_db; integrated security=true");
            _command = new SqlCommand();
            //_connection.ConnectionString = "server=BANGHO\\SQLEXPRESS; database=meeni_erp_db; integrated security=true";
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
        }

        public void closeConnection()
        {
            if (_reader != null) _reader.Close();
            _connection.Close();
        }
    }
}
