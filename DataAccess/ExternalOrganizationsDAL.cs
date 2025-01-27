using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace DataAccess
{
    public class ExternalOrganizationsDAL
    {
        private Database _db;

        public ExternalOrganizationsDAL(Database db)
        {
            _db = db;
        }

        public ExternalOrganization Read(int externalOrganizationId)
        {
            try
            {
                _db.SetProcedure("sp_read_external_organization");
                _db.SetParameter("@external_organization_id", externalOrganizationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    ExternalOrganization externalOrganization = new ExternalOrganization();
                    ReadRow(externalOrganization);
                    return externalOrganization;
                }

                return null;
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

        private void ReadRow(ExternalOrganization externalOrganization)
        {
            externalOrganization.Id = Convert.ToInt32(_db.Reader["external_organization_id"]);
        }
    }
}
