using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace DataAccess
{
    public class StakeholdersDAL
    {
        private Database _db;

        public StakeholdersDAL(Database db)
        {
            _db = db;
        }

        public Stakeholder Read(int stakeholderId)
        {
            try
            {
                _db.SetProcedure("sp_read_stakeholder");
                _db.SetParameter("@stakeholder_id", stakeholderId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Stakeholder stakeholder = new Stakeholder();
                    ReadRow(stakeholder);
                    return stakeholder;
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

        public int FindOrganizationId(int stakeholderId)
        {
            try
            {
                _db.SetProcedure("sp_find_organization_id");
                _db.SetParameter("@stakeholder_id", stakeholderId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["organization_id"];
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

        private void ReadRow(Stakeholder stakeholder)
        {
            stakeholder.Id = Convert.ToInt32(_db.Reader["stakeholder_id"]);
        }
    }
}
