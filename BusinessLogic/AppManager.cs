using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class AppManager
    {
        private Database _db;
        private AddressesManager _addressesManager;
        private CitiesManager _citiesManager;
        private CountriesManager _countriesManager;
        private EmployeesManager _employeesManager;
        private EntitiesManager _entitiesManager;
        private ImagesManager _imagesManager;
        private OrganizationsManager _organizationsManager;
        private PartnersManager _partnersManager;
        private PricingPlansManager _pricingPlansManager;
        private ProvincesManager _provincesManager;
        private RolesManager _rolesManager;
        private StakeholdersManager _stakeholdersManager;
        private UsersManager _usersManager;

        public AddressesManager Addresses => _addressesManager;
        public CitiesManager Cities => _citiesManager;
        public CountriesManager Countries => _countriesManager;
        public EmployeesManager Employees => _employeesManager;
        public EntitiesManager Entities => _entitiesManager;
        public ImagesManager Images => _imagesManager;
        public OrganizationsManager Organizations => _organizationsManager;
        public PartnersManager Partners => _partnersManager;
        public PricingPlansManager PricingPlans => _pricingPlansManager;
        public ProvincesManager Provinces => _provincesManager;
        public RolesManager Roles => _rolesManager;
        public StakeholdersManager Stakeholders => _stakeholdersManager;
        public UsersManager Users => _usersManager;

        public AppManager()
        {
            _db = new Database();
            _addressesManager = new AddressesManager(_db);
            _citiesManager = new CitiesManager(_db);
            _countriesManager = new CountriesManager(_db);
            _employeesManager = new EmployeesManager(_db);
            _entitiesManager = new EntitiesManager(_db);
            _imagesManager = new ImagesManager(_db);
            _organizationsManager = new OrganizationsManager(_db);
            _partnersManager = new PartnersManager(_db);
            _pricingPlansManager = new PricingPlansManager(_db);
            _provincesManager = new ProvincesManager(_db);
            _rolesManager = new RolesManager(_db);
            _stakeholdersManager = new StakeholdersManager(_db);
            _usersManager = new UsersManager(_db);
        }

        public bool SignUp(ref User user, ref Organization organization)
        {
            try
            {
                ValidateSignUp(user, organization);

                using (var transaction = new TransactionScope())
                {
                    organization.Id = _organizationsManager.Create(organization);
                    _usersManager.Create(user, organization.Id);
                    user = _usersManager.Read(user.Id);
                    organization = _organizationsManager.Read(organization.Id);
                    transaction.Complete();
                    return true;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public bool Login(ref User user, ref Organization organization)
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
                    organization.Id = _stakeholdersManager.FindOrganizationId(user.Id);
                    organization = _organizationsManager.Read(organization.Id);

                    if (organization.ActivityStatus == false)
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

        private void ValidateSignUp(User user, Organization organization)
        {
            if (0 < _usersManager.FindId(user))
            {
                throw new ValidationException("Nombre de usuario no disponible.");
            }

            if (string.IsNullOrEmpty(organization.Email))
            {
                throw new ValidationException("Ingresar el correo electrónico de la empresa.");
            }

            Validator.ValidateEmail(organization.Email);
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
