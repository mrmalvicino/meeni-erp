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

        public List<Warehouse> list()
        {
            List<Product> productsList = new List<Product>();

            try
            {
                _database.setQuery("select WarehouseId, ActiveStatus, WarehouseName, AdressId from Warehouses");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Product product = new Warehouse();

                    product.WarehouseId = (int)_database.Reader["WarehouseId"];
                    warehouse.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    warehouse.Name = (string)_database.Reader["WarehouseName"];
                    warehouse.Adress.AdressId = (int)_database.Reader["AdressId"];

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

        public void add(Warehouse warehouse)
        {
            int dbAdressId = _adressesManager.getId(warehouse.Adress);

            if (dbAdressId == 0)
            {
                _adressesManager.add(warehouse.Adress);
                warehouse.Adress.AdressId = Helper.getLastId("Adresses");
            }
            else
            {
                warehouse.Adress.AdressId = dbAdressId;
            }

            try
            {
                _database.setQuery("insert into Warehouses (ActiveStatus, WarehouseName, AdressId) values (@ActiveStatus, @WarehouseName, @AdressId)");
                setParameters(warehouse);
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

        public void edit(Warehouse warehouse)
        {
            int dbAdressId = _adressesManager.getId(warehouse.Adress);

            if (dbAdressId == 0)
            {
                _adressesManager.add(warehouse.Adress);
                warehouse.Adress.AdressId = Helper.getLastId("Adresses");
            }
            else if (dbAdressId == warehouse.Adress.AdressId)
            {
                _adressesManager.edit(warehouse.Adress);
            }
            else
            {
                warehouse.Adress.AdressId = dbAdressId;
            }

            try
            {
                _database.setQuery("update Warehouses set ActiveStatus = @ActiveStatus, WarehouseName = @WarehouseName, AdressId = @AdressId where WarehouseId = @WarehouseId");
                _database.setParameter("@WarehouseId", warehouse.WarehouseId);
                setParameters(warehouse);
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

        public void delete(Warehouse warehouse)
        {
            try
            {
                _database.setQuery("delete from Warehouses where WarehouseId = @WarehouseId");
                _database.setParameter("@WarehouseId", warehouse.WarehouseId);
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

        private void setParameters(Warehouse warehouse)
        {
            _database.setParameter("@ActiveStatus", warehouse.ActiveStatus);
            _database.setParameter("@WarehouseName", warehouse.Name);
            _database.setParameter("@AdressId", warehouse.Adress.AdressId);
        }
    }
}
