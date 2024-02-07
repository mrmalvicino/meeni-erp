using System;
using System.Collections.Generic;
using Entities;

namespace BLL
{
    public class CustomersManager : BusinessPartnersManager
    {
        // METHODS

        public List<Customer> list()
        {
            List<Customer> list = new List<Customer>();
            
            try
            {
                _database.setQuery("SELECT CustomerId, SalesAmount, BusinessPartnerId FROM customers");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Customer customer = new Customer();

                    customer.CustomerId = (int)_database.Reader["CustomerId"];
                    customer.SalesAmount = (int)_database.Reader["SalesAmount"];
                    customer.BusinessPartnerId = (int)_database.Reader["BusinessPartnerId"];
                    readBusinessPartner(customer, customer.BusinessPartnerId);
                    readIndividual(customer, customer.IndividualId);
                    readPhone(customer.Phone, customer.Phone.PhoneId);
                    readAdress(customer.Adress, customer.Adress.AdressId);
                    readTaxCode(customer.TaxCode, customer.TaxCode.TaxCodeId);
                    readCountry(customer.Phone.Country, customer.Phone.Country.CountryId);
                    readCountry(customer.Adress.Country, customer.Adress.Country.CountryId);
                    readProvince(customer.Phone.Province, customer.Phone.Province.ProvinceId);
                    readProvince(customer.Adress.Province, customer.Adress.Province.ProvinceId);

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

        public void add(Customer customer)
        {
            try
            {
                _database.setQuery("INSERT INTO customers (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY, @PaymentMethod, @InvoiceCategory)");
                setupIndividualParameters(customer);
                _database.setParameter("@PaymentMethod", customer.PaymentMethod);
                _database.setParameter("@InvoiceCategory", customer.InvoiceCategory);
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

        public void edit(Customer customer)
        {
            try
            {
                _database.setQuery("UPDATE customers SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY, PaymentMethod = @PaymentMethod, InvoiceCategory = @InvoiceCategory WHERE CustomerId = @CustomerId");
                setupIndividualParameters(customer);
                _database.setParameter("@PaymentMethod", customer.PaymentMethod);
                _database.setParameter("@InvoiceCategory", customer.InvoiceCategory);
                _database.setParameter("@CustomerId", customer.CustomerId);
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

        public void delete(int customerId)
        {
            try
            {
                _database.setQuery("DELETE FROM customers WHERE CustomerId = @CustomerId");
                _database.setParameter("@CustomerId", customerId);
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
