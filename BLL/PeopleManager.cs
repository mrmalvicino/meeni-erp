using DAL;
using Entities;
using System;

namespace BLL
{
    public class PeopleManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private ImagesManager _imagesManager = new ImagesManager();

        // METHODS

        public Person read(int personId)
        {
            Person person = new Person();

            try
            {
                _database.setQuery("select FirstName, LastName, ImageId from People where PersonId = @PersonId");
                _database.setParameter("@PersonId", personId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    person.PersonId = personId;
                    person.FirstName = (string)_database.Reader["FirstName"];
                    person.LastName = (string)_database.Reader["LastName"];
                    person.Image.ImageId = (int)_database.Reader["ImageId"];
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

            person.Image = _imagesManager.read(person.Image.ImageId);

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

        public int getId(Person person)
        {
            person.PersonId = 0;

            try
            {
                _database.setQuery("select PersonId from People where FirstName = @FirstName and LastName = @LastName and ImageId = @ImageId");
                _database.setParameter("@FirstName", person.FirstName);
                _database.setParameter("@LastName", person.LastName);
                _database.setParameter("@ImageId", person.Image.ImageId);
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
    }
}
