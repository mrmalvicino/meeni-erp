using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class UsersForm : Form
    {
        // ATTRIBUTES

        private MainForm _mainForm = null;
        private User _selectedUser;
        private List<User> _usersTable;
        private List<User> _filteredUsers;
        private UsersManager _usersManager = new UsersManager();

        // CONSTRUCT

        public UsersForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            actionsPanel.BackColor = Palette.LightBackColor;
            dataGridView.BackgroundColor = Palette.LightBackColor;
            userIdTextBox.ForeColor = Palette.ForeColor;
            userNameTextBox.ForeColor = Palette.ForeColor;
            userIdTextBox.BackColor = Palette.LightBackColor;
            userNameTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["IsPerson"].Visible = false;
                dataGridView.Columns["FirstName"].Visible = false;
                dataGridView.Columns["LastName"].Visible = false;
                dataGridView.Columns["BusinessName"].Visible = false;
                dataGridView.Columns["BusinessDescription"].Visible = false;
                dataGridView.Columns["ImageUrl"].Visible = false;
                dataGridView.Columns["Email"].Visible = false;
                dataGridView.Columns["Phone"].Visible = false;
                dataGridView.Columns["Adress"].Visible = false;
                dataGridView.Columns["LegalId"].Visible = false;
                dataGridView.Columns["EmployeeId"].Visible = false;
                dataGridView.Columns["IsUser"].Visible = false;
                dataGridView.Columns["Admission"].Visible = false;
                dataGridView.Columns["Category"].Visible = false;
                dataGridView.Columns["UserId"].Visible = false;
                dataGridView.Columns["UserPassword"].Visible = false;
                Functions.fillDataGrid(dataGridView);
            }
        }

        private void loadProfile(int userId, string userName)
        {
            userIdTextBox.Text = userId.ToString();
            userNameTextBox.Text = userName;
        }

        private void refreshTable()
        {
            try
            {
                _usersTable = _usersManager.list();
                dataGridView.DataSource = _usersTable;
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
                _filteredUsers = _usersTable.FindAll(reg => ((reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)) && reg.FirstName.ToUpper().Contains(filter.ToUpper()));
            else
                _filteredUsers = _usersTable.FindAll(reg => (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive));

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredUsers;
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
                loadProfile(-1, "N/A");
            }
        }

        // EVENTS

        private void UsersForm_Load(object sender, EventArgs e)
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
                _selectedUser = (User)dataGridView.CurrentRow.DataBoundItem;
                Functions.loadImage(pictureBox, _selectedUser.ImageUrl);
                loadProfile(_selectedUser.UserId, _selectedUser.ToString());
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            FormsManager formsManager = new FormsManager(_mainForm);
            formsManager.closeForm<EmployeesForm>();
            EmployeesForm employeesForm = new EmployeesForm(true);
            employeesForm.MdiParent = this.MdiParent;
            employeesForm.Show();
            MessageBox.Show("Seleccione un empleado para crear un usuario.", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UserRegisterForm registerForm = new UserRegisterForm(_selectedUser);
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
                    _usersManager.delete(_selectedUser.UserId);
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
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_path"] + "Clientes.csv");
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
    }
}
