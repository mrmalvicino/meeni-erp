using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
{
    public class PeopleManager : BaseManager<Person>
    {
        private Person _person;
        private PeopleDAL _peopleDAL;
        private ImagesManager _imagesManager;
        private AddressesManager _addressesManager;
        private int _internalOrganizationId;

        public PeopleManager(Database db)
        {
            _peopleDAL = new PeopleDAL(db);
            _imagesManager = new ImagesManager(db);
            _addressesManager = new AddressesManager(db);
        }

        protected override int Create(Person person)
        {
            return Create(person, _internalOrganizationId);
        }

        public int Create(Person person, int internalOrganizationId)
        {
            _imagesManager.HandleEntity(person.ProfileImage);
            _addressesManager.HandleEntity(person.Address);

            try
            {
                return _peopleDAL.Create(person, internalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Person Read(int personId)
        {
            if (personId == 0)
            {
                return null;
            }

            try
            {
                _person = _peopleDAL.Read(personId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _person.ProfileImage = _imagesManager.Read(Helper.GetId(_person.ProfileImage));
            _person.Address = _addressesManager.Read(Helper.GetId(_person.Address));

            return _person;
        }

        protected override void Update(Person person)
        {
            Update(person, _internalOrganizationId);
        }

        public void Update(Person person, int internalOrganizationId)
        {
            _imagesManager.HandleEntity(person.ProfileImage);
            _addressesManager.HandleEntity(person.Address);

            try
            {
                _peopleDAL.Update(person, internalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected override int FindId(Person person)
        {
            return FindId(person, _internalOrganizationId);
        }

        public int FindId(Person person, int internalOrganizationId)
        {
            try
            {
                return _peopleDAL.FindId(person, internalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public int FindInternalOrganizationId(Person person)
        {
            try
            {
                return _peopleDAL.FindInternalOrganizationId(person);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void HandleEntity(Person person, int internalOrganizationId)
        {
            _internalOrganizationId = internalOrganizationId;
            HandleEntity(person);
        }
    }
}
