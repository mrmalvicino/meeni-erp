using DataAccess;
using DomainModel;
using Exceptions;
using System;

namespace BusinessLogic
{
    public class EmployeesManager
    {
        private Employee _employee;
        private EmployeesDAL _employeesDAL;

        public EmployeesManager(Database db)
        {
            _employeesDAL = new EmployeesDAL(db);
        }

        public int Create(Employee employee)
        {
            try
            {
                return _employeesDAL.Create(employee);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Employee Read(int employeeId)
        {
            if (employeeId == 0)
            {
                return null;
            }

            try
            {
                _employee = _employeesDAL.Read(employeeId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _employee;
        }
    }
}
