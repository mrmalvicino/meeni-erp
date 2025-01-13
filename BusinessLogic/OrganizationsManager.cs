using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class OrganizationsManager
    {
        private OrganizationsDAL _organizationsDAL;
        
        public OrganizationsManager(Database db)
        {
            _organizationsDAL = new OrganizationsDAL(db);
        }

        public int Create(Organization organization)
        {
            try
            {
                return _organizationsDAL.Create(organization);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
