using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class ImagesManager
    {
        private ImagesDAL _imagesDAL;

        public ImagesManager(Database db)
        {
            _imagesDAL = new ImagesDAL(db);
        }

        public Image Read(int imageId)
        {
            if (imageId == 0)
            {
                return null;
            }

            try
            {
                return _imagesDAL.Read(imageId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
