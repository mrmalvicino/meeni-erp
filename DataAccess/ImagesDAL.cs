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

        public int Create(Image image)
        {
            try
            {
                _db.SetProcedure("sp_create_image");
                SetParameters(image);
                image.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return image.Id;
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

        public void Update(Image image)
        {
            try
            {
                _db.SetProcedure("sp_update_image");
                SetParameters(image, true);
                _db.ExecuteAction();
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

        public int FindId(Image image)
        {
            try
            {
                _db.SetProcedure("sp_find_image_id");
                _db.SetParameter("@url", image.URL);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["image_id"];
                }

                return 0;
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

        private void SetParameters(Image image, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@image_id", image.Id);
            }

            _db.SetParameter("@url", image.URL);
        }

        private void ReadRow(Image image)
        {
            image.Id = Convert.ToInt32(_db.Reader["image_id"]);
            image.URL = _db.Reader["url"].ToString();
        }
    }
}
