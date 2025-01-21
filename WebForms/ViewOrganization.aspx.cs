using BusinessLogic;
using DomainModel;
using Utilities;
using System;
using Exceptions;

namespace WebForms
{
    public partial class ViewOrganization : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private InternalOrganization _internalOrganization;
        private User _user;

        public ViewOrganization()
        {
            _appManager = new ApplicationManager();
        }

        private void LoadImage()
        {
            if (Validator.URLIsValid(ImageURLTxt.Text))
            {
                LogoImg.ImageUrl = ImageURLTxt.Text;
                return;
            }

            LogoImg.ImageUrl = "https://github.com/mrmalvicino/meeni-erp/blob/main/WebForms/images/logo.png?raw=true";
        }

        private void FetchInternalOrganization()
        {
            _internalOrganization = Session["loggedOrganization"] as InternalOrganization;
        }

        private void MapControls()
        {
            ImageURLTxt.Text = _internalOrganization.LogoImage.URL;
            OrganizationNameTxt.Text = _internalOrganization.Name;
            CUITTxt.Text = _internalOrganization.CUIT;
            EmailTxt.Text = _internalOrganization.Email;
            PhoneTxt.Text = _internalOrganization.Phone;
            StreetNameTxt.Text = _internalOrganization.Address.StreetName;
            StreetNumberTxt.Text = _internalOrganization.Address.StreetNumber;
            FlatTxt.Text = _internalOrganization.Address.Flat;
            DetailsTxt.Text = _internalOrganization.Address.Details;
            CityTxt.Text = _internalOrganization.Address.City.Name;
            ProvinceTxt.Text = _internalOrganization.Address.Province.Name;
            CountryTxt.Text = _internalOrganization.Address.Country.Name;
        }

        private void MapAttributes()
        {
            _internalOrganization.LogoImage.URL = ImageURLTxt.Text;
            _internalOrganization.Name = OrganizationNameTxt.Text;
            _internalOrganization.CUIT = CUITTxt.Text;
            _internalOrganization.Email = EmailTxt.Text;
            _internalOrganization.Phone = PhoneTxt.Text;
            _internalOrganization.Address.StreetName = StreetNameTxt.Text;
            _internalOrganization.Address.StreetNumber = StreetNumberTxt.Text;
            _internalOrganization.Address.Flat = FlatTxt.Text;
            _internalOrganization.Address.Details = DetailsTxt.Text;
            _internalOrganization.Address.City.Name = CityTxt.Text;
            _internalOrganization.Address.Province.Name = ProvinceTxt.Text;
            _internalOrganization.Address.Country.Name = CountryTxt.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchInternalOrganization();

            if (!IsPostBack)
            {
                MapControls();
            }

            LoadImage();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            MapAttributes();

            try
            {
                _appManager.InternalOrganizations.Update(_internalOrganization);
                Session.Add("loggedOrganization", _internalOrganization);
                Response.Redirect("Dashboard.aspx", false);
            }
            catch (ValidationException ex)
            {
                (this.Master.Master as Site)?.ShowModal(ex.Message);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (ValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}