using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class BusinessPartnersManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private IndividualsManager _individualsManager = new IndividualsManager();

        // METHODS

        public BusinessPartner readBusinessPartner(int businessPartnerId)
        {
            BusinessPartner businessPartner = new BusinessPartner();

            try
            {
                _database.setQuery("select BusinessPartnerId, PaymentMethod, InvoiceCategory, IndividualId from BusinessPartners where BusinessPartnerId = @BusinessPartnerId");
                _database.setParameter("@BusinessPartnerId", businessPartnerId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    businessPartner.BusinessPartnerId = (int)_database.Reader["BusinessPartnerId"];

                    if (!(_database.Reader["PaymentMethod"] is DBNull))
                        businessPartner.PaymentMethod = (string)_database.Reader["PaymentMethod"];

                    if (!(_database.Reader["InvoiceCategory"] is DBNull))
                        businessPartner.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];

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

            Individual individual = _individualsManager.readIndividual(businessPartner.IndividualId);
            Helper.assign(businessPartner, individual);

            return businessPartner;
        }
        
        public void add(BusinessPartner businessPartner)
        {
            try
            {
                _database.setQuery("INSERT INTO businessPartners (PaymentMethod, InvoiceCategory, IndividualId) VALUES (@PaymentMethod, @InvoiceCategory, @IndividualId)");

                _database.setParameter("@PaymentMethod", businessPartner.PaymentMethod);
                _database.setParameter("@InvoiceCategory", businessPartner.InvoiceCategory);
                _database.setParameter("@IndividualId", businessPartner.IndividualId);

                _database.executeAction();

                //add(businessPartner.copyToIndividual());
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
            try
            {
                _database.setQuery("UPDATE customers SET PaymentMethod = @PaymentMethod, InvoiceCategory = @InvoiceCategory, IndividualId = @IndividualId WHERE BusinessPartnerId = @BusinessPartnerId");

                _database.setParameter("@BusinessPartnerId", businessPartner.BusinessPartnerId);
                _database.setParameter("@PaymentMethod", businessPartner.PaymentMethod);
                _database.setParameter("@InvoiceCategory", businessPartner.InvoiceCategory);
                _database.setParameter("@IndividualId", businessPartner.IndividualId);

                _database.executeAction();

                //edit(businessPartner.copyToIndividual());
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
                _database.setQuery("DELETE FROM businessPartners WHERE BusinessPartnerId = @BusinessPartnerId");
                _database.setParameter("@BusinessPartnerId", businessPartner.BusinessPartnerId);
                _database.executeAction();

                //delete(businessPartner.copyToIndividual());
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
    }
}
