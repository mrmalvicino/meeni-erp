using DomainModel;
using Exceptions;
using System;

namespace DataAccess
{
    public class ImagesDAL
    {
        private Database _db;

        public ImagesDAL(Database db)
        {
            _db = db;
        }

        public Image Read(int imageId)
        {
            try
            {
                _db.SetQuery("select * from images where image_id = @image_id");
                _db.SetParameter("@image_id", imageId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Image image = new Image();
                    ReadRow(image);
                    return image;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void ReadRow(Image image)
        {
            image.Id = Convert.ToInt32(_db.Reader["image_id"]);
            image.Url = _db.Reader["image_url"].ToString();
        }
    }
}
