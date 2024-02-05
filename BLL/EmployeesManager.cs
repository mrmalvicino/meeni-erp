using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class EmployeesManager : IndividualsManager
    {
        // METHODS

        public List<Employee> list()
        {
            List<Employee> list = new List<Employee>();

            try
            {
                _database.setQuery("SELECT EmployeeId, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, Admission, CategoryId, Area, Title, Seniority FROM employees E, categories C WHERE E.CategoryId = C.Id");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Employee employee = new Employee();

                    readIndividual(employee);
                    employee.EmployeeId = (int)_database.Reader["EmployeeId"];
                    employee.Admission = (DateTime)_database.Reader["Admission"];

                    if (!(_database.Reader["CategoryId"] is DBNull))
                    {
                        employee.Category.Id = (int)_database.Reader["CategoryId"];
                        employee.Category.Area = (string)_database.Reader["Area"];
                        employee.Category.Title = (string)_database.Reader["Title"];
                        employee.Category.Seniority = (string)_database.Reader["Seniority"];
                    }

                    list.Add(employee);
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

        public void add(Employee reg)
        {
            try
            {
                _database.setQuery("INSERT INTO employees (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, CategoryId) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY, @CategoryId)");
                setupIndividualParameters(reg);
                _database.setParameter("@CategoryId", reg.Category.Id);
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

        public void edit(Employee reg)
        {
            try
            {
                _database.setQuery("UPDATE employees SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY, CategoryId = @CategoryId WHERE EmployeeId = @EmployeeId");
                setupIndividualParameters(reg);
                _database.setParameter("@EmployeeId", reg.EmployeeId);
                _database.setParameter("@CategoryId", reg.Category.Id);
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

        public void delete(int EmployeeId)
        {
            try
            {
                _database.setQuery("DELETE FROM employees WHERE EmployeeId = @EmployeeId");
                _database.setParameter("@EmployeeId", EmployeeId);
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
