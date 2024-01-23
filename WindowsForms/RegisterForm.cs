using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Configuration;
using Entities;
using BLL;

namespace WindowsForms
{
    public partial class RegisterForm : Form
    {
        // ATTRIBUTES

        Individual _individual = null;
        OpenFileDialog _file = null;
        CustomersManager _customersManager = new CustomersManager();

        //CONSTRUCT

        public RegisterForm() // Para agregar un registro
        {
            InitializeComponent();
        }

        public RegisterForm(Individual individual) // Para editar un registro
        {
            InitializeComponent();
            _individual = individual;
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.darkBackground();
            mainPanel.BackColor = Palette.lightBackground();
            imagePanel.BackColor = Palette.lightBackground();
            contactPanel.BackColor = Palette.lightBackground();
            adressPanel.BackColor = Palette.lightBackground();
        }

        // EVENTS

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            if (_individual == null) // Se está agregando un registro
            {
                _individual = new Individual();
                activeStatusCheckBox.Enabled = false;
            }
            else // Se está editando un registro
            {
                activeStatusCheckBox.Checked = _individual.ActiveStatus;
                isPersonCheckBox.Checked = _individual.IsPerson;
                firstNameTextBox.Text = _individual.FirstName;
                lastNameTextBox.Text = _individual.LastName;
                businessNameTextBox.Text = _individual.BusinessName;
                businessDescriptionTextBox.Text = _individual.BusinessDescription;
                imageUrlTextBox.Text = _individual.ImageUrl;
                emailTextBox.Text = _individual.Email;

                phoneCountryTextBox.Text = _individual.Phone.Country.ToString();
                phoneAreaTextBox.Text = _individual.Phone.Area.ToString();
                phoneNumberTextBox.Text = _individual.Phone.Number.ToString();

                adressCountryTextBox.Text = _individual.Adress.Country;
                adressProvinceTextBox.Text = _individual.Adress.Province;
                adressCityTextBox.Text = _individual.Adress.City;
                adressZipCodeTextBox.Text = _individual.Adress.ZipCode;
                adressStreetTextBox.Text = _individual.Adress.Street;
                adressStreetNumberTextBox.Text = _individual.Adress.StreetNumber.ToString();
                adressFlatTextBox.Text = _individual.Adress.Flat;

                legalIdXXTextBox.Text = _individual.LegalId.XX;
                legalIdDNITextBox.Text = _individual.LegalId.DNI.ToString();
                legalIdYTextBox.Text = _individual.LegalId.Y;

                Functions.loadImage(pictureBox, imageUrlTextBox.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _individual.ActiveStatus = activeStatusCheckBox.Checked;
                _individual.IsPerson = isPersonCheckBox.Checked;
                _individual.FirstName = firstNameTextBox.Text;
                _individual.LastName = lastNameTextBox.Text;
                _individual.BusinessName = businessNameTextBox.Text;
                _individual.BusinessDescription = businessDescriptionTextBox.Text;
                _individual.ImageUrl = imageUrlTextBox.Text;
                _individual.Email = emailTextBox.Text;

                _individual.Phone.Country = int.Parse(phoneCountryTextBox.Text);
                _individual.Phone.Area = int.Parse(phoneAreaTextBox.Text);
                _individual.Phone.Number = int.Parse(phoneNumberTextBox.Text);

                _individual.Adress.Country = adressCountryTextBox.Text;
                _individual.Adress.Province = adressProvinceTextBox.Text;
                _individual.Adress.City = adressCityTextBox.Text;
                _individual.Adress.ZipCode = adressZipCodeTextBox.Text;
                _individual.Adress.Street = adressStreetTextBox.Text;
                _individual.Adress.StreetNumber = int.Parse(adressStreetNumberTextBox.Text);
                _individual.Adress.Flat = adressFlatTextBox.Text;

                _individual.LegalId.XX = legalIdXXTextBox.Text;
                _individual.LegalId.DNI = int.Parse(legalIdDNITextBox.Text);
                _individual.LegalId.Y = legalIdYTextBox.Text;
                
                if (0 < _individual.Id) _customersManager.edit(_individual); // Se está agregando un registro
                else _customersManager.add(_individual); // Se está editando un registro

                if (_file == null && !(imageUrlTextBox.Text.ToLower().Contains("http")))
                    File.Copy(imageUrlTextBox.Text, ConfigurationManager.AppSettings["images_path"]);

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
                imageUrlTextBox.Text = _file.FileName;
                Functions.loadImage(pictureBox, imageUrlTextBox.Text);
            }
        }
    }
}
