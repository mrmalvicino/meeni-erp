using System;
using System.Data.Common;
using System.Data.SqlClient;
using DomainModel;

namespace DataAccess
{
    public class UsersDAL
    {
        private Database _db;

        public UsersDAL(Database db)
        {
            _db = db;
        }

        public int Create(User user, Organization organization)
        {
            try
            {
                _db.SetProcedure("sp_create_user");
                SetParameters(user, organization.Id);
                user.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _db.CloseConnection();
            }

            return user.Id;
        }

        private void SetParameters(User user, int organizationId, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@user_id", user.Id);
                _db.SetParameter("@activity_status", user.ActivityStatus);
            }

            _db.SetParameter("@username", user.Username);
            _db.SetParameter("@user_password", user.Password);
            _db.SetParameter("@organization_id", organizationId);
        }
    }
}
