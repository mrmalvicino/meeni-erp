using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
{
    public class CountriesManager : BaseManager<Country>
    {
        private Country _country;
        private CountriesDAL _countriesDAL;

        public CountriesManager(Database db)
        {
            _countriesDAL = new CountriesDAL(db);
        }

        protected override int Create(Country country)
        {
            try
            {
                Validate(country);
                return _countriesDAL.Create(country);
            }
            catch (Exception ex) when (!(ex is ValidationException))
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

        protected override void Update(Country country)
        {
            // Not necessary for entities in which DB tables have no fields appart from those that form a unique constraint.
        }

        protected override int FindId(Country country)
        {
            try
            {
                return _countriesDAL.FindId(country);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public int FindId(Province province)
        {
            try
            {
                return _countriesDAL.FindId(province);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Handle(Country country)
        {
            HandleAttribute(country);
        }

        private void Validate(Country country)
        {
            Validator.ValidateCountryName(country.Name);
        }
    }
}
