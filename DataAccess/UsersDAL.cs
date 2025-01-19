using System;
using DomainModel;
using Exceptions;

namespace DataAccess
{
    public class UsersDAL
    {
        private Database _db;

        public UsersDAL(Database db)
        {
            _db = db;
        }

        public int Create(User user)
        {
            try
            {
                _db.SetProcedure("sp_create_user");
                SetParameters(user);
                user.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return user.Id;
        }

        public User Read(int userId)
        {
            try
            {
                _db.SetQuery("select * from users where user_id = @user_id");
                _db.SetParameter("@user_id", userId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    User user = new User();
                    ReadRow(user);
                    return user;
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

        public int FindId(User user)
        {
            try
            {
                _db.SetProcedure("sp_find_user_id");
                _db.SetParameter("@username", user.Username);
                _db.SetParameter("@password", user.Password);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["user_id"];
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

        private void SetParameters(User user)
        {
            _db.SetParameter("@user_id", user.Id);
            _db.SetParameter("@username", user.Username);
            _db.SetParameter("@password", user.Password);
        }

        private void ReadRow(User user)
        {
            user.Id = Convert.ToInt32(_db.Reader["user_id"]);
            user.Username = _db.Reader["username"].ToString();
            user.Password = _db.Reader["password"].ToString();
        }
    }
}
