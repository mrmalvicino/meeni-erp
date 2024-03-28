using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class CategoriesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Category> list()
        {
            List<Category> categoriesList = new List<Category>();

            try
            {
                _database.setQuery("select CategoryId, CategoryName from Categories");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Category category = new Category();

                    category.CategoryId = Convert.ToInt32(_database.Reader["CategoryId"]);
                    category.Name = (string)_database.Reader["CategoryName"];

                    categoriesList.Add(category);
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

            return categoriesList;
        }

        public void add(Category category)
        {
            try
            {
                _database.setQuery("insert into Categories (CategoryName) values (@CategoryName)");
                setParameters(category);
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

        public void edit(Category category)
        {
            try
            {
                _database.setQuery("update Categories set CategoryName = @CategoryName where CategoryId = @CategoryId");
                _database.setParameter("@CategoryId", category.CategoryId);
                setParameters(category);
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

        public int getId(Category category)
        {
            if (category == null)
            {
                return 0;
            }

            int categoryId = 0;

            try
            {
                _database.setQuery("select CategoryId from Categories where CategoryName = @CategoryName");
                _database.setParameter("@CategoryName", category.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    categoryId = Convert.ToInt32(_database.Reader["CategoryId"]);
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

            return categoryId;
        }

        private void setParameters(Category category)
        {
            if (Validations.hasData(category.Name))
            {
                _database.setParameter("@CategoryName", category.Name);
            }
            else
            {
                _database.setParameter("@CategoryName", DBNull.Value);
            }
        }
    }
}
