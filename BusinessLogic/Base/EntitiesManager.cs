using DomainModel.Base;
using BusinessLogic.Common;
using BusinessLogic.Locations;
using DataAccess;
using DataAccess.Base;
using Exceptions;
using System;
using System.Transactions;
using Utilities;

namespace BusinessLogic.Base
{
    public class EntitiesManager
    {
        private Entity _entity;
        private EntitiesDAL _entitiesDAL;
        private ImagesManager _imagesManager;
        private AddressesManager _addressesManager;
        private IdentificationsManager _identificationsManager;

        public EntitiesManager(Database db)
        {
            _entitiesDAL = new EntitiesDAL(db);
            _imagesManager = new ImagesManager(db);
            _addressesManager = new AddressesManager(db);
            _identificationsManager = new IdentificationsManager(db);
        }

        public int Create(Entity entity)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    entity.Image = _imagesManager.Handle(entity.Image);
                    entity.Address = _addressesManager.Handle(entity.Address);
                    entity.Identification = _identificationsManager.Handle(entity.Identification, FindOrganizationId(entity.Id));
                    Validate(entity);
                    entity.Id = _entitiesDAL.Create(entity);
                    transaction.Complete();
                    return entity.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public Entity Read(int entityId)
        {
            if (entityId == 0)
            {
                return null;
            }

            try
            {
                _entity = _entitiesDAL.Read(entityId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _entity.Image = _imagesManager.Read(Helper.GetId(_entity.Image));
            _entity.Address = _addressesManager.Read(Helper.GetId(_entity.Address));
            _entity.Identification = _identificationsManager.Read(Helper.GetId(_entity.Identification));

            return _entity;
        }

        public void Update(Entity entity)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    entity.Image = _imagesManager.Handle(entity.Image);
                    entity.Address = _addressesManager.Handle(entity.Address);
                    entity.Identification = _identificationsManager.Handle(entity.Identification, FindOrganizationId(entity.Id));
                    Validate(entity);
                    _entitiesDAL.Update(entity);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        private int FindOrganizationId(int entityId)
        {
            try
            {
                return _entitiesDAL.FindOrganizationId(entityId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        private void Validate(Entity entity)
        {
            Validator.ValidateEntityName(entity.Name);

            if (!string.IsNullOrEmpty(entity.Email))
            {
                Validator.ValidateEmail(entity.Email);
            }

            if (!string.IsNullOrEmpty(entity.Phone))
            {
                Validator.ValidatePhone(entity.Phone);
            }

            if (entity.BirthDate != DateTime.MinValue)
            {
                Validator.ValidateBirthDate(entity.BirthDate);
            }
        }
    }
}
