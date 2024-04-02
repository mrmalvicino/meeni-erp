using System;
using System.Collections.Generic;
using DAL;
using Entities;
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
                _database.setQuery("select ServiceId, ServiceDescription, ItemId from Services");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Service service = new Service();

                    service.ServiceId = (int)_database.Reader["ServiceId"];
                    service.Description = (string)_database.Reader["ServiceDescription"];
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
            }

            return servicesList;
        }

        public Service read(int serviceId)
        {
            Service service = new Service();

            try
            {
                _database.setQuery("select ServiceDescription, ItemId from Services where ServiceId = @ServiceId");
                _database.setParameter("@ServiceId", serviceId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    service.ServiceId = serviceId;
                    service.Description = (string)_database.Reader["ServiceDescription"];
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

            return service;
        }

        public void add(Service service)
        {
            _itemsManager.add(service);
            service.ItemId = Helper.getLastId("Items");

            try
            {
                _database.setQuery("insert into Services (ServiceDescription, ItemId) values (@ServiceDescription, @ItemId)");
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

            try
            {
                _database.setQuery("update Services set ServiceDescription = @ServiceDescription, ItemId = @ItemId where ServiceId = @ServiceId");
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
            _database.setParameter("@ServiceDescription", service.Description);
            _database.setParameter("@ItemId", service.ItemId);
        }
    }
}
