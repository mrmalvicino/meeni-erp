using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class ServicesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private Item _item;
        private ItemsManager _itemsManager = new ItemsManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();

        // METHODS

        public List<Service> list()
        {
            List<Service> servicesList = new List<Service>();

            try
            {
                _database.setQuery("select ServiceId, ModelId, ItemId from Services");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Service service = new Service();

                    service.ServiceId = (int)_database.Reader["ServiceId"];
                    service.Model.ModelId = (int)_database.Reader["ModelId"];
                    service.ItemId = (int)_database.Reader["ItemId"];

                    servicesList.Add(service);
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

            foreach (Service service in servicesList)
            {
                _item = _itemsManager.read(service.ItemId);
                Helper.assignItem(service, _item);
                service.Model = _modelsManager.read(service.Model.ModelId);
                service.Brand.BrandId = _modelsManager.getBrandId(service.Model);
                service.Brand = _brandsManager.read(service.Brand.BrandId);
            }

            return servicesList;
        }

        public Service read(int serviceId)
        {
            Service service = new Service();

            try
            {
                _database.setQuery("select ModelId, ItemId from Services where ServiceId = @ServiceId");
                _database.setParameter("@ServiceId", serviceId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    service.ServiceId = serviceId;
                    service.Model.ModelId = (int)_database.Reader["ModelId"];
                    service.ItemId = (int)_database.Reader["ItemId"];
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

            _item = _itemsManager.read(service.ItemId);
            Helper.assignItem(service, _item);
            service.Model = _modelsManager.read(service.Model.ModelId);
            service.Brand.BrandId = _modelsManager.getBrandId(service.Model);
            service.Brand = _brandsManager.read(service.Brand.BrandId);

            return service;
        }

        public void add(Service service)
        {
            _itemsManager.add(service);
            service.ItemId = Helper.getLastId("Items");

            int dbBrandId = _brandsManager.getId(service.Brand);

            if (dbBrandId == 0)
            {
                _brandsManager.add(service.Brand);
                service.Brand.BrandId = Helper.getLastId("Brands");
            }
            else
            {
                service.Brand.BrandId = dbBrandId;
            }

            int dbModelId = _modelsManager.getId(service.Model);

            if (dbModelId == 0)
            {
                _modelsManager.add(service.Model, service.Brand.BrandId);
                service.Model.ModelId = Helper.getLastId("Models");
            }
            else
            {
                service.Model.ModelId = dbModelId;
            }

            try
            {
                _database.setQuery("insert into Services (ModelId, ItemId) values (@ModelId, @ItemId)");
                setParameters(service);
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

        public void edit(Service service)
        {
            _itemsManager.edit(service);

            int dbBrandId = _brandsManager.getId(service.Brand);

            if (dbBrandId == 0)
            {
                _brandsManager.add(service.Brand);
                service.Brand.BrandId = Helper.getLastId("Brands");
            }
            else if (dbBrandId == service.Brand.BrandId)
            {
                _brandsManager.edit(service.Brand);
            }
            else
            {
                service.Brand.BrandId = dbBrandId;
            }

            int dbModelId = _modelsManager.getId(service.Model);

            if (dbModelId == 0)
            {
                _modelsManager.add(service.Model, service.Brand.BrandId);
                service.Model.ModelId = Helper.getLastId("Models");
            }
            else if (dbModelId == service.Model.ModelId)
            {
                _modelsManager.edit(service.Model, service.Brand.BrandId);
            }
            else
            {
                service.Model.ModelId = dbModelId;
            }

            try
            {
                _database.setQuery("update Services set ModelId = @ModelId, ItemId = @ItemId where ServiceId = @ServiceId");
                _database.setParameter("@ServiceId", service.ServiceId);
                setParameters(service);
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

        public void delete(Service service)
        {
            try
            {
                _database.setQuery("delete from Services where ServiceId = @ServiceId");
                _database.setParameter("@ServiceId", service.ServiceId);
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

            _itemsManager.delete(service);
        }

        private void setParameters(Service service)
        {
            _database.setParameter("@ModelId", service.Model.ModelId);
            _database.setParameter("@ItemId", service.ItemId);
        }
    }
}
