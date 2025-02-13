using DomainModel.Stakeholders;
using Exceptions;
using System;
using System.Collections.Generic;

namespace DataAccess.Stakeholders
{
    public class EmployeesDAL
    {
        private Database _db;

        public EmployeesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Employee employee)
        {
            try
            {
                _db.SetProcedure("sp_create_employee");
                SetParameters(employee);
                employee.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return employee.Id;
        }

        public Employee Read(int employeeId)
        {
            try
            {
                _db.SetQuery("select * from employees where employee_id = @employee_id");
                _db.SetParameter("@employee_id", employeeId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Employee employee = new Employee();
                    ReadRow(employee);
                    return employee;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Update(Employee employee)
        {
            try
            {
                _db.SetProcedure("sp_update_employee");
                SetParameters(employee);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Toggle(int employeeId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_employee");
                _db.SetParameter("@employee_id", employeeId);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public List<Employee> List(int organizationId, bool active, bool inactive)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                _db.SetProcedure("sp_list_employees");
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Employee employee = new Employee();
                    ReadRow(employee);
                    employees.Add(employee);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return employees;
        }

        private void SetParameters(Employee employee)
        {
            _db.SetParameter("@employee_id", employee.Id);

            if (employee.AdmissionDate != null && employee.AdmissionDate != DateTime.MinValue)
            {
                _db.SetParameter("@admission_date", employee.AdmissionDate);
            }
        }

        private void ReadRow(Employee employee)
        {
            employee.Id = Convert.ToInt32(_db.Reader["employee_id"]);
            employee.ActivityStatus = Convert.ToBoolean(_db.Reader["activity_status"]);
            employee.AdmissionDate = Convert.ToDateTime(_db.Reader["admission_date"]);
        }
    }
}
