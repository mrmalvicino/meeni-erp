using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class PeopleManager
    {
        private PeopleDAL _peopleDAL;

        public PeopleManager(Database db)
        {
            _peopleDAL = new PeopleDAL(db);
        }

        public int FindInternalOrganizationId(Person person)
        {
            try
            {
                return _peopleDAL.FindInternalOrganizationId(person);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
