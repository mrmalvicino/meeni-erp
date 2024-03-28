using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class CategoriesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Country> list()
        {
            List<Country> countriesList = new List<Country>();

            try
            {
                _database.setQuery("select CountryId, CountryName from Countries");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Country country = new Country();

                    country.CountryId = Convert.ToInt32(_database.Reader["CountryId"]);
                    country.Name = (string)_database.Reader["CountryName"];

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
                _database.setQuery("insert into Countries (CountryName) values (@CountryName)");
                setParameters(country);
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

        public void edit(Country country)
        {
            try
            {
                _database.setQuery("update Countries set CountryName = @CountryName where CountryId = @CountryId");
                _database.setParameter("@CountryId", country.CountryId);
                setParameters(country);
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

        public int getId(Country country)
        {
            if (country == null)
            {
                return 0;
            }

            int countryId = 0;

            try
            {
                _database.setQuery("select CountryId from Countries where CountryName = @CountryName");
                _database.setParameter("@CountryName", country.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    countryId = Convert.ToInt32(_database.Reader["CountryId"]);
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

            return countryId;
        }

        private void setParameters(Country country)
        {
            if (Validations.hasData(country.Name))
            {
                _database.setParameter("@CountryName", country.Name);
            }
            else
            {
                _database.setParameter("@CountryName", DBNull.Value);
            }
        }
    }
}
