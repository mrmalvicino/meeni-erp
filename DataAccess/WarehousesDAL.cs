using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess
{
    public class WarehousesDAL
    {
        private Database _db;

        public WarehousesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Warehouse warehouse, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_create_warehouse");
                SetParameters(warehouse, organizationId);
                warehouse.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return warehouse.Id;
        }

        public Warehouse Read(int warehouseId)
        {
            try
            {
                _db.SetQuery("select * from warehouses where warehouse_id = @warehouse_id");
                _db.SetParameter("@warehouse_id", warehouseId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Warehouse warehouse = new Warehouse();
                    ReadRow(warehouse);
                    return warehouse;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Update(Warehouse warehouse)
        {
            try
            {
                _db.SetProcedure("sp_update_warehouse");
                SetParameters(warehouse, 0, true);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Toggle(int warehouseId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_warehouse");
                _db.SetParameter("@warehouse_id", warehouseId);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public List<Warehouse> List(int organizationId, bool active, bool inactive)
        {
            List<Warehouse> warehouses = new List<Warehouse>();

            try
            {
                _db.SetProcedure("sp_list_warehouses");
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Warehouse warehouse = new Warehouse();
                    ReadRow(warehouse);
                    warehouses.Add(warehouse);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return warehouses;
        }

        public int FindOrganizationId(int warehouseId)
        {
            try
            {
                _db.SetProcedure("sp_find_warehouse_organization_id");
                _db.SetParameter("@warehouse_id", warehouseId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["organization_id"];
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void SetParameters(Warehouse warehouse, int organizationId = 0, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@warehouse_id", warehouse.Id);
            }

            _db.SetParameter("@name", warehouse.Name);

            if (warehouse.Address != null)
            {
                _db.SetParameter("@address_id", warehouse.Address.Id);
            }
            else
            {
                _db.SetParameter("@address_id", DBNull.Value);
            }

            if (0 < organizationId)
            {
                _db.SetParameter("@organization_id", organizationId);
            }
        }

        private void ReadRow(Warehouse warehouse)
        {
            warehouse.Id = Convert.ToInt32(_db.Reader["warehouse_id"]);
            warehouse.ActivityStatus = Convert.ToBoolean(_db.Reader["activity_status"]);
            warehouse.Name = _db.Reader["name"].ToString();
            warehouse.Address = Helper.Instantiate<Address>(_db.Reader["address_id"]);
        }
    }
}
