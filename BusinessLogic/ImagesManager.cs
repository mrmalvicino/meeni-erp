using DataAccess;
using DomainModel;
using Exceptions;
using System;

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
            try
            {
                return _imagesDAL.Create(image);
            }
            catch (Exception ex)
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
                _imagesDAL.Update(image);
            }
            catch (Exception ex)
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
    }
}
