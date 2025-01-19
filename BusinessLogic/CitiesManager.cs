using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class CitiesManager
    {
        private City _city;
        private CitiesDAL _citiesDAL;

        public CitiesManager(Database db)
        {
            _citiesDAL = new CitiesDAL(db);
        }

        public int Create(City city, int provinceId)
        {
            try
            {
                return _citiesDAL.Create(city, provinceId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public City Read(int cityId)
        {
            if (cityId == 0)
            {
                return null;
            }

            try
            {
                _city = _citiesDAL.Read(cityId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _city;
        }
    }
}
