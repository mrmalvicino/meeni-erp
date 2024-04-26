using BLL;
using Entities;
using System;
using System.Windows.Forms;
using Utilities;

namespace WindowsForms
{
    public partial class CustomerRegisterForm : Form
    {
        // ATTRIBUTES

        private Customer _customer = null;
        private CustomersManager _customersManager = new CustomersManager();
        private OrganizationsManager _organizationsManager = new OrganizationsManager();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();
        private CitiesManager _citiesManager = new CitiesManager();

        //CONSTRUCT

        public CustomerRegisterForm()
        {
            InitializeComponent();
        }

        public CustomerRegisterForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        // METHODS

        private bool validateRegister()
        {
            // Birth

            if (birthDateTimePicker.Value < birthDateTimePicker.MinDate || DateTime.Today < birthDateTimePicker.Value)
            {
                Validations.error("La fecha ingresada no es válida.");
                return false;
            }

            // TaxCode

            if (!Validations.isNumber(taxCodePrefixTextBox.Text))
            {
                Validations.error("Los campos de CUIL o CUIT solo admiten caracteres numéricos.");
                return false;
            }

            if (!Validations.isNumber(taxCodeNumberTextBox.Text))
            {
                Validations.error("El campo de DNI solo admite caracteres numéricos.");
                return false;
            }

            if (!Validations.isNumber(taxCodeSuffixTextBox.Text))
            {
                Validations.error("Los campos de CUIL o CUIT solo admiten caracteres numéricos.");
                return false;
            }

            if (taxCodePrefixTextBox.Text != "" && taxCodeSuffixTextBox.Text == "")
            {
                Validations.error("El CUIL/CUIT está incompleto.");
                return false;
            }

            if (taxCodePrefixTextBox.Text == "" && taxCodeSuffixTextBox.Text != "")
            {
                Validations.error("El CUIL/CUIT está incompleto.");
                return false;
            }

            if (taxCodeNumberTextBox.Text == "" && (taxCodePrefixTextBox.Text != "" || taxCodeSuffixTextBox.Text != ""))
            {
                Validations.error("El CUIL/CUIT está incompleto.");
                return false;
            }

            // Person-Organization

            if (organizationNameComboBox.Text == "" && (firstNameTextBox.Text == "" || lastNameTextBox.Text == ""))
            {
                Validations.error("Ingresar el nombre y apellido de una persona o el nombre de una organización.");
                return false;
            }

            // Phone

            if (!Validations.isNumber(phoneTextBox.Text))
            {
                Validations.error("El número de teléfono solo admite caracteres numéricos.");
                return false;
            }

            // Adress

            if (Validations.isNumber(streetNumberTextBox.Text) == false)
            {
                Validations.error("El número de calle solo admite caracteres numéricos.");
                return false;
            }

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
            activeStatusCheckBox.Checked = _customer.ActiveStatus;
            phoneTextBox.Text = _customer.Phone;
            emailTextBox.Text = _customer.Email;

            if (birthDateTimePicker.MinDate < _customer.Birth && _customer.Birth < birthDateTimePicker.MaxDate)
            {
                birthDateTimePicker.Value = DateTime.Parse(_customer.Birth.ToShortDateString());
            }

            if (0 < _customer.TaxCode.TaxCodeId)
            {
                taxCodePrefixTextBox.Text = _customer.TaxCode.Prefix;
                taxCodeNumberTextBox.Text = _customer.TaxCode.Number;
                taxCodeSuffixTextBox.Text = _customer.TaxCode.Suffix;
            }

            if (0 < _customer.Adress.City.CityId)
            {
                streetNameTextBox.Text = _customer.Adress.StreetName;
                streetNumberTextBox.Text = _customer.Adress.StreetNumber;
                flatTextBox.Text = _customer.Adress.Flat;
                detailsTextBox.Text = _customer.Adress.Details;
                adressCityComboBox.SelectedValue = _customer.Adress.City.CityId;
                zipCodeTextBox.Text = _customer.Adress.City.ZipCode;
                adressProvinceComboBox.SelectedValue = _customer.Adress.Province.ProvinceId;
                adressCountryComboBox.SelectedValue = _customer.Adress.Country.CountryId;
            }
            else
            {
                adressCityComboBox.SelectedIndex = -1;
                adressProvinceComboBox.SelectedIndex = -1;
                adressCountryComboBox.SelectedIndex = -1;
            }

            if (0 < _customer.Organization.OrganizationId)
            {
                organizationNameComboBox.SelectedValue = _customer.Organization.OrganizationId;
                organizationDescriptionTextBox.Text = _customer.Organization.Description;
            }

            if (0 < _customer.Person.PersonId)
            {
                firstNameTextBox.Text = _customer.Person.FirstName;
                lastNameTextBox.Text = _customer.Person.LastName;
            }

            if (0 < _customer.Image.ImageId)
            {
                imageUrlTextBox.Text = _customer.Image.Url;
            }
        }

        private void mapBusinessPartner()
        {
            mapIndividual();
            paymentMethodComboBox.Text = _customer.PaymentMethod;
            invoiceCategoryComboBox.Text = _customer.InvoiceCategory;
        }

        private void mapCustomer()
        {
            mapBusinessPartner();
        }

        private void setIndividual()
        {
            _customer.ActiveStatus = activeStatusCheckBox.Checked;
            _customer.Phone = phoneTextBox.Text;
            _customer.Email = emailTextBox.Text;
            _customer.Birth = birthDateTimePicker.Value;

            if (Validations.hasData(taxCodeNumberTextBox.Text))
            {
                _customer.TaxCode.Prefix = taxCodePrefixTextBox.Text;
                _customer.TaxCode.Number = taxCodeNumberTextBox.Text;
                _customer.TaxCode.Suffix = taxCodeSuffixTextBox.Text;
            }
            else
            {
                _customer.TaxCode = null;
            }

            if (Validations.hasData(adressCityComboBox.Text))
            {
                _customer.Adress.StreetName = streetNameTextBox.Text;
                _customer.Adress.StreetNumber = streetNumberTextBox.Text;
                _customer.Adress.Flat = flatTextBox.Text;
                _customer.Adress.Details = detailsTextBox.Text;
                _customer.Adress.City.Name = adressCityComboBox.Text;
                _customer.Adress.City.ZipCode = zipCodeTextBox.Text;
                _customer.Adress.Province.Name = adressProvinceComboBox.Text;
                _customer.Adress.Country.Name = adressCountryComboBox.Text;
            }
            else
            {
                _customer.Adress = null;
            }

            if (Validations.hasData(firstNameTextBox.Text))
            {
                _customer.Person.FirstName = firstNameTextBox.Text;
                _customer.Person.LastName = lastNameTextBox.Text;
            }
            else
            {
                _customer.Person = null;
            }

            if (Validations.hasData(organizationNameComboBox.Text))
            {
                _customer.Organization.Name = organizationNameComboBox.Text;
                _customer.Organization.Description = organizationDescriptionTextBox.Text;
            }
            else
            {
                _customer.Organization = null;
            }

            if (Validations.hasData(imageUrlTextBox.Text))
            {
                _customer.Image.Url = imageUrlTextBox.Text;
            }
            else
            {
                _customer.Image = null;
            }
        }

        private void setBusinessPartner()
        {
            setIndividual();
            _customer.PaymentMethod = paymentMethodComboBox.Text;
            _customer.InvoiceCategory = invoiceCategoryComboBox.Text;
        }

        private void setCustomer()
        {
            setBusinessPartner();
        }

        // EVENTS

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            clearComboBoxes();

            try
            {
                birthDateTimePicker.Value = birthDateTimePicker.MinDate;
                bindComboBoxes();

                if (_customer == null)
                {
                    _customer = new Customer();
                    activeStatusCheckBox.Enabled = false;
                }
                else
                {
                    mapCustomer();
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
            {
                return;
            }

            try
            {
                setCustomer();

                if (0 < _customer.CustomerId)
                {
                    _customersManager.edit(_customer);
                }
                else
                {
                    _customersManager.add(_customer);
                }

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imageUrlTextBox_Leave(object sender, EventArgs e)
        {
            Functions.loadImage(profilePictureBox, imageUrlTextBox.Text);
        }
    }
}
