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

        // METHODS

        public Item read(int itemId)
        {
            Item item = new Item();

            try
            {
                _database.setQuery("select Prefix, Number, Suffix from Items where ItemId = @ItemId");
                _database.setParameter("@ItemId", itemId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    item.ItemId = itemId;

                    if (!(_database.Reader["Prefix"] is DBNull))
                    {
                        item.Prefix = (string)_database.Reader["Prefix"];
                    }

                    item.Number = (string)_database.Reader["Number"];

                    if (!(_database.Reader["Suffix"] is DBNull))
                    {
                        item.Suffix = (string)_database.Reader["Suffix"];
                    }
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

            return item;
        }

        public void add(Item item)
        {
            try
            {
                _database.setQuery("insert into Items (Prefix, Number, Suffix) values (@Prefix, @Number, @Suffix)");
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
            try
            {
                _database.setQuery("update Items set Prefix = @Prefix, Number = @Number, Suffix = @Suffix where ItemId = @ItemId");
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

        public int getId(Item item)
        {
            if (item == null)
            {
                return 0;
            }

            int itemId = 0;

            try
            {
                _database.setQuery("select ItemId from Items where Number = @Number");
                _database.setParameter("@Number", item.Number);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    itemId = (int)_database.Reader["ItemId"];
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

            return itemId;
        }

        private void setParameters(Item item)
        {
            if (Validations.hasData(item.Prefix, 2, 2))
            {
                _database.setParameter("@Prefix", item.Prefix);
            }
            else
            {
                _database.setParameter("@Prefix", DBNull.Value);
            }

            if (Validations.hasData(item.Number))
            {
                _database.setParameter("@Number", item.Number);
            }
            else
            {
                _database.setParameter("@Number", DBNull.Value);
            }

            if (Validations.hasData(item.Suffix, 1, 1))
            {
                _database.setParameter("@Suffix", item.Suffix);
            }
            else
            {
                _database.setParameter("@Suffix", DBNull.Value);
            }
        }
    }
}
