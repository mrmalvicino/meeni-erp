using DataAccess;
using DataAccess.Common;
using DomainModel.Common;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic.Common
{
    public class ImagesManager : BaseManager<Image>
    {
        private Image _image;
        private ImagesDAL _imagesDAL;

        public ImagesManager(Database db)
        {
            _imagesDAL = new ImagesDAL(db);
        }

        protected override int Create(Image image)
        {
            try
            {
                Validate(image);
                return _imagesDAL.Create(image);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Image Read(int imageId)
        {
            if (imageId == 0)
            {
                return null;
            }

            try
            {
                _image = _imagesDAL.Read(imageId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _image;
        }

        protected override void Update(Image image)
        {
            try
            {
                Validate(image);
                _imagesDAL.Update(image);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected override int FindId(Image image)
        {
            try
            {
                return _imagesDAL.FindId(image);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Image Handle(Image image)
        {
            if (image == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(image.URL))
            {
                return null;
            }

            HandleAttribute(image);

            return image;
        }

        private void Validate(Image image)
        {
            Validator.ValidateURL(image.URL);
        }
    }
}
