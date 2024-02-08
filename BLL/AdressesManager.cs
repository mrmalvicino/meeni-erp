using DAL;
using Entities;
using System;

namespace BLL
{
    public class AdressesManager
    {
        // ATTRIBUTES

        Database _database = new Database();
        CountriesManager _countriesManager = new CountriesManager();
        ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public void add(Adress adress)
        {
            try
            {
                _database.setQuery("INSERT INTO adresses (AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId) VALUES (@AdressCity, @AdressZipCode, @AdressStreetName, @AdressStreetNumber, @AdressFlat, @CountryId, @ProvinceId)");

                _database.setParameter("@AdressCity", adress.City);
                _database.setParameter("@AdressZipCode", adress.ZipCode);
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

        public void readAdress(Adress adress, int adressId)
        {
            _database.setQuery($"SELECT AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId FROM adresses WHERE AdressId = {adressId}");
            _database.executeReader();

            adress.City = (string)_database.Reader["AdressCity"];
            adress.ZipCode = (string)_database.Reader["AdressZipCode"];
            adress.StreetName = (string)_database.Reader["AdressStreetName"];
            adress.StreetNumber = (int)_database.Reader["AdressStreetNumber"];
            adress.Flat = (string)_database.Reader["AdressFlat"];
            adress.Country.CountryId = (int)_database.Reader["CountryId"];
            adress.Province.ProvinceId = (int)_database.Reader["ProvinceId"];
        }
    }
}
