using DAL;
using Entities;
using System;

namespace BLL
{
    public class AdressesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();
        private CitiesManager _citiesManager = new CitiesManager();

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
            adress.Country.CountryId = _countriesManager.getIdByName(adress.Country);
            adress.Province.ProvinceId = _provincesManager.getIdByName(adress.Province);
            adress.City.CityId = _citiesManager.getId(adress.City);

            if (adress.Country.CountryId == 0)
            {
                adress.Country.PhoneAreaCode = "default_" + (Functions.getLastId("Individuals") + 1).ToString();
                adress.Country.Currency.CurrencyId = 1; // Modena por defecto
                _countriesManager.add(adress.Country);
                adress.Country.CountryId = Functions.getLastId("Countries");
            }

            if (adress.Province.ProvinceId == 0)
            {
                adress.Province.PhoneAreaCode = "default_" + (Functions.getLastId("Individuals") + 1).ToString();
                _provincesManager.add(adress.Province, adress.Country.CountryId);
                adress.Province.ProvinceId = Functions.getLastId("Provinces");
            }

            if (adress.City.CityId == 0)
            {
                _citiesManager.add(adress.City, adress.Province.ProvinceId);
                adress.City.CityId = Functions.getLastId("Cities");
            }

            try
            {
                _database.setQuery("insert into Adresses (StreetName, StreetNumber, Flat, Details, CityId) values (@StreetName, @StreetNumber, @Flat, @Details, @CityId)");
                _database.setParameter("@StreetName", adress.StreetName);
                _database.setParameter("@StreetNumber", adress.StreetNumber);
                _database.setParameter("@Flat", adress.Flat);
                _database.setParameter("@Details", adress.Details);
                _database.setParameter("@CityId", adress.City.CityId);
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
            int dbProvinceId = _provincesManager.getIdByName(adress.Province);
            int dbCityId = _citiesManager.getId(adress.City);

            if (dbCountryId == adress.Country.CountryId)
            {
                adress.Country.PhoneAreaCode = "default_" + (Functions.getLastId("Individuals") + 1).ToString();
                adress.Country.Currency.CurrencyId = 1; // Modena por defecto
                _countriesManager.edit(adress.Country);
            }
            else if (dbCountryId == 0)
            {
                adress.Country.PhoneAreaCode = "default_" + (Functions.getLastId("Individuals") + 1).ToString();
                adress.Country.Currency.CurrencyId = 1; // Modena por defecto
                _countriesManager.add(adress.Country);
                adress.Country.CountryId = Functions.getLastId("Countries");
            }
            else
            {
                adress.Country.CountryId = dbCountryId;
            }

            if (dbProvinceId == adress.Province.ProvinceId)
            {
                adress.Province.PhoneAreaCode = "default_" + (Functions.getLastId("Individuals") + 1).ToString();
                _provincesManager.edit(adress.Province, adress.Country.CountryId);
            }
            else if (dbProvinceId == 0)
            {
                adress.Province.PhoneAreaCode = "default_" + (Functions.getLastId("Individuals") + 1).ToString();
                _provincesManager.add(adress.Province, adress.Country.CountryId);
                adress.Province.ProvinceId = Functions.getLastId("Provinces");
            }
            else
            {
                adress.Province.ProvinceId = dbProvinceId;
            }

            if (dbCityId == adress.City.CityId)
            {
                _citiesManager.edit(adress.City, adress.Province.ProvinceId);
            }
            else if (dbCityId == 0)
            {
                _citiesManager.add(adress.City, adress.Province.ProvinceId);
                adress.City.CityId = Functions.getLastId("Cities");
            }
            else
            {
                adress.City.CityId = dbCityId;
            }

            try
            {
                _database.setQuery("update Adresses set StreetName = @StreetName, StreetNumber = @StreetNumber, Flat = @Flat, Details = @Details, CityId = @CityId where AdressId = @AdressId");
                _database.setParameter("@AdressId", adress.AdressId);
                _database.setParameter("@StreetName", adress.StreetName);
                _database.setParameter("@StreetNumber", adress.StreetNumber);
                _database.setParameter("@Flat", adress.Flat);
                _database.setParameter("@Details", adress.Details);
                _database.setParameter("@CityId", adress.City.CityId);
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
            adress.AdressId = 0;

            try
            {
                _database.setQuery("select AdressId from Adresses where StreetName = @StreetName and StreetNumber = @StreetNumber and CityId = @CityId");
                _database.setParameter("@StreetName", adress.StreetName);
                _database.setParameter("@StreetNumber", adress.StreetNumber);
                _database.setParameter("@CityId", adress.City.CityId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    adress.AdressId = (int)_database.Reader["AdressId"];
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

            return adress.AdressId;
        }
    }
}
