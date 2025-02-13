using DomainModel.Products;
using Exceptions;
using System;
using System.Collections.Generic;

namespace DataAccess.Products
{
    public class CategoriesDAL
    {
        private Database _db;

        public CategoriesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Category category, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_create_category");
                SetParameters(category, organizationId);
                category.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return category.Id;
        }

        public Category Read(int categoryId)
        {
            try
            {
                _db.SetQuery("select * from categories where category_id = @category_id");
                _db.SetParameter("@category_id", categoryId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Category category = new Category();
                    ReadRow(category);
                    return category;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Update(Category category)
        {
            try
            {
                _db.SetProcedure("sp_update_category");
                SetParameters(category, 0, true);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Toggle(int categoryId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_category");
                _db.SetParameter("@category_id", categoryId);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public List<Category> List(int organizationId, bool active, bool inactive)
        {
            List<Category> categories = new List<Category>();

            try
            {
                _db.SetProcedure("sp_list_categories");
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Category category = new Category();
                    ReadRow(category);
                    categories.Add(category);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return categories;
        }

        public List<Category> ListProductCategories(int productId = 0)
        {
            List<Category> categories = new List<Category>();

            try
            {
                _db.SetProcedure("sp_list_product_categories");
                _db.SetParameter("@product_id", productId);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Category category = new Category();
                    ReadRow(category);
                    categories.Add(category);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return categories;
        }

        private void SetParameters(Category category, int organizationId = 0, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@category_id", category.Id);
            }

            _db.SetParameter("@name", category.Name);

            if (0 < organizationId)
            {
                _db.SetParameter("@organization_id", organizationId);
            }
        }

        private void ReadRow(Category category)
        {
            category.Id = Convert.ToInt32(_db.Reader["category_id"]);
            category.ActivityStatus = Convert.ToBoolean(_db.Reader["activity_status"]);
            category.Name = _db.Reader["name"].ToString();
        }
    }
}
