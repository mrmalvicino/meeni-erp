using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class WarehousesManager
    {
        private Warehouse _warehouse;
        private WarehousesDAL _warehousesDAL;
        private AddressesManager _addressesManager;
        private CompartmentsManager _compartmentsManager;

        public WarehousesManager(Database db)
        {
            _warehousesDAL = new WarehousesDAL(db);
            _addressesManager = new AddressesManager(db);
            _compartmentsManager = new CompartmentsManager(db);
        }

        public int Create(Warehouse warehouse, int organizationId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    warehouse.Address = _addressesManager.Handle(warehouse.Address);
                    Validate(warehouse);
                    warehouse.Id = _warehousesDAL.Create(warehouse, organizationId);
                    transaction.Complete();
                    return warehouse.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public Warehouse Read(int warehouseId)
        {
            if (warehouseId == 0)
            {
                return null;
            }

            try
            {
                _warehouse = _warehousesDAL.Read(warehouseId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _warehouse.Address = _addressesManager.Read(Helper.GetId(_warehouse.Address));
            _warehouse.Compartments = _compartmentsManager.List(_warehouse.Id, true, false);

            return _warehouse;
        }

        public void Update(Warehouse warehouse)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    warehouse.Address = _addressesManager.Handle(warehouse.Address);
                    Validate(warehouse);
                    _warehousesDAL.Update(warehouse);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public void Toggle(int warehouseId)
        {
            try
            {
                _warehousesDAL.Toggle(warehouseId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Warehouse> List(int organizationId, bool active, bool inactive)
        {
            try
            {
                List<Warehouse> warehouses;
                warehouses = _warehousesDAL.List(organizationId, active, inactive);

                foreach (var warehouse in warehouses)
                {
                    warehouse.Address = _addressesManager.Read(Helper.GetId(warehouse.Address));
                    warehouse.Compartments = _compartmentsManager.List(warehouse.Id, true, false);
                }

                return warehouses;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public int FindOrganizationId(int warehouseId)
        {
            try
            {
                return _warehousesDAL.FindOrganizationId(warehouseId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        private void Validate(Warehouse warehouse)
        {
            if (string.IsNullOrEmpty(warehouse.Name))
            {
                throw new ValidationException("Ingresar un nombre para el depósito.");
            }
        }
    }
}
