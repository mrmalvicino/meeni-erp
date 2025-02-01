using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class EmployeesManager
    {
        private Employee _employee;
        private EmployeesDAL _employeesDAL;
        private Stakeholder _stakeholder;
        private StakeholdersManager _stakeholdersManager;

        public EmployeesManager(Database db)
        {
            _employeesDAL = new EmployeesDAL(db);
            _stakeholdersManager = new StakeholdersManager(db);
        }

        public int Create(Employee employee, int organizationId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    employee.Id = _stakeholdersManager.Create(employee, organizationId);
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

            _stakeholder = _stakeholdersManager.Read(_employee.Id);
            Helper.AssignEntity(_employee, _stakeholder);

            return _employee;
        }

        public void Update(Employee employee)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _stakeholdersManager.Update(employee);
                    _employeesDAL.Update(employee);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public void Toggle(int employeeId)
        {
            try
            {
                _employeesDAL.Toggle(employeeId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Employee> List(int organizationId, bool active, bool inactive)
        {
            try
            {
                List<Employee> employees;
                employees = _employeesDAL.List(organizationId, active, inactive);

                foreach (var employee in employees)
                {
                    _stakeholder = _stakeholdersManager.Read(employee.Id);
                    Helper.AssignEntity(employee, _stakeholder);
                }

                return employees;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}
