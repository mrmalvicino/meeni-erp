using DomainModel.Inventory;
using DomainModel.Products;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.Inventory
{
    public class CompartmentsDAL
    {
        private Database _db;

        public CompartmentsDAL(Database db)
        {
            _db = db;
        }

        public int Create(Compartment compartment, int warehouseId)
        {
            try
            {
                _db.SetProcedure("sp_create_compartment");
                SetParameters(compartment, warehouseId);
                compartment.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return compartment.Id;
        }

        public Compartment Read(int compartmentId)
        {
            try
            {
                _db.SetQuery("select * from compartments where compartment_id = @compartment_id");
                _db.SetParameter("@compartment_id", compartmentId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Compartment compartment = new Compartment();
                    ReadRow(compartment);
                    return compartment;
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

        public void Update(Compartment compartment)
        {
            try
            {
                _db.SetProcedure("sp_update_compartment");
                SetParameters(compartment, 0, true);
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

        public void Toggle(int compartmentId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_compartment");
                _db.SetParameter("@compartment_id", compartmentId);
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

        public List<Compartment> List(int warehouseId, bool active, bool inactive)
        {
            List<Compartment> compartments = new List<Compartment>();

            try
            {
                _db.SetProcedure("sp_list_compartments");
                _db.SetParameter("@warehouse_id", warehouseId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Compartment compartment = new Compartment();
                    ReadRow(compartment);
                    compartments.Add(compartment);
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

            return compartments;
        }

        private void SetParameters(Compartment compartment, int warehouseId = 0, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@compartment_id", compartment.Id);
            }

            _db.SetParameter("@name", compartment.Name);
            _db.SetParameter("@stock", compartment.Stock);
            _db.SetParameter("@product_id", compartment.Product.Id);

            if (0 < warehouseId)
            {
                _db.SetParameter("@warehouse_id", warehouseId);
            }
        }

        private void ReadRow(Compartment compartment)
        {
            compartment.Id = Convert.ToInt32(_db.Reader["compartment_id"]);
            compartment.ActivityStatus = Convert.ToBoolean(_db.Reader["activity_status"]);
            compartment.Name = _db.Reader["name"].ToString();
            compartment.Stock = Convert.ToInt32(_db.Reader["stock"]);
            compartment.Product = Helper.Instantiate<Product>(_db.Reader["product_id"]);
        }
    }
}
