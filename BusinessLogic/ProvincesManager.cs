using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class ProvincesManager
    {
        private Province _province;
        private ProvincesDAL _provincesDAL;

        public ProvincesManager(Database db)
        {
            _provincesDAL = new ProvincesDAL(db);
        }

        public int Create(Province province, int countryId)
        {
            try
            {
                return _provincesDAL.Create(province, countryId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Province Read(int provinceId)
        {
            if (provinceId == 0)
            {
                return null;
            }

            try
            {
                _province = _provincesDAL.Read(provinceId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _province;
        }
    }
}
