using DomainModel;
using Exceptions;
using System;

namespace DataAccess
{
    public class CountriesDAL
    {
        private Database _db;

        public CountriesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Country country)
        {
            try
            {
                _db.SetProcedure("sp_create_country");
                SetParameters(country);
                country.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return country.Id;
        }

        public Country Read(int countryId)
        {
            try
            {
                _db.SetQuery("select * from countries where country_id = @country_id");
                _db.SetParameter("@country_id", countryId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Country country = new Country();
                    ReadRow(country);
                    return country;
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

        private void SetParameters(Country country, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@country_id", country.Id);
            }

            _db.SetParameter("@country_name", country.Name);
        }

        private void ReadRow(Country country)
        {
            country.Id = Convert.ToInt32(_db.Reader["country_id"]);
            country.Name = _db.Reader["country_name"].ToString();
        }
    }
}
