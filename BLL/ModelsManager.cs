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
                _database.setQuery("select Prefix, Number, Suffix from Models where ModelId = @ModelId");
                _database.setParameter("@ModelId", modelId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    model.ModelId = modelId;

                    if (!(_database.Reader["Prefix"] is DBNull))
                    {
                        model.Prefix = (string)_database.Reader["Prefix"];
                    }

                    model.Number = (string)_database.Reader["Number"];

                    if (!(_database.Reader["Suffix"] is DBNull))
                    {
                        model.Suffix = (string)_database.Reader["Suffix"];
                    }
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

        public void add(Model model)
        {
            try
            {
                _database.setQuery("insert into Models (Prefix, Number, Suffix) values (@Prefix, @Number, @Suffix)");
                setParameters(model);
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

        public void edit(Model model)
        {
            try
            {
                _database.setQuery("update Models set Prefix = @Prefix, Number = @Number, Suffix = @Suffix where ModelId = @ModelId");
                _database.setParameter("@ModelId", model.ModelId);
                setParameters(model);
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
                _database.setQuery("select ModelId from Models where Number = @Number");
                _database.setParameter("@Number", model.Number);
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

        private void setParameters(Model model)
        {
            if (Validations.hasData(model.Prefix, 2, 2))
            {
                _database.setParameter("@Prefix", model.Prefix);
            }
            else
            {
                _database.setParameter("@Prefix", DBNull.Value);
            }

            if (Validations.hasData(model.Number))
            {
                _database.setParameter("@Number", model.Number);
            }
            else
            {
                _database.setParameter("@Number", DBNull.Value);
            }

            if (Validations.hasData(model.Suffix, 1, 1))
            {
                _database.setParameter("@Suffix", model.Suffix);
            }
            else
            {
                _database.setParameter("@Suffix", DBNull.Value);
            }
        }
    }
}
