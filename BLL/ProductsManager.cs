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
        private Item _item;
        private ItemsManager _itemsManager = new ItemsManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();

        // METHODS

        public List<Product> list()
        {
            List<Product> productsList = new List<Product>();

            try
            {
                _database.setQuery("select ProductId, ModelId, ItemId from Products");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Product product = new Product();

                    product.ProductId = (int)_database.Reader["ProductId"];
                    product.Model.ModelId = (int)_database.Reader["ModelId"];
                    product.ItemId = (int)_database.Reader["ItemId"];

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

            foreach (Product product in productsList)
            {
                _item = _itemsManager.read(product.ItemId);
                Helper.assignItem(product, _item);
            }

            return productsList;
        }

        public void add(Product product)
        {
            _itemsManager.add(product);
            product.ItemId = Helper.getLastId("Items");

            int dbModelId = _modelsManager.getId(product.Model);

            if (dbModelId == 0)
            {
                _modelsManager.add(product.Model);
                product.Model.ModelId = Helper.getLastId("Models");
            }
            else
            {
                product.Model.ModelId = dbModelId;
            }

            try
            {
                _database.setQuery("insert into Products (ModelId, ItemId) values (@ModelId, @ItemId)");
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
            _itemsManager.edit(product);

            int dbModelId = _modelsManager.getId(product.Model);

            if (dbModelId == 0)
            {
                _modelsManager.add(product.Model);
                product.Model.ModelId = Helper.getLastId("Models");
            }
            else if (dbModelId == product.Model.ModelId)
            {
                _modelsManager.edit(product.Model);
            }
            else
            {
                product.Model.ModelId = dbModelId;
            }

            try
            {
                _database.setQuery("update Products set ModelId = @ModelId, ItemId = @ItemId where ProductId = @ProductId");
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

            _itemsManager.delete(product);
        }

        private void setParameters(Product product)
        {
            _database.setParameter("@ModelId", product.Model.ModelId);
            _database.setParameter("@ItemId", product.ItemId);
        }
    }
}
