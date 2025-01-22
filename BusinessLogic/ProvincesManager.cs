using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class ProvincesManager : BaseManager<Province>
    {
        private Province _province;
        private ProvincesDAL _provincesDAL;
        private int _countryId;

        public ProvincesManager(Database db)
        {
            _provincesDAL = new ProvincesDAL(db);
        }

        protected override int Create(Province province)
        {
            return Create(province, _countryId);
        }

        public int Create(Province province, int countryId)
        {
            try
            {
                return _provincesDAL.Create(province, countryId);
            }
            catch (Exception ex) when (!(ex is ValidationException))
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

        protected override void Update(Province province)
        {
            // Not necessary for entities in which DB tables have no fields appart from those that form a unique constraint.
        }

        protected override int FindId(Province province)
        {
            return FindId(province, _countryId);
        }

        public int FindId(Province province, int countryId)
        {
            try
            {
                return _provincesDAL.FindId(province, countryId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public int FindId(City city)
        {
            try
            {
                return _provincesDAL.FindId(city);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Handle(Province province, int countryId)
        {
            _countryId = countryId;
            HandleEntity(province);
        }
    }
}
