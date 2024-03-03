using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using BLL;
using Entities;

namespace WindowsForms
{
    public partial class CustomerRegisterForm : Form
    {
        // ATTRIBUTES

        Customer _customer = null;
        OpenFileDialog _file = null;
        CustomersManager _customersManager = new CustomersManager();
        OrganizationsManager _organizationsManager = new OrganizationsManager();
        CountriesManager _countriesManager = new CountriesManager();
        ProvincesManager _provincesManager = new ProvincesManager();
        CitiesManager _citiesManager = new CitiesManager();

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

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            imagePanel.BackColor = Palette.LightBackColor;
            contactPanel.BackColor = Palette.LightBackColor;
            adressPanel.BackColor = Palette.LightBackColor;
            specialPanel.BackColor = Palette.LightBackColor;
        }

        private bool validateRegister()
        {
            if (Validations.isNumber(taxCodeNumberTextBox.Text) == false)
            {
                MessageBox.Show("El campo de DNI solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (isPersonCheckBox.Checked)
            {
                if (Validations.isEmpty(firstNameTextBox.Text) || Validations.isEmpty(lastNameTextBox.Text))
                {
                    MessageBox.Show("Las personas físicas deben tener nombre y apellido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (Validations.isNumber(phoneNumberTextBox.Text) == false)
            {
                MessageBox.Show("El número de teléfono solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validations.isNumber(streetNumberTextBox.Text) == false)
            {
                MessageBox.Show("El número de calle solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (paymentMethodComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar el método de pago preferido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (invoiceCategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar el tipo de factura.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void bindComboBoxes()
        {
            organizationNameComboBox.DataSource = _organizationsManager.list();
            organizationNameComboBox.ValueMember = "OrganizationId";
            organizationNameComboBox.DisplayMember = "Name";

            phoneCountryComboBox.DataSource = _countriesManager.list();
            phoneCountryComboBox.ValueMember = "CountryId";
            phoneCountryComboBox.DisplayMember = "PhoneAreaCode";

            phoneProvinceComboBox.DataSource = _provincesManager.list();
            phoneProvinceComboBox.ValueMember = "ProvinceId";
            phoneProvinceComboBox.DisplayMember = "PhoneAreaCode";
            
            adressCountryComboBox.DataSource = _countriesManager.list();
            adressCountryComboBox.ValueMember = "CountryId";
            adressCountryComboBox.DisplayMember = "Name";
            
            adressProvinceComboBox.DataSource = _provincesManager.list();
            adressProvinceComboBox.ValueMember = "ProvinceId";
            adressProvinceComboBox.DisplayMember = "Name";
            
            cityComboBox.DataSource = _citiesManager.list();
            cityComboBox.ValueMember = "CityId";
            cityComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            organizationNameComboBox.SelectedIndex = -1;
            phoneCountryComboBox.SelectedIndex = -1;
            phoneProvinceComboBox.SelectedIndex = -1;
            adressCountryComboBox.SelectedIndex = -1;
            adressProvinceComboBox.SelectedIndex = -1;
            cityComboBox.SelectedIndex = -1;
        }

        private void mapIndividual()
        {
            activeStatusCheckBox.Checked = _customer.ActiveStatus;
            emailTextBox.Text = _customer.Email;
            birthDateTimePicker.Value = DateTime.Parse(_customer.Birth.ToShortDateString());

            if (0 < _customer.TaxCode.TaxCodeId) // Si tiene, mapear TaxCode
            {
                taxCodePrefixTextBox.Text = _customer.TaxCode.Prefix;
                taxCodeNumberTextBox.Text = _customer.TaxCode.Number.ToString();
                taxCodeSuffixTextBox.Text = _customer.TaxCode.Suffix;
            }

            if (0 < _customer.Adress.City.CityId) // Si tiene, mapear Adress
            {
                streetNameTextBox.Text = _customer.Adress.StreetName;
                streetNumberTextBox.Text = _customer.Adress.StreetNumber.ToString();
                flatTextBox.Text = _customer.Adress.Flat;
                detailsTextBox.Text = _customer.Adress.Details;
                cityComboBox.SelectedValue = _customer.Adress.City.CityId;
                adressProvinceComboBox.SelectedValue = _customer.Adress.Province.ProvinceId;
                adressCountryComboBox.SelectedValue = _customer.Adress.Country.CountryId;
            }
            else
            {
                cityComboBox.SelectedIndex = -1;
                adressProvinceComboBox.SelectedIndex = -1;
                adressCountryComboBox.SelectedIndex = -1;
            }
            
            if (0 < _customer.Phone.PhoneId) // Si tiene, mapear Phone
            {
                phoneCountryComboBox.SelectedValue = _customer.Adress.Country.CountryId;
                phoneProvinceComboBox.SelectedValue = _customer.Adress.Province.ProvinceId;
                phoneNumberTextBox.Text = _customer.Phone.Number.ToString();
            }
            else
            {
                phoneCountryComboBox.SelectedIndex = -1;
                phoneProvinceComboBox.SelectedIndex = -1;
            }

            if (0 < _customer.Person.PersonId) // Si tiene, mapear Person
            {
                firstNameTextBox.Text = _customer.Person.FirstName;
                lastNameTextBox.Text = _customer.Person.LastName;
            }

            if (0 < _customer.Organization.OrganizationId) // Si tiene, mapear Organization
            {
                organizationNameComboBox.SelectedValue = _customer.Organization.OrganizationId;
                organizationDescriptionTextBox.Text = _customer.Organization.Description;
            }
        }

        private void mapBusinessPartner()
        {
            mapIndividual();
            paymentMethodComboBox.Text = _customer.PaymentMethod;
            invoiceCategoryComboBox.Text = _customer.InvoiceCategory;
        }

        // EVENTS

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                bindComboBoxes();

                if (_customer == null) // Se está agregando un registro
                {
                    _customer = new Customer();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else // Se está editando un registro
                {
                    mapBusinessPartner();
                    Functions.loadImage(profilePictureBox, imageUrlTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
                return;

            try
            {
                _customer.ActiveStatus = activeStatusCheckBox.Checked;
                _customer.Email = emailTextBox.Text;

                if (phoneNumberTextBox.Text != "") _customer.Phone.Number = int.Parse(phoneNumberTextBox.Text);

                _customer.Adress.StreetName = streetNameTextBox.Text;
                if (streetNumberTextBox.Text != "") _customer.Adress.StreetNumber = int.Parse(streetNumberTextBox.Text);
                _customer.Adress.Flat = flatTextBox.Text;

                _customer.TaxCode.Prefix = taxCodePrefixTextBox.Text;
                if (taxCodeNumberTextBox.Text != "") _customer.TaxCode.Number = int.Parse(taxCodeNumberTextBox.Text);
                _customer.TaxCode.Suffix = taxCodeSuffixTextBox.Text;

                _customer.PaymentMethod = paymentMethodComboBox.Text;
                _customer.InvoiceCategory = invoiceCategoryComboBox.Text;

                if (0 < _customer.CustomerId)
                    _customersManager.edit(_customer); // Se está editando un registro
                else
                    _customersManager.add(_customer); // Se está agregando un registro

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

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _file = new OpenFileDialog();
            _file.Filter = "jpg|*.jpg;|png|*.png";
            _file.Title = "Seleccionar imagen";

            if (_file.ShowDialog() == DialogResult.OK)
            {
                Functions.loadImage(profilePictureBox, _file.FileName);
                DateTime currentDateTime = DateTime.Now;
                string dateTimeFormat = "yyyyMMddHHmmss";
                string formattedDateTime = currentDateTime.ToString(dateTimeFormat);
                imageUrlTextBox.Text = ConfigurationManager.AppSettings["images_path"] + formattedDateTime + ".png";

                if (_file != null && !(imageUrlTextBox.Text.ToLower().Contains("http")))
                    File.Copy(_file.FileName, imageUrlTextBox.Text);
            }
        }

        private void legalIdDNITextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(taxCodeNumberTextBox.Text))
                taxCodeNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                taxCodeNumberTextBox.ForeColor = Palette.ValidationColor;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(phoneNumberTextBox.Text))
                phoneNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                phoneNumberTextBox.ForeColor = Palette.ValidationColor;
        }

        private void adressStreetNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(streetNumberTextBox.Text))
                streetNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                streetNumberTextBox.ForeColor = Palette.ValidationColor;
        }

        private void isPersonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            firstNameTextBox.Enabled = !firstNameTextBox.Enabled;
            lastNameTextBox.Enabled = !lastNameTextBox.Enabled;

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }
    }
}
