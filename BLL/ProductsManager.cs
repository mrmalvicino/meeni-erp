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
                product.Model = _modelsManager.read(product.Model.ModelId);
                product.Brand.BrandId = _modelsManager.getBrandId(product.Model);
                product.Brand = _brandsManager.read(product.Brand.BrandId);
            }

            return productsList;
        }

        public Product read(int productId)
        {
            Product product = new Product();

            try
            {
                _database.setQuery("select ModelId, ItemId from Products");
                _database.setParameter("@ProductId", productId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    product.ProductId = productId;
                    product.Model.ModelId = (int)_database.Reader["ModelId"];
                    product.ItemId = (int)_database.Reader["ItemId"];
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

            _item = _itemsManager.read(product.ItemId);
            Helper.assignItem(product, _item);
            product.Model = _modelsManager.read(product.Model.ModelId);
            product.Brand.BrandId = _modelsManager.getBrandId(product.Model);
            product.Brand = _brandsManager.read(product.Brand.BrandId);

            return product;
        }

        public void add(Product product)
        {
            _itemsManager.add(product);
            product.ItemId = Helper.getLastId("Items");

            int dbBrandId = _brandsManager.getId(product.Brand);

            if (dbBrandId == 0)
            {
                _brandsManager.add(product.Brand);
                product.Brand.BrandId = Helper.getLastId("Brands");
            }
            else
            {
                product.Brand.BrandId = dbBrandId;
            }

            int dbModelId = _modelsManager.getId(product.Model);

            if (dbModelId == 0)
            {
                _modelsManager.add(product.Model, product.Brand.BrandId);
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

            int dbBrandId = _brandsManager.getId(product.Brand);

            if (dbBrandId == 0)
            {
                _brandsManager.add(product.Brand);
                product.Brand.BrandId = Helper.getLastId("Brands");
            }
            else if (dbBrandId == product.Brand.BrandId)
            {
                _brandsManager.edit(product.Brand);
            }
            else
            {
                product.Brand.BrandId = dbBrandId;
            }

            int dbModelId = _modelsManager.getId(product.Model);

            if (dbModelId == 0)
            {
                _modelsManager.add(product.Model, product.Brand.BrandId);
                product.Model.ModelId = Helper.getLastId("Models");
            }
            else if (dbModelId == product.Model.ModelId)
            {
                _modelsManager.edit(product.Model, product.Brand.BrandId);
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
