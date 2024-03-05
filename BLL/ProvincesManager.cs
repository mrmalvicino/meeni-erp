using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ProvincesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Province> list(int countryId = 0)
        {
            List<Province> provincesList = new List<Province>();
            string query = "select ProvinceId, ProvinceName, PhoneAreaCode from Provinces";

            if (0 < countryId)
            {
                query += " where CountryId = @CountryId";
                _database.setParameter("@CountryId", countryId);
            }

            try
            {
                _database.setQuery(query);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Province province = new Province();

                    province.ProvinceId = Convert.ToInt32(_database.Reader["ProvinceId"]);
                    province.Name = (string)_database.Reader["ProvinceName"];
                    province.PhoneAreaCode = (string)_database.Reader["PhoneAreaCode"];

                    provincesList.Add(province);
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

            return provincesList;
        }
    }
}
