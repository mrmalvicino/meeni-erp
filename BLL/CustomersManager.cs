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
        private BusinessPartner _businessPartner;
        private BusinessPartnersManager _businessPartnersManager = new BusinessPartnersManager();

        // METHODS

        public List<Customer> listCustomers()
        {
            List<Customer> customersList = new List<Customer>();
            
            try
            {
                _database.setQuery("select CustomerId, SalesAmount, BusinessPartnerId from Customers");
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

            foreach (Customer customer in customersList)
            {
                _businessPartner = _businessPartnersManager.readBusinessPartner(customer.BusinessPartnerId);
                Functions.assign(customer, _businessPartner);
            }

            return customersList;
        }

        public void add(Customer customer)
        {
            _businessPartnersManager.add(customer);
            int businessPartnerId = Functions.getLastId("BusinessPartners");

            try
            {
                _database.setQuery("insert into Customers (SalesAmount, BusinessPartnerId) values (@SalesAmount, @BusinessPartnerId)");
                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", businessPartnerId);
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
            _businessPartnersManager.edit(customer);

            try
            {
                _database.setQuery("update Customers set SalesAmount = @SalesAmount, BusinessPartnerId = @BusinessPartnerId where CustomerId = @CustomerId");
                _database.setParameter("@CustomerId", customer.CustomerId);
                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);
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

        public void delete(Customer customer)
        {
            try
            {
                _database.setQuery("delete from Customers where CustomerId = @CustomerId");
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

            _businessPartnersManager.delete(customer);
        }
    }
}
