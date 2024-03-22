using DAL;
using Entities;
using System;

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

        public Individual read(int individualId)
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
                    {
                        individual.Email = (string)_database.Reader["Email"];
                    }

                    if (!(_database.Reader["Birth"] is DBNull))
                    {
                        individual.Birth = (DateTime)_database.Reader["Birth"];
                    }

                    if (!(_database.Reader["TaxCodeId"] is DBNull))
                    {
                        individual.TaxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];
                    }

                    if (!(_database.Reader["AdressId"] is DBNull))
                    {
                        individual.Adress.AdressId = (int)_database.Reader["AdressId"];
                    }

                    if (!(_database.Reader["PhoneId"] is DBNull))
                    {
                        individual.Phone.PhoneId = (int)_database.Reader["PhoneId"];
                    }

                    if (!(_database.Reader["PersonId"] is DBNull))
                    {
                        individual.Person.PersonId = (int)_database.Reader["PersonId"];
                    }

                    if (!(_database.Reader["OrganizationId"] is DBNull))
                    {
                        individual.Organization.OrganizationId = (int)_database.Reader["OrganizationId"];
                    }
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

            individual.TaxCode = _taxCodesManager.read(individual.TaxCode.TaxCodeId);
            individual.Adress = _adressesManager.read(individual.Adress.AdressId);
            individual.Phone = _phonesManager.read(individual.Phone.PhoneId);
            individual.Person = _peopleManager.read(individual.Person.PersonId);
            individual.Organization = _organizationsManager.read(individual.Organization.OrganizationId);

            return individual;
        }
        
        public void add(Individual individual)
        {
            if (individual.TaxCode != null)
            {
                _taxCodesManager.add(individual.TaxCode);
                individual.TaxCode.TaxCodeId = Functions.getLastId("TaxCodes");
            }

            if (individual.Adress != null)
            {
                _adressesManager.add(individual.Adress);
                individual.Adress.AdressId = Functions.getLastId("Adresses");
            }

            if (individual.Phone != null)
            {
                _phonesManager.add(individual.Phone);
                individual.Phone.PhoneId = Functions.getLastId("Phones");
            }

            if (individual.Person != null)
            {
                _peopleManager.add(individual.Person);
                individual.Person.PersonId = Functions.getLastId("People");
            }

            if (_organizationsManager.getId(individual.Organization) == 0)
            {
                _organizationsManager.add(individual.Organization);
                individual.Organization.OrganizationId = Functions.getLastId("Organizations");
            }

            try
            {
                _database.setQuery("insert into individuals (ActiveStatus, Email, Birth, TaxCodeId, AdressId, PhoneId, PersonId, OrganizationId) values (@ActiveStatus, @Email, @Birth, @TaxCodeId, @AdressId, @PhoneId, @PersonId, @OrganizationId)");
                _database.setParameter("@ActiveStatus", individual.ActiveStatus);
                _database.setParameter("@Email", individual.Email);
                _database.setParameter("@Birth", individual.Birth);

                if (individual.TaxCode != null)
                {
                    _database.setParameter("@TaxCodeId", individual.TaxCode.TaxCodeId);
                }
                else
                {
                    _database.setParameter("@TaxCodeId", DBNull.Value);
                }

                if (individual.Adress != null)
                {
                    _database.setParameter("@AdressId", individual.Adress.AdressId);
                }
                else
                {
                    _database.setParameter("@AdressId", DBNull.Value);
                }

                if (individual.Phone != null)
                {
                    _database.setParameter("@PhoneId", individual.Phone.PhoneId);
                }
                else
                {
                    _database.setParameter("@PhoneId", DBNull.Value);
                }

                if (individual.Person != null)
                {
                    _database.setParameter("@PersonId", individual.Person.PersonId);
                }
                else
                {
                    _database.setParameter("@PersonId", DBNull.Value);
                }

                if (individual.Organization != null)
                {
                    _database.setParameter("@OrganizationId", individual.Organization.OrganizationId);
                }
                else
                {
                    _database.setParameter("@OrganizationId", DBNull.Value);
                }

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

        public void edit(Individual individual)
        {
            int dbTaxCodeId = _taxCodesManager.getId(individual.TaxCode);
            int dbAdressId = _adressesManager.getId(individual.Adress);
            int dbPhoneId = _phonesManager.getId(individual.Phone);
            int dbPersonId = _peopleManager.getId(individual.Person);
            int dbOrganizationId = _organizationsManager.getId(individual.Organization);

            if (dbTaxCodeId == individual.TaxCode.TaxCodeId)
            {
                _taxCodesManager.edit(individual.TaxCode);
            }
            else if (dbTaxCodeId == 0)
            {
                _taxCodesManager.add(individual.TaxCode);
                individual.TaxCode.TaxCodeId = Functions.getLastId("TaxCodes");
            }
            else
            {
                individual.TaxCode.TaxCodeId = dbTaxCodeId;
            }

            if (dbAdressId == individual.Adress.AdressId)
            {
                _adressesManager.edit(individual.Adress);
            }
            else if (dbAdressId == 0)
            {
                _adressesManager.add(individual.Adress);
                individual.Adress.AdressId = Functions.getLastId("Adresses");
            }
            else
            {
                individual.Adress.AdressId = dbAdressId;
            }

            if (dbPhoneId == individual.Phone.PhoneId)
            {
                _phonesManager.edit(individual.Phone);
            }
            else if (dbPhoneId == 0)
            {
                _phonesManager.add(individual.Phone);
            }
            else
            {
                individual.Phone.PhoneId = dbPhoneId;
            }

            if (dbPersonId == 0) // analizar flujo. definir unicidad de personas.
            {
                _peopleManager.add(individual.Person);
            }
            else
            {
                individual.Person.PersonId = dbPersonId;
            }

            if (dbOrganizationId == individual.Organization.OrganizationId)
            {
                //_organizationsManager.edit(individual.Organization);
            }
            else if (dbOrganizationId == 0)
            {
                _organizationsManager.add(individual.Organization);
            }
            else
            {
                individual.Organization.OrganizationId = dbOrganizationId;
            }

            try
            {
                _database.setQuery("update Individuals set ActiveStatus = @ActiveStatus, Email = @Email, Birth = @Birth, TaxCodeId = @TaxCodeId, AdressId = @AdressId, PhoneId = @PhoneId, PersonId = @PersonId, OrganizationId = @OrganizationId where IndividualId = @IndividualId");
                _database.setParameter("@IndividualId", individual.IndividualId);
                _database.setParameter("@ActiveStatus", individual.ActiveStatus);
                _database.setParameter("@Email", individual.Email);
                _database.setParameter("@Birth", individual.Birth);
                _database.setParameter("@TaxCodeId", individual.TaxCode.TaxCodeId);
                _database.setParameter("@AdressId", individual.Adress.AdressId);
                _database.setParameter("@PhoneId", individual.Phone.PhoneId);
                _database.setParameter("@PersonId", individual.Person.PersonId);
                _database.setParameter("@OrganizationId", individual.Organization.OrganizationId);
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

        public void delete(Individual individual)
        {
            try
            {
                _database.setQuery("delete from Individuals where IndividualId = @IndividualId");
                _database.setParameter("@IndividualId", individual.IndividualId);
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
