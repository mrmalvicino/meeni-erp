using Entities;
using DAL;

namespace BLL
{
    public class IndividualsManager
    {
        // ATTRIBUTES

        protected Database _database = new Database();

        // METHODS

        protected void readIndividual(Individual individual, int individualId)
        {
            _database.setQuery($"SELECT ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneId, AdressId, TaxCodeId FROM individuals WHERE IndividualId = {individualId}");
            _database.executeReader();

            individual.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
            individual.IsPerson = (bool)_database.Reader["IsPerson"];
            individual.FirstName = (string)_database.Reader["FirstName"];
            individual.LastName = (string)_database.Reader["LastName"];
            individual.BusinessName = (string)_database.Reader["BusinessName"];
            individual.BusinessDescription = (string)_database.Reader["BusinessDescription"];
            individual.ImageUrl = (string)_database.Reader["ImageUrl"];
            individual.Email = (string)_database.Reader["Email"];

            individual.Phone.PhoneId = (int)_database.Reader["PhoneId"];
            individual.Adress.AdressId = (int)_database.Reader["AdressId"];
            individual.TaxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];
        }

        protected void readPhone(Phone phone, int phoneId)
        {
            _database.setQuery($"SELECT PhoneNumber, CountryId, ProvinceId FROM phones WHERE PhoneId = {phoneId}");
            _database.executeReader();

            phone.Number = (int)_database.Reader["PhoneNumber"];
            phone.Country.CountryId = (int)_database.Reader["CountryId"];
            phone.Province.ProvinceId = (int)_database.Reader["ProvinceId"];
        }

        protected void readAdress(Adress adress, int adressId)
        {
            _database.setQuery($"SELECT AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId FROM adresses WHERE AdressId = {adressId}");
            _database.executeReader();

            adress.City = (string)_database.Reader["AdressCity"];
            adress.ZipCode = (string)_database.Reader["AdressZipCode"];
            adress.StreetName = (string)_database.Reader["AdressStreetName"];
            adress.StreetNumber = (int)_database.Reader["AdressStreetNumber"];
            adress.Flat = (string)_database.Reader["AdressFlat"];
            adress.Country.CountryId = (int)_database.Reader["CountryId"];
            adress.Province.ProvinceId = (int)_database.Reader["ProvinceId"];
        }

        protected void readTaxCode(TaxCode taxCode, int taxCodeId)
        {
            _database.setQuery($"SELECT TaxCodePrefix, TaxCodeNumber, TaxCodeSuffix FROM taxCodes WHERE TaxCodeId = {taxCodeId}");
            _database.executeReader();

            taxCode.Prefix = (string)_database.Reader["TaxCodePrefix"];
            taxCode.Number = (int)_database.Reader["TaxCodeNumber"];
            taxCode.Suffix = (string)_database.Reader["TaxCodeSuffix"];
        }

        protected void readCountry(Country country, int countryId)
        {
            _database.setQuery($"SELECT CountryName, CountryPhoneAreaCode, CurrencyId FROM countries WHERE CountryId = {countryId}");
            _database.executeReader();

            country.Name = (string)_database.Reader["CountryName"];
            country.PhoneAreaCode = (int)_database.Reader["CountryPhoneAreaCode"];
            country.Currency.CurrencyId = (int)_database.Reader["CurrencyId"];
        }

        protected void readProvince(Province province, int provinceId)
        {
            _database.setQuery($"SELECT ProvinceName, ProvincePhoneAreaCode FROM provinces WHERE ProvinceId = {provinceId}");
            _database.executeReader();

            province.Name = (string)_database.Reader["ProvinceName"];
            province.PhoneAreaCode = (int)_database.Reader["ProvincePhoneAreaCode"];
        }

        protected void readCurrency(Currency currency, int currencyId)
        {
            _database.setQuery($"SELECT Code, Name, Rate, BlackRate FROM currencies WHERE CurrencyId = {currencyId}");
            _database.executeReader();

            currency.Code = (string)_database.Reader["CountryName"];
            currency.Name = (string)_database.Reader["Name"];
            currency.Rate = (decimal)_database.Reader["Rate"];
            currency.BlackRate = (decimal)_database.Reader["BlackRate"];
        }

        protected void setupIndividualParameters(Individual reg)
        {
            _database.setParameter("@ActiveStatus", reg.ActiveStatus);
            _database.setParameter("@IsPerson", reg.IsPerson);
            _database.setParameter("@FirstName", reg.FirstName);
            _database.setParameter("@LastName", reg.LastName);
            _database.setParameter("@BusinessName", reg.BusinessName);
            _database.setParameter("@BusinessDescription", reg.BusinessDescription);
            _database.setParameter("@ImageUrl", reg.ImageUrl);
            _database.setParameter("@Email", reg.Email);

            _database.setParameter("@PhoneCountry", reg.Phone.Country.PhoneAreaCode);
            _database.setParameter("@PhoneArea", reg.Phone.Province.PhoneAreaCode);
            _database.setParameter("@PhoneNumber", reg.Phone.Number);

            _database.setParameter("@AdressCity", reg.Adress.City);
            _database.setParameter("@AdressZipCode", reg.Adress.ZipCode);
            _database.setParameter("@AdressStreet", reg.Adress.StreetName);
            _database.setParameter("@AdressStreetNumber", reg.Adress.StreetNumber);
            _database.setParameter("@AdressFlat", reg.Adress.Flat);
            _database.setParameter("@AdressCountry", reg.Adress.Country.Name);
            _database.setParameter("@AdressProvince", reg.Adress.Province.Name);

            _database.setParameter("@LegalIdXX", reg.TaxCode.Prefix);
            _database.setParameter("@LegalIdDNI", reg.TaxCode.Number);
            _database.setParameter("@LegalIdY", reg.TaxCode.Suffix);
        }
    }
}
