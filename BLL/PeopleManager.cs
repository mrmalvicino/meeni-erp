using System;
using DAL;
using Entities;

namespace BLL
{
    public class PeopleManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public Person read(int personId)
        {
            Person person = new Person();

            try
            {
                _database.setQuery("select FirstName, LastName from People where PersonId = @PersonId");
                _database.setParameter("@PersonId", personId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    person.PersonId = personId;
                    person.FirstName = (string)_database.Reader["FirstName"];
                    person.LastName = (string)_database.Reader["LastName"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            return person;
        }

        public void add(Person person)
        {
            try
            {
                _database.setQuery("insert into People (FirstName, LastName) values (@FirstName, @LastName)");
                setParameters(person);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void edit(Person person)
        {
            try
            {
                _database.setQuery("update People set FirstName = @FirstName, LastName = @LastName where PersonId = @PersonId");
                _database.setParameter("@PersonId", person.PersonId);
                setParameters(person);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public int getId(Person person)
        {
            if (person == null)
            {
                return 0;
            }

            person.PersonId = 0;

            try
            {
                _database.setQuery("select PersonId from People where FirstName = @FirstName and LastName = @LastName");
                _database.setParameter("@FirstName", person.FirstName);
                _database.setParameter("@LastName", person.LastName);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    person.PersonId = (int)_database.Reader["PersonId"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            return person.PersonId;
        }

        private void setParameters(Person person)
        {
            if (Functions.hasData(person.FirstName))
            {
                _database.setParameter("@FirstName", person.FirstName);
            }
            else
            {
                _database.setParameter("@FirstName", DBNull.Value);
            }

            if (Functions.hasData(person.LastName))
            {
                _database.setParameter("@LastName", person.LastName);
            }
            else
            {
                _database.setParameter("@LastName", DBNull.Value);
            }
        }
    }
}
