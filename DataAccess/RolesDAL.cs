using System;

namespace DataAccess
{
    public class RolesDAL
    {
        private Database _db;

        public RolesDAL(Database db)
        {
            _db = db;
        }

        public void CreateUserRole(int userId, int roleId)
        {
            try
            {
                _db.SetProcedure("sp_create_user_role");
                _db.SetParameter("@user_id", userId);
                _db.SetParameter("@role_id", roleId);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _db.CloseConnection();
            }
        }
    }
}
