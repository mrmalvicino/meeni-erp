using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BLL;
using Entities;

namespace WindowsForms
{
    public partial class SuppliersForm : Form
    {
        // ATTRIBUTES

        private Supplier _selectedSupplier;
        private List<Supplier> _suppliersTable;
        private List<Supplier> _filteredSuppliers;
        private SuppliersManager _suppliersManager = new SuppliersManager();

        // CONSTRUCT

        public SuppliersForm()
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
                dataGridView.Columns["IsPerson"].Width = 50;
                dataGridView.Columns["FirstName"].Width = 80;
                dataGridView.Columns["LastName"].Width = 80;
                dataGridView.Columns["BusinessDescription"].Width = 120;
                dataGridView.Columns["ImageUrl"].Visible = false;
                dataGridView.Columns["Email"].Width = 150;
                dataGridView.Columns["Phone"].Width = 120;
                dataGridView.Columns["Adress"].Width = 150;
                dataGridView.Columns["TaxCode"].Width = 80;
                dataGridView.Columns["PaymentMethod"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["PaymentMethod"].Width = 50;
                dataGridView.Columns["InvoiceCategory"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["InvoiceCategory"].Width = 50;
                dataGridView.Columns["IsIndispensable"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["IsIndispensable"].Width = 80;
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
                //_suppliersTable = _suppliersManager.list();
                dataGridView.DataSource = _suppliersTable;
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
                _filteredSuppliers = _suppliersTable.FindAll(reg => ((reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)) && (reg.Person.FirstName.ToUpper().Contains(filter.ToUpper()) || reg.Person.LastName.ToUpper().Contains(filter.ToUpper()) || reg.Organization.Name.ToUpper().Contains(filter.ToUpper()) || reg.Organization.Description.ToUpper().Contains(filter.ToUpper()) || reg.Email.ToUpper().Contains(filter.ToUpper()) || reg.TaxCode.ToString().Contains(filter)));
            else
                _filteredSuppliers = _suppliersTable.FindAll(reg => (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive));

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredSuppliers;
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

        private void SuppliersForm_Load(object sender, EventArgs e)
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
                _selectedSupplier = (Supplier)dataGridView.CurrentRow.DataBoundItem;
                //Functions.loadImage(pictureBox, _selectedSupplier.ImageUrl);
                //loadProfile(_selectedSupplier.SupplierId, _selectedSupplier.ToString(), _selectedSupplier.BusinessDescription, _selectedSupplier.Phone.ToString(), _selectedSupplier.Email.ToString(), _selectedSupplier.Adress.ToString());
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            SupplierRegisterForm registerForm = new SupplierRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SupplierRegisterForm registerForm = new SupplierRegisterForm(_selectedSupplier);
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
                    _suppliersManager.delete(_selectedSupplier);
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
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_path"] + "Proveedores.csv");
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Text = "";
            showActiveCheckBox.Checked = true;
            showInactiveCheckBox.Checked = false;
            applyFilter();
        }

        private void filterTextBox_TextChanged_1(object sender, EventArgs e)
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
