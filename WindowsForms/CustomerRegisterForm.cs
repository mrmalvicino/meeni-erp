using System;
using System.Windows.Forms;
using System.Collections.Generic;
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

            if (!Validations.isNumber(taxCodeNumberTextBox.Text))
            {
                Validations.error("El campo de DNI solo admite caracteres numéricos.");
                return false;
            }

            // Person-Organization

            if (!Validations.isEmpty(organizationNameComboBox.Text) && organizationNameComboBox.SelectedIndex == -1)
            {
                Validations.error("La organización ingresada no es válida.");
                return false;
            }

            if (Validations.isEmpty(organizationNameComboBox.Text) && (Validations.isEmpty(firstNameTextBox.Text) || Validations.isEmpty(lastNameTextBox.Text)))
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

            if (!Validations.isEmpty(phoneNumberTextBox.Text) && phoneCountryComboBox.Text == "")
            {
                Validations.error("Especificar el código de área de país del teléfono.");
                return false;
            }

            if (!Validations.isEmpty(phoneNumberTextBox.Text) && phoneProvinceComboBox.Text == "")
            {
                Validations.error("Especificar el código de área de provincia del teléfono.");
                return false;
            }

            if (!Validations.isEmpty(phoneNumberTextBox.Text) && phoneCountryComboBox.SelectedIndex == -1)
            {
                Validations.error("El código de área de país del teléfono no es válido.");
                return false;
            }

            if (!Validations.isEmpty(phoneNumberTextBox.Text) && phoneProvinceComboBox.SelectedIndex == -1)
            {
                Validations.error("El código de área de provincia del teléfono no es válido.");
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

            //phoneProvinceComboBox.DataSource = _provincesManager.list();
            phoneProvinceComboBox.ValueMember = "ProvinceId";
            phoneProvinceComboBox.DisplayMember = "PhoneAreaCode";
            
            adressCountryComboBox.DataSource = _countriesManager.list();
            adressCountryComboBox.ValueMember = "CountryId";
            adressCountryComboBox.DisplayMember = "Name";
            
            //adressProvinceComboBox.DataSource = _provincesManager.list();
            adressProvinceComboBox.ValueMember = "ProvinceId";
            adressProvinceComboBox.DisplayMember = "Name";
            
            //cityComboBox.DataSource = _citiesManager.list();
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

            _customer.TaxCode.Prefix = taxCodePrefixTextBox.Text;
            _customer.TaxCode.Number = taxCodeNumberTextBox.Text;
            _customer.TaxCode.Suffix = taxCodeSuffixTextBox.Text;

            _customer.Adress.StreetName = streetNameTextBox.Text;
            _customer.Adress.StreetNumber = streetNumberTextBox.Text;
            _customer.Adress.Flat = flatTextBox.Text;
            _customer.Adress.Details = detailsTextBox.Text;
            _customer.Adress.City = (City)cityComboBox.SelectedItem;
            _customer.Adress.City.ZipCode = zipCodeTextBox.Text;
            _customer.Adress.Province = (Province)adressProvinceComboBox.SelectedItem;
            _customer.Adress.Country = (Country)adressCountryComboBox.SelectedItem;

            _customer.Phone.Country = (Country)phoneCountryComboBox.SelectedItem;
            _customer.Phone.Province = (Province)phoneProvinceComboBox.SelectedItem;
            _customer.Phone.Number = phoneNumberTextBox.Text;

            _customer.Person.FirstName = firstNameTextBox.Text;
            _customer.Person.LastName = lastNameTextBox.Text;

            _customer.Organization = (Organization)organizationNameComboBox.SelectedItem;
            _customer.Organization.Description = organizationDescriptionTextBox.Text;

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

            setCustomer();
            MessageBox.Show("TaxCodeId: " + _customer.TaxCode.TaxCodeId.ToString());
            MessageBox.Show("AdressId: " + _customer.Adress.AdressId.ToString());//
            MessageBox.Show("AdressCountryId: " + _customer.Adress.Country.CountryId.ToString());// ver que pasa si no hay adress id
            MessageBox.Show("AdressProvinceId: " + _customer.Adress.Province.ProvinceId.ToString());// ver que pasa si no hay adress id
            MessageBox.Show("AdressCityId: " + _customer.Adress.City.CityId.ToString());// ver que pasa si no hay adress id
            MessageBox.Show("PhoneId: " + _customer.Phone.PhoneId.ToString());
            MessageBox.Show("PhoneCountryId: " + _customer.Phone.Country.CountryId.ToString()); // ver que pasa si no hay phone id
            MessageBox.Show("PhoneProvinceId: " + _customer.Phone.Province.ProvinceId.ToString()); // ver que pasa si no hay phone id
            MessageBox.Show("PersonId: " + _customer.Person.PersonId.ToString());
            MessageBox.Show("OrganizationId: " + _customer.Organization.OrganizationId.ToString());
            MessageBox.Show("IndividualId: " + _customer.IndividualId.ToString());//
            MessageBox.Show("BusinessPartnerId: " + _customer.BusinessPartnerId.ToString());
            MessageBox.Show("CustomerId: " + _customer.CustomerId.ToString());
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

        private void phoneCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            phoneProvinceComboBox.DataSource = null;

            if (phoneCountryComboBox.SelectedIndex != -1)
            {
                Country country = (Country)phoneCountryComboBox.SelectedItem;
                phoneProvinceComboBox.DataSource = _provincesManager.list(country.CountryId);
            }

            phoneProvinceComboBox.ValueMember = "ProvinceId";
            phoneProvinceComboBox.DisplayMember = "PhoneAreaCode";
        }

        private void adressCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            adressProvinceComboBox.DataSource = null;

            if (adressCountryComboBox.SelectedIndex != -1)
            {
                Country country = (Country)adressCountryComboBox.SelectedItem;                
                adressProvinceComboBox.DataSource = _provincesManager.list(country.CountryId);
            }
        }

        private void adressProvinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.DataSource = null;

            if (adressProvinceComboBox.SelectedIndex != -1)
            {
                Province province = (Province)adressProvinceComboBox.SelectedItem;
                cityComboBox.DataSource = _citiesManager.list(province.ProvinceId);
            }
        }

        private void taxCodePrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(taxCodePrefixTextBox.Text))
                taxCodePrefixTextBox.ForeColor = Palette.DefaultBlack;
            else
                taxCodePrefixTextBox.ForeColor = Palette.ValidationColor;
        }

        private void taxCodeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(taxCodeNumberTextBox.Text))
                taxCodeNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                taxCodeNumberTextBox.ForeColor = Palette.ValidationColor;
        }

        private void taxCodeSuffixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(taxCodeSuffixTextBox.Text))
                taxCodeSuffixTextBox.ForeColor = Palette.DefaultBlack;
            else
                taxCodeSuffixTextBox.ForeColor = Palette.ValidationColor;
        }

        private void phoneCountryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(phoneCountryComboBox.Text))
                phoneCountryComboBox.ForeColor = Palette.DefaultBlack;
            else
                phoneCountryComboBox.ForeColor = Palette.ValidationColor;
        }

        private void phoneProvinceComboBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(phoneProvinceComboBox.Text))
                phoneProvinceComboBox.ForeColor = Palette.DefaultBlack;
            else
                phoneProvinceComboBox.ForeColor = Palette.ValidationColor;
        }

        private void phoneNumberTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (Validations.isNumber(phoneNumberTextBox.Text))
                phoneNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                phoneNumberTextBox.ForeColor = Palette.ValidationColor;
        }

        private void streetNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(streetNumberTextBox.Text))
                streetNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                streetNumberTextBox.ForeColor = Palette.ValidationColor;
        }
    }
}
