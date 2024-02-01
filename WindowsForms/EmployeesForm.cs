using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EmployeesForm : Form
    {
        // ATTRIBUTES

        private Employee _selectedEmployee;
        private List<Employee> _employeesTable;
        private List<Employee> _filteredEmployees;
        private EmployeesManager _employeesManager = new EmployeesManager();

        // CONSTRUCT

        public EmployeesForm()
        {
            InitializeComponent();
        }

        public EmployeesForm(bool userButtonIsVisible)
        {
            InitializeComponent();
            userButton.Visible = userButtonIsVisible;
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            actionsPanel.BackColor = Palette.LightBackColor;
            dataGridView.BackgroundColor = Palette.LightBackColor;
            idTextBox.ForeColor = Palette.ForeColor;
            nameTextBox.ForeColor = Palette.ForeColor;
            descriptionTextBox.ForeColor = Palette.ForeColor;
            phoneTextBox.ForeColor = Palette.ForeColor;
            emailTextBox.ForeColor = Palette.ForeColor;
            adressTextBox.ForeColor = Palette.ForeColor;
            idTextBox.BackColor = Palette.LightBackColor;
            nameTextBox.BackColor = Palette.LightBackColor;
            descriptionTextBox.BackColor = Palette.LightBackColor;
            emailTextBox.BackColor = Palette.LightBackColor;
            phoneTextBox.BackColor = Palette.LightBackColor;
            adressTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["EmployeeId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["IsPerson"].Visible = false;
                dataGridView.Columns["FirstName"].Width = 80;
                dataGridView.Columns["LastName"].Width = 80;
                dataGridView.Columns["BusinessDescription"].Width = 120;
                dataGridView.Columns["ImageUrl"].Visible = false;
                dataGridView.Columns["Email"].Width = 150;
                dataGridView.Columns["Phone"].Width = 120;
                dataGridView.Columns["Adress"].Width = 150;
                dataGridView.Columns["LegalId"].Width = 80;
                dataGridView.Columns["IsUser"].Visible = false;
                dataGridView.Columns["Admission"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["Admission"].Width = 110;
                dataGridView.Columns["Category"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["Category"].Width = 150;
                Functions.fillDataGrid(dataGridView);
            }
        }

        private void loadProfile(int id, string name, string description, string phone, string email, string adress)
        {
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            descriptionTextBox.Text = description;
            phoneTextBox.Text = phone;
            emailTextBox.Text = email;
            adressTextBox.Text = adress;
        }

        private void refreshTable()
        {
            try
            {
                _employeesTable = _employeesManager.list();
                dataGridView.DataSource = _employeesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void applyFilter()
        {
            string filter = filterTextBox.Text;
            bool showActive = showActiveCheckBox.Checked;
            bool showInactive = showInactiveCheckBox.Checked;

            if (2 < filter.Length)
                _filteredEmployees = _employeesTable.FindAll(reg => ((reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)) && (reg.FirstName.ToUpper().Contains(filter.ToUpper()) || reg.LastName.ToUpper().Contains(filter.ToUpper()) || reg.BusinessName.ToUpper().Contains(filter.ToUpper()) || reg.BusinessDescription.ToUpper().Contains(filter.ToUpper()) || reg.Email.ToUpper().Contains(filter.ToUpper()) || reg.LegalId.ToString().Contains(filter)));
            else
                _filteredEmployees = _employeesTable.FindAll(reg => (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive));

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredEmployees;
            setupDataGridView();
            validateDataGridView();
        }

        private void validateDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                exportCSVButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                exportCSVButton.Enabled = false;
                loadProfile(-1, "N/A", "N/A", "N/A", "N/A", "N/A");
                Functions.loadImage(pictureBox, "");
            }
        }

        // EVENTS

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            refreshTable();
            setupDataGridView();
            applyFilter();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                _selectedEmployee = (Employee)dataGridView.CurrentRow.DataBoundItem;
                Functions.loadImage(pictureBox, _selectedEmployee.ImageUrl);
                loadProfile(_selectedEmployee.EmployeeId, _selectedEmployee.ToString(), _selectedEmployee.BusinessDescription, _selectedEmployee.Phone.ToString(), _selectedEmployee.Email.ToString(), _selectedEmployee.Adress.ToString());
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm registerForm = new EmployeeRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm registerForm = new EmployeeRegisterForm(_selectedEmployee);
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Esta acción no puede deshacerse. ¿Está seguro que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    _employeesManager.delete(_selectedEmployee.EmployeeId);
                    refreshTable();
                    applyFilter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportCSVButton_Click(object sender, EventArgs e)
        {
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_path"] + "Empleados.csv");
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Text = "";
            showActiveCheckBox.Checked = true;
            showInactiveCheckBox.Checked = false;
            applyFilter();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void showActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void showInactiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee.IsUser)
            {
                MessageBox.Show("El empleado seleccionado ya tiene un usuario creado.", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserRegisterForm registerForm = new UserRegisterForm(_selectedEmployee);
            registerForm.ShowDialog();
        }
    }
}
