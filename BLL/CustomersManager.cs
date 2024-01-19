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
                command.CommandText = "SELECT Id, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, SalesAmount FROM customers";
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();

                    customer.Id = (int)reader["Id"];
                    customer.ActiveStatus = (bool)reader["ActiveStatus"];
                    customer.IsPerson = (bool)reader["IsPerson"];
                    customer.FirstName = (string)reader["FirstName"];
                    customer.LastName = (string)reader["LastName"];
                    customer.BusinessName = (string)reader["BusinessName"];
                    customer.BusinessDescription = (string)reader["BusinessDescription"];
                    customer.ImageUrl = (string)reader["ImageUrl"];
                    customer.Email = (string)reader["Email"];

                    customer.Phone.Country = (int)reader["PhoneCountry"];
                    customer.Phone.Area = (int)reader["PhoneArea"];
                    customer.Phone.Number = (int)reader["PhoneNumber"];

                    customer.Adress.Country = (string)reader["AdressCountry"];
                    customer.Adress.Province = (string)reader["AdressProvince"];
                    customer.Adress.City = (string)reader["AdressCity"];
                    customer.Adress.ZipCode = (string)reader["AdressZipCode"];
                    customer.Adress.Street = (string)reader["AdressStreet"];
                    customer.Adress.StreetNumber = (int)reader["AdressStreetNumber"];
                    customer.Adress.Flat = (string)reader["AdressFlat"];

                    customer.LegalId.XX = (string)reader["LegalIdXX"];
                    customer.LegalId.DNI = (int)reader["LegalIdDNI"];
                    customer.LegalId.Y = (string)reader["LegalIdY"];

                    customer.PaymentMethod = (string)reader["PaymentMethod"];
                    customer.InvoiceCategory = (string)reader["InvoiceCategory"];
                    customer.SalesAmount = (int)reader["SalesAmount"];

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
