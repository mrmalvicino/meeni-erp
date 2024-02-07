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

        protected void readBusinessPartner(BusinessPartner businessPartner, int businessPartnerId)
        {
            _database.setQuery($"SELECT PaymentMethod, InvoiceCategory, IndividualId FROM businessPartners WHERE BusinessPartnerId = {businessPartnerId}");
            _database.executeReader();

            businessPartner.PaymentMethod = (string)_database.Reader["PaymentMethod"];
            businessPartner.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];
            businessPartner.IndividualId = (int)_database.Reader["IndividualId"];
        }

        public void delete(BusinessPartner businessPartner)
        {
            try
            {
                _database.setQuery("DELETE FROM businessPartners WHERE BusinessPartnerId = @BusinessPartnerId");
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
        }
    }
}
