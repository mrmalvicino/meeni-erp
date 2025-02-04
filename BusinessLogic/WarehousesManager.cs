using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class WarehousesManager
    {
        private Warehouse _warehouse;
        private WarehousesDAL _warehousesDAL;
        private CompartmentsManager _compartmentsManager;

        public WarehousesManager(Database db)
        {
            _warehousesDAL = new WarehousesDAL(db);
            _compartmentsManager = new CompartmentsManager(db);
        }

        public int Create(Warehouse warehouse, int organizationId)
        {
            try
            {
                warehouse.Id = _warehousesDAL.Create(warehouse, organizationId);
                return warehouse.Id;
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
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

            _warehouse.Compartments = _compartmentsManager.List(_warehouse.Id, true, false);

            return _warehouse;
        }

        public void Update(Warehouse warehouse)
        {
            try
            {
                _warehousesDAL.Update(warehouse);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
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
                    warehouse.Compartments = _compartmentsManager.List(warehouse.Id, true, false);
                }

                return warehouses;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
