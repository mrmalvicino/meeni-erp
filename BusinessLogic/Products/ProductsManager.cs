using DataAccess;
using DataAccess.Products;
using DomainModel.Products;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Transactions;
using Utilities;

namespace BusinessLogic.Products
{
    public class ProductsManager
    {
        private Product _product;
        private ProductsDAL _productsDAL;
        private BrandsManager _brandsManager;
        private CategoriesManager _categoriesManager;

        public ProductsManager(Database db)
        {
            _productsDAL = new ProductsDAL(db);
            _brandsManager = new BrandsManager(db);
            _categoriesManager = new CategoriesManager(db);
        }

        public int Create(Product product, int organizationId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    product.Brand = _brandsManager.Handle(_product.Brand, organizationId);
                    // Handle categories?
                    product.Id = _productsDAL.Create(product, organizationId);
                    transaction.Complete();
                    return product.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public Product Read(int productId)
        {
            if (productId == 0)
            {
                return null;
            }

            try
            {
                _product = _productsDAL.Read(productId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _product.Brand = _brandsManager.Read(Helper.GetId(_product.Brand));
            _product.Categories = _categoriesManager.ListProductCategories(_product.Id);

            return _product;
        }

        public void Update(Product product)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    product.Brand = _brandsManager.Handle(_product.Brand, FindOrganizationId(_product.Id));
                    // Handle categories?
                    _productsDAL.Update(product);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public void Toggle(int productId)
        {
            try
            {
                _productsDAL.Toggle(productId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Product> List(int organizationId, bool active, bool inactive)
        {
            try
            {
                List<Product> products;
                products = _productsDAL.List(organizationId, active, inactive);

                foreach (var product in products)
                {
                    product.Brand = _brandsManager.Read(Helper.GetId(product.Brand));
                    product.Categories = _categoriesManager.ListProductCategories(product.Id);
                }

                return products;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        private int FindOrganizationId(int productId)
        {
            try
            {
                return _productsDAL.FindOrganizationId(productId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
