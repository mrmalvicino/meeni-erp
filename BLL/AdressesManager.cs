using System;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class AdressesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();
        private CitiesManager _citiesManager = new CitiesManager();

        // PROPERTIES

        public string Default { get; set; }

        // METHODS

        public Adress read(int adressId)
        {
            Adress adress = new Adress();

            try
            {
                _database.setQuery(
                    "select " +
                    "A.AdressId, A.StreetName, A.StreetNumber, A.Flat, A.Details, A.CityId, " +
                    "CI.CityName, CI.ZipCode, CI.ProvinceId, " +
                    "P.ProvinceName, P.CountryId, CO.CountryName " +
                    "from Adresses A " +
                    "inner join Cities CI on A.CityId = CI.CityId " +
                    "inner join Provinces P on CI.ProvinceId = P.ProvinceId " +
                    "inner join Countries CO on P.CountryId = CO.CountryId " +
                    "where AdressId = @AdressId"
                );
                _database.setParameter("@AdressId", adressId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    adress.AdressId = (int)_database.Reader["AdressId"];
                    adress.StreetName = (string)_database.Reader["StreetName"];
                    adress.StreetNumber = (string)_database.Reader["StreetNumber"];

                    if (!(_database.Reader["Flat"] is DBNull))
                    {
                        adress.Flat = (string)_database.Reader["Flat"];
                    }

                    if (!(_database.Reader["Details"] is DBNull))
                    {
                        adress.Details = (string)_database.Reader["Details"];
                    }

                    adress.City.CityId = Convert.ToInt32(_database.Reader["CityId"]);
                    adress.City.Name = (string)_database.Reader["CityName"];

                    if (!(_database.Reader["ZipCode"] is DBNull))
                    {
                        adress.City.ZipCode = (string)_database.Reader["ZipCode"];
                    }

                    adress.Province.ProvinceId = Convert.ToInt32(_database.Reader["ProvinceId"]);
                    adress.Province.Name = (string)_database.Reader["ProvinceName"];
                    adress.Country.CountryId = Convert.ToInt32(_database.Reader["CountryId"]);
                    adress.Country.Name = (string)_database.Reader["CountryName"];
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

            return adress;
        }

        public void add(Adress adress)
        {
            int dbCountryId = _countriesManager.getIdByName(adress.Country);

            if (dbCountryId == 0)
            {
                adress.Country.PhoneAreaCode = Default;
                adress.Country.Currency.CurrencyId = 1;
                _countriesManager.add(adress.Country);
                adress.Country.CountryId = Helper.getLastId("Countries");
            }

            int dbProvinceId = _provincesManager.getIdByName(adress.Province);
            
            if (dbProvinceId == 0)
            {
                adress.Province.PhoneAreaCode = Default;
                _provincesManager.add(adress.Province, adress.Country.CountryId);
                adress.Province.ProvinceId = Helper.getLastId("Provinces");
            }

            int dbCityId = _citiesManager.getId(adress.City);

            if (dbCityId == 0)
            {
                _citiesManager.add(adress.City, adress.Province.ProvinceId);
                adress.City.CityId = Helper.getLastId("Cities");
            }

            try
            {
                _database.setQuery("insert into Adresses (StreetName, StreetNumber, Flat, Details, CityId) values (@StreetName, @StreetNumber, @Flat, @Details, @CityId)");
                setParameters(adress);
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

        public void edit(Adress adress)
        {
            int dbCountryId = _countriesManager.getIdByName(adress.Country);

            if (dbCountryId == 0)
            {
                adress.Country.PhoneAreaCode = Default;
                adress.Country.Currency.CurrencyId = 1;
                _countriesManager.add(adress.Country);
                adress.Country.CountryId = Helper.getLastId("Countries");
            }
            else if (dbCountryId == adress.Country.CountryId)
            {
                adress.Country.PhoneAreaCode = Default;
                adress.Country.Currency.CurrencyId = 1;
                _countriesManager.edit(adress.Country);
            }
            else
            {
                adress.Country.CountryId = dbCountryId;
            }

            int dbProvinceId = _provincesManager.getIdByName(adress.Province);

            if (dbProvinceId == 0)
            {
                adress.Province.PhoneAreaCode = Default;
                _provincesManager.add(adress.Province, adress.Country.CountryId);
                adress.Province.ProvinceId = Helper.getLastId("Provinces");
            }
            else if (dbProvinceId == adress.Province.ProvinceId)
            {
                adress.Province.PhoneAreaCode = Default;
                _provincesManager.edit(adress.Province, adress.Country.CountryId);
            }
            else
            {
                adress.Province.ProvinceId = dbProvinceId;
            }

            int dbCityId = _citiesManager.getId(adress.City);

            if (dbCityId == 0)
            {
                _citiesManager.add(adress.City, adress.Province.ProvinceId);
                adress.City.CityId = Helper.getLastId("Cities");
            }
            else if (dbCityId == adress.City.CityId)
            {
                _citiesManager.edit(adress.City, adress.Province.ProvinceId);
            }
            else
            {
                adress.City.CityId = dbCityId;
            }

            try
            {
                _database.setQuery("update Adresses set StreetName = @StreetName, StreetNumber = @StreetNumber, Flat = @Flat, Details = @Details, CityId = @CityId where AdressId = @AdressId");
                _database.setParameter("@AdressId", adress.AdressId);
                setParameters(adress);
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

        public int getId(Adress adress)
        {
            if (adress == null)
            {
                return 0;
            }

            int adressId = 0;

            try
            {
                _database.setQuery("select AdressId from Adresses where StreetName = @StreetName and StreetNumber = @StreetNumber and CityId = @CityId");
                _database.setParameter("@StreetName", adress.StreetName);
                _database.setParameter("@StreetNumber", adress.StreetNumber);
                _database.setParameter("@CityId", adress.City.CityId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    adressId = (int)_database.Reader["AdressId"];
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

            return adressId;
        }

        private void setParameters(Adress adress)
        {
            if (Validations.hasData(adress.StreetName))
            {
                _database.setParameter("@StreetName", adress.StreetName);
            }
            else
            {
                _database.setParameter("@StreetName", DBNull.Value);
            }

            if (Validations.hasData(adress.StreetNumber))
            {
                _database.setParameter("@StreetNumber", adress.StreetNumber);
            }
            else
            {
                _database.setParameter("@StreetNumber", DBNull.Value);
            }

            if (Validations.hasData(adress.Flat))
            {
                _database.setParameter("@Flat", adress.Flat);
            }
            else
            {
                _database.setParameter("@Flat", DBNull.Value);
            }

            if (Validations.hasData(adress.Details))
            {
                _database.setParameter("@Details", adress.Details);
            }
            else
            {
                _database.setParameter("@Details", DBNull.Value);
            }

            if (adress.City != null)
            {
                _database.setParameter("@CityId", adress.City.CityId);
            }
            else
            {
                _database.setParameter("@CityId", DBNull.Value);
            }
        }
    }
}
