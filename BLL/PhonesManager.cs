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
                _database.setQuery("INSERT INTO phones (PhoneNumber, CountryId, ProvinceId) VALUES (@PhoneNumber, @CountryId, @ProvinceId)");

                _database.setParameter("@PhoneNumber", phone.Number);
                _database.setParameter("@CountryId", phone.Country.CountryId);
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);

                _database.executeAction();

                //_countriesManager.update(phone.Country);
                //_provincesManager.update(phone.Province);
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
                _database.setQuery("UPDATE adresses SET PhoneNumber = @PhoneNumber, CountryId = @CountryId, ProvinceId = @ProvinceId WHERE PhoneId = @PhoneId");

                _database.setParameter("@PhoneId", phone.PhoneId);
                _database.setParameter("@PhoneNumber", phone.Number);
                _database.setParameter("@CountryId", phone.Country.CountryId);
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);

                _database.executeAction();

                //_countriesManager.edit(phone.Country);
                //_provincesManager.edit(phone.Province);
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
                _database.setQuery("DELETE FROM phones WHERE PhoneId = @PhoneId");
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
