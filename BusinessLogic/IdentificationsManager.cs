using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class IdentificationsManager : BaseManager<Identification>
    {
        private Identification _identification;
        private IdentificationsDAL _identificationsDAL;
        private IdentificationTypesManager _identificationTypesManager;
        private int _organizationId;

        public IdentificationsManager(Database db)
        {
            _identificationsDAL = new IdentificationsDAL(db);
            _identificationTypesManager = new IdentificationTypesManager(db);
        }

        protected override int Create(Identification identification)
        {
            try
            {
                Validate(identification);
                return _identificationsDAL.Create(identification);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Identification Read(int identificationId)
        {
            if (identificationId == 0)
            {
                return null;
            }

            try
            {
                _identification = _identificationsDAL.Read(identificationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _identification;
        }

        protected override void Update(Identification identification)
        {
            try
            {
                Validate(identification);
                _identificationsDAL.Update(identification);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected override int FindId(Identification identification)
        {
            return FindId(identification, _organizationId);
        }

        public int FindId(Identification identification, int organizationId)
        {
            try
            {
                return _identificationsDAL.FindId(identification, organizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Identification Handle(Identification identification, int organizationId)
        {
            if (string.IsNullOrWhiteSpace(identification.Code))
            {
                return null;
            }

            _organizationId = organizationId;
            HandleAttribute(identification);

            return identification;
        }

        private void Validate(Identification identification)
        {
            // TODO
        }
    }
}
