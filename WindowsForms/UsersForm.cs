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

        private User _selectedUser;
        private List<User> _usersTable;
        private List<User> _filteredUsers;
        private UsersManager _usersManager = new UsersManager();

        // CONSTRUCT

        public UsersForm()
        {
            InitializeComponent();
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
                dataGridView.Columns["Id"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["ImageUrl"].Visible = false;
                dataGridView.Columns["InvoiceCategory"].DisplayIndex = dataGridView.ColumnCount - 3;
                dataGridView.Columns["PaymentMethod"].DisplayIndex = dataGridView.ColumnCount - 2;
                dataGridView.Columns["SalesAmount"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["IsPerson"].Width = 50;
                dataGridView.Columns["InvoiceCategory"].Width = 50;
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
                _filteredUsers = _usersTable.FindAll(reg => ((reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)) && (reg.FirstName.ToUpper().Contains(filter.ToUpper()) || reg.LastName.ToUpper().Contains(filter.ToUpper()) || reg.BusinessName.ToUpper().Contains(filter.ToUpper()) || reg.BusinessDescription.ToUpper().Contains(filter.ToUpper()) || reg.Email.ToUpper().Contains(filter.ToUpper()) || reg.LegalId.ToString().Contains(filter)));
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
                loadProfile(-1, "N/A", "N/A", "N/A", "N/A", "N/A");
                Functions.loadImage(pictureBox, "");
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
                loadProfile(_selectedUser.UserId, _selectedUser.ToString(), _selectedUser.BusinessDescription, _selectedUser.Phone.ToString(), _selectedUser.Email.ToString(), _selectedUser.Adress.ToString());
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            UserRegisterForm registerForm = new UserRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
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

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
