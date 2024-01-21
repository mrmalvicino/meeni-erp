using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class CustomersManager
    {
        public List<Customer> list()
        {
            List<Customer> list = new List<Customer>();
            Database database = new Database();

            try
            {
                database.setQuery("SELECT Id, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, SalesAmount FROM customers");
                database.executeReader();

                while (database.Reader.Read())
                {
                    Customer customer = new Customer();

                    customer.Id = (int)database.Reader["Id"];
                    customer.ActiveStatus = (bool)database.Reader["ActiveStatus"];
                    customer.IsPerson = (bool)database.Reader["IsPerson"];
                    customer.FirstName = (string)database.Reader["FirstName"];
                    customer.LastName = (string)database.Reader["LastName"];
                    customer.BusinessName = (string)database.Reader["BusinessName"];
                    customer.BusinessDescription = (string)database.Reader["BusinessDescription"];
                    customer.ImageUrl = (string)database.Reader["ImageUrl"];
                    customer.Email = (string)database.Reader["Email"];

                    customer.Phone.Country = (int)database.Reader["PhoneCountry"];
                    customer.Phone.Area = (int)database.Reader["PhoneArea"];
                    customer.Phone.Number = (int)database.Reader["PhoneNumber"];

                    customer.Adress.Country = (string)database.Reader["AdressCountry"];
                    customer.Adress.Province = (string)database.Reader["AdressProvince"];
                    customer.Adress.City = (string)database.Reader["AdressCity"];
                    customer.Adress.ZipCode = (string)database.Reader["AdressZipCode"];
                    customer.Adress.Street = (string)database.Reader["AdressStreet"];
                    customer.Adress.StreetNumber = (int)database.Reader["AdressStreetNumber"];
                    customer.Adress.Flat = (string)database.Reader["AdressFlat"];

                    customer.LegalId.XX = (string)database.Reader["LegalIdXX"];
                    customer.LegalId.DNI = (int)database.Reader["LegalIdDNI"];
                    customer.LegalId.Y = (string)database.Reader["LegalIdY"];

                    customer.PaymentMethod = (string)database.Reader["PaymentMethod"];
                    customer.InvoiceCategory = (string)database.Reader["InvoiceCategory"];
                    customer.SalesAmount = (int)database.Reader["SalesAmount"];

                    list.Add(customer);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                database.closeConnection();
            }
        }
    }
}
