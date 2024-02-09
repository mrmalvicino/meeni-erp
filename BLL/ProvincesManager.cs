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

        public List<Province> listProvinces()
        {
            List<Province> provincesList = new List<Province>();

            try
            {
                _database.setQuery("SELECT ProvinceId, ProvinceName, ProvincePhoneAreaCode FROM provinces");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Province province = new Province();

                    province.ProvinceId = (int)_database.Reader["ProvinceId"];
                    province.Name = (string)_database.Reader["ProvinceName"];
                    province.PhoneAreaCode = (int)_database.Reader["ProvincePhoneAreaCode"];

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
