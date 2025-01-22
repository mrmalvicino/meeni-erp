using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
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
            Validate(image);

            try
            {
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
            Validate(image);

            try
            {
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

        public void Handle(Image image)
        {
            HandleEntity(image);
        }

        private void Validate(Image image)
        {
            if (!Validator.URLExists(image.URL))
            {
                throw new ValidationException("La URL de la imagen no es válida.");
            }
        }
    }
}
