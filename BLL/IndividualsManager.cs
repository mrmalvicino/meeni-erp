using System;
using Entities;
using DAL;

namespace BLL
{
    public class IndividualsManager // Es necesario hacer atributos y métodos protected para que los managers que hereden tengan acceso
    {
        // ATTRIBUTES

        protected Database _database = new Database();

        // METHODS

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
            _database.setParameter("@PhoneCountry", reg.Phone.Country);
            _database.setParameter("@PhoneArea", reg.Phone.Area);
            _database.setParameter("@PhoneNumber", reg.Phone.Number);
            _database.setParameter("@AdressCountry", reg.Adress.Country);
            _database.setParameter("@AdressProvince", reg.Adress.Province);
            _database.setParameter("@AdressCity", reg.Adress.City);
            _database.setParameter("@AdressZipCode", reg.Adress.ZipCode);
            _database.setParameter("@AdressStreet", reg.Adress.Street);
            _database.setParameter("@AdressStreetNumber", reg.Adress.StreetNumber);
            _database.setParameter("@AdressFlat", reg.Adress.Flat);
            _database.setParameter("@LegalIdXX", reg.LegalId.XX);
            _database.setParameter("@LegalIdDNI", reg.LegalId.DNI);
            _database.setParameter("@LegalIdY", reg.LegalId.Y);
        }

        protected void readIndividual(Individual reg)
        {
            if (!(_database.Reader["ActiveStatus"] is DBNull))
                reg.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
            if (!(_database.Reader["IsPerson"] is DBNull))
                reg.IsPerson = (bool)_database.Reader["IsPerson"];
            if (!(_database.Reader["FirstName"] is DBNull))
                reg.FirstName = (string)_database.Reader["FirstName"];
            if (!(_database.Reader["LastName"] is DBNull))
                reg.LastName = (string)_database.Reader["LastName"];
            if (!(_database.Reader["BusinessName"] is DBNull))
                reg.BusinessName = (string)_database.Reader["BusinessName"];
            if (!(_database.Reader["BusinessDescription"] is DBNull))
                reg.BusinessDescription = (string)_database.Reader["BusinessDescription"];
            if (!(_database.Reader["ImageUrl"] is DBNull))
                reg.ImageUrl = (string)_database.Reader["ImageUrl"];
            if (!(_database.Reader["Email"] is DBNull))
                reg.Email = (string)_database.Reader["Email"];

            if (!(_database.Reader["PhoneCountry"] is DBNull))
                reg.Phone.Country = (int)_database.Reader["PhoneCountry"];
            if (!(_database.Reader["PhoneArea"] is DBNull))
                reg.Phone.Area = (int)_database.Reader["PhoneArea"];
            if (!(_database.Reader["PhoneNumber"] is DBNull))
                reg.Phone.Number = (int)_database.Reader["PhoneNumber"];

            if (!(_database.Reader["AdressCountry"] is DBNull))
                reg.Adress.Country = (string)_database.Reader["AdressCountry"];
            if (!(_database.Reader["AdressProvince"] is DBNull))
                reg.Adress.Province = (string)_database.Reader["AdressProvince"];
            if (!(_database.Reader["AdressCity"] is DBNull))
                reg.Adress.City = (string)_database.Reader["AdressCity"];
            if (!(_database.Reader["AdressZipCode"] is DBNull))
                reg.Adress.ZipCode = (string)_database.Reader["AdressZipCode"];
            if (!(_database.Reader["AdressStreet"] is DBNull))
                reg.Adress.Street = (string)_database.Reader["AdressStreet"];
            if (!(_database.Reader["AdressStreetNumber"] is DBNull))
                reg.Adress.StreetNumber = (int)_database.Reader["AdressStreetNumber"];
            if (!(_database.Reader["AdressFlat"] is DBNull))
                reg.Adress.Flat = (string)_database.Reader["AdressFlat"];

            if (!(_database.Reader["LegalIdXX"] is DBNull))
                reg.LegalId.XX = (string)_database.Reader["LegalIdXX"];
            if (!(_database.Reader["LegalIdDNI"] is DBNull))
                reg.LegalId.DNI = (int)_database.Reader["LegalIdDNI"];
            if (!(_database.Reader["LegalIdY"] is DBNull))
                reg.LegalId.Y = (string)_database.Reader["LegalIdY"];
        }
    }
}
