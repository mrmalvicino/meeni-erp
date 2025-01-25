using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class ApplicationManager
    {
        private Database _db;
        private AddressesManager _addressesManager;
        private CitiesManager _citiesManager;
        private CountriesManager _countriesManager;
        private EmployeesManager _employeesManager;
        private ExternalOrganizationsManager _externalOrganizationsManager;
        private ImagesManager _imagesManager;
        private InternalOrganizationsManager _internalOrganizationsManager;
        private LegalEntitiesManager _legalEntitiesManager;
        private PeopleManager _peopleManager;
        private PricingPlansManager _pricingPlansManager;
        private ProvincesManager _provincesManager;
        private RolesManager _rolesManager;
        private UsersManager _usersManager;

        public AddressesManager Addresses => _addressesManager;
        public CitiesManager Cities => _citiesManager;
        public CountriesManager Countries => _countriesManager;
        public EmployeesManager Employees => _employeesManager;
        public ExternalOrganizationsManager ExternalOrganizations => _externalOrganizationsManager;
        public ImagesManager Images => _imagesManager;
        public InternalOrganizationsManager InternalOrganizations => _internalOrganizationsManager;
        public LegalEntitiesManager LegalEntities => _legalEntitiesManager;
        public PeopleManager People => _peopleManager;
        public PricingPlansManager PricingPlans => _pricingPlansManager;
        public ProvincesManager Provinces => _provincesManager;
        public RolesManager Roles => _rolesManager;
        public UsersManager Users => _usersManager;

        public ApplicationManager()
        {
            _db = new Database();
            _addressesManager = new AddressesManager(_db);
            _citiesManager = new CitiesManager(_db);
            _countriesManager = new CountriesManager(_db);
            _employeesManager = new EmployeesManager(_db);
            _externalOrganizationsManager = new ExternalOrganizationsManager(_db);
            _imagesManager = new ImagesManager(_db);
            _internalOrganizationsManager = new InternalOrganizationsManager(_db);
            _legalEntitiesManager = new LegalEntitiesManager(_db);
            _peopleManager = new PeopleManager(_db);
            _pricingPlansManager = new PricingPlansManager(_db);
            _provincesManager = new ProvincesManager(_db);
            _rolesManager = new RolesManager(_db);
            _usersManager = new UsersManager(_db);
        }

        public bool SignUp(ref User user, ref InternalOrganization internalOrganization)
        {
            try
            {
                ValidateSignUp(user, internalOrganization);

                using (var transaction = new TransactionScope())
                {
                    internalOrganization.Id = _internalOrganizationsManager.Create(internalOrganization);
                    _usersManager.Create(user, internalOrganization.Id);
                    user = _usersManager.Read(user.Id);
                    internalOrganization = _internalOrganizationsManager.Read(internalOrganization.Id);
                    transaction.Complete();
                    return true;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public bool Login(ref User user, ref InternalOrganization internalOrganization)
        {
            try
            {
                ValidateLogin(user);

                using (var transaction = new TransactionScope())
                {
                    user.Id = _usersManager.FindId(user.Username, user.Password);

                    if (user.Id == 0)
                    {
                        throw new ValidationException("Las credenciales ingresadas son inválidas.");
                    }

                    user = _usersManager.Read(user.Id);
                    internalOrganization.Id = _peopleManager.FindInternalOrganizationId(user);
                    internalOrganization = _internalOrganizationsManager.Read(internalOrganization.Id);

                    if (internalOrganization.ActivityStatus == false)
                    {
                        throw new ValidationException("La empresa ha sido dada de baja.");
                    }

                    transaction.Complete();
                    return true;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        private void ValidateSignUp(User user, InternalOrganization internalOrganization)
        {
            if (0 < _usersManager.FindId(user))
            {
                throw new ValidationException("Nombre de usuario no disponible.");
            }

            if (string.IsNullOrEmpty(internalOrganization.Email))
            {
                throw new ValidationException("Ingresar el correo electrónico de la empresa.");
            }

            Validator.ValidateEmail(internalOrganization.Email);
        }

        private void ValidateLogin(User user)
        {
            if (string.IsNullOrEmpty(user.Username))
            {
                throw new ValidationException("Ingresar nombre de usuario.");
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                throw new ValidationException("Ingresar contraseña.");
            }
        }
    }
}
