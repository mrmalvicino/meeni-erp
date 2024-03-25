﻿using System;
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
            phone.Country.CountryId = _countriesManager.getIdByCode(phone.Country);
            phone.Province.ProvinceId = _provincesManager.getIdByCode(phone.Province);

            if (phone.Country.CountryId == 0)
            {
                phone.Country.Name = "default_" + (Helper.getLastId("Individuals") + 1).ToString();
                phone.Country.Currency.CurrencyId = 1; // Modena por defecto
                _countriesManager.add(phone.Country);
                phone.Country.CountryId = Helper.getLastId("Countries");
            }

            if (phone.Province.ProvinceId == 0)
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

            phone.PhoneId = 0;

            try
            {
                _database.setQuery("select PhoneId from Phones where Number = @Number");
                _database.setParameter("@Number", phone.Number);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    phone.PhoneId = (int)_database.Reader["PhoneId"];
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

            return phone.PhoneId;
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
