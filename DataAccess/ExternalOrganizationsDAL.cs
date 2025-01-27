using Exceptions;
using System;

namespace DataAccess
{
    public class ExternalOrganizationsDAL
    {
        private Database _db;

        public ExternalOrganizationsDAL(Database db)
        {
            _db = db;
        }

        public int FindInternalId(int externalOrganizationId)
        {
            try
            {
                _db.SetProcedure("sp_find_organization_internal_id");
                _db.SetParameter("@external_organization_id", externalOrganizationId);
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
