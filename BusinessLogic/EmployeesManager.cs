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
        private Entity _entity;
        private EntitiesManager _entitiesManager;

        public EmployeesManager(Database db)
        {
            _employeesDAL = new EmployeesDAL(db);
            _entitiesManager = new EntitiesManager(db);
        }

        public int Create(Employee employee, int organizationId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    employee.Id = _entitiesManager.Create(employee, organizationId);
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

            _entity = _entitiesManager.Read(_employee.Id);
            Helper.AssignEntity(_employee, _entity);

            return _employee;
        }

        public void Update(Employee employee)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _entitiesManager.CallUpdate(employee);
                    _employeesDAL.Update(employee);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public void Toggle(Employee employee)
        {
            try
            {
                _employeesDAL.Toggle(employee);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
