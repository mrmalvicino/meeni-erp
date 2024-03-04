using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class IndividualsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private TaxCodesManager _taxCodesManager = new TaxCodesManager();
        private AdressesManager _adressesManager = new AdressesManager();
        private PhonesManager _phonesManager = new PhonesManager();
        private PeopleManager _peopleManager = new PeopleManager();
        private OrganizationsManager _organizationsManager = new OrganizationsManager();

        // METHODS

        public Individual readIndividual(int individualId)
        {
            Individual individual = new Individual();

            try
            {
                _database.setQuery("select ActiveStatus, Email, Birth, TaxCodeId, AdressId, PhoneId, PersonId, OrganizationId from Individuals where IndividualId = @IndividualId");
                _database.setParameter("@IndividualId", individualId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    individual.IndividualId = individualId;
                    individual.ActiveStatus = (bool)_database.Reader["ActiveStatus"];

                    if (!(_database.Reader["Email"] is DBNull))
                        individual.Email = (string)_database.Reader["Email"];

                    if (!(_database.Reader["Birth"] is DBNull))
                        individual.Birth = (DateTime)_database.Reader["Birth"];

                    if (!(_database.Reader["TaxCodeId"] is DBNull))
                        individual.TaxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];

                    if (!(_database.Reader["AdressId"] is DBNull))
                        individual.Adress.AdressId = (int)_database.Reader["AdressId"];

                    if (!(_database.Reader["PhoneId"] is DBNull))
                        individual.Phone.PhoneId = (int)_database.Reader["PhoneId"];

                    if (!(_database.Reader["PersonId"] is DBNull))
                        individual.Person.PersonId = (int)_database.Reader["PersonId"];

                    if (!(_database.Reader["OrganizationId"] is DBNull))
                        individual.Organization.OrganizationId = (int)_database.Reader["OrganizationId"];
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

            individual.TaxCode = _taxCodesManager.readTaxCode(individual.TaxCode.TaxCodeId);
            individual.Adress = _adressesManager.readAdress(individual.Adress.AdressId);
            individual.Phone = _phonesManager.readPhone(individual.Phone.PhoneId);
            individual.Person = _peopleManager.readPerson(individual.Person.PersonId);
            individual.Organization = _organizationsManager.readOrganization(individual.Organization.OrganizationId);

            return individual;
        }
        
        public void add(Individual individual)
        {
            try
            {
                _database.setQuery("INSERT INTO individuals (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneId, AdressId, TaxCodeId) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneId, @AdressId, @TaxCodeId)");

                _database.setParameter("@ActiveStatus", individual.ActiveStatus);
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
