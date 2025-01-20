using DomainModel;
using Exceptions;
using System;

namespace DataAccess
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
                SetParameters(employee, true);
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

        private void SetParameters(Employee employee, bool isUpdate = false)
        {
            _db.SetParameter("@employee_id", employee.Id);

            if (isUpdate)
            {
                _db.SetParameter("@activity_status", employee.ActivityStatus);
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
