using DomainModel;
using Exceptions;
using System;

namespace DataAccess
{
    public class ProvincesDAL
    {
        private Database _db;

        public ProvincesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Province province, int countryId)
        {
            try
            {
                _db.SetProcedure("sp_create_province");
                SetParameters(province, countryId);
                province.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return province.Id;
        }

        public Province Read(int provinceId)
        {
            try
            {
                _db.SetQuery("select * from provinces where province_id = @province_id");
                _db.SetParameter("@province_id", provinceId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Province province = new Province();
                    ReadRow(province);
                    return province;
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

        public int FindId(Province province, int countryId)
        {
            try
            {
                _db.SetProcedure("sp_find_province_id");
                _db.SetParameter("@province_name", province.Name);
                _db.SetParameter("@country_id", countryId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["country_id"];
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

        public int FindId(City city)
        {
            try
            {
                _db.SetQuery("select province_id from cities where city_id = @city_id");
                _db.SetParameter("@city_id", city.Id);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["province_id"];
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

        private void SetParameters(Province province, int countryId, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@province_id", province.Id);
            }

            _db.SetParameter("@province_name", province.Name);
            _db.SetParameter("@country_id", countryId);
        }

        private void ReadRow(Province province)
        {
            province.Id = Convert.ToInt32(_db.Reader["province_id"]);
            province.Name = _db.Reader["province_name"].ToString();
        }
    }
}
