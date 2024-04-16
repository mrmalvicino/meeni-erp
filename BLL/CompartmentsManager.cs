using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

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
                _database.setQuery("select CompartmentId, ActiveStatus, CompartmentName, Stock, ProductId from Compartments where WarehouseId = @WarehouseId");
                _database.setParameter("WarehouseId", warehouseId);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Compartment compartment = new Compartment();

                    compartment.CompartmentId = (int)_database.Reader["CompartmentId"];
                    compartment.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
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

        public void add(Compartment compartment, int warehouseId)
        {
            compartment.Product.ProductId = _productsManager.getId(compartment.Product);

            try
            {
                _database.setQuery("insert into Compartments (ActiveStatus, CompartmentName, Stock, ProductId, WarehouseId) values (@ActiveStatus, @CompartmentName, @Stock, @ProductId, @WarehouseId)");
                setParameters(compartment, warehouseId);
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

        public void edit(Compartment compartment, int warehouseId)
        {
            compartment.Product.ProductId = _productsManager.getId(compartment.Product);

            try
            {
                _database.setQuery("update Compartments set ActiveStatus = @ActiveStatus, CompartmentName = @CompartmentName, Stock = @Stock, ProductId = @ProductId, WarehouseId = @WarehouseId where CompartmentId = @CompartmentId");
                _database.setParameter("@CompartmentId", compartment.CompartmentId);
                setParameters(compartment, warehouseId);
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

        public void delete(Compartment compartment)
        {
            try
            {
                _database.setQuery("delete from Compartments where CompartmentId = @CompartmentId");
                _database.setParameter("@CompartmentId", compartment.CompartmentId);
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

        private void setParameters(Compartment compartment, int warehouseId)
        {
            _database.setParameter("@ActiveStatus", compartment.ActiveStatus);
            _database.setParameter("@CompartmentName", compartment.Name);
            _database.setParameter("@Stock", compartment.Stock);
            _database.setParameter("@ProductId", compartment.Product.ProductId);
            _database.setParameter("@WarehouseId", warehouseId);
        }
    }
}
