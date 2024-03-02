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

        public List<Country> list()
        {
            List<Country> countriesList = new List<Country>();

            try
            {
                _database.setQuery("select CountryId, CountryName, PhoneAreaCode from Countries");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Country country = new Country();

                    country.CountryId = Convert.ToInt32(_database.Reader["CountryId"]);
                    country.Name = (string)_database.Reader["CountryName"];
                    country.PhoneAreaCode = (int)_database.Reader["PhoneAreaCode"];

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
    }
}
