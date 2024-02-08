using DAL;
using Entities;
using System;

namespace BLL
{
    public class ProvincesManager
    {
        // ATTRIBUTES

        Database _database = new Database();

        // METHODS

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

        public void readProvince(Province province, int provinceId)
        {
            _database.setQuery($"SELECT ProvinceName, ProvincePhoneAreaCode FROM provinces WHERE ProvinceId = {provinceId}");
            _database.executeReader();

            province.Name = (string)_database.Reader["ProvinceName"];
            province.PhoneAreaCode = (int)_database.Reader["ProvincePhoneAreaCode"];
        }
    }
}
