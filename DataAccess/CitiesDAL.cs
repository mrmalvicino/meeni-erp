using DomainModel;
using Exceptions;
using System;

namespace DataAccess
{
    public class CitiesDAL
    {
        private Database _db;

        public CitiesDAL(Database db)
        {
            _db = db;
        }

        public int Create(City city, int provinceId)
        {
            try
            {
                _db.SetProcedure("sp_create_city");
                SetParameters(city, provinceId);
                city.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return city.Id;
        }

        public City Read(int cityId)
        {
            try
            {
                _db.SetQuery("select * from cities where city_id = @city_id");
                _db.SetParameter("@city_id", cityId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    City city = new City();
                    ReadRow(city);
                    return city;
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

        public int FindId(City city, int provinceId)
        {
            try
            {
                _db.SetProcedure("sp_find_city_id");
                _db.SetParameter("@city_name", city.Name);
                _db.SetParameter("@province_id", provinceId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["city_id"];
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

        private void SetParameters(City city, int provinceId, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@city_id", city.Id);
            }

            _db.SetParameter("@city_name", city.Name);

            if (city.ZipCode != null)
            {
                _db.SetParameter("@zip_code", city.ZipCode);
            }
            else
            {
                _db.SetParameter("@zip_code", DBNull.Value);
            }

            _db.SetParameter("@province_id", provinceId);
        }

        private void ReadRow(City city)
        {
            city.Id = Convert.ToInt32(_db.Reader["city_id"]);
            city.Name = _db.Reader["city_name"].ToString();
            city.ZipCode = _db.Reader["zip_code"]?.ToString();
        }
    }
}
