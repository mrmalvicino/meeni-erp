using DataAccess;

namespace BusinessLogic
{
    public class ImagesManager
    {
        private ImagesDAL _imagesDAL;

        public ImagesManager(Database db)
        {
            _imagesDAL = new ImagesDAL(db);
        }
    }
}
