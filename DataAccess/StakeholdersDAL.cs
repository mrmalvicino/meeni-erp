using DomainModel;
using Exceptions;
using System;

namespace DataAccess
{
    public class StakeholdersDAL
    {
        private Database _db;

        public StakeholdersDAL(Database db)
        {
            _db = db;
        }

        public int Create(Stakeholder stakeholder, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_create_stakeholder");
                SetParameters(stakeholder, organizationId);
                stakeholder.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return stakeholder.Id;
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

        public void Update(Stakeholder stakeholder)
        {
            try
            {
                _db.SetProcedure("sp_update_stakeholder");
                SetParameters(stakeholder);
                _db.ExecuteAction();
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

        private void SetParameters(Stakeholder stakeholder, int organizationId = 0)
        {
            _db.SetParameter("@stakeholder_id", stakeholder.Id);

            if (0 < organizationId)
            {
                _db.SetParameter("@organization_id", organizationId);
            }
        }

        private void ReadRow(Stakeholder stakeholder)
        {
            stakeholder.Id = Convert.ToInt32(_db.Reader["stakeholder_id"]);
        }
    }
}
