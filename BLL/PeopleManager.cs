using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PeopleManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private ImagesManager _imagesManager = new ImagesManager();

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

        public void add(Person person)
        {
            person.Image.ImageId = _imagesManager.getId(person.Image);

            if (person.Image.ImageId == 0)
            {
                _imagesManager.add(person.Image);
                person.Image.ImageId = _imagesManager.getId(person.Image);
            }

            try
            {
                _database.setQuery("insert into People (FirstName, LastName, ImageId) values (@FirstName, @LastName, @ImageId)");
                _database.setParameter("@FirstName", person.FirstName);
                _database.setParameter("@LastName", person.LastName);
                _database.setParameter("@ImageId", person.Image.ImageId);
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
    }
}
