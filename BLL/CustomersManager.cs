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
        // ATTRIBUTES

        Database _database = new Database();

        // METHODS

        public List<Customer> list()
        {
            List<Customer> list = new List<Customer>();
            
            try
            {
                _database.setQuery("SELECT Id, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, SalesAmount FROM customers");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Customer customer = new Customer();

                    customer.Id = (int)_database.Reader["Id"];
                    if (!(_database.Reader["ActiveStatus"] is DBNull))
                        customer.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    if (!(_database.Reader["IsPerson"] is DBNull))
                        customer.IsPerson = (bool)_database.Reader["IsPerson"];
                    if (!(_database.Reader["FirstName"] is DBNull))
                        customer.FirstName = (string)_database.Reader["FirstName"];
                    if (!(_database.Reader["LastName"] is DBNull))
                        customer.LastName = (string)_database.Reader["LastName"];
                    if (!(_database.Reader["BusinessName"] is DBNull))
                        customer.BusinessName = (string)_database.Reader["BusinessName"];
                    if (!(_database.Reader["BusinessDescription"] is DBNull))
                        customer.BusinessDescription = (string)_database.Reader["BusinessDescription"];
                    if (!(_database.Reader["ImageUrl"] is DBNull))
                        customer.ImageUrl = (string)_database.Reader["ImageUrl"];
                    if (!(_database.Reader["Email"] is DBNull))
                        customer.Email = (string)_database.Reader["Email"];

                    if (!(_database.Reader["PhoneCountry"] is DBNull))
                        customer.Phone.Country = (int)_database.Reader["PhoneCountry"];
                    if (!(_database.Reader["PhoneArea"] is DBNull))
                        customer.Phone.Area = (int)_database.Reader["PhoneArea"];
                    if (!(_database.Reader["PhoneNumber"] is DBNull))
                        customer.Phone.Number = (int)_database.Reader["PhoneNumber"];

                    if (!(_database.Reader["AdressCountry"] is DBNull))
                        customer.Adress.Country = (string)_database.Reader["AdressCountry"];
                    if (!(_database.Reader["AdressProvince"] is DBNull))
                        customer.Adress.Province = (string)_database.Reader["AdressProvince"];
                    if (!(_database.Reader["AdressCity"] is DBNull))
                        customer.Adress.City = (string)_database.Reader["AdressCity"];
                    if (!(_database.Reader["AdressZipCode"] is DBNull))
                        customer.Adress.ZipCode = (string)_database.Reader["AdressZipCode"];
                    if (!(_database.Reader["AdressStreet"] is DBNull))
                        customer.Adress.Street = (string)_database.Reader["AdressStreet"];
                    if (!(_database.Reader["AdressStreetNumber"] is DBNull))
                        customer.Adress.StreetNumber = (int)_database.Reader["AdressStreetNumber"];
                    if (!(_database.Reader["AdressFlat"] is DBNull))
                        customer.Adress.Flat = (string)_database.Reader["AdressFlat"];

                    if (!(_database.Reader["LegalIdXX"] is DBNull))
                        customer.LegalId.XX = (string)_database.Reader["LegalIdXX"];
                    if (!(_database.Reader["LegalIdDNI"] is DBNull))
                        customer.LegalId.DNI = (int)_database.Reader["LegalIdDNI"];
                    if (!(_database.Reader["LegalIdY"] is DBNull))
                        customer.LegalId.Y = (string)_database.Reader["LegalIdY"];

                    if (!(_database.Reader["PaymentMethod"] is DBNull)) 
                        customer.PaymentMethod = (string)_database.Reader["PaymentMethod"];
                    if (!(_database.Reader["InvoiceCategory"] is DBNull)) 
                        customer.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];
                    if (!(_database.Reader["SalesAmount"] is DBNull)) 
                        customer.SalesAmount = (int)_database.Reader["SalesAmount"];

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
                _database.closeConnection();
            }
        }

        public void add(Individual reg)
        {
            try
            {
                _database.setQuery("INSERT INTO customers (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY)");
                
                _database.setParameter("@ActiveStatus", reg.ActiveStatus);
                _database.setParameter("@IsPerson", reg.IsPerson);
                _database.setParameter("@FirstName", reg.FirstName);
                _database.setParameter("@LastName", reg.LastName);
                _database.setParameter("@BusinessName", reg.BusinessName);
                _database.setParameter("@BusinessDescription", reg.BusinessDescription);
                _database.setParameter("@ImageUrl", reg.ImageUrl);
                _database.setParameter("@Email", reg.Email);
                _database.setParameter("@PhoneCountry", reg.Phone.Country);
                _database.setParameter("@PhoneArea", reg.Phone.Area);
                _database.setParameter("@PhoneNumber", reg.Phone.Number);
                _database.setParameter("@AdressCountry", reg.Adress.Country);
                _database.setParameter("@AdressProvince", reg.Adress.Province);
                _database.setParameter("@AdressCity", reg.Adress.City);
                _database.setParameter("@AdressZipCode", reg.Adress.ZipCode);
                _database.setParameter("@AdressStreet", reg.Adress.Street);
                _database.setParameter("@AdressStreetNumber", reg.Adress.StreetNumber);
                _database.setParameter("@AdressFlat", reg.Adress.Flat);
                _database.setParameter("@LegalIdXX", reg.LegalId.XX);
                _database.setParameter("@LegalIdDNI", reg.LegalId.DNI);
                _database.setParameter("@LegalIdY", reg.LegalId.Y);

                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void edit(Individual reg)
        {
            try
            {
                _database.setQuery("UPDATE customers SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY WHERE Id = @Id");

                _database.setParameter("@Id", reg.Id);
                _database.setParameter("@ActiveStatus", reg.ActiveStatus);
                _database.setParameter("@IsPerson", reg.IsPerson);
                _database.setParameter("@FirstName", reg.FirstName);
                _database.setParameter("@LastName", reg.LastName);
                _database.setParameter("@BusinessName", reg.BusinessName);
                _database.setParameter("@BusinessDescription", reg.BusinessDescription);
                _database.setParameter("@ImageUrl", reg.ImageUrl);
                _database.setParameter("@Email", reg.Email);
                _database.setParameter("@PhoneCountry", reg.Phone.Country);
                _database.setParameter("@PhoneArea", reg.Phone.Area);
                _database.setParameter("@PhoneNumber", reg.Phone.Number);
                _database.setParameter("@AdressCountry", reg.Adress.Country);
                _database.setParameter("@AdressProvince", reg.Adress.Province);
                _database.setParameter("@AdressCity", reg.Adress.City);
                _database.setParameter("@AdressZipCode", reg.Adress.ZipCode);
                _database.setParameter("@AdressStreet", reg.Adress.Street);
                _database.setParameter("@AdressStreetNumber", reg.Adress.StreetNumber);
                _database.setParameter("@AdressFlat", reg.Adress.Flat);
                _database.setParameter("@LegalIdXX", reg.LegalId.XX);
                _database.setParameter("@LegalIdDNI", reg.LegalId.DNI);
                _database.setParameter("@LegalIdY", reg.LegalId.Y);

                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void delete(int id)
        {
            try
            {
                _database.setQuery("DELETE FROM customers WHERE Id = @Id");
                _database.setParameter("@Id", id);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }
    }
}
