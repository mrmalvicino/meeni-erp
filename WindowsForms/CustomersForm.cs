using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using BLL;
using Entities;

namespace WindowsForms
{
    public partial class CustomersForm : Form
    {
        // ATTRIBUTES

        private Customer _selectedCustomer;
        private List<Customer> _customersTable;
        private List<Customer> _filteredCustomers;
        private CustomersManager _customersManager = new CustomersManager();

        // CONSTRUCT

        public CustomersForm()
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
                dataGridView.Columns["IndividualId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["FirstName"].Width = 60;
                dataGridView.Columns["LastName"].Width = 60;
                dataGridView.Columns["BusinessDescription"].Width = 120;
                dataGridView.Columns["ImageUrl"].Visible = false;
                dataGridView.Columns["Email"].Width = 150;
                dataGridView.Columns["Phone"].Width = 100;
                dataGridView.Columns["Adress"].Width = 150;
                dataGridView.Columns["TaxCode"].Width = 70;
                dataGridView.Columns["BusinessPartnerId"].Visible = false;
                dataGridView.Columns["PaymentMethod"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["PaymentMethod"].Width = 50;
                dataGridView.Columns["InvoiceCategory"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["InvoiceCategory"].Width = 50;
                dataGridView.Columns["CustomerId"].Visible = false;
                dataGridView.Columns["SalesAmount"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["SalesAmount"].Width = 50;
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
                _customersTable = _customersManager.listCustomers();
                dataGridView.DataSource = _customersTable;
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
                _filteredCustomers = _customersTable.FindAll(reg => ((reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)) && (reg.Person.FirstName.ToUpper().Contains(filter.ToUpper()) || reg.Person.LastName.ToUpper().Contains(filter.ToUpper()) || reg.Organization.OrganizationName.ToUpper().Contains(filter.ToUpper()) || reg.Organization.OrganizationDescription.ToUpper().Contains(filter.ToUpper()) || reg.Email.ToUpper().Contains(filter.ToUpper()) || reg.TaxCode.ToString().Contains(filter) ) );
            else
                _filteredCustomers = _customersTable.FindAll(reg => (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive));

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredCustomers;
            //setupDataGridView();
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

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            refreshTable();
            //setupDataGridView();
            applyFilter();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                _selectedCustomer = (Customer)dataGridView.CurrentRow.DataBoundItem;
                //Functions.loadImage(pictureBox, _selectedCustomer.ImageUrl);
                loadProfile(_selectedCustomer.CustomerId, _selectedCustomer.ToString(), _selectedCustomer.Organization.OrganizationDescription, _selectedCustomer.Phone.ToString(), _selectedCustomer.Email.ToString(), _selectedCustomer.Adress.ToString());
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CustomerRegisterForm registerForm = new CustomerRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CustomerRegisterForm registerForm = new CustomerRegisterForm(_selectedCustomer);
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
                    _customersManager.delete(_selectedCustomer);
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
