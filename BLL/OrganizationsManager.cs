using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class OrganizationsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private ImagesManager _imagesManager = new ImagesManager();

        // METHODS

        public List<Organization> list()
        {
            List<Organization> organizationsList = new List<Organization>();

            try
            {
                _database.setQuery("select OrganizationId, OrganizationName, OrganizationDescription, ImageId from Organizations");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Organization organization = new Organization();

                    organization.OrganizationId = (int)_database.Reader["OrganizationId"];
                    organization.Name = (string)_database.Reader["OrganizationName"];

                    if (!(_database.Reader["OrganizationDescription"] is DBNull))
                    {
                        organization.Description = (string)_database.Reader["OrganizationDescription"];
                    }

                    if (!(_database.Reader["ImageId"] is DBNull))
                    {
                        organization.Image.ImageId = (int)_database.Reader["ImageId"];
                    }

                    organizationsList.Add(organization);
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

            return organizationsList;
        }

        public Organization read(int organizationId)
        {
            Organization organization = new Organization();

            try
            {
                _database.setQuery("select OrganizationName, OrganizationDescription, ImageId from Organizations where OrganizationId = @OrganizationId");
                _database.setParameter("@OrganizationId", organizationId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    organization.OrganizationId = organizationId;
                    organization.Name = (string)_database.Reader["OrganizationName"];

                    if (!(_database.Reader["OrganizationDescription"] is DBNull))
                    {
                        organization.Description = (string)_database.Reader["OrganizationDescription"];
                    }

                    if (!(_database.Reader["ImageId"] is DBNull))
                    {
                        organization.Image.ImageId = (int)_database.Reader["ImageId"];
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

            organization.Image = _imagesManager.read(organization.Image.ImageId);

            return organization;
        }

        public void add(Organization organization)
        {
            organization.Image.ImageId = _imagesManager.getId(organization.Image);

            if (organization.Image.ImageId == 0)
            {
                _imagesManager.add(organization.Image);
                organization.Image.ImageId = _imagesManager.getId(organization.Image);
            }

            try
            {
                _database.setQuery("insert into Organizations (OrganizationName, OrganizationDescription, ImageId) values (@OrganizationName, @OrganizationDescription, @ImageId)");
                _database.setParameter("@OrganizationName", organization.Name);
                _database.setParameter("@OrganizationDescription", organization.Description);
                _database.setParameter("@ImageId", organization.Image.ImageId);
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

        public int getId(Organization organization)
        {
            organization.OrganizationId = 0;

            try
            {
                _database.setQuery("select OrganizationId from Organizations where OrganizationName = @OrganizationName");
                _database.setParameter("@OrganizationName", organization.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    organization.OrganizationId = (int)_database.Reader["OrganizationId"];
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

            return organization.OrganizationId;
        }
    }
}
