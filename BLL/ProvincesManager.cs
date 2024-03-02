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

        public List<Province> list()
        {
            List<Province> provincesList = new List<Province>();

            try
            {
                _database.setQuery("select ProvinceId, ProvinceName, PhoneAreaCode from Provinces");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Province province = new Province();

                    province.ProvinceId = Convert.ToInt32(_database.Reader["ProvinceId"]);
                    province.Name = (string)_database.Reader["ProvinceName"];
                    province.PhoneAreaCode = (int)_database.Reader["PhoneAreaCode"];

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
