using BusinessLogic;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace WebForms
{
    public partial class EditEntity : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _loggedOrganization;
        private Entity _entity;
        private int _entityId;

        public EditEntity()
        {
            _appManager = new AppManager();
        }

        private void LoadImage()
        {
            if (Validator.URLExists(ImageURLTxt.Text))
            {
                LogoImg.ImageUrl = ImageURLTxt.Text;
                return;
            }

            ImageURLTxt.Text = "";
            LogoImg.ImageUrl = "https://github.com/mrmalvicino/meeni-erp/blob/main/WebForms/images/logo.png?raw=true";
        }

        private void FetchURL()
        {
            string organizationId = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(organizationId))
            {
                _entityId = Convert.ToInt32(organizationId);
            }
        }

        private void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        private void FetchLegalEntity()
        {
            FetchURL();
            FetchSession();

            bool tenancy = _appManager.Stakeholders.FindOrganizationId(_entityId) == _loggedOrganization.Id;

            if (0 < _entityId && tenancy)
            {
                _entity = _appManager.Entities.Read(_entityId);
                return;
            }

            _entity = _loggedOrganization;
        }

        private void MapControls()
        {
            if (_entity.Image != null)
            {
                ImageURLTxt.Text = _entity.Image.URL;
            }

            NameTxt.Text = _entity.Name;
            TaxCodeTxt.Text = _entity.TaxCode;
            EmailTxt.Text = _entity.Email;
            PhoneTxt.Text = _entity.Phone;

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

        private void InstantiateAttributes()
        {
            if (_entity.Image == null)
            {
                _entity.Image = new Image();
            }

            if (_entity.Address == null)
            {
                _entity.Address = new Address(true);
            }
        }

        private void MapAttributes()
        {
            _entity.Image.URL = ImageURLTxt.Text;
            _entity.Name = NameTxt.Text;
            _entity.TaxCode = TaxCodeTxt.Text;
            _entity.Email = EmailTxt.Text;
            _entity.Phone = PhoneTxt.Text;
            _entity.Address.StreetName = StreetNameTxt.Text;
            _entity.Address.StreetNumber = StreetNumberTxt.Text;
            _entity.Address.Flat = FlatTxt.Text;
            _entity.Address.Details = DetailsTxt.Text;
            _entity.Address.City.Name = CityTxt.Text;
            _entity.Address.City.ZipCode = ZipCodeTxt.Text;
            _entity.Address.Province.Name = ProvinceTxt.Text;
            _entity.Address.Country.Name = CountryTxt.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchLegalEntity();

            if (!IsPostBack)
            {
                MapControls();
            }

            LoadImage();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            InstantiateAttributes();
            MapAttributes();

            try
            {
                _appManager.Entities.Update(_entity);
                Response.Redirect("Dashboard.aspx", false);
            }
            catch (ValidationException ex)
            {
                (this.Master.Master as Site)?.ShowModal(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}