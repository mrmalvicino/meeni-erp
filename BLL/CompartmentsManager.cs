using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class CompartmentsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private ProductsManager _productsManager = new ProductsManager();

        // METHODS

        public List<Compartment> list(int warehouseId)
        {
            List<Compartment> compartments = new List<Compartment>();

            try
            {
                _database.setQuery("select CompartmentId, CompartmentName, Stock, ProductId from Compartments where WarehouseId = @WarehouseId");
                _database.setParameter("WarehouseId", warehouseId);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Compartment compartment = new Compartment();

                    compartment.CompartmentId = (int)_database.Reader["CompartmentId"];
                    compartment.Name = (string)_database.Reader["CompartmentName"];
                    compartment.Stock = (int)_database.Reader["Stock"];
                    compartment.Product.ProductId = (int)_database.Reader["ProductId"];
                    
                    compartments.Add(compartment);
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

            foreach (Compartment compartment in compartments)
            {
                compartment.Product = _productsManager.read(compartment.Product.ProductId);
            }

            return compartments;
        }
    }
}
