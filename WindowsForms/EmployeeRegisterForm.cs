using BLL;
using Entities;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EmployeeRegisterForm : Form
    {
        // ATTRIBUTES

        Employee _employee = null;
        OpenFileDialog _file = null;
        EmployeesManager _employeesManager = new EmployeesManager();
        CategoriesManager _categoriesManager = new CategoriesManager();

        //CONSTRUCT

        public EmployeeRegisterForm()
        {
            InitializeComponent();
        }

        public EmployeeRegisterForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
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

            if (categoryAreaComboBox.Text == "")
            {
                MessageBox.Show("Indicar en qué área trabaja el empleado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (categoryTitleComboBox.Text == "")
            {
                MessageBox.Show("Indicar el título del puesto del empleado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (categorySeniorityComboBox.Text == "")
            {
                MessageBox.Show("Indicar la experiencia del empleado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_categoriesManager.getCategoryId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text) == -1)
            {
                MessageBox.Show("Los datos de área, título y experiencia no representan una categoría existente. Si así lo requiere, puede agregarla como una nueva categoría.", "Categoría inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // EVENTS

        private void EmployeeRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                categoryAreaComboBox.DataSource = _categoriesManager.listRegisters("Area");
                categoryTitleComboBox.DataSource = _categoriesManager.listRegisters("Title");
                categorySeniorityComboBox.DataSource = _categoriesManager.listRegisters("Seniority");

                if (_employee == null) // Se está agregando un registro
                {
                    _employee = new Employee();
                    activeStatusCheckBox.Enabled = false;
                    categoryAreaComboBox.SelectedIndex = -1;
                    categoryTitleComboBox.SelectedIndex = -1;
                    categorySeniorityComboBox.SelectedIndex = -1;
                }
                else // Se está editando un registro
                {
                    categoryAreaComboBox.Text = _employee.Category.Area;
                    categoryTitleComboBox.Text = _employee.Category.Title;
                    categorySeniorityComboBox.Text = _employee.Category.Seniority;

                    activeStatusCheckBox.Checked = _employee.ActiveStatus;
                    isPersonCheckBox.Checked = _employee.IsPerson;
                    firstNameTextBox.Text = _employee.FirstName;
                    lastNameTextBox.Text = _employee.LastName;
                    businessNameTextBox.Text = _employee.BusinessName;
                    businessDescriptionTextBox.Text = _employee.BusinessDescription;
                    imageUrlTextBox.Text = _employee.ImageUrl;
                    emailTextBox.Text = _employee.Email;

                    phoneCountryTextBox.Text = _employee.Phone.Country.ToString();
                    phoneAreaTextBox.Text = _employee.Phone.Area.ToString();
                    phoneNumberTextBox.Text = _employee.Phone.Number.ToString();

                    adressCountryTextBox.Text = _employee.Adress.Country;
                    adressProvinceTextBox.Text = _employee.Adress.Province;
                    adressCityTextBox.Text = _employee.Adress.City;
                    adressZipCodeTextBox.Text = _employee.Adress.ZipCode;
                    adressStreetTextBox.Text = _employee.Adress.Street;
                    adressStreetNumberTextBox.Text = _employee.Adress.StreetNumber.ToString();
                    adressFlatTextBox.Text = _employee.Adress.Flat;

                    legalIdXXTextBox.Text = _employee.LegalId.XX;
                    legalIdDNITextBox.Text = _employee.LegalId.DNI.ToString();
                    legalIdYTextBox.Text = _employee.LegalId.Y;

                    Functions.loadImage(pictureBox, imageUrlTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
                return;

            try
            {
                _employee.ActiveStatus = activeStatusCheckBox.Checked;
                _employee.IsPerson = isPersonCheckBox.Checked;
                _employee.FirstName = firstNameTextBox.Text;
                _employee.LastName = lastNameTextBox.Text;
                _employee.BusinessName = businessNameTextBox.Text;
                _employee.BusinessDescription = businessDescriptionTextBox.Text;
                _employee.ImageUrl = imageUrlTextBox.Text;
                _employee.Email = emailTextBox.Text;

                if (phoneCountryTextBox.Text != "") _employee.Phone.Country = int.Parse(phoneCountryTextBox.Text);
                if (phoneAreaTextBox.Text != "") _employee.Phone.Area = int.Parse(phoneAreaTextBox.Text);
                if (phoneNumberTextBox.Text != "") _employee.Phone.Number = int.Parse(phoneNumberTextBox.Text);

                _employee.Adress.Country = adressCountryTextBox.Text;
                _employee.Adress.Province = adressProvinceTextBox.Text;
                _employee.Adress.City = adressCityTextBox.Text;
                _employee.Adress.ZipCode = adressZipCodeTextBox.Text;
                _employee.Adress.Street = adressStreetTextBox.Text;
                if (adressStreetNumberTextBox.Text != "") _employee.Adress.StreetNumber = int.Parse(adressStreetNumberTextBox.Text);
                _employee.Adress.Flat = adressFlatTextBox.Text;

                _employee.LegalId.XX = legalIdXXTextBox.Text;
                if (legalIdDNITextBox.Text != "") _employee.LegalId.DNI = int.Parse(legalIdDNITextBox.Text);
                _employee.LegalId.Y = legalIdYTextBox.Text;

                _employee.Category.Id = _categoriesManager.getCategoryId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text);
                _employee.Category.Area = categoryAreaComboBox.Text;
                _employee.Category.Title = categoryTitleComboBox.Text;
                _employee.Category.Seniority = categorySeniorityComboBox.Text;

                if (0 < _employee.EmployeeId)
                    _employeesManager.edit(_employee); // Se está editando un registro
                else
                    _employeesManager.add(_employee); // Se está agregando un registro

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

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if (0 < _categoriesManager.getCategoryId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text))
            {
                MessageBox.Show($"La categoría {categoryTitleComboBox.Text} {categorySeniorityComboBox.Text} perteneciente al área de {categoryAreaComboBox.Text} ya existe.", "Categoría existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult answer = MessageBox.Show($"¿Desea agregar la categoría {categoryTitleComboBox.Text} {categorySeniorityComboBox.Text} perteneciente al área de {categoryAreaComboBox.Text}?", "Nueva categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    Category newCategory = new Category();
                    newCategory.Area = categoryAreaComboBox.Text;
                    newCategory.Title = categoryTitleComboBox.Text;
                    newCategory.Seniority = categorySeniorityComboBox.Text;
                    _categoriesManager.add(newCategory);
                }
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            int id = _categoriesManager.getCategoryId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text);

            if (id == -1)
            {
                MessageBox.Show($"La categoría {categoryTitleComboBox.Text} {categorySeniorityComboBox.Text} perteneciente al área de {categoryAreaComboBox.Text} no existe.", "Categoría inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult answer = MessageBox.Show("Esta acción no puede deshacerse. ¿Está seguro que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    _categoriesManager.delete(id);
                }
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserRegisterForm registerForm = new UserRegisterForm(_selectedEmployee);
            registerForm.ShowDialog();
        }
    }
}
