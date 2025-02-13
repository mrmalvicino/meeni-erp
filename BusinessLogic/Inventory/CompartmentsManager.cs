using DomainModel.Inventory;
using BusinessLogic.Products;
using DataAccess;
using DataAccess.Inventory;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Inventory
{
    public class CompartmentsManager
    {
        private Compartment _compartment;
        private CompartmentsDAL _compartmentsDAL;
        private ProductsManager _productsManager;

        public CompartmentsManager(Database db)
        {
            _compartmentsDAL = new CompartmentsDAL(db);
            _productsManager = new ProductsManager(db);
        }

        public int Create(Compartment compartment, int warehouseId)
        {
            try
            {
                compartment.Id = _compartmentsDAL.Create(compartment, warehouseId);
                return compartment.Id;
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Compartment Read(int compartmentId)
        {
            if (compartmentId == 0)
            {
                return null;
            }

            try
            {
                _compartment = _compartmentsDAL.Read(compartmentId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _compartment.Product = _productsManager.Read(_compartment.Product.Id);

            return _compartment;
        }

        public void Update(Compartment compartment)
        {
            try
            {
                _compartmentsDAL.Update(compartment);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Toggle(int compartmentId)
        {
            try
            {
                _compartmentsDAL.Toggle(compartmentId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Compartment> List(int warehouseId, bool active, bool inactive)
        {
            try
            {
                List<Compartment> compartments;
                compartments = _compartmentsDAL.List(warehouseId, active, inactive);

                foreach (var compartment in compartments)
                {
                    compartment.Product = _productsManager.Read(compartment.Product.Id);
                }

                return compartments;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
