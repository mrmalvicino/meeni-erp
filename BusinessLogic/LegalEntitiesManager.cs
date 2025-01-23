using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class LegalEntitiesManager
    {
        private LegalEntity _legalEntity;
        private LegalEntitiesDAL _legalEntitiesDAL;
        private ImagesManager _imagesManager;
        private AddressesManager _addressesManager;

        public LegalEntitiesManager(Database db)
        {
            _legalEntitiesDAL = new LegalEntitiesDAL(db);
            _imagesManager = new ImagesManager(db);
            _addressesManager = new AddressesManager(db);
        }

        public int Create(LegalEntity legalEntity)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    legalEntity.LogoImage = _imagesManager.Handle(legalEntity.LogoImage);
                    legalEntity.Address = _addressesManager.Handle(legalEntity.Address);
                    Validate(legalEntity);
                    legalEntity.Id = _legalEntitiesDAL.Create(legalEntity);
                    transaction.Complete();
                    return legalEntity.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public LegalEntity Read(int legalEntityId)
        {
            if (legalEntityId == 0)
            {
                return null;
            }

            try
            {
                _legalEntity = _legalEntitiesDAL.Read(legalEntityId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _legalEntity.LogoImage = _imagesManager.Read(Helper.GetId(_legalEntity.LogoImage));
            _legalEntity.Address = _addressesManager.Read(Helper.GetId(_legalEntity.Address));

            return _legalEntity;
        }

        public void Update(LegalEntity legalEntity)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    legalEntity.LogoImage = _imagesManager.Handle(legalEntity.LogoImage);
                    legalEntity.Address = _addressesManager.Handle(legalEntity.Address);
                    Validate(legalEntity);
                    _legalEntitiesDAL.Update(legalEntity);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        private void Validate(LegalEntity legalEntity)
        {
            Validator.ValidateOrganizationName(legalEntity.Name);

            if (!string.IsNullOrEmpty(legalEntity.CUIT))
            {
                Validator.ValidateCUIT(legalEntity.CUIT);
            }

            if (!string.IsNullOrEmpty(legalEntity.Email))
            {
                Validator.ValidateEmail(legalEntity.Email);
            }

            if (!string.IsNullOrEmpty(legalEntity.Phone))
            {
                Validator.ValidatePhone(legalEntity.Phone);
            }
        }
    }
}
