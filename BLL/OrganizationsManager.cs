using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrganizationsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Organization> list()
        {
            List<Organization> organizationsList = new List<Organization>();

            try
            {
                _database.setQuery("select OrganizationId, OrganizationName, OrganizationDescription from Organizations");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Organization organization = new Organization();

                    organization.OrganizationId = (int)_database.Reader["OrganizationId"];
                    organization.Name = (string)_database.Reader["OrganizationName"];
                    if (!(_database.Reader["OrganizationDescription"] is DBNull))
                        organization.Description = (string)_database.Reader["OrganizationDescription"];

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

        public Organization readOrganization(int organizationId)
        {
            Organization organization = new Organization();

            try
            {
                _database.setQuery("select OrganizationName, OrganizationDescription from Organizations where OrganizationId = @OrganizationId");
                _database.setParameter("@OrganizationId", organizationId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    organization.OrganizationId = organizationId;
                    organization.Name = (string)_database.Reader["OrganizationName"];
                    if (!(_database.Reader["OrganizationDescription"] is DBNull))
                        organization.Description = (string)_database.Reader["OrganizationDescription"];
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

            return organization;
        }
    }
}
