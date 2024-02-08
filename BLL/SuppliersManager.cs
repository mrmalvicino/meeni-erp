using System;
using System.Collections.Generic;
using Entities;

namespace BLL
{
    public class SuppliersManager : IndividualsManager
    {
        // METHODS

        public List<Supplier> list()
        {
            List<Supplier> list = new List<Supplier>();

            try
            {
                _database.setQuery("SELECT Id, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, IsIndispensable FROM suppliers");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Supplier supplier = new Supplier();

                    supplier.SupplierId = (int)_database.Reader["Id"];

                    if (!(_database.Reader["PaymentMethod"] is DBNull))
                        supplier.PaymentMethod = (string)_database.Reader["PaymentMethod"];
                    if (!(_database.Reader["InvoiceCategory"] is DBNull))
                        supplier.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];
                    if (!(_database.Reader["IsIndispensable"] is DBNull))
                        supplier.IsIndispensable = (bool)_database.Reader["IsIndispensable"];

                    list.Add(supplier);
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

        public void add(Supplier reg)
        {
            try
            {
                _database.setQuery("INSERT INTO suppliers (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY, @PaymentMethod, @InvoiceCategory)");
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

        public void edit(Supplier supplier)
        {
            try
            {
                _database.setQuery("UPDATE suppliers SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY, PaymentMethod = @PaymentMethod, InvoiceCategory = @InvoiceCategory WHERE SupplierId = @SupplierId");
                _database.setParameter("@PaymentMethod", supplier.PaymentMethod);
                _database.setParameter("@InvoiceCategory", supplier.InvoiceCategory);
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
        }

        public void delete(int id)
        {
            try
            {
                _database.setQuery("DELETE FROM suppliers WHERE Id = @Id");
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
