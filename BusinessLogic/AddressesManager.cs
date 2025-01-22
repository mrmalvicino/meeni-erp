using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class AddressesManager : BaseManager<Address>
    {
        private Address _address;
        private AddressesDAL _addressesDAL;
        private CountriesManager _countriesManager;
        private ProvincesManager _provincesManager;
        private CitiesManager _citiesManager;

        public AddressesManager(Database db)
        {
            _addressesDAL = new AddressesDAL(db);
            _countriesManager = new CountriesManager(db);
            _provincesManager = new ProvincesManager(db);
            _citiesManager = new CitiesManager(db);
        }

        protected override int Create(Address address)
        {
            _countriesManager.Handle(address.Country);
            _provincesManager.Handle(address.Province, address.Country.Id);
            _citiesManager.Handle(address.City, address.Province.Id);

            try
            {
                return _addressesDAL.Create(address);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Address Read(int addressId)
        {
            if (addressId == 0)
            {
                return null;
            }

            try
            {
                _address = _addressesDAL.Read(addressId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _address.City = _citiesManager.Read(_address.City.Id);

            int provinceId = _provincesManager.FindId(_address.City);
            _address.Province = _provincesManager.Read(provinceId);

            int countryId = _countriesManager.FindId(_address.Province);
            _address.Country = _countriesManager.Read(countryId);

            return _address;
        }

        protected override void Update(Address address)
        {
            _countriesManager.Handle(address.Country);
            _provincesManager.Handle(address.Province, address.Country.Id);
            _citiesManager.Handle(address.City, address.Province.Id);

            try
            {
                _addressesDAL.Update(address);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected override int FindId(Address address)
        {
            try
            {
                return _addressesDAL.FindId(address);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Handle(Address address)
        {
            HandleEntity(address);
        }
    }
}
