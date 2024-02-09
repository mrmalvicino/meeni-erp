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

        public List<BusinessPartner> listBusinessPartners()
        {
            List<BusinessPartner> businessPartnersList = new List<BusinessPartner>();

            try
            {
                _database.setQuery("SELECT BusinessPartnerId, PaymentMethod, InvoiceCategory, IndividualId FROM businessPartners");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    BusinessPartner businessPartner = new BusinessPartner();

                    businessPartner.BusinessPartnerId = (int)_database.Reader["BusinessPartnerId"];
                    businessPartner.PaymentMethod = (string)_database.Reader["PaymentMethod"];
                    businessPartner.InvoiceCategory = (string)_database.Reader["InvoiceCategory"];
                    businessPartner.IndividualId = (int)_database.Reader["IndividualId"];

                    businessPartnersList.Add(businessPartner);
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

            foreach (BusinessPartner b in businessPartnersList)
            {
                foreach (Individual i in listIndividuals())
                {
                    if (b.IndividualId == i.IndividualId)
                    {
                        b.ActiveStatus = i.ActiveStatus;
                        b.IsPerson = i.IsPerson;
                        b.FirstName = i.FirstName;
                        b.LastName = i.LastName;
                        b.BusinessName = i.BusinessName;
                        b.BusinessDescription = i.BusinessDescription;
                        b.ImageUrl = i.ImageUrl;
                        b.Email = i.Email;
                        b.Phone.PhoneId = i.Phone.PhoneId;
                        b.Adress.AdressId = i.Adress.AdressId;
                        b.TaxCode.TaxCodeId = i.TaxCode.TaxCodeId;

                        b.Phone.Number = i.Phone.Number;
                        b.Phone.Country.CountryId = i.Phone.Country.CountryId;
                        b.Phone.Province.ProvinceId = i.Phone.Province.ProvinceId;

                        b.Phone.Country.PhoneAreaCode = i.Phone.Country.PhoneAreaCode;
                        b.Phone.Province.PhoneAreaCode = i.Phone.Province.PhoneAreaCode;

                        b.Adress.City = i.Adress.City;
                        b.Adress.ZipCode = i.Adress.ZipCode;
                        b.Adress.StreetName = i.Adress.StreetName;
                        b.Adress.StreetNumber = i.Adress.StreetNumber;
                        b.Adress.Flat = i.Adress.Flat;
                        b.Adress.Country.CountryId = i.Adress.Country.CountryId;
                        b.Adress.Province.ProvinceId = i.Adress.Province.ProvinceId;

                        b.Adress.Country.Name = i.Adress.Country.Name;
                        b.Adress.Province.Name = i.Adress.Province.Name;

                        b.TaxCode.Prefix = i.TaxCode.Prefix;
                        b.TaxCode.Number = i.TaxCode.Number;
                        b.TaxCode.Suffix = i.TaxCode.Suffix;
                    }
                }
            }

            return businessPartnersList;
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

                add(businessPartner.copyToIndividual());
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

                edit(businessPartner.copyToIndividual());
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

                delete(businessPartner.copyToIndividual());
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
