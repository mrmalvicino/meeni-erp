using System;
using System.Collections.Generic;
using System.Security.Policy;
using Entities;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace BLL
{
    public class CustomersManager : BusinessPartnersManager
    {
        // METHODS

        public List<Customer> listCustomers()
        {
            List<Customer> customersList = new List<Customer>();
            
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

                    customersList.Add(customer);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            foreach (Customer c in customersList)
            {
                foreach (BusinessPartner b in listBusinessPartners())
                {
                    if (c.BusinessPartnerId == b.BusinessPartnerId)
                    {
                        c.PaymentMethod = b.PaymentMethod;
                        c.InvoiceCategory = b.InvoiceCategory;
                        c.IndividualId = b.IndividualId;

                        c.ActiveStatus = b.ActiveStatus;
                        c.IsPerson = b.IsPerson;
                        c.FirstName = b.FirstName;
                        c.LastName = b.LastName;
                        c.BusinessName = b.BusinessName;
                        c.BusinessDescription = b.BusinessDescription;
                        c.ImageUrl = b.ImageUrl;
                        c.Email = b.Email;
                        c.Phone.PhoneId = b.Phone.PhoneId;
                        c.Adress.AdressId = b.Adress.AdressId;
                        c.TaxCode.TaxCodeId = b.TaxCode.TaxCodeId;

                        c.Phone.Number = b.Phone.Number;
                        c.Phone.Country.CountryId = b.Phone.Country.CountryId;
                        c.Phone.Province.ProvinceId = b.Phone.Province.ProvinceId;

                        c.Phone.Country.PhoneAreaCode = b.Phone.Country.PhoneAreaCode;
                        c.Phone.Province.PhoneAreaCode = b.Phone.Province.PhoneAreaCode;

                        c.Adress.City = b.Adress.City;
                        c.Adress.ZipCode = b.Adress.ZipCode;
                        c.Adress.StreetName = b.Adress.StreetName;
                        c.Adress.StreetNumber = b.Adress.StreetNumber;
                        c.Adress.Flat = b.Adress.Flat;
                        c.Adress.Country.CountryId = b.Adress.Country.CountryId;
                        c.Adress.Province.ProvinceId = b.Adress.Province.ProvinceId;

                        c.Adress.Country.Name = b.Adress.Country.Name;
                        c.Adress.Province.Name = b.Adress.Province.Name;

                        c.TaxCode.Prefix = b.TaxCode.Prefix;
                        c.TaxCode.Number = b.TaxCode.Number;
                        c.TaxCode.Suffix = b.TaxCode.Suffix;
                    }
                }
            }

            return customersList;
        }

        public void add(Customer customer)
        {
            try
            {
                _database.setQuery("INSERT INTO customers (SalesAmount, BusinessPartnerId) VALUES (@SalesAmount, @BusinessPartnerId)");

                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);

                _database.executeAction();

                add(customer.copyToBusinessPartner());
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
                _database.setQuery("UPDATE customers SET SalesAmount = @SalesAmount, BusinessPartnerId = @BusinessPartnerId WHERE CustomerId = @CustomerId");

                _database.setParameter("@CustomerId", customer.CustomerId);
                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);

                _database.executeAction();

                edit(customer.copyToBusinessPartner());
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

        public void delete(Customer customer)
        {
            try
            {
                _database.setQuery("DELETE FROM customers WHERE CustomerId = @CustomerId");
                _database.setParameter("@CustomerId", customer.CustomerId);
                _database.executeAction();

                delete(customer.copyToBusinessPartner());
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
