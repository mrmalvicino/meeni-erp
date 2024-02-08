using Entities;
using DAL;
using System;

namespace BLL
{
    public class IndividualsManager
    {
        // ATTRIBUTES

        protected Database _database = new Database();
        private PhonesManager _phonesManager = new PhonesManager();
        private AdressesManager _adressesManager = new AdressesManager();
        private TaxCodesManager _taxCodesManager = new TaxCodesManager();

        // METHODS

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

        public void readIndividual(Individual individual, int individualId)
        {
            _database.setQuery($"SELECT ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneId, AdressId, TaxCodeId FROM individuals WHERE IndividualId = {individualId}");
            _database.executeReader();

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
        }
    }
}
