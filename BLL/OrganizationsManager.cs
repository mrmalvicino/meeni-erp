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
