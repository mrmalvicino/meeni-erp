using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class ProductsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Product> list()
        {
            List<Product> productsList = new List<Product>();

            try
            {
                _database.setQuery("select ProductId, ActiveStatus, ProductName, AdressId from Products");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Product product = new Product();

                    product.ProductId = (int)_database.Reader["ProductId"];
                    product.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    product.Name = (string)_database.Reader["ProductName"];
                    product.Adress.AdressId = (int)_database.Reader["AdressId"];

                    productsList.Add(product);
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

            return productsList;
        }

        public void add(Product product)
        {
            int dbAdressId = _adressesManager.getId(product.Adress);

            if (dbAdressId == 0)
            {
                _adressesManager.add(product.Adress);
                product.Adress.AdressId = Helper.getLastId("Adresses");
            }
            else
            {
                product.Adress.AdressId = dbAdressId;
            }

            try
            {
                _database.setQuery("insert into Products (ActiveStatus, ProductName, AdressId) values (@ActiveStatus, @ProductName, @AdressId)");
                setParameters(product);
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

        public void edit(Product product)
        {
            int dbAdressId = _adressesManager.getId(product.Adress);

            if (dbAdressId == 0)
            {
                _adressesManager.add(product.Adress);
                product.Adress.AdressId = Helper.getLastId("Adresses");
            }
            else if (dbAdressId == product.Adress.AdressId)
            {
                _adressesManager.edit(product.Adress);
            }
            else
            {
                product.Adress.AdressId = dbAdressId;
            }

            try
            {
                _database.setQuery("update Products set ActiveStatus = @ActiveStatus, ProductName = @ProductName, AdressId = @AdressId where ProductId = @ProductId");
                _database.setParameter("@ProductId", product.ProductId);
                setParameters(product);
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

        public void delete(Product product)
        {
            try
            {
                _database.setQuery("delete from Products where ProductId = @ProductId");
                _database.setParameter("@ProductId", product.ProductId);
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

        private void setParameters(Product product)
        {
            _database.setParameter("@ActiveStatus", product.ActiveStatus);
            _database.setParameter("@ProductName", product.Name);
            _database.setParameter("@AdressId", product.Adress.AdressId);
        }
    }
}
