using BusinessLogic;
using DomainModel;
using System;
using Utilities;

namespace WebForms.UserControls
{
    public partial class EditEntity : System.Web.UI.UserControl
    {
        private AppManager _appManager;
        private Entity _entity;

        public Entity Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        public bool IsSwitchable
        {
            get { return IsOrganizationDiv.Visible; }
            set { IsOrganizationDiv.Visible = value; }
        }

        public EditEntity()
        {
            _appManager = new AppManager();
        }

        private void SetAddress()
        {
            if (_entity.Address == null)
            {
                _entity.Address = new Address(true);
            }

            _entity.Address.StreetName = AddressFieldsUC.GetStreetName();
            _entity.Address.StreetNumber = AddressFieldsUC.GetStreetNumber();
            _entity.Address.Flat = AddressFieldsUC.GetFlat();
            _entity.Address.Details = AddressFieldsUC.GetDetails();
            _entity.Address.City.Name = AddressFieldsUC.GetCityName();
            _entity.Address.City.ZipCode = AddressFieldsUC.GetZipCode();
            _entity.Address.Province.Name = AddressFieldsUC.GetProvinceName();
            _entity.Address.Country.Name = AddressFieldsUC.GetCountryName();
        }

        private void SetBirthDate()
        {
            DateTime birthDate;
            DateTime.TryParse(BirthDateTxt.Text, out birthDate);
            _entity.BirthDate = birthDate;
        }

        private void SetIdentification()
        {
            if (_entity.Identification == null)
            {
                _entity.Identification = new Identification(true);
            }

            _entity.Identification.Code = Formatter.FormatIdentificationCode(IdentificationCodeTxt.Text);
            int id = Convert.ToInt32(IdentificationTypesDDL.SelectedValue);
            _entity.Identification.IdentificationType = _appManager.IdentificationTypes.Read(id);
        }

        private void SetName()
        {
            if (IsOrganizationChk.Checked)
            {
                _entity.SetOrganizationName(EntityNameUC.GetOrganizationName());
            }
            else
            {
                _entity.SetPersonName(EntityNameUC.GetFirstName(), EntityNameUC.GetLastName());
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
            _entity.IsOrganization = IsOrganizationChk.Checked;
            SetIdentification();
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
                AddressFieldsUC.SetStreetName(_entity.Address.StreetName);
                AddressFieldsUC.SetStreetNumber(_entity.Address.StreetNumber);
                AddressFieldsUC.SetFlat(_entity.Address.Flat);
                AddressFieldsUC.SetDetails(_entity.Address.Details);
                AddressFieldsUC.SetCityName(_entity.Address.City?.Name);
                AddressFieldsUC.SetZipCode(_entity.Address.City?.ZipCode);
                AddressFieldsUC.SetProvinceName(_entity.Address.Province?.Name);
                AddressFieldsUC.SetCountryName(_entity.Address.Country?.Name);
            }
        }

        private void GetIdentification()
        {
            if (_entity.Identification != null)
            {
                IdentificationCodeTxt.Text = _entity.Identification.Code;
                IdentificationTypesDDL.SelectedValue = _entity.Identification.IdentificationType.Id.ToString();
            }
        }

        private void GetName()
        {
            if (_entity.IsOrganization)
            {
                IsOrganizationChk.Checked = true;
                EntityNameUC.ShowOrganizationName();
                EntityNameUC.SetOrganizationName(_entity.GetOrganizationName());
            }
            else
            {
                IsOrganizationChk.Checked = false;
                EntityNameUC.ShowPersonName();
                EntityNameUC.SetPersonName(_entity.GetFirstName(), _entity.GetLastName());
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
            IsOrganizationChk.Checked = _entity.IsOrganization;
            GetIdentification();
            BirthDateTxt.Text = _entity.BirthDate.ToString("yyyy-MM-dd");
            EmailTxt.Text = _entity.Email;
            PhoneTxt.Text = _entity.Phone;
            GetAddress();
        }

        public void BindIdentificationTypesDDL()
        {
            IdentificationTypesDDL.DataSource = _appManager.IdentificationTypes.List();
            IdentificationTypesDDL.DataTextField = "Name";
            IdentificationTypesDDL.DataValueField = "Id";
            IdentificationTypesDDL.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindIdentificationTypesDDL();
                MapControls();
            }

            LoadImage();
        }

        protected void IsOrganizationChk_CheckedChanged(object sender, EventArgs e)
        {
            EntityNameUC.ToggleNameType();
        }
    }
}