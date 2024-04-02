using System;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class SupplierRegisterForm : Form
    {
        // ATTRIBUTES

        private Supplier _supplier = null;
        private SuppliersManager _suppliersManager = new SuppliersManager();
        private OrganizationsManager _organizationsManager = new OrganizationsManager();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();
        private CitiesManager _citiesManager = new CitiesManager();

        //CONSTRUCT

        public SupplierRegisterForm()
        {
            InitializeComponent();
        }

        public SupplierRegisterForm(Supplier supplier)
        {
            InitializeComponent();
            _supplier = supplier;
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
            activeStatusCheckBox.Checked = _supplier.ActiveStatus;
            phoneTextBox.Text = _supplier.Phone;
            emailTextBox.Text = _supplier.Email;

            if (birthDateTimePicker.MinDate < _supplier.Birth && _supplier.Birth < birthDateTimePicker.MaxDate)
            {
                birthDateTimePicker.Value = DateTime.Parse(_supplier.Birth.ToShortDateString());
            }

            if (0 < _supplier.TaxCode.TaxCodeId)
            {
                taxCodePrefixTextBox.Text = _supplier.TaxCode.Prefix;
                taxCodeNumberTextBox.Text = _supplier.TaxCode.Number;
                taxCodeSuffixTextBox.Text = _supplier.TaxCode.Suffix;
            }

            if (0 < _supplier.Adress.City.CityId)
            {
                streetNameTextBox.Text = _supplier.Adress.StreetName;
                streetNumberTextBox.Text = _supplier.Adress.StreetNumber;
                flatTextBox.Text = _supplier.Adress.Flat;
                detailsTextBox.Text = _supplier.Adress.Details;
                adressCityComboBox.SelectedValue = _supplier.Adress.City.CityId;
                zipCodeTextBox.Text = _supplier.Adress.City.ZipCode;
                adressProvinceComboBox.SelectedValue = _supplier.Adress.Province.ProvinceId;
                adressCountryComboBox.SelectedValue = _supplier.Adress.Country.CountryId;
            }
            else
            {
                adressCityComboBox.SelectedIndex = -1;
                adressProvinceComboBox.SelectedIndex = -1;
                adressCountryComboBox.SelectedIndex = -1;
            }

            if (0 < _supplier.Organization.OrganizationId)
            {
                organizationNameComboBox.SelectedValue = _supplier.Organization.OrganizationId;
                organizationDescriptionTextBox.Text = _supplier.Organization.Description;
            }

            if (0 < _supplier.Person.PersonId)
            {
                firstNameTextBox.Text = _supplier.Person.FirstName;
                lastNameTextBox.Text = _supplier.Person.LastName;
            }

            if (0 < _supplier.Image.ImageId)
            {
                imageUrlTextBox.Text = _supplier.Image.Url;
            }
        }

        private void mapBusinessPartner()
        {
            mapIndividual();
            paymentMethodComboBox.Text = _supplier.PaymentMethod;
            invoiceCategoryComboBox.Text = _supplier.InvoiceCategory;
        }

        private void mapSupplier()
        {
            mapBusinessPartner();
        }

        private void setIndividual()
        {
            _supplier.ActiveStatus = activeStatusCheckBox.Checked;
            _supplier.Phone = phoneTextBox.Text;
            _supplier.Email = emailTextBox.Text;
            _supplier.Birth = birthDateTimePicker.Value;

            if (Validations.hasData(taxCodeNumberTextBox.Text))
            {
                _supplier.TaxCode.Prefix = taxCodePrefixTextBox.Text;
                _supplier.TaxCode.Number = taxCodeNumberTextBox.Text;
                _supplier.TaxCode.Suffix = taxCodeSuffixTextBox.Text;
            }
            else
            {
                _supplier.TaxCode = null;
            }

            if (Validations.hasData(adressCityComboBox.Text))
            {
                _supplier.Adress.StreetName = streetNameTextBox.Text;
                _supplier.Adress.StreetNumber = streetNumberTextBox.Text;
                _supplier.Adress.Flat = flatTextBox.Text;
                _supplier.Adress.Details = detailsTextBox.Text;
                _supplier.Adress.City.Name = adressCityComboBox.Text;
                _supplier.Adress.City.ZipCode = zipCodeTextBox.Text;
                _supplier.Adress.Province.Name = adressProvinceComboBox.Text;
                _supplier.Adress.Country.Name = adressCountryComboBox.Text;
            }
            else
            {
                _supplier.Adress = null;
            }

            if (Validations.hasData(firstNameTextBox.Text))
            {
                _supplier.Person.FirstName = firstNameTextBox.Text;
                _supplier.Person.LastName = lastNameTextBox.Text;
            }
            else
            {
                _supplier.Person = null;
            }

            if (Validations.hasData(organizationNameComboBox.Text))
            {
                _supplier.Organization.Name = organizationNameComboBox.Text;
                _supplier.Organization.Description = organizationDescriptionTextBox.Text;
            }
            else
            {
                _supplier.Organization = null;
            }

            if (Validations.hasData(imageUrlTextBox.Text))
            {
                _supplier.Image.Url = imageUrlTextBox.Text;
            }
            else
            {
                _supplier.Image = null;
            }
        }

        private void setBusinessPartner()
        {
            setIndividual();
            _supplier.PaymentMethod = paymentMethodComboBox.Text;
            _supplier.InvoiceCategory = invoiceCategoryComboBox.Text;
        }

        private void setSupplier()
        {
            setBusinessPartner();
        }

        // EVENTS

        private void SupplierRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                birthDateTimePicker.Value = birthDateTimePicker.MinDate;
                bindComboBoxes();

                if (_supplier == null)
                {
                    _supplier = new Supplier();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else
                {
                    mapSupplier();
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
                setSupplier();

                if (0 < _supplier.SupplierId)
                {
                    _suppliersManager.edit(_supplier);
                }
                else
                {
                    _suppliersManager.add(_supplier);
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
