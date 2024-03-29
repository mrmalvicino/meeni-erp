﻿using System;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class IndividualsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private TaxCodesManager _taxCodesManager = new TaxCodesManager();
        private AdressesManager _adressesManager = new AdressesManager();
        private PeopleManager _peopleManager = new PeopleManager();
        private OrganizationsManager _organizationsManager = new OrganizationsManager();
        private ImagesManager _imagesManager = new ImagesManager();

        // METHODS

        public Individual read(int individualId)
        {
            Individual individual = new Individual();

            try
            {
                _database.setQuery("select ActiveStatus, Phone, Email, Birth, TaxCodeId, AdressId, PersonId, OrganizationId, ImageId from Individuals where IndividualId = @IndividualId");
                _database.setParameter("@IndividualId", individualId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    individual.IndividualId = individualId;
                    individual.ActiveStatus = (bool)_database.Reader["ActiveStatus"];

                    if (!(_database.Reader["Phone"] is DBNull))
                    {
                        individual.Phone = (string)_database.Reader["Phone"];
                    }

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

                    if (!(_database.Reader["PersonId"] is DBNull))
                    {
                        individual.Person.PersonId = (int)_database.Reader["PersonId"];
                    }

                    if (!(_database.Reader["OrganizationId"] is DBNull))
                    {
                        individual.Organization.OrganizationId = (int)_database.Reader["OrganizationId"];
                    }

                    if (!(_database.Reader["ImageId"] is DBNull))
                    {
                        individual.Image.ImageId = (int)_database.Reader["ImageId"];
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
            individual.Person = _peopleManager.read(individual.Person.PersonId);
            individual.Organization = _organizationsManager.read(individual.Organization.OrganizationId);
            individual.Image = _imagesManager.read(individual.Image.ImageId);

            return individual;
        }
        
        public void add(Individual individual)
        {
            if (individual.TaxCode != null)
            {
                int dbTaxCodeId = _taxCodesManager.getId(individual.TaxCode);

                if (dbTaxCodeId == 0)
                {
                    _taxCodesManager.add(individual.TaxCode);
                    individual.TaxCode.TaxCodeId = Helper.getLastId("TaxCodes");
                }
                else
                {
                    individual.TaxCode.TaxCodeId = dbTaxCodeId;
                }
            }

            if (individual.Adress != null)
            {
                int dbAdressId = _adressesManager.getId(individual.Adress);

                if (dbAdressId == 0)
                {
                    _adressesManager.add(individual.Adress);
                    individual.Adress.AdressId = Helper.getLastId("Adresses");
                }
                else
                {
                    individual.Adress.AdressId= dbAdressId;
                }
            }

            if (individual.Person != null)
            {
                int dbPersonId = _peopleManager.getId(individual.Person);

                if (dbPersonId == 0)
                {
                    _peopleManager.add(individual.Person);
                    individual.Person.PersonId = Helper.getLastId("People");
                }
                else
                {
                    individual.Person.PersonId = dbPersonId;
                }
            }

            if (individual.Organization != null)
            {
                int dbOrganizationId = _organizationsManager.getId(individual.Organization);

                if (dbOrganizationId == 0)
                {
                    _organizationsManager.add(individual.Organization);
                    individual.Organization.OrganizationId = Helper.getLastId("Organizations");
                }
                else
                {
                    individual.Organization.OrganizationId = dbOrganizationId;
                }
            }

            if (individual.Image != null)
            {
                int dbImageId = _imagesManager.getId(individual.Image);

                if (dbImageId == 0)
                {
                    _imagesManager.add(individual.Image);
                    individual.Image.ImageId = Helper.getLastId("Images");
                }
                else
                {
                    individual.Image.ImageId = dbImageId;
                }
            }

            try
            {
                _database.setQuery("insert into individuals (ActiveStatus, Phone, Email, Birth, TaxCodeId, AdressId, PersonId, OrganizationId, ImageId) values (@ActiveStatus, @Phone, @Email, @Birth, @TaxCodeId, @AdressId, @PersonId, @OrganizationId, @ImageId)");
                setParameters(individual);
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
            if (individual.TaxCode != null)
            {
                int dbTaxCodeId = _taxCodesManager.getId(individual.TaxCode);

                if (dbTaxCodeId == 0)
                {
                    _taxCodesManager.add(individual.TaxCode);
                    individual.TaxCode.TaxCodeId = Helper.getLastId("TaxCodes");
                }
                else if (dbTaxCodeId == individual.TaxCode.TaxCodeId)
                {
                    _taxCodesManager.edit(individual.TaxCode);
                }
                else
                {
                    individual.TaxCode.TaxCodeId = dbTaxCodeId;
                }
            }

            if (individual.Adress != null)
            {
                int dbAdressId = _adressesManager.getId(individual.Adress);

                if (dbAdressId == 0)
                {
                    _adressesManager.add(individual.Adress);
                    individual.Adress.AdressId = Helper.getLastId("Adresses");
                }
                else if (dbAdressId == individual.Adress.AdressId)
                {
                    _adressesManager.edit(individual.Adress);
                }
                else
                {
                    individual.Adress.AdressId = dbAdressId;
                }
            }

            if (individual.Person != null)
            {
                int dbPersonId = _peopleManager.getId(individual.Person);

                if (dbPersonId == 0)
                {
                    _peopleManager.add(individual.Person);
                    individual.Person.PersonId = Helper.getLastId("People");
                }
                else if (dbPersonId == individual.Person.PersonId)
                {
                    _peopleManager.edit(individual.Person);
                }
                else
                {
                    individual.Person.PersonId = dbPersonId;
                }
            }
            
            if ( individual.Organization != null)
            {
                int dbOrganizationId = _organizationsManager.getId(individual.Organization);

                if (dbOrganizationId == 0)
                {
                    _organizationsManager.add(individual.Organization);
                    individual.Organization.OrganizationId = Helper.getLastId("Organizations");
                }
                else if (dbOrganizationId == individual.Organization.OrganizationId)
                {
                    _organizationsManager.edit(individual.Organization);
                }
                else
                {
                    individual.Organization.OrganizationId = dbOrganizationId;
                }
            }

            if (individual.Image != null)
            {
                int dbImageId = _imagesManager.getId(individual.Image);

                if (dbImageId == 0)
                {
                    _imagesManager.add(individual.Image);
                    individual.Image.ImageId = Helper.getLastId("Images");
                }
                else if (dbImageId == individual.Image.ImageId)
                {
                    _imagesManager.edit(individual.Image);
                }
                else
                {
                    individual.Image.ImageId = dbImageId;
                }
            }

            try
            {
                _database.setQuery("update Individuals set ActiveStatus = @ActiveStatus, Phone = @Phone, Email = @Email, Birth = @Birth, TaxCodeId = @TaxCodeId, AdressId = @AdressId, PersonId = @PersonId, OrganizationId = @OrganizationId, ImageId = @ImageId where IndividualId = @IndividualId");
                _database.setParameter("@IndividualId", individual.IndividualId);
                setParameters(individual);
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

        private void setParameters(Individual individual)
        {
            _database.setParameter("@ActiveStatus", individual.ActiveStatus);

            if (Validations.hasData(individual.Phone))
            {
                _database.setParameter("@Phone", individual.Phone);
            }
            else
            {
                _database.setParameter("@Phone", DBNull.Value);
            }

            if (Validations.hasData(individual.Email))
            {
                _database.setParameter("@Email", individual.Email);
            }
            else
            {
                _database.setParameter("@Email", DBNull.Value);
            }

            if (individual.Birth != new DateTime(9000, 1, 1))
            {
                _database.setParameter("@Birth", individual.Birth);
            }
            else
            {
                _database.setParameter("@Birth", DBNull.Value);
            }

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

            if (individual.Image != null)
            {
                _database.setParameter("@ImageId", individual.Image.ImageId);
            }
            else
            {
                _database.setParameter("@ImageId", DBNull.Value);
            }
        }
    }
}
