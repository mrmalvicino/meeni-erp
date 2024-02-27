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

        public Province readProvince(int provinceId)
        {
            Province province = new Province();

            try
            {
                _database.setQuery("select ProvinceName, PhoneAreaCode from Provinces where ProvinceId = @ProvinceId");
                _database.setParameter("@ProvinceId", provinceId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    province.ProvinceId = provinceId;
                    province.Name = (string)_database.Reader["ProvinceName"];
                    province.PhoneAreaCode = (int)_database.Reader["PhoneAreaCode"];
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

            return province;
        }

        public void add(Province province)
        {

        }

        public void edit(Province province)
        {

        }

        public void delete(Province province)
        {
            try
            {
                _database.setQuery("DELETE FROM provinces WHERE ProvinceId = @ProvinceId");
                _database.setParameter("@ProvinceId", province.ProvinceId);
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

        public void update(Province province)
        {
            // agrega si no existe, editar si existe
        }
    }
}
