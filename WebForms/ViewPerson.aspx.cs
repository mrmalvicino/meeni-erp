using BusinessLogic;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace WebForms
{
    public partial class ViewPerson : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private InternalOrganization _loggedOrganization;
        private User _loggedUser;
        private Person _person;
        private int _personId;

        public ViewPerson()
        {
            _appManager = new ApplicationManager();
        }

        private void LoadImage()
        {
            if (Validator.URLExists(ImageURLTxt.Text))
            {
                ProfileImg.ImageUrl = ImageURLTxt.Text;
                return;
            }

            ImageURLTxt.Text = "";
            ProfileImg.ImageUrl = "https://github.com/mrmalvicino/meeni-erp/blob/main/WebForms/images/logo.png?raw=true";
        }

        private void FetchURL()
        {
            string employeeId = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(employeeId))
            {
                _personId = Convert.ToInt32(employeeId);
            }
        }

        private void FetchSession()
        {
            _loggedUser = Session["loggedUser"] as User;
            _loggedOrganization = Session["loggedOrganization"] as InternalOrganization;
        }

        private void FetchPerson()
        {
            FetchURL();
            FetchSession();

            bool tenancy = _appManager.People.FindInternalId(_personId) == _loggedOrganization.Id;

            if (0 < _personId && tenancy)
            {
                _person = _appManager.People.Read(_personId);
                return;
            }

            _person = _loggedUser;
        }

        private void MapControls()
        {
            if (_person.ProfileImage != null)
            {
                ImageURLTxt.Text = _person.ProfileImage.URL;
            }

            DNITxt.Text = _person.DNI;
            CUILTxt.Text = _person.CUIL;
            FirstNameTxt.Text = _person.FirstName;
            LastNameTxt.Text = _person.LastName;
            EmailTxt.Text = _person.Email;
            PhoneTxt.Text = _person.Phone;
            BirthDateTxt.Text = _person.BirthDate.ToString("yyyy-MM-dd");

            if (_person.Address != null)
            {
                StreetNameTxt.Text = _person.Address.StreetName;
                StreetNumberTxt.Text = _person.Address.StreetNumber;
                FlatTxt.Text = _person.Address.Flat;
                DetailsTxt.Text = _person.Address.Details;
                CityTxt.Text = _person.Address.City?.Name;
                ZipCodeTxt.Text = _person.Address.City?.ZipCode;
                ProvinceTxt.Text = _person.Address.Province?.Name;
                CountryTxt.Text = _person.Address.Country?.Name;
            }
        }

        private void InstantiateAttributes()
        {
            if (_person.ProfileImage == null)
            {
                _person.ProfileImage = new Image();
            }

            if (_person.Address == null)
            {
                _person.Address = new Address(true);
            }
        }

        private void MapAttributes()
        {
            _person.ProfileImage.URL = ImageURLTxt.Text;
            _person.DNI = DNITxt.Text;
            _person.CUIL = CUILTxt.Text;
            _person.FirstName = FirstNameTxt.Text;
            _person.LastName = LastNameTxt.Text;
            _person.Email = EmailTxt.Text;
            _person.Phone = PhoneTxt.Text;
            _person.Address.StreetName = StreetNameTxt.Text;
            _person.Address.StreetNumber = StreetNumberTxt.Text;
            _person.Address.Flat = FlatTxt.Text;
            _person.Address.Details = DetailsTxt.Text;
            _person.Address.City.Name = CityTxt.Text;
            _person.Address.City.ZipCode = ZipCodeTxt.Text;
            _person.Address.Province.Name = ProvinceTxt.Text;
            _person.Address.Country.Name = CountryTxt.Text;

            DateTime birthDate;
            DateTime.TryParse(BirthDateTxt.Text, out birthDate);
            _person.BirthDate = birthDate;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchPerson();

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
                _appManager.People.CallUpdate(_person);
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