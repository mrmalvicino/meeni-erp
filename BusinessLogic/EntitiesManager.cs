using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class EntitiesManager
    {
        private Entity _entity;
        private EntitiesDAL _entitiesDAL;
        private ImagesManager _imagesManager;
        private AddressesManager _addressesManager;

        public EntitiesManager(Database db)
        {
            _entitiesDAL = new EntitiesDAL(db);
            _imagesManager = new ImagesManager(db);
            _addressesManager = new AddressesManager(db);
        }

        public int Create(Entity entity)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    entity.LogoImage = _imagesManager.Handle(entity.LogoImage);
                    entity.Address = _addressesManager.Handle(entity.Address);
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

            _entity.LogoImage = _imagesManager.Read(Helper.GetId(_entity.LogoImage));
            _entity.Address = _addressesManager.Read(Helper.GetId(_entity.Address));

            return _entity;
        }

        public void Update(Entity entity)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    entity.LogoImage = _imagesManager.Handle(entity.LogoImage);
                    entity.Address = _addressesManager.Handle(entity.Address);
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

        private void Validate(Entity entity)
        {
            Validator.ValidateOrganizationName(entity.Name);

            if (!string.IsNullOrEmpty(entity.CUIT))
            {
                Validator.ValidateCUIT(entity.CUIT);
            }

            if (!string.IsNullOrEmpty(entity.Email))
            {
                Validator.ValidateEmail(entity.Email);
            }

            if (!string.IsNullOrEmpty(entity.Phone))
            {
                Validator.ValidatePhone(entity.Phone);
            }
        }
    }
}
