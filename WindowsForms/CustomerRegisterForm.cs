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

            if (Validations.isNumber(phoneCountryTextBox.Text) == false)
            {
                MessageBox.Show("El código de país del teléfono solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validations.isNumber(phoneProvinceTextBox.Text) == false)
            {
                MessageBox.Show("El código de área del teléfono solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        // EVENTS

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            if (_customer == null) // Se está agregando un registro
            {
                _customer = new Customer();
                activeStatusCheckBox.Enabled = false;
            }
            else // Se está editando un registro
            {
                activeStatusCheckBox.Checked = _customer.ActiveStatus;
                emailTextBox.Text = _customer.Email;

                phoneNumberTextBox.Text = _customer.Phone.Number.ToString();
                phoneCountryTextBox.Text = _customer.Phone.Country.PhoneAreaCode.ToString();
                phoneProvinceTextBox.Text = _customer.Phone.Province.PhoneAreaCode.ToString();

                streetNameTextBox.Text = _customer.Adress.StreetName;
                streetNumberTextBox.Text = _customer.Adress.StreetNumber.ToString();
                flatTextBox.Text = _customer.Adress.Flat;

                legalIdXXTextBox.Text = _customer.TaxCode.Prefix;
                legalIdDNITextBox.Text = _customer.TaxCode.Number.ToString();
                legalIdYTextBox.Text = _customer.TaxCode.Suffix;

                paymentMethodComboBox.Text = _customer.PaymentMethod;
                invoiceCategoryComboBox.Text = _customer.InvoiceCategory;

                Functions.loadImage(pictureBox, imageUrlTextBox.Text);
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
                if (phoneCountryTextBox.Text != "") _customer.Phone.Country.PhoneAreaCode = int.Parse(phoneCountryTextBox.Text);
                if (phoneProvinceTextBox.Text != "") _customer.Phone.Province.PhoneAreaCode = int.Parse(phoneProvinceTextBox.Text);

                _customer.Adress.StreetName = streetNameTextBox.Text;
                if (streetNumberTextBox.Text != "") _customer.Adress.StreetNumber = int.Parse(streetNumberTextBox.Text);
                _customer.Adress.Flat = flatTextBox.Text;

                _customer.TaxCode.Prefix = legalIdXXTextBox.Text;
                if (legalIdDNITextBox.Text != "") _customer.TaxCode.Number = int.Parse(legalIdDNITextBox.Text);
                _customer.TaxCode.Suffix = legalIdYTextBox.Text;

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
            if (Validations.isNumber(phoneProvinceTextBox.Text))
                phoneProvinceTextBox.ForeColor = Palette.DefaultBlack;
            else
                phoneProvinceTextBox.ForeColor = Palette.ValidationColor;
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
