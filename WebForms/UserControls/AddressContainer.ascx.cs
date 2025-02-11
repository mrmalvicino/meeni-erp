using DomainModel;
using System;

namespace WebForms.UserControls
{
    public partial class AddressContainer : System.Web.UI.UserControl
    {
        private Address _address;

        public Address Address
        {
            get
            {
                _address = (Address)ViewState["Address"];

                if (_address == null)
                {
                    _address = new Address(true);
                }

                _address.StreetName = StreetNameTxt.Text;
                _address.StreetNumber = StreetNumberTxt.Text;
                _address.Flat = FlatTxt.Text;
                _address.Details = DetailsTxt.Text;
                _address.City.Name = CityTxt.Text;
                _address.City.ZipCode = ZipCodeTxt.Text;
                _address.Province.Name = ProvinceTxt.Text;
                _address.Country.Name = CountryTxt.Text;

                return _address;
            }

            set
            {
                _address = value;

                if (_address != null)
                {
                    StreetNameTxt.Text = _address.StreetName;
                    StreetNumberTxt.Text = _address.StreetNumber;
                    FlatTxt.Text = _address.Flat;
                    DetailsTxt.Text = _address.Details;
                    CityTxt.Text = _address.City.Name;
                    ZipCodeTxt.Text = _address.City.ZipCode;
                    ProvinceTxt.Text = _address.Province.Name;
                    CountryTxt.Text = _address.Country.Name;
                    ViewState["Address"] = _address;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}