﻿using System;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class BusinessPartnersManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private Individual _individual;
        private IndividualsManager _individualsManager = new IndividualsManager();

        // METHODS

        public BusinessPartner read(int businessPartnerId)
        {
            BusinessPartner businessPartner = new BusinessPartner();

            try
            {
                _database.setQuery("select PaymentMethod, InvoiceCategory, IndividualId from BusinessPartners where BusinessPartnerId = @BusinessPartnerId");
                _database.setParameter("@BusinessPartnerId", businessPartnerId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    businessPartner.BusinessPartnerId = businessPartnerId;

                    if (!(_database.Reader["PaymentMethod"] is DBNull))
                    {
                        businessPartner.PaymentMethod = (string)_database.Reader["PaymentMethod"];
                    }

                    if (!(_database.Reader["InvoiceCategory"] is DBNull))
                    {
                        businessPartner.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];
                    }

                    businessPartner.IndividualId = (int)_database.Reader["IndividualId"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            _individual = _individualsManager.read(businessPartner.IndividualId);
            Helper.assignIndividual(businessPartner, _individual);

            return businessPartner;
        }
        
        public void add(BusinessPartner businessPartner)
        {
            _individualsManager.add(businessPartner);
            businessPartner.IndividualId = Helper.getLastId("Individuals");

            try
            {
                _database.setQuery("insert into BusinessPartners (PaymentMethod, InvoiceCategory, IndividualId) values (@PaymentMethod, @InvoiceCategory, @IndividualId)");
                setParameters(businessPartner);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void edit(BusinessPartner businessPartner)
        {
            _individualsManager.edit(businessPartner);

            try
            {
                _database.setQuery("update BusinessPartners set PaymentMethod = @PaymentMethod, InvoiceCategory = @InvoiceCategory, IndividualId = @IndividualId where BusinessPartnerId = @BusinessPartnerId");
                _database.setParameter("@BusinessPartnerId", businessPartner.BusinessPartnerId);
                setParameters(businessPartner);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void delete(BusinessPartner businessPartner)
        {
            try
            {
                _database.setQuery("delete from BusinessPartners where BusinessPartnerId = @BusinessPartnerId");
                _database.setParameter("@BusinessPartnerId", businessPartner.BusinessPartnerId);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            _individualsManager.delete(businessPartner);
        }

        private void setParameters(BusinessPartner businessPartner)
        {
            if (Validations.hasData(businessPartner.PaymentMethod))
            {
                _database.setParameter("@PaymentMethod", businessPartner.PaymentMethod);
            }
            else
            {
                _database.setParameter("@PaymentMethod", DBNull.Value);
            }

            if (Validations.hasData(businessPartner.InvoiceCategory, 0))
            {
                _database.setParameter("@InvoiceCategory", businessPartner.InvoiceCategory);
            }
            else
            {
                _database.setParameter("@InvoiceCategory", DBNull.Value);
            }

            _database.setParameter("@IndividualId", businessPartner.IndividualId);
        }
    }
}
