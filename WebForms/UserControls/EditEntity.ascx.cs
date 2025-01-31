using DomainModel;
using System;
using Utilities;

namespace WebForms.UserControls
{
    public partial class EditEntity : System.Web.UI.UserControl
    {
        private Entity _entity;
        private string[] _items = new string[] { "Organización", "Persona", "CUIT/CUIL", "DNI" };

        public Entity Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        public bool IsSwitchable
        {
            get { return EntityTypeDiv.Visible; }
            set { EntityTypeDiv.Visible = value; }
        }

        private void SetAddress()
        {
            if (_entity.Address == null)
            {
                _entity.Address = new Address(true);
            }

            _entity.Address.StreetName = StreetNameTxt.Text;
            _entity.Address.StreetNumber = StreetNumberTxt.Text;
            _entity.Address.Flat = FlatTxt.Text;
            _entity.Address.Details = DetailsTxt.Text;
            _entity.Address.City.Name = CityTxt.Text;
            _entity.Address.City.ZipCode = ZipCodeTxt.Text;
            _entity.Address.Province.Name = ProvinceTxt.Text;
            _entity.Address.Country.Name = CountryTxt.Text;
        }

        private void SetBirthDate()
        {
            DateTime birthDate;
            DateTime.TryParse(BirthDateTxt.Text, out birthDate);
            _entity.BirthDate = birthDate;
        }

        private void SetTaxCode()
        {
            if (TaxCodeDDL.SelectedItem.Value == _items[2])
            {
                _entity.SetCUIT(TaxCodeTxt.Text);
            }
            else
            {
                _entity.SetDNI(TaxCodeTxt.Text);
            }
        }

        private void SetName()
        {
            if (_entity.IsOrganization())
            {
                _entity.SetOrganizationName(NameTxt.Text);
            }
            else
            {
                _entity.SetPersonName(FirstNameTxt.Text, LastNameTxt.Text);
            }
        }

        private void SetImage()
        {
            if (_entity.Image == null)
            {
                _entity.Image = new Image();
            }

            _entity.Image.URL = ImageURLTxt.Text;
        }

        public void MapAttributes()
        {
            SetImage();
            SetName();
            SetTaxCode();
            SetBirthDate();
            _entity.Email = EmailTxt.Text;
            _entity.Phone = PhoneTxt.Text;
            SetAddress();
        }

        private void LoadImage()
        {
            if (Validator.URLExists(ImageURLTxt.Text))
            {
                EntityImg.ImageUrl = ImageURLTxt.Text;
                return;
            }

            ImageURLTxt.Text = "";
            EntityImg.ImageUrl = "https://github.com/mrmalvicino/meeni-erp/blob/main/WebForms/images/logo.png?raw=true";
        }

        private void GetAddress()
        {
            if (_entity.Address != null)
            {
                StreetNameTxt.Text = _entity.Address.StreetName;
                StreetNumberTxt.Text = _entity.Address.StreetNumber;
                FlatTxt.Text = _entity.Address.Flat;
                DetailsTxt.Text = _entity.Address.Details;
                CityTxt.Text = _entity.Address.City?.Name;
                ZipCodeTxt.Text = _entity.Address.City?.ZipCode;
                ProvinceTxt.Text = _entity.Address.Province?.Name;
                CountryTxt.Text = _entity.Address.Country?.Name;
            }
        }

        private void GetTaxCode()
        {
            if (_entity.TaxCodeIsDNI())
            {
                TaxCodeDDL.SelectedIndex = 1;
                TaxCodeTxt.Text = _entity.GetDNI();
            }
            else
            {
                TaxCodeDDL.SelectedIndex = 0;
                TaxCodeTxt.Text = _entity.GetCUIT();
            }
        }

        private void GetName()
        {
            if (_entity.IsOrganization())
            {
                EntityTypeDDL.SelectedIndex = 0;
                OrganizationNameDiv.Visible = true;
                PersonNameDiv.Visible = false;
                NameTxt.Text = _entity.GetOrganizationName();
            }
            else
            {
                EntityTypeDDL.SelectedIndex = 1;
                OrganizationNameDiv.Visible = false;
                PersonNameDiv.Visible = true;
                FirstNameTxt.Text = _entity.GetFirstName();
                LastNameTxt.Text = _entity.GetLastName();
            }
        }

        private void GetImage()
        {
            if (_entity.Image != null)
            {
                ImageURLTxt.Text = _entity.Image.URL;
            }
        }

        public void MapControls()
        {
            GetImage();
            GetName();
            GetTaxCode();
            BirthDateTxt.Text = _entity.BirthDate.ToString("yyyy-MM-dd");
            EmailTxt.Text = _entity.Email;
            PhoneTxt.Text = _entity.Phone;
            GetAddress();
        }

        public void BindDDL()
        {
            EntityTypeDDL.Items.Add(new System.Web.UI.WebControls.ListItem(_items[0], _items[0]));
            EntityTypeDDL.Items.Add(new System.Web.UI.WebControls.ListItem(_items[1], _items[1]));
            TaxCodeDDL.Items.Add(new System.Web.UI.WebControls.ListItem(_items[2], _items[2]));
            TaxCodeDDL.Items.Add(new System.Web.UI.WebControls.ListItem(_items[3], _items[3]));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDDL();
                MapControls();
            }

            LoadImage();
        }

        protected void EntityTypeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EntityTypeDDL.SelectedItem.Value == _items[0])
            {
                OrganizationNameDiv.Visible = true;
                PersonNameDiv.Visible = false;
            }
            else
            {
                OrganizationNameDiv.Visible = false;
                PersonNameDiv.Visible = true;
            }
        }
    }
}