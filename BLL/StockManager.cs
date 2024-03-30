using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class StockManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private WarehousesManager _warehousesManager = new WarehousesManager();
        private ProductsManager _productsManager = new ProductsManager();

        // METHODS

        public List<Stock> list()
        {
            List<Stock> stockList = new List<Stock>();

            try
            {
                _database.setQuery("select WarehouseId, ProductId, Stock from WarehouseProductRelations");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Stock stock = new Stock();

                    stock.Warehouse.WarehouseId = (int)_database.Reader["WarehouseId"];
                    stock.Product.ProductId = (int)_database.Reader["ProductId"];
                    stock.Amount = (int)_database.Reader["Stock"];

                    stockList.Add(stock);
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

            foreach (Stock stock in stockList)
            {
                stock.Warehouse = _warehousesManager.read(stock.Warehouse.WarehouseId);
                stock.Product = _productsManager.read(stock.Product.ProductId);
            }

            return stockList;
        }
    }
}
