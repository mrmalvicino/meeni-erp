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
                Helper.assign(customer, _businessPartner);
            }

            return customersList;
        }

        public void add(Customer customer)
        {
            try
            {
                _database.setQuery("insert into Customers (SalesAmount, BusinessPartnerId) values (@SalesAmount, @BusinessPartnerId)");
                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);
                _database.executeAction();
                _businessPartnersManager.add(customer);

                // Este metodo tiene que agregar los datos del customer en el resto de las tablas
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
                _database.setQuery("update Customers set SalesAmount = @SalesAmount, BusinessPartnerId = @BusinessPartnerId where CustomerId = @CustomerId");
                _database.setParameter("@CustomerId", customer.CustomerId);
                _database.setParameter("@SalesAmount", customer.SalesAmount);
                _database.setParameter("@BusinessPartnerId", customer.BusinessPartnerId);
                _database.executeAction();

                // Este metodo tiene que editar los datos del customer en el resto de las tablas
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

                // Este metodo tiene que borrar los datos del customer del resto de las tablas
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
