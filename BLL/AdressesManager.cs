using System;
using DAL;
using Entities;

namespace BLL
{
    public class AdressesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public Adress readAdress(int adressId)
        {
            Adress adress = new Adress();

            try
            {
                _database.setQuery(
                    "select " +
                    "A.StreetName, A.StreetNumber, A.Flat, A.Details, CI.CityName, CI.ZipCode, P.ProvinceName, CO.CountryName " +
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
                    adress.StreetName = (string)_database.Reader["StreetName"];
                    adress.StreetNumber = (int)_database.Reader["StreetNumber"];
                    if (!(_database.Reader["Flat"] is DBNull))
                        adress.Flat = (string)_database.Reader["Flat"];
                    if (!(_database.Reader["Details"] is DBNull))
                        adress.Details = (string)_database.Reader["Details"];
                    adress.City.Name = (string)_database.Reader["CityName"];
                    if (!(_database.Reader["ZipCode"] is DBNull))
                        adress.City.ZipCode = (string)_database.Reader["ZipCode"];
                    adress.Province.Name = (string)_database.Reader["ProvinceName"];
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
            try
            {
                _database.setQuery("INSERT INTO adresses (AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId) VALUES (@AdressCity, @AdressZipCode, @AdressStreetName, @AdressStreetNumber, @AdressFlat, @CountryId, @ProvinceId)");

                _database.setParameter("@AdressStreetName", adress.StreetName);
                _database.setParameter("@AdressStreetNumber", adress.StreetNumber);
                _database.setParameter("@AdressFlat", adress.Flat);
                _database.setParameter("@CountryId", adress.Country.CountryId);
                _database.setParameter("@ProvinceId", adress.Province.ProvinceId);

                _database.executeAction();

                _countriesManager.update(adress.Country);
                _provincesManager.update(adress.Province);
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
            try
            {
                _database.setQuery("UPDATE adresses SET AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreetName = @AdressStreetName, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, CountryId = @CountryId, ProvinceId = @ProvinceId WHERE AdressId = @AdressId");

                _database.setParameter("@AdressId", adress.AdressId);
                _database.setParameter("@AdressCity", adress.AdressId);
                _database.setParameter("@AdressZipCode", adress.AdressId);
                _database.setParameter("@AdressStreetName", adress.AdressId);
                _database.setParameter("@AdressStreetNumber", adress.AdressId);
                _database.setParameter("@AdressFlat", adress.AdressId);
                _database.setParameter("@CountryId", adress.Country.CountryId);
                _database.setParameter("@ProvinceId", adress.Province.ProvinceId);

                _database.executeAction();

                _countriesManager.edit(adress.Country);
                _provincesManager.edit(adress.Province);
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

        public void delete(Adress adress)
        {
            try
            {
                _database.setQuery("DELETE FROM adresses WHERE AdressId = @AdressId");
                _database.setParameter("@AdressId", adress.AdressId);
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
    }
}
