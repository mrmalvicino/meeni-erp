using Entities;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class IndividualsManager
    {
        // ATTRIBUTES

        protected Database _database = new Database();
        private PhonesManager _phonesManager = new PhonesManager();
        private AdressesManager _adressesManager = new AdressesManager();
        private TaxCodesManager _taxCodesManager = new TaxCodesManager();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();

        // METHODS

        public List<Individual> listIndividuals()
        {
            List<Individual> individualsList = new List<Individual>();

            try
            {
                _database.setQuery("SELECT IndividualId, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneId, AdressId, TaxCodeId FROM individuals");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Individual individual= new Individual();

                    individual.IndividualId = (int)_database.Reader["IndividualId"];
                    individual.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    individual.IsPerson = (bool)_database.Reader["IsPerson"];
                    individual.FirstName = (string)_database.Reader["FirstName"];
                    individual.LastName = (string)_database.Reader["LastName"];
                    individual.BusinessName = (string)_database.Reader["BusinessName"];
                    individual.BusinessDescription = (string)_database.Reader["BusinessDescription"];
                    individual.ImageUrl = (string)_database.Reader["ImageUrl"];
                    individual.Email = (string)_database.Reader["Email"];
                    individual.Phone.PhoneId = (int)_database.Reader["PhoneId"];
                    individual.Adress.AdressId = (int)_database.Reader["AdressId"];
                    individual.TaxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];

                    individualsList.Add(individual);
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

            foreach (Individual i in individualsList)
            {
                foreach (Phone p in _phonesManager.listPhones())
                {
                    if (i.Phone.PhoneId == p.PhoneId)
                    {
                        i.Phone.Number = p.Number;
                        i.Phone.Country.CountryId = p.Country.CountryId;
                        i.Phone.Province.ProvinceId = p.Province.ProvinceId;

                        i.Phone.Country.PhoneAreaCode = p.Country.PhoneAreaCode;
                        i.Phone.Province.PhoneAreaCode = p.Province.PhoneAreaCode;
                    }
                }

                foreach (Adress a in _adressesManager.listAdresses())
                {
                    if (i.Adress.AdressId == a.AdressId)
                    {
                        i.Adress.City = a.City;
                        i.Adress.ZipCode = a.ZipCode;
                        i.Adress.StreetName = a.StreetName;
                        i.Adress.StreetNumber = a.StreetNumber;
                        i.Adress.Flat = a.Flat;
                        i.Adress.Country.CountryId = a.Country.CountryId;
                        i.Adress.Province.ProvinceId = a.Province.ProvinceId;

                        i.Adress.Country.Name = a.Country.Name;
                        i.Adress.Province.Name = a.Province.Name;
                    }
                }

                foreach (TaxCode t in _taxCodesManager.listTaxCodes())
                {
                    if (i.TaxCode.TaxCodeId == t.TaxCodeId)
                    {
                        i.TaxCode.Prefix = t.Prefix;
                        i.TaxCode.Number = t.Number;
                        i.TaxCode.Suffix = t.Suffix;
                    }
                }
            }

            return individualsList;
        }

        public void add(Individual individual)
        {
            try
            {
                _database.setQuery("INSERT INTO individuals (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneId, AdressId, TaxCodeId) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneId, @AdressId, @TaxCodeId)");

                _database.setParameter("@ActiveStatus", individual.ActiveStatus);
                _database.setParameter("@IsPerson", individual.IsPerson);
                _database.setParameter("@FirstName", individual.FirstName);
                _database.setParameter("@LastName", individual.LastName);
                _database.setParameter("@BusinessName", individual.BusinessName);
                _database.setParameter("@BusinessDescription", individual.BusinessDescription);
                _database.setParameter("@ImageUrl", individual.ImageUrl);
                _database.setParameter("@Email", individual.Email);
                _database.setParameter("@PhoneId", individual.Phone.PhoneId);
                _database.setParameter("@AdressId", individual.Adress.AdressId);
                _database.setParameter("@TaxCodeId", individual.TaxCode.TaxCodeId);

                _database.executeAction();

                _phonesManager.add(individual.Phone);
                _adressesManager.add(individual.Adress);
                _taxCodesManager.add(individual.TaxCode);
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

        public void edit(Individual individual)
        {
            try
            {
                _database.setQuery("UPDATE customers SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneId = @PhoneId, AdressId = @AdressId, TaxCodeId = @TaxCodeId WHERE IndividualId = @IndividualId");

                _database.setParameter("@IndividualId", individual.IndividualId);
                _database.setParameter("@ActiveStatus", individual.ActiveStatus);
                _database.setParameter("@IsPerson", individual.IsPerson);
                _database.setParameter("@FirstName", individual.FirstName);
                _database.setParameter("@LastName", individual.LastName);
                _database.setParameter("@BusinessName", individual.BusinessName);
                _database.setParameter("@BusinessDescription", individual.BusinessDescription);
                _database.setParameter("@ImageUrl", individual.ImageUrl);
                _database.setParameter("@Email", individual.Email);
                _database.setParameter("@PhoneId", individual.Phone.PhoneId);
                _database.setParameter("@AdressId", individual.Adress.AdressId);
                _database.setParameter("@TaxCodeId", individual.TaxCode.TaxCodeId);

                _database.executeAction();

                _phonesManager.edit(individual.Phone);
                _adressesManager.edit(individual.Adress);
                _taxCodesManager.edit(individual.TaxCode);
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

        public void delete(Individual individual)
        {
            try
            {
                _database.setQuery("DELETE FROM individuals WHERE IndividualId = @IndividualId");
                _database.setParameter("@IndividualId", individual.IndividualId);
                _database.executeAction();

                _phonesManager.delete(individual.Phone);
                _adressesManager.delete(individual.Adress);
                _taxCodesManager.delete(individual.TaxCode);
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
