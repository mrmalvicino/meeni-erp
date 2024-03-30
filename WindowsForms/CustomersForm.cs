using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class CustomersForm : Form
    {
        // ATTRIBUTES

        private Customer _customer;
        private CustomersManager _customersManager = new CustomersManager();
        private List<Customer> _customersTable;
        private List<Customer> _filteredCustomers;

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
                dataGridView.Columns["BusinessPartnerId"].Visible = false;
                dataGridView.Columns["CustomerId"].Visible = false;
                dataGridView.Columns["Image"].Visible = false;

                dataGridView.Columns["Person"].Width = 80;
                dataGridView.Columns["Organization"].Width = 80;
                dataGridView.Columns["TaxCode"].Width = 70;
                dataGridView.Columns["Adress"].Width = 150;
                dataGridView.Columns["Phone"].Width = 100;
                dataGridView.Columns["Email"].Width = 150;
                dataGridView.Columns["Birth"].Width = 50;
                dataGridView.Columns["PaymentMethod"].Width = 50;
                dataGridView.Columns["InvoiceCategory"].Width = 50;
                dataGridView.Columns["SalesAmount"].Width = 50;

                dataGridView.Columns["Person"].DisplayIndex = 0;
                dataGridView.Columns["Organization"].DisplayIndex = 1;
                dataGridView.Columns["TaxCode"].DisplayIndex = 2;
                dataGridView.Columns["Adress"].DisplayIndex = 3;
                dataGridView.Columns["Phone"].DisplayIndex = 4;
                dataGridView.Columns["Email"].DisplayIndex = 5;
                dataGridView.Columns["Birth"].DisplayIndex = 6;
                dataGridView.Columns["PaymentMethod"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["InvoiceCategory"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["SalesAmount"].DisplayIndex = dataGridView.ColumnCount - 1;

                dataGridView.Columns["Birth"].DefaultCellStyle.Format = "dd/mm/yy";

                Functions.fillDataGrid(dataGridView);
            }
        }

        private void validateDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                exportButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                exportButton.Enabled = false;
                loadProfile();
                Functions.loadImage(profilePictureBox, "");
            }
        }

        private void refreshTable()
        {
            try
            {
                _customersTable = _customersManager.list();
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
            {
                _filteredCustomers = _customersTable.FindAll(reg =>
                    (
                        (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                    )
                    &&
                    (
                        reg.Person.ToString().ToUpper().Contains(filter.ToUpper()) || 
                        reg.Organization.ToString().ToUpper().Contains(filter.ToUpper()) || 
                        reg.Email.ToUpper().Contains(filter.ToUpper()) || 
                        reg.TaxCode.ToString().Contains(filter)
                    )
                );
            }
            else
            {
                _filteredCustomers = _customersTable.FindAll(reg =>
                    (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                );
            }                

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredCustomers;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Customer customer = null)
        {
            if (customer != null)
            {
                idTextBox.Text = "Cliente N⁰ " + customer.CustomerId.ToString();
                nameTextBox.Text = customer.ToString();

                if (Validations.hasData(customer.Organization.Description))
                {
                    descriptionTextBox.Text = customer.Organization.Description;
                }
                else
                {
                    descriptionTextBox.Text = "";
                }

                if (customer.Phone != null)
                {
                    phoneTextBox.Text = customer.Phone.ToString();
                }
                else
                {
                    phoneTextBox.Text = "";
                }

                if (Validations.hasData(customer.Email))
                {
                    emailTextBox.Text = customer.Email;
                }
                else
                {
                    emailTextBox.Text = "";
                }

                if (customer.Adress != null)
                {
                    adressTextBox.Text = customer.Adress.ToString();
                }
                else
                {
                    adressTextBox.Text = "";
                }
            }
            else
            {
                idTextBox.Text = "No hay clientes disponibles";
                nameTextBox.Text = "";
                descriptionTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
                adressTextBox.Text = "";
            }
        }

        // EVENTS

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            dataGridView.SelectionChanged -= dataGridView_SelectionChanged;
            setupStyle();
            refreshTable();
            applyFilter();
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {           
            if (dataGridView.CurrentRow != null)
            {
                _customer = (Customer)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_customer);
                Functions.loadImage(profilePictureBox, _customer.Image);
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
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
            CustomerRegisterForm registerForm = new CustomerRegisterForm(_customer);
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
                    _customersManager.delete(_customer);
                    refreshTable();
                    applyFilter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_folder"] + "Clientes.csv");
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
