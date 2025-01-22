using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
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
            try
            {
                using (var transaction = new TransactionScope())
                {
                    employee.Id = _peopleManager.Create(employee, internalOrganizationId);
                    employee.Id = _employeesDAL.Create(employee);
                    transaction.Complete();
                    return employee.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
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
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _peopleManager.Update(employee, internalOrganizationId);
                    _employeesDAL.Update(employee);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }
    }
}
