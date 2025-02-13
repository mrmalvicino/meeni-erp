using DomainModel.Products;
using Exceptions;
using System;
using System.Collections.Generic;

namespace DataAccess.Products
{
    public class BrandsDAL
    {
        private Database _db;

        public BrandsDAL(Database db)
        {
            _db = db;
        }

        public int Create(Brand brand, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_create_brand");
                SetParameters(brand, organizationId);
                brand.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return brand.Id;
        }

        public Brand Read(int brandId)
        {
            try
            {
                _db.SetQuery("select * from brands where brand_id = @brand_id");
                _db.SetParameter("@brand_id", brandId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Brand brand = new Brand();
                    ReadRow(brand);
                    return brand;
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

        public void Update(Brand brand)
        {
            try
            {
                _db.SetProcedure("sp_update_brand");
                SetParameters(brand, 0, true);
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

        public void Toggle(int brandId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_brand");
                _db.SetParameter("@brand_id", brandId);
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

        public List<Brand> List(int organizationId, bool active, bool inactive)
        {
            List<Brand> brands = new List<Brand>();

            try
            {
                _db.SetProcedure("sp_list_brands");
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Brand brand = new Brand();
                    ReadRow(brand);
                    brands.Add(brand);
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

            return brands;
        }

        public int FindId(Brand brand, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_find_brand_id");
                _db.SetParameter("@name", brand.Name);
                _db.SetParameter("@organization_id", organizationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["brand_id"];
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

        private void SetParameters(Brand brand, int organizationId = 0, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@brand_id", brand.Id);
            }

            _db.SetParameter("@name", brand.Name);

            if (0 < organizationId)
            {
                _db.SetParameter("@organization_id", organizationId);
            }
        }

        private void ReadRow(Brand brand)
        {
            brand.Id = Convert.ToInt32(_db.Reader["brand_id"]);
            brand.ActivityStatus = Convert.ToBoolean(_db.Reader["activity_status"]);
            brand.Name = _db.Reader["name"].ToString();
        }
    }
}
