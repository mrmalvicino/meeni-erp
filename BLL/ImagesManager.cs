using System;
using DAL;
using Entities;

namespace BLL
{
    public class ImagesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public string readIndividualImage<T>(T obj)
            where T : Individual, new()
        {
            string imageUrl = "";
            string queryString;
            int filterId;
            
            if (obj.isPerson())
            {
                queryString = "select I.ImageUrl from Images I inner join People P on P.ImageId = I.ImageId where P.PersonId = @filterId";
                filterId = obj.Person.PersonId;
            }
            else
            {
                queryString = "select I.ImageUrl from Images I inner join Organizations O on O.ImageId = I.ImageId where O.OrganizationId = @filterId";
                filterId = obj.Organization.OrganizationId;
            }

            try
            {
                _database.setQuery(queryString);
                _database.setParameter("@filterId", filterId);
                _database.executeReader();

                if (_database.Reader.Read())
                    imageUrl = (string)_database.Reader["ImageUrl"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            return imageUrl;
        }
    }
}
