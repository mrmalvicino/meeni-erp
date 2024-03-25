using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

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

        public void add(Province province, int countryId)
        {
            try
            {
                _database.setQuery("insert into Provinces (ProvinceName, PhoneAreaCode, CountryId) values (@ProvinceName, @PhoneAreaCode, @CountryId)");
                setParameters(province, countryId);
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

        public void edit(Province province, int countryId)
        {
            try
            {
                _database.setQuery("update Provinces set ProvinceName = @ProvinceName, PhoneAreaCode = @PhoneAreaCode, CountryId = @CountryId where ProvinceId = @ProvinceId");
                _database.setParameter("@ProvinceId", province.ProvinceId);
                setParameters(province, countryId);
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

        public int getIdByName(Province province)
        {
            if (province == null)
            {
                return 0;
            }

            province.ProvinceId = 0;

            try
            {
                _database.setQuery("select ProvinceId from Provinces where ProvinceName = @ProvinceName");
                _database.setParameter("@ProvinceName", province.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    province.ProvinceId = Convert.ToInt32(_database.Reader["ProvinceId"]);
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

            return province.ProvinceId;
        }

        public int getIdByCode(Province province)
        {
            if (province == null)
            {
                return 0;
            }

            province.ProvinceId = 0;

            try
            {
                _database.setQuery("select ProvinceId from Provinces where PhoneAreaCode = @PhoneAreaCode");
                _database.setParameter("@PhoneAreaCode", province.PhoneAreaCode);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    province.ProvinceId = Convert.ToInt32(_database.Reader["ProvinceId"]);
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

            return province.ProvinceId;
        }

        private void setParameters(Province province, int countryId)
        {
            if (Validations.hasData(province.Name))
            {
                _database.setParameter("@ProvinceName", province.Name);
            }
            else
            {
                _database.setParameter("@ProvinceName", DBNull.Value);
            }

            if (Validations.hasData(province.PhoneAreaCode))
            {
                _database.setParameter("@PhoneAreaCode", province.PhoneAreaCode);
            }
            else
            {
                _database.setParameter("@PhoneAreaCode", DBNull.Value);
            }

            if (0 < countryId)
            {
                _database.setParameter("@CountryId", countryId);
            }
            else
            {
                _database.setParameter("@CountryId", DBNull.Value);
            }            
        }
    }
}
