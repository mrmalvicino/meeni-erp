using DomainModel;
using Exceptions;
using System;

namespace DataAccess
{
    public class PeopleDAL
    {
        private Database _db;

        public PeopleDAL(Database db)
        {
            _db = db;
        }

        public int FindInternalOrganizationId(Person person)
        {
            try
            {
                _db.SetQuery("select internal_organization_id from people where person_id = @person_id");
                _db.SetParameter("@person_id", person.Id);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["internal_organization_id"];
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }
    }
}
