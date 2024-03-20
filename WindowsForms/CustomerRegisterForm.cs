﻿using System;
using System.Windows.Forms;
using BLL;
using Entities;

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
        private ImagesManager _imagesManager = new ImagesManager();

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
                Validations.error("Además de un prefijo, el CUIL o CUIT requiere de un sufijo.");
                return false;
            }

            if (taxCodePrefixTextBox.Text == "" && taxCodeSuffixTextBox.Text != "")
            {
                Validations.error("Además de un sufijo, el CUIL o CUIT requiere de un prefijo.");
                return false;
            }

            if (taxCodeNumberTextBox.Text == "" && (taxCodePrefixTextBox.Text != "" || taxCodeSuffixTextBox.Text != ""))
            {
                Validations.error("Además de un prefijo y un sufijo, el CUIL o CUIT requiere de un número de DNI.");
                return false;
            }

            // Person-Organization

            if (organizationNameComboBox.Text == "" && (firstNameTextBox.Text == "" || lastNameTextBox.Text == ""))
            {
                Validations.error("Ingresar el nombre y apellido de una persona o el nombre de una organización.");
                return false;
            }

            // Phone

            if (!Validations.isNumber(phoneNumberTextBox.Text))
            {
                Validations.error("El número de teléfono solo admite caracteres numéricos.");
                return false;
            }

            if (phoneNumberTextBox.Text != "" && phoneCountryComboBox.Text == "")
            {
                Validations.error("Especificar el código de área de país del teléfono.");
                return false;
            }

            if (phoneNumberTextBox.Text != "" && phoneProvinceComboBox.Text == "")
            {
                Validations.error("Especificar el código de área de provincia del teléfono.");
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
            organizationNameComboBox.DataSource = _organizationsManager.list(); ;
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

            adressCityComboBox.DataSource = _citiesManager.list();
            adressCityComboBox.ValueMember = "CityId";
            adressCityComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            organizationNameComboBox.SelectedIndex = -1;
            phoneCountryComboBox.SelectedIndex = -1;
            phoneProvinceComboBox.SelectedIndex = -1;
            adressCountryComboBox.SelectedIndex = -1;
            adressProvinceComboBox.SelectedIndex = -1;
            adressCityComboBox.SelectedIndex = -1;
        }

        private void mapIndividual()
        {
            activeStatusCheckBox.Checked = _customer.ActiveStatus;
            emailTextBox.Text = _customer.Email;

            if (birthDateTimePicker.MinDate < _customer.Birth && _customer.Birth < birthDateTimePicker.MaxDate) // Si tiene, mapear Birth
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
                adressCityComboBox.SelectedValue = _customer.Adress.City.CityId;
                adressProvinceComboBox.SelectedValue = _customer.Adress.Province.ProvinceId;
                adressCountryComboBox.SelectedValue = _customer.Adress.Country.CountryId;
            }
            else
            {
                adressCityComboBox.SelectedIndex = -1;
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

            imageUrlTextBox.Text = _imagesManager.readIndividualImage(_customer);
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

        private void setCustomer()
        {
            _customer.ActiveStatus = activeStatusCheckBox.Checked;
            _customer.Email = emailTextBox.Text;
            _customer.Birth = birthDateTimePicker.Value;

            if (taxCodeNumberTextBox.Text != "")
            {
                _customer.TaxCode.Prefix = taxCodePrefixTextBox.Text;
                _customer.TaxCode.Number = taxCodeNumberTextBox.Text;
                _customer.TaxCode.Suffix = taxCodeSuffixTextBox.Text;
            }
            else
            {
                _customer.TaxCode = null;
            }

            if (adressCityComboBox.Text != "")
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

            if (phoneNumberTextBox.Text != "")
            {
                _customer.Phone.Country.PhoneAreaCode = phoneCountryComboBox.Text;
                _customer.Phone.Province.PhoneAreaCode = phoneProvinceComboBox.Text;
                _customer.Phone.Number = phoneNumberTextBox.Text;
            }
            else
            {
                _customer.Phone = null;
            }

            if (firstNameTextBox.Text != "")
            {
            _customer.Person.FirstName = firstNameTextBox.Text;
            _customer.Person.LastName = lastNameTextBox.Text;
            }
            else
            {
                _customer.Person = null;
            }

            if (organizationNameComboBox.Text != "")
            {
            _customer.Organization.Name = organizationNameComboBox.Text;
            _customer.Organization.Description = organizationDescriptionTextBox.Text;
            }
            else
            {
                _customer.Organization = null;
            }

            if (_customer.isPerson())
            {
                _customer.Person.Image.Url = imageUrlTextBox.Text;
                _customer.Organization.Image.Url = "";
            }
            else
            {
                _customer.Organization.Image.Url = imageUrlTextBox.Text;
                _customer.Person.Image.Url = "";
            }

            _customer.PaymentMethod = paymentMethodComboBox.Text;
            _customer.InvoiceCategory = invoiceCategoryComboBox.Text;
        }

        // EVENTS

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                birthDateTimePicker.Value = birthDateTimePicker.MinDate;
                bindComboBoxes();

                if (_customer == null) // Se está agregando un registro
                {
                    _customer = new Customer();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else // Se está editando un registro
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
                return;

            try
            {
                setCustomer();

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
    }
}
