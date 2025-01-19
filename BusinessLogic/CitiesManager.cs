using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class CitiesManager : BaseManager<City>
    {
        private City _city;
        private CitiesDAL _citiesDAL;
        private int _provinceId;

        public CitiesManager(Database db)
        {
            _citiesDAL = new CitiesDAL(db);
        }

        protected override int Create(City city)
        {
            return Create(city, _provinceId);
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

        protected override void Update(City city)
        {
            // Not necessary for entities in which DB tables have no fields appart from those that form a unique constraint.
        }

        protected override int FindId(City city)
        {
            return FindId(city, _provinceId);
        }

        public int FindId(City city, int provinceId)
        {
            try
            {
                return _citiesDAL.FindId(city, provinceId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void HandleEntity(City city, int provinceId)
        {
            _provinceId = provinceId;
            HandleEntity(city);
        }
    }
}
