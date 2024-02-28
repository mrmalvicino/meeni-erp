using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImagesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public string readImage<T>(int id)
        {
            string imageUrl = "";

            try
            {
                if (typeof(T) == typeof(Person))
                    _database.setQuery("select I.ImageUrl from Images I inner join ImagePersonRelations R on I.ImageId = R.ImageId inner join People P on R.PersonId = P.PersonId where P.PersonId = @id");
                else if (typeof(T) == typeof(Organization))
                    _database.setQuery("select I.ImageUrl from Images I inner join ImageOrganizationRelations R on I.ImageId = R.ImageId inner join Organizations O on R.OrganizationId = O.OrganizationId where O.OrganizationId = @id");
                else if (typeof(T) == typeof(Product))
                    _database.setQuery("select I.ImageUrl from Images I inner join ImageProductRelations R on I.ImageId = R.ImageId inner join Products P on R.ProductId = P.ProductId where P.ProductId = @id");

                _database.setParameter("@id", id);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    imageUrl = (string)_database.Reader["ImageUrl"];
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

            return imageUrl;
        }

        public List<string> listImages<T>(int id)
        {
            List<string> imagesList = new List<string>();

            try
            {
                if (typeof(T) == typeof(Person))
                    _database.setQuery("select I.ImageUrl from Images I inner join ImagePersonRelations R on I.ImageId = R.ImageId inner join People P on R.PersonId = P.PersonId where P.PersonId = @id");
                else if (typeof(T) == typeof(Organization))
                    _database.setQuery("select I.ImageUrl from Images I inner join ImageOrganizationRelations R on I.ImageId = R.ImageId inner join Organizations O on R.OrganizationId = O.OrganizationId where O.OrganizationId = @id");
                else if (typeof(T) == typeof(Product))
                    _database.setQuery("select I.ImageUrl from Images I inner join ImageProductRelations R on I.ImageId = R.ImageId inner join Products P on R.ProductId = P.ProductId where P.ProductId = @id");

                _database.setParameter("@id", id);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    string imageUrl = (string)_database.Reader["ImageUrl"];
                    imagesList.Add(imageUrl);
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

            return imagesList;
        }
    }
}
