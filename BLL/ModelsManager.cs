using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class ModelsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Model> list()
        {
            List<Model> modelsList = new List<Model>();

            try
            {
                _database.setQuery("select ModelId, ModelName from Models");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Model model = new Model();

                    model.ModelId = Convert.ToInt32(_database.Reader["ModelId"]);
                    model.Name = (string)_database.Reader["ModelName"];

                    modelsList.Add(model);
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

            return modelsList;
        }

        public Model read(int modelId)
        {
            Model model = new Model();

            try
            {
                _database.setQuery("select ModelName from Models where ModelId = @ModelId");
                _database.setParameter("@ModelId", modelId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    model.ModelId = modelId;
                    model.Name = (string)_database.Reader["ModelName"];
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

            return model;
        }

        public void add(Model model, int brandId)
        {
            try
            {
                _database.setQuery("insert into Models (ModelName, BrandId) values (@ModelName, @BrandId)");
                setParameters(model, brandId);
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

        public void edit(Model model, int brandId)
        {
            try
            {
                _database.setQuery("update Models set ModelName = @ModelName, BrandId = @BrandId where ModelId = @ModelId");
                _database.setParameter("@ModelId", model.ModelId);
                setParameters(model, brandId);
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

        public int getId(Model model)
        {
            if (model == null)
            {
                return 0;
            }

            int modelId = 0;

            try
            {
                _database.setQuery("select ModelId from Models where ModelName = @ModelName");
                _database.setParameter("@ModelName", model.Name);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    modelId = (int)_database.Reader["ModelId"];
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

            return modelId;
        }

        public int getBrandId(Model model)
        {
            if (model == null)
            {
                return 0;
            }

            int brandId = 0;

            try
            {
                _database.setQuery("select BrandId from Models where ModelId = @ModelId");
                _database.setParameter("@ModelId", model.ModelId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    brandId = (int)_database.Reader["BrandId"];
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

            return brandId;
        }

        private void setParameters(Model model, int brandId)
        {
            _database.setParameter("@ModelName", model.Name);
            _database.setParameter("@BrandId", brandId);
        }
    }
}
