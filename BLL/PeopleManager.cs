using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PeopleManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public Person readPerson(int personId)
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
    }
}
