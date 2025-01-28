using BusinessLogic;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace WebForms
{
    public partial class ViewOrganization : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _loggedOrganization;
        private Entity _legalEntity;
        private int _organizationId;

        public ViewOrganization()
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
                _organizationId = Convert.ToInt32(organizationId);
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

            bool tenancy = _appManager.ExternalOrganizations.FindInternalId(_organizationId) == _loggedOrganization.Id;

            if (0 < _organizationId && tenancy)
            {
                _legalEntity = _appManager.LegalEntities.Read(_organizationId);
                return;
            }

            _legalEntity = _loggedOrganization;
        }

        private void MapControls()
        {
            if (_legalEntity.LogoImage != null)
            {
                ImageURLTxt.Text = _legalEntity.LogoImage.URL;
            }

            OrganizationNameTxt.Text = _legalEntity.Name;
            CUITTxt.Text = _legalEntity.CUIT;
            EmailTxt.Text = _legalEntity.Email;
            PhoneTxt.Text = _legalEntity.Phone;

            if (_legalEntity.Address != null)
            {
                StreetNameTxt.Text = _legalEntity.Address.StreetName;
                StreetNumberTxt.Text = _legalEntity.Address.StreetNumber;
                FlatTxt.Text = _legalEntity.Address.Flat;
                DetailsTxt.Text = _legalEntity.Address.Details;
                CityTxt.Text = _legalEntity.Address.City?.Name;
                ZipCodeTxt.Text = _legalEntity.Address.City?.ZipCode;
                ProvinceTxt.Text = _legalEntity.Address.Province?.Name;
                CountryTxt.Text = _legalEntity.Address.Country?.Name;
            }
        }

        private void InstantiateAttributes()
        {
            if (_legalEntity.LogoImage == null)
            {
                _legalEntity.LogoImage = new Image();
            }

            if (_legalEntity.Address == null)
            {
                _legalEntity.Address = new Address(true);
            }
        }

        private void MapAttributes()
        {
            _legalEntity.LogoImage.URL = ImageURLTxt.Text;
            _legalEntity.Name = OrganizationNameTxt.Text;
            _legalEntity.CUIT = CUITTxt.Text;
            _legalEntity.Email = EmailTxt.Text;
            _legalEntity.Phone = PhoneTxt.Text;
            _legalEntity.Address.StreetName = StreetNameTxt.Text;
            _legalEntity.Address.StreetNumber = StreetNumberTxt.Text;
            _legalEntity.Address.Flat = FlatTxt.Text;
            _legalEntity.Address.Details = DetailsTxt.Text;
            _legalEntity.Address.City.Name = CityTxt.Text;
            _legalEntity.Address.City.ZipCode = ZipCodeTxt.Text;
            _legalEntity.Address.Province.Name = ProvinceTxt.Text;
            _legalEntity.Address.Country.Name = CountryTxt.Text;
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
                _appManager.LegalEntities.Update(_legalEntity);
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