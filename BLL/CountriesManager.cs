using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CountriesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Country> listCountries()
        {
            List<Country> countriesList = new List<Country>();

            try
            {
                _database.setQuery("SELECT CountryId, CountryName, CountryPhoneAreaCode, CurrencyId FROM countries");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Country country = new Country();

                    country.CountryId = (int)_database.Reader["CountryId"];
                    country.Name = (string)_database.Reader["CountryName"];
                    country.PhoneAreaCode = (int)_database.Reader["CountryPhoneAreaCode"];
                    country.Currency.CurrencyId = (int)_database.Reader["CurrencyId"];

                    countriesList.Add(country);
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

            return countriesList;
        }

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
    }
}
