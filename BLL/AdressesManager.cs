using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class AdressesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public List<Adress> listAdresses()
        {
            List<Adress> adressesList = new List<Adress>();

            try
            {
                _database.setQuery("SELECT AdressId, AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId FROM adresses");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Adress adress = new Adress();

                    adress.AdressId = (int)_database.Reader["AdressId"];
                    adress.StreetName = (string)_database.Reader["AdressStreetName"];
                    adress.StreetNumber = (int)_database.Reader["AdressStreetNumber"];
                    adress.Flat = (string)_database.Reader["AdressFlat"];

                    adressesList.Add(adress);
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

            foreach (Adress a in adressesList)
            {
                foreach (Country c in _countriesManager.listCountries())
                {
                    if (a.Country.CountryId == c.CountryId)
                    {
                        a.Country.Name = c.Name;
                    }
                }

                foreach (Province p in _provincesManager.listProvinces())
                {
                    if (a.Province.ProvinceId == p.ProvinceId)
                    {
                        a.Province.Name = p.Name;
                    }
                }
            }

            return adressesList;
        }

        public void add(Adress adress)
        {
            try
            {
                _database.setQuery("INSERT INTO adresses (AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId) VALUES (@AdressCity, @AdressZipCode, @AdressStreetName, @AdressStreetNumber, @AdressFlat, @CountryId, @ProvinceId)");

                _database.setParameter("@AdressStreetName", adress.StreetName);
                _database.setParameter("@AdressStreetNumber", adress.StreetNumber);
                _database.setParameter("@AdressFlat", adress.Flat);
                _database.setParameter("@CountryId", adress.Country.CountryId);
                _database.setParameter("@ProvinceId", adress.Province.ProvinceId);

                _database.executeAction();

                _countriesManager.update(adress.Country);
                _provincesManager.update(adress.Province);
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

        public void edit(Adress adress)
        {
            try
            {
                _database.setQuery("UPDATE adresses SET AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreetName = @AdressStreetName, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, CountryId = @CountryId, ProvinceId = @ProvinceId WHERE AdressId = @AdressId");

                _database.setParameter("@AdressId", adress.AdressId);
                _database.setParameter("@AdressCity", adress.AdressId);
                _database.setParameter("@AdressZipCode", adress.AdressId);
                _database.setParameter("@AdressStreetName", adress.AdressId);
                _database.setParameter("@AdressStreetNumber", adress.AdressId);
                _database.setParameter("@AdressFlat", adress.AdressId);
                _database.setParameter("@CountryId", adress.Country.CountryId);
                _database.setParameter("@ProvinceId", adress.Province.ProvinceId);

                _database.executeAction();

                _countriesManager.edit(adress.Country);
                _provincesManager.edit(adress.Province);
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

        public void delete(Adress adress)
        {
            try
            {
                _database.setQuery("DELETE FROM adresses WHERE AdressId = @AdressId");
                _database.setParameter("@AdressId", adress.AdressId);
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
