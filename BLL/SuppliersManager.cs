using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class SuppliersManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private BusinessPartner _businessPartner;
        private BusinessPartnersManager _businessPartnersManager = new BusinessPartnersManager();

        // METHODS

        public List<Supplier> list()
        {
            List<Supplier> suppliersList = new List<Supplier>();

            try
            {
                _database.setQuery("select SupplierId, BusinessPartnerId from Suppliers");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Supplier supplier = new Supplier();

                    supplier.SupplierId = (int)_database.Reader["SupplierId"];
                    supplier.BusinessPartnerId = (int)_database.Reader["BusinessPartnerId"];

                    suppliersList.Add(supplier);
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

            foreach (Supplier supplier in suppliersList)
            {
                _businessPartner = _businessPartnersManager.read(supplier.BusinessPartnerId);
                Helper.assignIndividual(supplier, _businessPartner);
            }

            return suppliersList;
        }

        public Supplier read(int supplierId)
        {
            Supplier supplier = new Supplier();

            try
            {
                _database.setQuery("select SupplierId, BusinessPartnerId from Suppliers where SupplierId = @SupplierId");
                _database.setParameter("@SupplierId", supplierId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    supplier.SupplierId = (int)_database.Reader["SupplierId"];
                    supplier.BusinessPartnerId = (int)_database.Reader["BusinessPartnerId"];
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

            _businessPartner = _businessPartnersManager.read(supplier.BusinessPartnerId);
            Helper.assignIndividual(supplier, _businessPartner);

            return supplier;
        }

        public void add(Supplier supplier)
        {
            _businessPartnersManager.add(supplier);
            supplier.BusinessPartnerId = Helper.getLastId("BusinessPartners");

            try
            {
                _database.setQuery("insert into Suppliers (BusinessPartnerId) values (@BusinessPartnerId)");
                setParameters(supplier);
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

        public void edit(Supplier supplier)
        {
            _businessPartnersManager.edit(supplier);

            try
            {
                _database.setQuery("update Suppliers set BusinessPartnerId = @BusinessPartnerId where SupplierId = @SupplierId");
                _database.setParameter("@SupplierId", supplier.SupplierId);
                setParameters(supplier);
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

        public void delete(Supplier supplier)
        {
            try
            {
                _database.setQuery("delete from Suppliers where SupplierId = @SupplierId");
                _database.setParameter("@SupplierId", supplier.SupplierId);
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

            _businessPartnersManager.delete(supplier);
        }

        private void setParameters(Supplier supplier)
        {
            _database.setParameter("@BusinessPartnerId", supplier.BusinessPartnerId);
        }
    }
}
