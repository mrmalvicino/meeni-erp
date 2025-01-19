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

        public AddressesManager(Database db)
        {
            _addressesDAL = new AddressesDAL(db);
        }

        protected override int Create(Address address)
        {
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

            return _address;
        }

        protected override void Update(Address address)
        {
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
    }
}
