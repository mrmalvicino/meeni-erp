using System;
using System.Collections.Generic;
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

        public List<Phone> listPhones()
        {
            List<Phone> phonesList = new List<Phone>();

            try
            {
                _database.setQuery("SELECT PhoneId, PhoneNumber, CountryId, ProvinceId FROM phones");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Phone phone = new Phone();

                    phone.PhoneId = (int)_database.Reader["PhoneId"];
                    phone.Number = (int)_database.Reader["PhoneNumber"];
                    phone.Country.CountryId = (int)_database.Reader["CountryId"];
                    phone.Province.ProvinceId = (int)_database.Reader["ProvinceId"];

                    phonesList.Add(phone);
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

            foreach (Phone ph in phonesList)
            {
                foreach (Country c in _countriesManager.listCountries())
                {
                    if (ph.Country.CountryId == c.CountryId)
                    {
                        ph.Country.PhoneAreaCode = c.PhoneAreaCode;
                    }
                }

                foreach (Province pr in _provincesManager.listProvinces())
                {
                    if (ph.Province.ProvinceId == pr.ProvinceId)
                    {
                        ph.Province.PhoneAreaCode = pr.PhoneAreaCode;
                    }
                }
            }

            return phonesList;
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

                _countriesManager.update(phone.Country);
                _provincesManager.update(phone.Province);
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

                _countriesManager.edit(phone.Country);
                _provincesManager.edit(phone.Province);
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

        public Phone readPhone(int phoneId)
        {
            _database.setQuery($"SELECT PhoneNumber, CountryId, ProvinceId FROM phones WHERE PhoneId = {phoneId}");
            _database.executeReader();

            Phone phone = new Phone();

            if (_database.Reader.Read())
            {
                phone.Number = (int)_database.Reader["PhoneNumber"];
                phone.Country.CountryId = (int)_database.Reader["CountryId"];
                phone.Province.ProvinceId = (int)_database.Reader["ProvinceId"];                
            }

            return phone;
        }
    }
}
