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

        public List<City> list(int provinceId = 0)
        {
            List<City> citiesList = new List<City>();
            string query = "select CityId, CityName, ZipCode from Cities";

            if (0 < provinceId)
            {
                query += " where ProvinceId = @ProvinceId";
                _database.setParameter("@ProvinceId", provinceId);
            }

            try
            {
                _database.setQuery(query);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    City city = new City();

                    city.CityId = Convert.ToInt32(_database.Reader["CityId"]);
                    city.Name = (string)_database.Reader["CityName"];

                    if (!(_database.Reader["ZipCode"] is DBNull))
                        city.ZipCode = (string)_database.Reader["ZipCode"];

                    citiesList.Add(city);
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

            return citiesList;
        }
    }
}
