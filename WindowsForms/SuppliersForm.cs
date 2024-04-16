using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class SuppliersForm : Form
    {
        // ATTRIBUTES

        private Supplier _supplier;
        private SuppliersManager _suppliersManager = new SuppliersManager();
        private List<Supplier> _suppliersTable;
        private List<Supplier> _filteredSuppliers;

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
                dataGridView.Columns["IndividualId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["BusinessPartnerId"].Visible = false;
                dataGridView.Columns["SupplierId"].Visible = false;
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

                dataGridView.Columns["Person"].DisplayIndex = 0;
                dataGridView.Columns["Organization"].DisplayIndex = 1;
                dataGridView.Columns["TaxCode"].DisplayIndex = 2;
                dataGridView.Columns["Adress"].DisplayIndex = 3;
                dataGridView.Columns["Phone"].DisplayIndex = 4;
                dataGridView.Columns["Email"].DisplayIndex = 5;
                dataGridView.Columns["Birth"].DisplayIndex = 6;
                dataGridView.Columns["PaymentMethod"].DisplayIndex = dataGridView.ColumnCount - 1;
                dataGridView.Columns["InvoiceCategory"].DisplayIndex = dataGridView.ColumnCount - 1;

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
                Functions.loadImage(pictureBox, "");
            }
        }

        private void refreshTable()
        {
            try
            {
                _suppliersTable = _suppliersManager.list();
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
            {
                _filteredSuppliers = _suppliersTable.FindAll(reg =>
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
                _filteredSuppliers = _suppliersTable.FindAll(reg =>
                    (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                );
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredSuppliers;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Supplier supplier = null)
        {
            if (supplier != null)
            {
                idTextBox.Text = "Proveedor N⁰ " + supplier.SupplierId.ToString();
                nameTextBox.Text = supplier.ToString();

                if (Validations.hasData(supplier.Organization.Description))
                {
                    descriptionTextBox.Text = supplier.Organization.Description;
                }
                else
                {
                    descriptionTextBox.Text = "";
                }

                if (supplier.Phone != null)
                {
                    phoneTextBox.Text = supplier.Phone.ToString();
                }
                else
                {
                    phoneTextBox.Text = "";
                }

                if (Validations.hasData(supplier.Email))
                {
                    emailTextBox.Text = supplier.Email;
                }
                else
                {
                    emailTextBox.Text = "";
                }

                if (supplier.Adress != null)
                {
                    adressTextBox.Text = supplier.Adress.ToString();
                }
                else
                {
                    adressTextBox.Text = "";
                }
            }
            else
            {
                idTextBox.Text = "No hay proveedores disponibles";
                nameTextBox.Text = "";
                descriptionTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
                adressTextBox.Text = "";
            }
        }

        // EVENTS

        private void SuppliersForm_Load(object sender, EventArgs e)
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
                _supplier = (Supplier)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_supplier);
                Functions.loadImage(pictureBox, _supplier.Image.Url);
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
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
            SupplierRegisterForm registerForm = new SupplierRegisterForm(_supplier);
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
                    _suppliersManager.delete(_supplier);
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

        private void clearButton_Click(object sender, EventArgs e)
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
