﻿using DAL;
using Entities;
using System;

namespace BLL
{
    public class ImagesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public Image read(int imageId)
        {
            Image image = new Image();

            try
            {
                _database.setQuery("select ImageUrl from Images where ImageId = @ImageId");
                _database.setParameter("@ImageId", imageId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    image.ImageId = imageId;
                    image.Url = (string)_database.Reader["ImageUrl"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            return image;
        }

        public void add(Image image)
        {
            try
            {
                _database.setQuery("insert into Images (ImageUrl) values (@ImageUrl)");
                _database.setParameter("@ImageUrl", image.Url);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void edit(Image image)
        {
            try
            {
                _database.setQuery("update Images set ImageUrl = @ImageUrl where ImageId = @ImageId");
                _database.setParameter("@ImageId", image.ImageId);
                _database.setParameter("@ImageUrl", image.Url);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public int getId(Image image)
        {
            try
            {
                _database.setQuery("select ImageId from Images where ImageUrl = @ImageUrl");
                _database.setParameter("@ImageUrl", image.Url);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    return (int)_database.Reader["ImageId"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            return 0;
        }
    }
}
