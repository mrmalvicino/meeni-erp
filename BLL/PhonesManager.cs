using System;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class PhonesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public Phone read(int phoneId)
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
            int dbCountryId = _countriesManager.getIdByCode(phone.Country);

            if (dbCountryId == 0)
            {
                phone.Country.Name = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                phone.Country.Currency.CurrencyId = 1; // Moneda por defecto
                _countriesManager.add(phone.Country);
                phone.Country.CountryId = Helper.getLastId("Countries");
            }

            int dbProvinceId = _provincesManager.getIdByCode(phone.Province);

            if (dbProvinceId == 0)
            {
                phone.Province.Name = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                _provincesManager.add(phone.Province, phone.Country.CountryId);
                phone.Province.ProvinceId = Helper.getLastId("Provinces");
            }

            try
            {
                _database.setQuery("insert into Phones (Number, ProvinceId) values (@Number, @ProvinceId)");
                setParameters(phone);
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
            int dbCountryId = _countriesManager.getIdByCode(phone.Country);

            if (dbCountryId == 0)
            {
                phone.Country.PhoneAreaCode = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                phone.Country.Currency.CurrencyId = 1; // Moneda por defecto
                _countriesManager.add(phone.Country);
                phone.Country.CountryId = Helper.getLastId("Countries");
            }
            else if (dbCountryId == phone.Country.CountryId)
            {
                phone.Country.PhoneAreaCode = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                phone.Country.Currency.CurrencyId = 1; // Moneda por defecto
                _countriesManager.edit(phone.Country);
            }
            else
            {
                phone.Country.CountryId = dbCountryId;
            }

            int dbProvinceId = _provincesManager.getIdByCode(phone.Province);

            if (dbProvinceId == 0)
            {
                phone.Province.PhoneAreaCode = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                _provincesManager.add(phone.Province, phone.Country.CountryId);
                phone.Province.ProvinceId = Helper.getLastId("Provinces");
            }
            else if (dbProvinceId == phone.Province.ProvinceId)
            {
                phone.Province.PhoneAreaCode = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                _provincesManager.edit(phone.Province, phone.Country.CountryId);
            }
            else
            {
                phone.Province.ProvinceId = dbProvinceId;
            }

            try
            {
                _database.setQuery("update Phones set Number = @Number, ProvinceId = @ProvinceId where PhoneId = @PhoneId");
                _database.setParameter("@PhoneId", phone.PhoneId);
                setParameters(phone);
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

        public int getId(Phone phone)
        {
            if (phone == null)
            {
                return 0;
            }

            int phoneId = 0;

            try
            {
                _database.setQuery("select PhoneId from Phones where Number = @Number");
                _database.setParameter("@Number", phone.Number);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    phoneId = (int)_database.Reader["PhoneId"];
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

            return phoneId;
        }

        private void setParameters(Phone phone)
        {
            if (Validations.hasData(phone.Number))
            {
                _database.setParameter("@Number", phone.Number);
            }
            else
            {
                _database.setParameter("@Number", DBNull.Value);
            }

            if (phone.Province != null)
            {
                _database.setParameter("@ProvinceId", phone.Province.ProvinceId);
            }
            else
            {
                _database.setParameter("@ProvinceId", DBNull.Value);
            }
        }
    }
}
