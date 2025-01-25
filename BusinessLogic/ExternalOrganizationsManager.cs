using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class ExternalOrganizationsManager
    {
        private Country _country;
        private ExternalOrganizationsDAL _externalOrganizationsDAL;

        public ExternalOrganizationsManager(Database db)
        {
            _externalOrganizationsDAL = new ExternalOrganizationsDAL(db);
        }

        public int FindInternalId(int externalOrganizationId)
        {
            try
            {
                return _externalOrganizationsDAL.FindInternalId(externalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
