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
        PositionsManager _positionsManager = new PositionsManager();

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
            isPersonCheckBox.Visible = false;
            isPersonLabel.Visible = false;
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

            if (_positionsManager.getPositionId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text) == -1)
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
                categoryAreaComboBox.DataSource = _positionsManager.list("Area");
                categoryTitleComboBox.DataSource = _positionsManager.list("Title");
                categorySeniorityComboBox.DataSource = _positionsManager.list("Seniority");

                if (_employee == null) // Se está agregando un registro
                {
                    _employee = new Employee();
                    userButton.Visible = false;
                    activeStatusCheckBox.Visible = false;
                    activeStatusLabel.Visible = false;
                    categoryAreaComboBox.SelectedIndex = -1;
                    categoryTitleComboBox.SelectedIndex = -1;
                    categorySeniorityComboBox.SelectedIndex = -1;
                }
                else // Se está editando un registro
                {
                    categoryTitleComboBox.Text = _employee.Position.Title;
                    categorySeniorityComboBox.Text = _employee.Position.Seniority.Name;
                    categoryAreaComboBox.Text = _employee.Position.Department.Name;

                    activeStatusCheckBox.Checked = _employee.ActiveStatus;
                    emailTextBox.Text = _employee.Email;

                    phoneNumberTextBox.Text = _employee.Phone.Number.ToString();
                    phoneCountryTextBox.Text = _employee.Phone.Country.PhoneAreaCode.ToString();
                    phoneAreaTextBox.Text = _employee.Phone.Province.PhoneAreaCode.ToString();

                    adressStreetTextBox.Text = _employee.Adress.StreetName;
                    adressStreetNumberTextBox.Text = _employee.Adress.StreetNumber.ToString();
                    adressFlatTextBox.Text = _employee.Adress.Flat;
                    adressCountryTextBox.Text = _employee.Adress.Country.Name;
                    adressProvinceTextBox.Text = _employee.Adress.Province.Name;

                    legalIdXXTextBox.Text = _employee.TaxCode.Prefix;
                    legalIdDNITextBox.Text = _employee.TaxCode.Number.ToString();
                    legalIdYTextBox.Text = _employee.TaxCode.Suffix;

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
                _employee.Email = emailTextBox.Text;

                if (phoneNumberTextBox.Text != "") _employee.Phone.Number = int.Parse(phoneNumberTextBox.Text);
                if (phoneCountryTextBox.Text != "") _employee.Phone.Country.PhoneAreaCode = int.Parse(phoneCountryTextBox.Text);
                if (phoneAreaTextBox.Text != "") _employee.Phone.Province.PhoneAreaCode = int.Parse(phoneAreaTextBox.Text);

                _employee.Adress.StreetName = adressStreetTextBox.Text;
                if (adressStreetNumberTextBox.Text != "") _employee.Adress.StreetNumber = int.Parse(adressStreetNumberTextBox.Text);
                _employee.Adress.Flat = adressFlatTextBox.Text;
                _employee.Adress.Country.Name = adressCountryTextBox.Text;
                _employee.Adress.Province.Name = adressProvinceTextBox.Text;

                _employee.TaxCode.Prefix = legalIdXXTextBox.Text;
                if (legalIdDNITextBox.Text != "") _employee.TaxCode.Number = int.Parse(legalIdDNITextBox.Text);
                _employee.TaxCode.Suffix = legalIdYTextBox.Text;

                _employee.Position.PositionId = _positionsManager.getPositionId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text);
                _employee.Position.Title = categoryTitleComboBox.Text;
                _employee.Position.Seniority.Name = categorySeniorityComboBox.Text;
                _employee.Position.Department.Name = categoryAreaComboBox.Text;

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
            if (0 < _positionsManager.getPositionId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text))
            {
                MessageBox.Show($"La categoría {categoryTitleComboBox.Text} {categorySeniorityComboBox.Text} perteneciente al área de {categoryAreaComboBox.Text} ya existe.", "Categoría existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult answer = MessageBox.Show($"¿Desea agregar la categoría {categoryTitleComboBox.Text} {categorySeniorityComboBox.Text} perteneciente al área de {categoryAreaComboBox.Text}?", "Nueva categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    Position newPosition = new Position();
                    newPosition.Department.Name = categoryAreaComboBox.Text;
                    newPosition.Title = categoryTitleComboBox.Text;
                    newPosition.Seniority.Name = categorySeniorityComboBox.Text;
                    _positionsManager.add(newPosition);
                }
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            int id = _positionsManager.getPositionId(categoryAreaComboBox.Text, categoryTitleComboBox.Text, categorySeniorityComboBox.Text);

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
                    _positionsManager.delete(id);
                }
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserRegisterForm registerForm = new UserRegisterForm(_employee);
            registerForm.ShowDialog();
        }
    }
}
