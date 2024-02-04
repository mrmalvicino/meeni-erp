using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using BLL;
using Entities;

namespace WindowsForms
{
    public partial class SupplierRegisterForm : Form
    {
        // ATTRIBUTES

        Supplier _supplier = null;
        OpenFileDialog _file = null;
        SuppliersManager _suppliersManager = new SuppliersManager();

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
            if (Validations.isNumber(legalIdDNITextBox.Text) == false)
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
            else
            {
                if (Validations.isEmpty(businessNameTextBox.Text))
                {
                    MessageBox.Show("Especificar el nombre de la organización.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (Validations.isNumber(phoneCountryTextBox.Text) == false)
            {
                MessageBox.Show("El código de país del teléfono solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validations.isNumber(phoneAreaTextBox.Text) == false)
            {
                MessageBox.Show("El código de área del teléfono solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validations.isNumber(phoneNumberTextBox.Text) == false)
            {
                MessageBox.Show("El número de teléfono solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validations.isNumber(adressStreetNumberTextBox.Text) == false)
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

        // EVENTS

        private void SupplierRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            if (_supplier == null) // Se está agregando un registro
            {
                _supplier = new Supplier();
                activeStatusCheckBox.Enabled = false;
            }
            else // Se está editando un registro
            {
                activeStatusCheckBox.Checked = _supplier.ActiveStatus;
                isPersonCheckBox.Checked = _supplier.IsPerson;
                firstNameTextBox.Text = _supplier.FirstName;
                lastNameTextBox.Text = _supplier.LastName;
                businessNameTextBox.Text = _supplier.BusinessName;
                businessDescriptionTextBox.Text = _supplier.BusinessDescription;
                imageUrlTextBox.Text = _supplier.ImageUrl;
                emailTextBox.Text = _supplier.Email;

                phoneCountryTextBox.Text = _supplier.Phone.Country.ToString();
                phoneAreaTextBox.Text = _supplier.Phone.Area.ToString();
                phoneNumberTextBox.Text = _supplier.Phone.Number.ToString();

                adressCountryTextBox.Text = _supplier.Adress.Country;
                adressProvinceTextBox.Text = _supplier.Adress.Province;
                adressCityTextBox.Text = _supplier.Adress.City;
                adressZipCodeTextBox.Text = _supplier.Adress.ZipCode;
                adressStreetTextBox.Text = _supplier.Adress.Street;
                adressStreetNumberTextBox.Text = _supplier.Adress.StreetNumber.ToString();
                adressFlatTextBox.Text = _supplier.Adress.Flat;

                legalIdXXTextBox.Text = _supplier.LegalId.XX;
                legalIdDNITextBox.Text = _supplier.LegalId.DNI.ToString();
                legalIdYTextBox.Text = _supplier.LegalId.Y;

                paymentMethodComboBox.Text = _supplier.PaymentMethod;
                invoiceCategoryComboBox.Text = _supplier.InvoiceCategory;

                Functions.loadImage(pictureBox, imageUrlTextBox.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
                return;

            try
            {
                _supplier.ActiveStatus = activeStatusCheckBox.Checked;
                _supplier.IsPerson = isPersonCheckBox.Checked;
                _supplier.FirstName = firstNameTextBox.Text;
                _supplier.LastName = lastNameTextBox.Text;
                _supplier.BusinessName = businessNameTextBox.Text;
                _supplier.BusinessDescription = businessDescriptionTextBox.Text;
                _supplier.ImageUrl = imageUrlTextBox.Text;
                _supplier.Email = emailTextBox.Text;

                if (phoneCountryTextBox.Text != "") _supplier.Phone.Country = int.Parse(phoneCountryTextBox.Text);
                if (phoneAreaTextBox.Text != "") _supplier.Phone.Area = int.Parse(phoneAreaTextBox.Text);
                if (phoneNumberTextBox.Text != "") _supplier.Phone.Number = int.Parse(phoneNumberTextBox.Text);

                _supplier.Adress.Country = adressCountryTextBox.Text;
                _supplier.Adress.Province = adressProvinceTextBox.Text;
                _supplier.Adress.City = adressCityTextBox.Text;
                _supplier.Adress.ZipCode = adressZipCodeTextBox.Text;
                _supplier.Adress.Street = adressStreetTextBox.Text;
                if (adressStreetNumberTextBox.Text != "") _supplier.Adress.StreetNumber = int.Parse(adressStreetNumberTextBox.Text);
                _supplier.Adress.Flat = adressFlatTextBox.Text;

                _supplier.LegalId.XX = legalIdXXTextBox.Text;
                if (legalIdDNITextBox.Text != "") _supplier.LegalId.DNI = int.Parse(legalIdDNITextBox.Text);
                _supplier.LegalId.Y = legalIdYTextBox.Text;

                _supplier.PaymentMethod = paymentMethodComboBox.Text;
                _supplier.InvoiceCategory = invoiceCategoryComboBox.Text;

                if (0 < _supplier.Id)
                    _suppliersManager.edit(_supplier); // Se está editando un registro
                else
                    _suppliersManager.add(_supplier); // Se está agregando un registro

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
            Functions.loadImage(pictureBox, imageUrlTextBox.Text);
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _file = new OpenFileDialog();
            _file.Filter = "jpg|*.jpg;|png|*.png";
            _file.Title = "Seleccionar imagen";

            if (_file.ShowDialog() == DialogResult.OK)
            {
                Functions.loadImage(pictureBox, _file.FileName);
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
            if (Validations.isNumber(legalIdDNITextBox.Text))
                legalIdDNITextBox.ForeColor = Palette.DefaultBlack;
            else
                legalIdDNITextBox.ForeColor = Palette.ValidationColor;
        }

        private void phoneCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(phoneCountryTextBox.Text))
                phoneCountryTextBox.ForeColor = Palette.DefaultBlack;
            else
                phoneCountryTextBox.ForeColor = Palette.ValidationColor;
        }

        private void phoneAreaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(phoneAreaTextBox.Text))
                phoneAreaTextBox.ForeColor = Palette.DefaultBlack;
            else
                phoneAreaTextBox.ForeColor = Palette.ValidationColor;
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
            if (Validations.isNumber(adressStreetNumberTextBox.Text))
                adressStreetNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                adressStreetNumberTextBox.ForeColor = Palette.ValidationColor;
        }
    }
}
