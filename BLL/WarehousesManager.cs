using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class WarehousesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Warehouse> list()
        {
            List<Warehouse> list = new List<Warehouse>();

            try
            {
                _database.setQuery("SELECT Id, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, SalesAmount FROM warehouses");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Warehouse warehouse = new Warehouse();

                    warehouse.Id = (int)_database.Reader["Id"];
                    warehouse.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    warehouse.Name = (string)_database.Reader["WarehouseName"];
                    warehouse.Adress.Id = (int)_database.Reader["AdressId"];

                    list.Add(warehouse);
                }

                return list;
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

        public void add(Warehouse reg)
        {
            try
            {
                _database.setQuery("INSERT INTO warehouses (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY, @PaymentMethod, @InvoiceCategory)");
                _database.setParameter("@PaymentMethod", reg.PaymentMethod);
                _database.setParameter("@InvoiceCategory", reg.InvoiceCategory);
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

        public void edit(Warehouse reg)
        {
            try
            {
                _database.setQuery("UPDATE warehouses SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY, PaymentMethod = @PaymentMethod, InvoiceCategory = @InvoiceCategory WHERE Id = @Id");
                _database.setParameter("@Id", reg.Id);
                _database.setParameter("@PaymentMethod", reg.PaymentMethod);
                _database.setParameter("@InvoiceCategory", reg.InvoiceCategory);
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

        public void delete(int id)
        {
            try
            {
                _database.setQuery("DELETE FROM warehouses WHERE Id = @Id");
                _database.setParameter("@Id", id);
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
    }
}
