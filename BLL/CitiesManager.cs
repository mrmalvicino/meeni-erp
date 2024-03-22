﻿using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CitiesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<City> list(int provinceId = 0)
        {
            List<City> citiesList = new List<City>();
            string query = "select CityId, CityName, ZipCode from Cities";

            if (0 < provinceId)
            {
                query += " where ProvinceId = @ProvinceId";
                _database.setParameter("@ProvinceId", provinceId);
            }

            try
            {
                _database.setQuery(query);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    City city = new City();

                    city.CityId = Convert.ToInt32(_database.Reader["CityId"]);
                    city.Name = (string)_database.Reader["CityName"];

                    if (!(_database.Reader["ZipCode"] is DBNull))
                    {
                        city.ZipCode = (string)_database.Reader["ZipCode"];
                    }

                    citiesList.Add(city);
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

            return citiesList;
        }

        public void add(City city, int provinceId)
        {
            try
            {
                _database.setQuery("insert into Cities (CityName, ZipCode, ProvinceId) values (@CityName, @ZipCode, @ProvinceId)");
                _database.setParameter("@CityName", city.Name);
                _database.setParameter("@ZipCode", city.ZipCode);
                _database.setParameter("@ProvinceId", provinceId);
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

        public void edit(City city, int provinceId)
        {
            try
            {
                _database.setQuery("update Cities set CityName = @CityName, ZipCode = @ZipCode, ProvinceId = @ProvinceId where CityId = @CityId");
                _database.setParameter("@CityId", city.CityId);
                _database.setParameter("@CityName", city.Name);
                _database.setParameter("@ZipCode", city.ZipCode);
                _database.setParameter("@ProvinceId", provinceId);
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

        public int getId(City city)
        {
            try
            {
                _database.setQuery("select CityId from Cities where CityName = @CityName");
                _database.setParameter("@CityName", city.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    city.CityId = Convert.ToInt32(_database.Reader["CityId"]);
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

            return city.CityId;
        }
    }
}
