using DataAccess;
using DataAccess.Base;
using DomainModel.Base;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Base
{
    public class IdentificationTypesManager
    {
        public enum Ids
        {
            DNIId = 1,
            CUITId = 2,
            OtherId = 3
        }

        private IdentificationType _identificationType;
        private IdentificationTypesDAL _IdentificationTypesDAL;

        public IdentificationTypesManager(Database db)
        {
            _IdentificationTypesDAL = new IdentificationTypesDAL(db);
        }

        public IdentificationType Read(int identificationTypeId)
        {
            if (identificationTypeId == 0)
            {
                return null;
            }

            try
            {
                _identificationType = _IdentificationTypesDAL.Read(identificationTypeId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _identificationType;
        }

        public List<IdentificationType> List()
        {
            try
            {
                return _IdentificationTypesDAL.List();
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
