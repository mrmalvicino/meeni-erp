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
                _database.setQuery("INSERT INTO customers (SalesAmount, BusinessPartnerId) VALUES (@SalesAmount, @BusinessPartnerId)");

                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);

                _database.executeAction();

                add(customer.toBusinessPartner());
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

                edit(customer.toBusinessPartner());
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

                delete(customer.toBusinessPartner());
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
