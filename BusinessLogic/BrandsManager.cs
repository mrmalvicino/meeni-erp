using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace BusinessLogic
{
    public class BrandsManager : BaseManager<Brand>
    {
        private Brand _brand;
        private BrandsDAL _brandsDAL;
        private int _organizationId;

        public BrandsManager(Database db)
        {
            _brandsDAL = new BrandsDAL(db);
        }

        protected override int Create(Brand attribute)
        {
            throw new NotImplementedException();
        }

        public int Create(Brand brand, int organizationId)
        {
            try
            {
                return _brandsDAL.Create(brand, organizationId);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Brand Read(int brandId)
        {
            if (brandId == 0)
            {
                return null;
            }

            try
            {
                _brand = _brandsDAL.Read(brandId);
                return _brand;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected override void Update(Brand attribute)
        {
            throw new NotImplementedException();
        }

        public void CallUpdate(Brand brand)
        {
            try
            {
                _brandsDAL.Update(brand);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void Toggle(int brandId)
        {
            try
            {
                _brandsDAL.Toggle(brandId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Brand> List(int organizationId, bool active, bool inactive)
        {
            try
            {
                return _brandsDAL.List(organizationId, active, inactive);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected override int FindId(Brand brand)
        {
            return FindId(brand, _organizationId);
        }

        public int FindId(Brand brand, int organizationId)
        {
            try
            {
                return _brandsDAL.FindId(brand, organizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Brand Handle(Brand brand, int organizationId)
        {
            if (brand == null)
            {
                return null;
            }

            if (Validator.IsEmpty(brand.Name))
            {
                return null;
            }

            _organizationId = organizationId;
            HandleAttribute(brand);

            return brand;
        }
    }
}
