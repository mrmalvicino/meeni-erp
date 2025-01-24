using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace DataAccess
{
    public class PeopleDAL
    {
        private Database _db;

        public PeopleDAL(Database db)
        {
            _db = db;
        }

        public int Create(Person person, int internalOrganizationId)
        {
            try
            {
                _db.SetProcedure("sp_create_person");
                SetParameters(person, internalOrganizationId);
                person.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return person.Id;
        }

        public Person Read(int personId)
        {
            try
            {
                _db.SetQuery("select * from people where person_id = @person_id");
                _db.SetParameter("@person_id", personId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Person person = new Person();
                    ReadRow(person);
                    return person;
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

        public void Update(Person person, int internalOrganizationId)
        {
            try
            {
                _db.SetProcedure("sp_update_person");
                SetParameters(person, internalOrganizationId, true);
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

        public int FindId(Person person, int internalOrganizationId)
        {
            try
            {
                _db.SetProcedure("sp_find_person_id");
                _db.SetParameter("@cuil", person.CUIL);
                _db.SetParameter("@internal_organization_id", internalOrganizationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["person_id"];
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

        private void SetParameters(Person person, int internalOrganizationId, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@person_id", person.Id);
            }

            if (!string.IsNullOrEmpty(person.CUIL))
            {
                _db.SetParameter("@cuil", person.CUIL);
            }
            else
            {
                _db.SetParameter("@cuil", DBNull.Value);
            }

            _db.SetParameter("@first_name", person.FirstName);
            _db.SetParameter("@last_name", person.LastName);

            if (!string.IsNullOrEmpty(person.Email))
            {
                _db.SetParameter("@email", person.Email);
            }
            else
            {
                _db.SetParameter("@email", DBNull.Value);
            }

            if (!string.IsNullOrEmpty(person.Phone))
            {
                _db.SetParameter("@phone", person.Phone);
            }
            else
            {
                _db.SetParameter("@phone", DBNull.Value);
            }

            if (person.BirthDate != null && person.BirthDate != DateTime.MinValue)
            {
                _db.SetParameter("@birth_date", person.BirthDate);
            }
            else
            {
                _db.SetParameter("@birth_date", DBNull.Value);
            }

            if (person.ProfileImage != null)
            {
                _db.SetParameter("@profile_image_id", person.ProfileImage.Id);
            }
            else
            {
                _db.SetParameter("@profile_image_id", DBNull.Value);
            }

            if (person.Address != null)
            {
                _db.SetParameter("@address_id", person.Address.Id);
            }
            else
            {
                _db.SetParameter("@address_id", DBNull.Value);
            }

            _db.SetParameter("@internal_organization_id", internalOrganizationId);
        }

        private void ReadRow(Person person)
        {
            person.Id = Convert.ToInt32(_db.Reader["person_id"]);
            person.CUIL = _db.Reader["cuil"]?.ToString();
            person.FirstName = _db.Reader["first_name"].ToString();
            person.LastName = _db.Reader["last_name"].ToString();
            person.Email = _db.Reader["email"]?.ToString();
            person.Phone = _db.Reader["phone"]?.ToString();
            person.BirthDate = _db.Reader["birth_date"] as DateTime? ?? person.BirthDate;
            person.ProfileImage = Helper.Instantiate<Image>(_db.Reader["profile_image_id"]);
            person.Address = Helper.Instantiate<Address>(_db.Reader["address_id"]);
        }
    }
}
