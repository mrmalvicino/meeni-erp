using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
{
    public class EmployeesManager
    {
        private Employee _employee;
        private EmployeesDAL _employeesDAL;
        private Person _person;
        private PeopleManager _peopleManager;

        public EmployeesManager(Database db)
        {
            _employeesDAL = new EmployeesDAL(db);
            _peopleManager = new PeopleManager(db);
        }

        public int Create(Employee employee, int internalOrganizationId)
        {
            employee.Id = _peopleManager.Create(employee, internalOrganizationId);

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

            _person = _peopleManager.Read(_employee.Id);
            Helper.AssignPerson(_employee, _person);

            return _employee;
        }

        public void Update(Employee employee, int internalOrganizationId)
        {
            _peopleManager.Update(employee, internalOrganizationId);

            try
            {
                _employeesDAL.Update(employee);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
