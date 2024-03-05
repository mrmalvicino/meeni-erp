using Entities;
using System.Xml.Linq;

namespace BLL
{
    public static class Helper
    {
        // METHODS

        public static void assign<DestinyClass, OriginClass>(DestinyClass destinyObject, OriginClass originObject)
            where DestinyClass : OriginClass, new()
            where OriginClass : Individual, new()
        {
            destinyObject.IndividualId = originObject.IndividualId;
            destinyObject.ActiveStatus = originObject.ActiveStatus;
            destinyObject.Email = originObject.Email;
            destinyObject.Birth = originObject.Birth;
            destinyObject.TaxCode = originObject.TaxCode;
            destinyObject.Adress = originObject.Adress;
            destinyObject.Phone = originObject.Phone;
            destinyObject.Person = originObject.Person;
            destinyObject.Organization = originObject.Organization;

            if (originObject is BusinessPartner)
            {
                (destinyObject as BusinessPartner).BusinessPartnerId = (originObject as BusinessPartner).BusinessPartnerId;
                (destinyObject as BusinessPartner).PaymentMethod = (originObject as BusinessPartner).PaymentMethod;
                (destinyObject as BusinessPartner).InvoiceCategory = (originObject as BusinessPartner).InvoiceCategory;
            }

            if (originObject is Customer)
            {
                (destinyObject as Customer).CustomerId = (originObject as Customer).CustomerId;
                (destinyObject as Customer).SalesAmount = (originObject as Customer).SalesAmount;
            }
        }
    }
}
