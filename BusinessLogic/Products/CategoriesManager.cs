using DataAccess;
using DataAccess.Products;
using DomainModel.Products;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Products
{
    public class CategoriesManager
    {
        private Category _category;
        private CategoriesDAL _categoriesDAL;

        public CategoriesManager(Database db)
        {
            _categoriesDAL = new CategoriesDAL(db);
        }

        public int Create(Category category, int organizationId)
        {
            try
            {
                return _categoriesDAL.Create(category, organizationId);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Category Read(int categoryId)
        {
            if (categoryId == 0)
            {
                return null;
            }

            try
            {
                _category = _categoriesDAL.Read(categoryId);
                return _category;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Update(Category category)
        {
            try
            {
                _categoriesDAL.Update(category);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Toggle(int categoryId)
        {
            try
            {
                _categoriesDAL.Toggle(categoryId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Category> List(int organizationId, bool active, bool inactive)
        {
            try
            {
                return _categoriesDAL.List(organizationId, active, inactive);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Category> ListProductCategories(int productId = 0)
        {
            try
            {
                return _categoriesDAL.ListProductCategories(productId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
