using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace BLL
{
    public class SuppliersManager : IndividualsManager
    {
        // METHODS

        public void createSuppliersTable()
        {
            string individualColumns = "ActiveStatus bit, IsPerson bit, FirstName varchar(30), LastName varchar(30), BusinessName varchar(30), BusinessDescription varchar(30), ImageUrl varchar(300), Email varchar(30)";
            string individualPhone = "PhoneCountry int, PhoneArea int, PhoneNumber int";
            string individualAdress = "AdressCountry varchar(30), AdressProvince varchar(30), AdressCity varchar(30), AdressZipCode varchar(30), AdressStreet varchar(30), AdressStreetNumber int, AdressFlat varchar(30)";
            string individualLegalId = "LegalIdXX varchar(30), LegalIdDNI int, LegalIdY varchar(30)";
            string businessPartnerColumns = "PaymentMethod varchar(30), InvoiceCategory varchar(30)";
            string supplierColumns = "IsIndispensable bit";
            string createTableQuery = $"CREATE TABLE suppliers(Id int primary key identity, {individualColumns}, {individualPhone}, {individualAdress}, {individualLegalId}, {businessPartnerColumns}, {supplierColumns})";
            _database.createTable("suppliers", createTableQuery);
        }

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

                    readIndividual(supplier);
                    supplier.Id = (int)_database.Reader["Id"];

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

        public void add(Individual reg)
        {
            try
            {
                _database.setQuery("INSERT INTO suppliers (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY)");
                setupIndividualParameters(reg);
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

        public void edit(Supplier reg)
        {
            try
            {
                _database.setQuery("UPDATE suppliers SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY WHERE Id = @Id");
                _database.setParameter("@Id", reg.Id);
                setupIndividualParameters(reg);
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
