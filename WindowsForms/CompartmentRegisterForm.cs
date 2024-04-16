using System;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class CompartmentRegisterForm : Form
    {
        // ATTRIBUTES

        private Compartment _compartment = null;
        private CompartmentsManager _compartmentsManager = new CompartmentsManager();

        //CONSTRUCT

        public CompartmentRegisterForm()
        {
            InitializeComponent();
        }

        public CompartmentRegisterForm(Compartment compartment)
        {
            InitializeComponent();
            _compartment = compartment;
        }

        // METHODS

        private bool validateRegister()
        {
            return true;
        }

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            imagePanel.BackColor = Palette.LightBackColor;
            contactPanel.BackColor = Palette.LightBackColor;
            adressPanel.BackColor = Palette.LightBackColor;
            specialPanel.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            organizationNameComboBox.DataSource = _organizationsManager.list();
            organizationNameComboBox.ValueMember = "OrganizationId";
            organizationNameComboBox.DisplayMember = "Name";

            adressCountryComboBox.DataSource = _countriesManager.list();
            adressCountryComboBox.ValueMember = "CountryId";
            adressCountryComboBox.DisplayMember = "Name";

            adressProvinceComboBox.DataSource = _provincesManager.list();
            adressProvinceComboBox.ValueMember = "ProvinceId";
            adressProvinceComboBox.DisplayMember = "Name";

            adressCityComboBox.DataSource = _citiesManager.list();
            adressCityComboBox.ValueMember = "CityId";
            adressCityComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            organizationNameComboBox.SelectedIndex = -1;
            adressCountryComboBox.SelectedIndex = -1;
            adressProvinceComboBox.SelectedIndex = -1;
            adressCityComboBox.SelectedIndex = -1;
        }

        private void mapIndividual()
        {
            activeStatusCheckBox.Checked = _compartment.ActiveStatus;
            phoneTextBox.Text = _compartment.Phone;
            emailTextBox.Text = _compartment.Email;

            if (birthDateTimePicker.MinDate < _compartment.Birth && _compartment.Birth < birthDateTimePicker.MaxDate)
            {
                birthDateTimePicker.Value = DateTime.Parse(_compartment.Birth.ToShortDateString());
            }

            if (0 < _compartment.TaxCode.TaxCodeId)
            {
                taxCodePrefixTextBox.Text = _compartment.TaxCode.Prefix;
                taxCodeNumberTextBox.Text = _compartment.TaxCode.Number;
                taxCodeSuffixTextBox.Text = _compartment.TaxCode.Suffix;
            }

            if (0 < _compartment.Adress.City.CityId)
            {
                streetNameTextBox.Text = _compartment.Adress.StreetName;
                streetNumberTextBox.Text = _compartment.Adress.StreetNumber;
                flatTextBox.Text = _compartment.Adress.Flat;
                detailsTextBox.Text = _compartment.Adress.Details;
                adressCityComboBox.SelectedValue = _compartment.Adress.City.CityId;
                zipCodeTextBox.Text = _compartment.Adress.City.ZipCode;
                adressProvinceComboBox.SelectedValue = _compartment.Adress.Province.ProvinceId;
                adressCountryComboBox.SelectedValue = _compartment.Adress.Country.CountryId;
            }
            else
            {
                adressCityComboBox.SelectedIndex = -1;
                adressProvinceComboBox.SelectedIndex = -1;
                adressCountryComboBox.SelectedIndex = -1;
            }

            if (0 < _compartment.Organization.OrganizationId)
            {
                organizationNameComboBox.SelectedValue = _compartment.Organization.OrganizationId;
                organizationDescriptionTextBox.Text = _compartment.Organization.Description;
            }

            if (0 < _compartment.Person.PersonId)
            {
                firstNameTextBox.Text = _compartment.Person.FirstName;
                lastNameTextBox.Text = _compartment.Person.LastName;
            }

            if (0 < _compartment.Image.ImageId)
            {
                imageUrlTextBox.Text = _compartment.Image.Url;
            }
        }

        private void mapBusinessPartner()
        {
            mapIndividual();
            paymentMethodComboBox.Text = _compartment.PaymentMethod;
            invoiceCategoryComboBox.Text = _compartment.InvoiceCategory;
        }

        private void mapCompartment()
        {
            mapBusinessPartner();
        }

        private void setIndividual()
        {
            _compartment.ActiveStatus = activeStatusCheckBox.Checked;
            _compartment.Phone = phoneTextBox.Text;
            _compartment.Email = emailTextBox.Text;
            _compartment.Birth = birthDateTimePicker.Value;

            if (Validations.hasData(taxCodeNumberTextBox.Text))
            {
                _compartment.TaxCode.Prefix = taxCodePrefixTextBox.Text;
                _compartment.TaxCode.Number = taxCodeNumberTextBox.Text;
                _compartment.TaxCode.Suffix = taxCodeSuffixTextBox.Text;
            }
            else
            {
                _compartment.TaxCode = null;
            }

            if (Validations.hasData(adressCityComboBox.Text))
            {
                _compartment.Adress.StreetName = streetNameTextBox.Text;
                _compartment.Adress.StreetNumber = streetNumberTextBox.Text;
                _compartment.Adress.Flat = flatTextBox.Text;
                _compartment.Adress.Details = detailsTextBox.Text;
                _compartment.Adress.City.Name = adressCityComboBox.Text;
                _compartment.Adress.City.ZipCode = zipCodeTextBox.Text;
                _compartment.Adress.Province.Name = adressProvinceComboBox.Text;
                _compartment.Adress.Country.Name = adressCountryComboBox.Text;
            }
            else
            {
                _compartment.Adress = null;
            }

            if (Validations.hasData(firstNameTextBox.Text))
            {
                _compartment.Person.FirstName = firstNameTextBox.Text;
                _compartment.Person.LastName = lastNameTextBox.Text;
            }
            else
            {
                _compartment.Person = null;
            }

            if (Validations.hasData(organizationNameComboBox.Text))
            {
                _compartment.Organization.Name = organizationNameComboBox.Text;
                _compartment.Organization.Description = organizationDescriptionTextBox.Text;
            }
            else
            {
                _compartment.Organization = null;
            }

            if (Validations.hasData(imageUrlTextBox.Text))
            {
                _compartment.Image.Url = imageUrlTextBox.Text;
            }
            else
            {
                _compartment.Image = null;
            }
        }

        private void setBusinessPartner()
        {
            setIndividual();
            _compartment.PaymentMethod = paymentMethodComboBox.Text;
            _compartment.InvoiceCategory = invoiceCategoryComboBox.Text;
        }

        private void setCompartment()
        {
            setBusinessPartner();
        }

        // EVENTS

        private void CompartmentRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                birthDateTimePicker.Value = birthDateTimePicker.MinDate;
                bindComboBoxes();

                if (_compartment == null)
                {
                    _compartment = new Compartment();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else
                {
                    mapCompartment();
                    Functions.loadImage(profilePictureBox, imageUrlTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
                return;

            try
            {
                setCompartment();

                if (0 < _compartment.CompartmentId)
                {
                    _compartmentsManager.edit(_compartment);
                }
                else
                {
                    _compartmentsManager.add(_compartment);
                }

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
