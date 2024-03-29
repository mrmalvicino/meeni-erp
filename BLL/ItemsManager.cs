using System;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class ItemsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CategoriesManager _categoriesManager = new CategoriesManager();

        // METHODS

        public Item read(int itemId)
        {
            Item item = new Item();

            try
            {
                _database.setQuery("select Price, Cost, CategoryId from Items where ItemId = @ItemId");
                _database.setParameter("@ItemId", itemId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    item.ItemId = itemId;
                    item.Price = (decimal)_database.Reader["Price"];
                    item.Cost = (decimal)_database.Reader["Cost"];
                    item.Category.CategoryId = (int)_database.Reader["CategoryId"];

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

            item.Category = _categoriesManager.read(item.Category.CategoryId);

            return item;
        }

        public void add(Item item)
        {
            int dbCategoryId = _categoriesManager.getId(item.Category);

            if (dbCategoryId == 0)
            {
                _categoriesManager.add(item.Category);
                item.Category.CategoryId = Helper.getLastId("Categories");
            }
            else
            {
                item.Category.CategoryId = dbCategoryId;
            }

            try
            {
                _database.setQuery("insert into Items (Price, Cost, CategoryId) values (@Price, @Cost, @CategoryId)");
                setParameters(item);
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

        public void edit(Item item)
        {
            int dbCategoryId = _categoriesManager.getId(item.Category);

            if (dbCategoryId == 0)
            {
                _categoriesManager.add(item.Category);
                item.Category.CategoryId = Helper.getLastId("Categories");
            }
            else if (dbCategoryId == item.Category.CategoryId)
            {
                _categoriesManager.edit(item.Category);
            }
            else
            {
                item.Category.CategoryId = dbCategoryId;
            }

            try
            {
                _database.setQuery("update Items set Price = @Price, Cost = @Cost, CategoryId = @CategoryId where ItemId = @ItemId");
                _database.setParameter("@ItemId", item.ItemId);
                setParameters(item);
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

        public void delete(Item item)
        {
            try
            {
                _database.setQuery("delete from Items where ItemId = @ItemId");
                _database.setParameter("@ItemId", item.ItemId);
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

        private void setParameters(Item item)
        {
            _database.setParameter("@Price", item.Price);
            _database.setParameter("@Cost", item.Cost);
            _database.setParameter("@CategoryId", item.Category.CategoryId);
        }
    }
}
