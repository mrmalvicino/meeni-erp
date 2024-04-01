using System;
using System.Collections.Generic;
using System.Diagnostics;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class CustomersManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private BusinessPartner _businessPartner;
        private BusinessPartnersManager _businessPartnersManager = new BusinessPartnersManager();

        // METHODS

        public List<Customer> list()
        {
            List<Customer> customersList = new List<Customer>();
            
            try
            {
                _database.setQuery("select CustomerId, BusinessPartnerId from Customers");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Customer customer = new Customer();

                    customer.CustomerId = (int)_database.Reader["CustomerId"];
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
                _businessPartner = _businessPartnersManager.read(customer.BusinessPartnerId);
                Helper.assignIndividual(customer, _businessPartner);
            }

            return customersList;
        }

        public Customer read(int customerId)
        {
            Customer customer = new Customer();

            try
            {
                _database.setQuery("select CustomerId, BusinessPartnerId from Customers where CustomerId = @CustomerId");
                _database.setParameter("@CustomerId", customerId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    customer.CustomerId = (int)_database.Reader["CustomerId"];
                    customer.BusinessPartnerId = (int)_database.Reader["BusinessPartnerId"];
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

            _businessPartner = _businessPartnersManager.read(customer.BusinessPartnerId);
            Helper.assignIndividual(customer, _businessPartner);

            return customer;
        }

        public void add(Customer customer)
        {
            _businessPartnersManager.add(customer);
            customer.BusinessPartnerId = Helper.getLastId("BusinessPartners");

            try
            {
                _database.setQuery("insert into Customers (BusinessPartnerId) values (@BusinessPartnerId)");
                setParameters(customer);
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
                _database.setQuery("update Customers set BusinessPartnerId = @BusinessPartnerId where CustomerId = @CustomerId");
                _database.setParameter("@CustomerId", customer.CustomerId);
                setParameters(customer);
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

        private void setParameters(Customer customer)
        {
            _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);
        }
    }
}
