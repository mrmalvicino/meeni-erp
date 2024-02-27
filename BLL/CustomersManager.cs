using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class CustomersManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private BusinessPartnersManager _businessPartnersManager = new BusinessPartnersManager();

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
                    if (!(_database.Reader["SalesAmount"] is DBNull))
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

            BusinessPartner businessPartner;

            foreach (Customer customer in customersList)
            {
                businessPartner = _businessPartnersManager.readBusinessPartner(customer.BusinessPartnerId);
                Helper.assign(customer, businessPartner);
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

                //add(customer.copyToBusinessPartner());
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

                //edit(customer.copyToBusinessPartner());
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

                //delete(customer.copyToBusinessPartner());
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
