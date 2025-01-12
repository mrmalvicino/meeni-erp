using DataAccess;
using DomainModel;
using System;

namespace BusinessLogic
{
    public class OrganizationsManager
    {
        private OrganizationsDAL _organizationsDAL;
        
        public OrganizationsManager()
        {
            _organizationsDAL = new OrganizationsDAL();
        }

        public int Create(Organization organization)
        {
            try
            {
                return _organizationsDAL.Create(organization);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
