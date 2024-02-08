using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessPartnersManager : IndividualsManager
    {
        // METHODS

        public void add(BusinessPartner businessPartner)
        {
            try
            {
                _database.setQuery("INSERT INTO businessPartners (PaymentMethod, InvoiceCategory, IndividualId) VALUES (@PaymentMethod, @InvoiceCategory, @IndividualId)");

                _database.setParameter("@PaymentMethod", businessPartner.PaymentMethod);
                _database.setParameter("@InvoiceCategory", businessPartner.InvoiceCategory);
                _database.setParameter("@IndividualId", businessPartner.IndividualId);

                _database.executeAction();

                add(businessPartner.toIndividual());
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

                edit(businessPartner.toIndividual());
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

                delete(businessPartner.toIndividual());
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
        public void readBusinessPartner(BusinessPartner businessPartner, int businessPartnerId)
        {
            _database.setQuery($"SELECT PaymentMethod, InvoiceCategory, IndividualId FROM businessPartners WHERE BusinessPartnerId = {businessPartnerId}");
            _database.executeReader();

            businessPartner.PaymentMethod = (string)_database.Reader["PaymentMethod"];
            businessPartner.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];
            businessPartner.IndividualId = (int)_database.Reader["IndividualId"];
        }
    }
}
