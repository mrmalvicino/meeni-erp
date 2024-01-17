using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace BLL
{
    public class CustomersManager
    {
        public List<Customer> list()
        {
            List<Customer> list = new List<Customer>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try
            {
                connection.ConnectionString = "server=BANGHO\\SQLEXPRESS; database=meeni_erp_db; integrated security=true";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Id, RegName FROM customers";
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = (int)reader["Id"];
                    customer.Name = (string)reader["RegName"];
                    list.Add(customer);
                }

                connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
