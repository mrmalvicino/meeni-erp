using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CitiesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public City readCity(int cityId)
        {
            City city = new City();

            try
            {
                _database.setQuery("select CityName, ZipCode from Cities where CityId = @CityId");
                _database.setParameter("@CityId", cityId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    city.CityId = cityId;
                    city.Name = (string)_database.Reader["CityName"];
                    city.ZipCode = (string)_database.Reader["ZipCode"];
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

            return city;
        }
    }
}
