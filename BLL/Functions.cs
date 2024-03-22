using System;
using DAL;
using Entities;

namespace BLL
{
    public static class Functions
    {
        // METHODS

        public static void assign<DestinyClass, OriginClass>(DestinyClass destinyObject, OriginClass originObject)
            where DestinyClass : Individual, new()
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
            destinyObject.Image = originObject.Image;

            if (originObject is BusinessPartner && destinyObject is BusinessPartner)
            {
                (destinyObject as BusinessPartner).BusinessPartnerId = (originObject as BusinessPartner).BusinessPartnerId;
                (destinyObject as BusinessPartner).PaymentMethod = (originObject as BusinessPartner).PaymentMethod;
                (destinyObject as BusinessPartner).InvoiceCategory = (originObject as BusinessPartner).InvoiceCategory;
            }

            if (originObject is Customer && destinyObject is Customer)
            {
                (destinyObject as Customer).CustomerId = (originObject as Customer).CustomerId;
                (destinyObject as Customer).SalesAmount = (originObject as Customer).SalesAmount;
            }
        }

        public static int getLastId(string table)
        {
            int lastId = 0;
            Database database = new Database();

            try
            {
                database.setQuery("select ident_current(@Table) as LastId");
                database.setParameter("@Table", table);
                database.executeReader();

                if (database.Reader.Read())
                    lastId = Convert.ToInt32(database.Reader["LastId"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                database.closeConnection();
            }

            return lastId;
        }

        public static bool hasData(string text)
        {
            if (text == "")
            {
                return false;
            }

            if (text.Length < 2)
            {
                return false;
            }

            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            return true;
        }
    }
}
