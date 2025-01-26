using BusinessLogic;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace WebForms
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private User _loggedUser;
        private Employee _employee;
        private int _employeeId;

        public ViewEmployee()
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
            string employeeId = Request.QueryString["employeeId"];

            if (!string.IsNullOrEmpty(employeeId))
            {
                _employeeId = Convert.ToInt32(employeeId);
            }
        }

        private void FetchLoggedUser()
        {
            _loggedUser = Session["loggedUser"] as User;
        }

        private void FetchEmployee()
        {
            FetchURL();
            FetchLoggedUser();

            bool tenancy = _appManager.People.FindInternalId(_employeeId) == _loggedUser.Id;

            if (0 < _employeeId && tenancy)
            {
                _employee = _appManager.Employees.Read(_employeeId);
                return;
            }

            _employee = _loggedUser;
        }

        private void MapControls()
        {
            if (_employee.ProfileImage != null)
            {
                ImageURLTxt.Text = _employee.ProfileImage.URL;
            }

            DNITxt.Text = _employee.DNI;
            CUILTxt.Text = _employee.CUIL;
            FirstNameTxt.Text = _employee.FirstName;
            LastNameTxt.Text = _employee.LastName;
            EmailTxt.Text = _employee.Email;
            PhoneTxt.Text = _employee.Phone;
            BirthDateTxt.Text = _employee.BirthDate.ToString("yyyy-MM-dd");

            if (_employee.Address != null)
            {
                StreetNameTxt.Text = _employee.Address.StreetName;
                StreetNumberTxt.Text = _employee.Address.StreetNumber;
                FlatTxt.Text = _employee.Address.Flat;
                DetailsTxt.Text = _employee.Address.Details;
                CityTxt.Text = _employee.Address.City?.Name;
                ZipCodeTxt.Text = _employee.Address.City?.ZipCode;
                ProvinceTxt.Text = _employee.Address.Province?.Name;
                CountryTxt.Text = _employee.Address.Country?.Name;
            }
        }

        private void InstantiateAttributes()
        {
            if (_employee.ProfileImage == null)
            {
                _employee.ProfileImage = new Image();
            }

            if (_employee.Address == null)
            {
                _employee.Address = new Address(true);
            }
        }

        private void MapAttributes()
        {
            _employee.ProfileImage.URL = ImageURLTxt.Text;
            _employee.DNI = DNITxt.Text;
            _employee.CUIL = CUILTxt.Text;
            _employee.FirstName = FirstNameTxt.Text;
            _employee.LastName = LastNameTxt.Text;
            _employee.Email = EmailTxt.Text;
            _employee.Phone = PhoneTxt.Text;
            _employee.Address.StreetName = StreetNameTxt.Text;
            _employee.Address.StreetNumber = StreetNumberTxt.Text;
            _employee.Address.Flat = FlatTxt.Text;
            _employee.Address.Details = DetailsTxt.Text;
            _employee.Address.City.Name = CityTxt.Text;
            _employee.Address.City.ZipCode = ZipCodeTxt.Text;
            _employee.Address.Province.Name = ProvinceTxt.Text;
            _employee.Address.Country.Name = CountryTxt.Text;

            DateTime birthDate;
            DateTime.TryParse(BirthDateTxt.Text, out birthDate);
            _employee.BirthDate = birthDate;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchEmployee();

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
                _appManager.Employees.Update(_employee);
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

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_loggedUser.Id == _employee.Id)
                {
                    _appManager.Employees.Toggle(_employee);
                    (this.Master.Master as Site)?.Logout();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}