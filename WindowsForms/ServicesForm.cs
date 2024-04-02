using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class ServicesForm : Form
    {
        // ATTRIBUTES

        private Service _service;
        private ServicesManager _servicesManager = new ServicesManager();
        private List<Service> _servicesTable;
        private List<Service> _filteredServices;

        // CONSTRUCT

        public ServicesForm()
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
            categoryTextBox.ForeColor = Palette.ForeColor;
            idTextBox.BackColor = Palette.LightBackColor;
            categoryTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["ItemId"].Visible = false;
                dataGridView.Columns["ServiceId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["Category"].DisplayIndex = 0;
                dataGridView.Columns["Description"].DisplayIndex = 1;

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
            }
        }

        private void refreshTable()
        {
            try
            {
                _servicesTable = _servicesManager.list();
                dataGridView.DataSource = _servicesTable;
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
                _filteredServices = _servicesTable.FindAll(reg =>
                    (
                        (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                    )
                    &&
                    (
                        reg.ToString().ToUpper().Contains(filter.ToUpper())
                    )
                );
            }
            else
            {
                _filteredServices = _servicesTable.FindAll(reg =>
                    (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                );
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredServices;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Service service = null)
        {
            if (service != null)
            {
                idTextBox.Text = "Servicio N⁰ " + service.ServiceId.ToString();
                categoryTextBox.Text = service.Category.ToString();
            }
            else
            {
                idTextBox.Text = "No hay servicios disponibles";
                categoryTextBox.Text = "";
            }
        }

        // EVENTS

        private void ServicesForm_Load(object sender, EventArgs e)
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
                _service = (Service)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_service);
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ServiceRegisterForm registerForm = new ServiceRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ServiceRegisterForm registerForm = new ServiceRegisterForm(_service);
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
                    _servicesManager.delete(_service);
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
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_folder"] + "Warehouses.csv");
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
