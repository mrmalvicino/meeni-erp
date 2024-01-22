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
using Entities;
using BLL;

namespace WindowsForms
{
    public partial class RegisterForm : Form
    {
        // ATTRIBUTES

        Individual _individual = new Individual();
        CustomersManager _customersManager = new CustomersManager();

        //CONSTRUCT

        public RegisterForm()
        {
            InitializeComponent();
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.darkBackground();
            picturePanel.BackColor = Palette.lightBackground();
            imagePanel.BackColor = Palette.lightBackground();
            mainPanel.BackColor = Palette.lightBackground();
            contactPanel.BackColor = Palette.lightBackground();
            adressPanel.BackColor = Palette.lightBackground();
        }

        // EVENTS

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            isPersonComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isPersonComboBox.SelectedItem.ToString() == "Persona física") _individual.IsPerson = true;
                _individual.ActiveStatus = true;
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
                _individual.Adress.ZipCode = zipCodeTextBox.Text;
                _individual.Adress.Street = adressStreetTextBox.Text;
                _individual.Adress.StreetNumber = int.Parse(adressStreetNumberTextBox.Text);
                _individual.Adress.Flat = adressFlatTextBox.Text;
                _individual.LegalId.XX = legalIdXXTextBox.Text;
                _individual.LegalId.DNI = int.Parse(legalIdDNITextBox.Text);
                _individual.LegalId.Y = legalIdYTextBox.Text;

                _customersManager.add(_individual);
                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
