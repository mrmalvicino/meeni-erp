﻿using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;

namespace BusinessLogic
{
    public class ApplicationManager
    {
        private Database _db;
        private ImagesManager _imagesManager;
        private InternalOrganizationsManager _internalOrganizationsManager;
        private LegalEntitiesManager _legalEntitiesManager;
        private PeopleManager _peopleManager;
        private PricingPlansManager _pricingPlansManager;
        private RolesManager _rolesManager;
        private UsersManager _usersManager;

        public ImagesManager Images => _imagesManager;
        public InternalOrganizationsManager InternalOrganizations => _internalOrganizationsManager;
        public LegalEntitiesManager LegalEntities => _legalEntitiesManager;
        public PeopleManager People => _peopleManager;
        public PricingPlansManager PricingPlans => _pricingPlansManager;
        public RolesManager Roles => _rolesManager;
        public UsersManager Users => _usersManager;

        public ApplicationManager()
        {
            _db = new Database();
            _imagesManager = new ImagesManager(_db);
            _internalOrganizationsManager = new InternalOrganizationsManager(_db);
            _legalEntitiesManager = new LegalEntitiesManager(_db);
            _peopleManager = new PeopleManager(_db);
            _pricingPlansManager = new PricingPlansManager(_db);
            _rolesManager = new RolesManager(_db);
            _usersManager = new UsersManager(_db);
        }

        public bool SignUp(ref User user, ref InternalOrganization internalOrganization)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    //internalOrganization.Id = _internalOrganizationsManager.Create(internalOrganization);
                    //_usersManager.Create(user);
                    //user = _usersManager.Read(user.Id);
                    //internalOrganization = _internalOrganizationsManager.Read(internalOrganization.Id);
                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new TransactionScopeException(ex);
                }
            }
        }

        public bool Login(ref User user, ref InternalOrganization internalOrganization)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    user.Id = _usersManager.FindId(user);

                    if (0 < user.Id)
                    {
                        user = _usersManager.Read(user.Id);
                        internalOrganization.Id = _peopleManager.FindInternalOrganizationId(user);
                        internalOrganization = _internalOrganizationsManager.Read(internalOrganization.Id);
                        transaction.Complete();
                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    throw new TransactionScopeException(ex);
                }
            }
        }
    }
}
