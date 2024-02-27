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
        private CurrenciesManager _currenciesManager = new CurrenciesManager();

        // METHODS

        public Country readCountry(int countryId)
        {
            Country country = new Country();

            try
            {
                _database.setQuery("select CountryName, PhoneAreaCode, CurrencyId from Countries");
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    country.CountryId = countryId;
                    country.Name = (string)_database.Reader["CountryName"];
                    country.PhoneAreaCode = (int)_database.Reader["PhoneAreaCode"];
                    country.Currency.CurrencyId = (int)_database.Reader["CurrencyId"];
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

            country.Currency = _currenciesManager.readCurrency(country.Currency.CurrencyId);

            return country;
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
