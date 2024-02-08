using DAL;
using Entities;
using System;

namespace BLL
{
    public class PhonesManager
    {
        // ATTRIBUTES

        Database _database = new Database();
        CountriesManager _countriesManager = new CountriesManager();
        ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public void add(Phone phone)
        {
            try
            {
                _database.setQuery("INSERT INTO phones (PhoneNumber, CountryId, ProvinceId) VALUES (@PhoneNumber, @CountryId, @ProvinceId)");

                _database.setParameter("@PhoneNumber", phone.Number);
                _database.setParameter("@CountryId", phone.Country.CountryId);
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);

                _database.executeAction();

                _countriesManager.update(phone.Country);
                _provincesManager.update(phone.Province);
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

        public void edit(Phone phone)
        {
            try
            {
                _database.setQuery("UPDATE adresses SET PhoneNumber = @PhoneNumber, CountryId = @CountryId, ProvinceId = @ProvinceId WHERE PhoneId = @PhoneId");

                _database.setParameter("@PhoneId", phone.PhoneId);
                _database.setParameter("@PhoneNumber", phone.Number);
                _database.setParameter("@CountryId", phone.Country.CountryId);
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);

                _database.executeAction();

                _countriesManager.edit(phone.Country);
                _provincesManager.edit(phone.Province);
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

        public void delete(Phone phone)
        {
            try
            {
                _database.setQuery("DELETE FROM phones WHERE PhoneId = @PhoneId");
                _database.setParameter("@PhoneId", phone.PhoneId);
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

        public void readPhone(Phone phone, int phoneId)
        {
            _database.setQuery($"SELECT PhoneNumber, CountryId, ProvinceId FROM phones WHERE PhoneId = {phoneId}");
            _database.executeReader();

            phone.Number = (int)_database.Reader["PhoneNumber"];
            phone.Country.CountryId = (int)_database.Reader["CountryId"];
            phone.Province.ProvinceId = (int)_database.Reader["ProvinceId"];
        }
    }
}
