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
                    country.PhoneAreaCode = (string)_database.Reader["PhoneAreaCode"];

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
            try
            {
                _database.setQuery("insert into Countries (CountryName, PhoneAreaCode) values (@CountryName, @PhoneAreaCode)");
                _database.setParameter("@CountryName", country.Name);
                _database.setParameter("@PhoneAreaCode", country.PhoneAreaCode);
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

        public int getIdByName(Country country)
        {
            try
            {
                _database.setQuery("select CountryId from Countries where CountryName = @CountryName");
                _database.setParameter("@CountryName", country.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    country.CountryId = Convert.ToInt32(_database.Reader["CountryId"]);
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

            return country.CountryId;
        }

        public int getIdByCode(Country country)
        {
            try
            {
                _database.setQuery("select CountryId from Countries where PhoneAreaCode = @PhoneAreaCode");
                _database.setParameter("@PhoneAreaCode", country.PhoneAreaCode);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    country.CountryId = Convert.ToInt32(_database.Reader["CountryId"]);
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

            return country.CountryId;
        }
    }
}
