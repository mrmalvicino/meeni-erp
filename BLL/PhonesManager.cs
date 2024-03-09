using System;
using System.Reflection;
using DAL;
using Entities;

namespace BLL
{
    public class PhonesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public Phone readPhone(int phoneId)
        {
            Phone phone = new Phone();

            try
            {
                _database.setQuery(
                    "select " +
                    "PH.PhoneId, PH.Number, PR.PhoneAreaCode as ProvincePhoneAreaCode, C.PhoneAreaCode as CountryPhoneAreaCode " +
                    "from Phones PH " +
                    "inner join Provinces PR on PH.ProvinceId = PR.ProvinceId " +
                    "inner join Countries C on PR.CountryId = C.CountryId " +
                    "where PhoneId = @PhoneId"
                );
                _database.setParameter("@PhoneId", phoneId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    phone.PhoneId = (int)_database.Reader["PhoneId"];
                    phone.Number = (string)_database.Reader["Number"];
                    phone.Province.PhoneAreaCode = (string)_database.Reader["ProvincePhoneAreaCode"];
                    phone.Country.PhoneAreaCode = (string)_database.Reader["CountryPhoneAreaCode"];
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

            return phone;
        }

        public void add(Phone phone)
        {
            try
            {
                _database.setQuery("insert into Phones (Number, ProvinceId) values (@Number, @ProvinceId)");
                _database.setParameter("@PhoneNumber", phone.Number);
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);
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

        public void edit(Phone phone)
        {
            try
            {
                _database.setQuery("update Phones set Number = @Number, ProvinceId = @ProvinceId where PhoneId = @PhoneId");
                _database.setParameter("@PhoneId", phone.PhoneId);
                _database.setParameter("@Number", phone.Number);
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);
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

        public void delete(Phone phone)
        {
            try
            {
                _database.setQuery("delete from Phones where PhoneId = @PhoneId");
                _database.setParameter("@PhoneId", phone.PhoneId);
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
    }
}
