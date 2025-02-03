using System;

namespace WebForms.UserControls
{
    public partial class AddressFields : System.Web.UI.UserControl
    {
        public string GetStreetName()
        {
            return StreetNameTxt.Text;
        }

        public void SetStreetName(string streetName)
        {
            StreetNameTxt.Text = streetName;
        }

        public string GetStreetNumber()
        {
            return StreetNumberTxt.Text;
        }

        public void SetStreetNumber(string streetNumber)
        {
            StreetNumberTxt.Text = streetNumber;
        }

        public string GetFlat()
        {
            return FlatTxt.Text;
        }

        public void SetFlat(string flat)
        {
            FlatTxt.Text = flat;
        }

        public string GetDetails()
        {
            return DetailsTxt.Text;
        }

        public void SetDetails(string details)
        {
            DetailsTxt.Text = details;
        }

        public string GetCityName()
        {
            return CityTxt.Text;
        }

        public void SetCityName(string cityName)
        {
            CityTxt.Text = cityName;
        }

        public string GetZipCode()
        {
            return ZipCodeTxt.Text;
        }

        public void SetZipCode(string zipCode)
        {
            ZipCodeTxt.Text = zipCode;
        }

        public string GetProvinceName()
        {
            return ProvinceTxt.Text;
        }

        public void SetProvinceName(string provinceName)
        {
            ProvinceTxt.Text = provinceName;
        }

        public string GetCountryName()
        {
            return CountryTxt.Text;
        }

        public void SetCountryName(string countryName)
        {
            CountryTxt.Text = countryName;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}