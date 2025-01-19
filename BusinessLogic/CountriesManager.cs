using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class CountriesManager
    {
        private Country _country;
        private CountriesDAL _countriesDAL;

        public CountriesManager(Database db)
        {
            _countriesDAL = new CountriesDAL(db);
        }

        public int Create(Country country)
        {
            try
            {
                return _countriesDAL.Create(country);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Country Read(int countryId)
        {
            if (countryId == 0)
            {
                return null;
            }

            try
            {
                _country = _countriesDAL.Read(countryId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _country;
        }
    }
}
