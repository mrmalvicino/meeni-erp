using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Category> list()
        {
            List<Category> list = new List<Category>();

            try
            {
                _database.setQuery("SELECT Id, Area, Title, Seniority FROM categories");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Category category = new Category();

                    category.Id = (int)_database.Reader["Id"];
                    category.Area = (string)_database.Reader["Area"];
                    category.Title = (string)_database.Reader["Title"];
                    category.Seniority = (string)_database.Reader["Seniority"];

                    list.Add(category);
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

        public List<string> list(string attribute)
        {
            List<string> list = new List<string>();

            try
            {
                _database.setQuery($"SELECT {attribute} FROM categories");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    string str = (string)_database.Reader[$"{attribute}"];

                    if (!list.Contains(str))
                        list.Add(str);
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

        public void add(Category reg)
        {
            try
            {
                _database.setQuery("INSERT INTO categories (Area, Title, Seniority) VALUES (@Area, @Title, @Seniority)");
                _database.setParameter("@Area", reg.Area);
                _database.setParameter("@Title", reg.Title);
                _database.setParameter("@Seniority", reg.Seniority);
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

        public void edit(Category reg)
        {
            try
            {
                _database.setQuery("UPDATE categories SET Area = @Area, Title = @Title, Seniority = @Seniority WHERE Id = @Id");
                _database.setParameter("@Id", reg.Id);
                _database.setParameter("@Area", reg.Area);
                _database.setParameter("@Title", reg.Title);
                _database.setParameter("@Seniority", reg.Seniority);
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

        public void delete(int id)
        {
            try
            {
                _database.setQuery("DELETE FROM categories WHERE Id = @Id");
                _database.setParameter("@Id", id);
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
        
        public int getCategoryId(string area, string title, string seniority)
        {
            foreach (Category category in list())
            {
                if (category.Area == area && category.Title == title && category.Seniority == seniority)
                    return category.Id;
            }

            return -1;
        }
    }
}
