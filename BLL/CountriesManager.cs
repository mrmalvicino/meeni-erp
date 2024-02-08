using DAL;
using Entities;
using System;

namespace BLL
{
    public class CountriesManager
    {
        // ATTRIBUTES

        Database _database = new Database();

        // METHODS

        public void add(Country country)
        {

        }

        public void edit(Country country)
        {

        }

        public void delete(Country country)
        {
            try
            {
                _database.setQuery("DELETE FROM countries WHERE CountryId = @CountryId");
                _database.setParameter("@CountryId", country.CountryId);
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

        public void update(Country country)
        {
            // agrega si no existe, editar si existe
        }

        public void readCountry(Country country, int countryId)
        {
            _database.setQuery($"SELECT CountryName, CountryPhoneAreaCode, CurrencyId FROM countries WHERE CountryId = {countryId}");
            _database.executeReader();

            country.Name = (string)_database.Reader["CountryName"];
            country.PhoneAreaCode = (int)_database.Reader["CountryPhoneAreaCode"];
            country.Currency.CurrencyId = (int)_database.Reader["CurrencyId"];
        }
    }
}
