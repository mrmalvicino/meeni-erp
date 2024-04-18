using System.Windows.Forms;
using Entities;
using System;
using Utilities;
using BLL;
using System.Configuration;
using System.Collections.Generic;

namespace WindowsForms
{
    public partial class CompartmentsForm : Form
    {
        // ATTRIBUTES

        private Warehouse _warehouse;
        private Compartment _compartment;
        private List<Compartment> _filteredCompartments;
        private CompartmentsManager _compartmentsManager = new CompartmentsManager();
        private WarehousesManager _warehousesManager = new WarehousesManager();

        // CONSTRUCT

        public CompartmentsForm()
        {
            InitializeComponent();
        }

        public CompartmentsForm(Warehouse warehouse = null)
        {
            if (warehouse != null)
            {
                _warehouse = warehouse;
            }

            InitializeComponent();
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            actionsPanel.BackColor = Palette.LightBackColor;
            dataGridView.BackgroundColor = Palette.LightBackColor;
            compartmentIdTextBox.ForeColor = Palette.ForeColor;
            compartmentNameTextBox.ForeColor = Palette.ForeColor;
            productIdTextBox.ForeColor = Palette.ForeColor;
            productNameTextBox.ForeColor = Palette.ForeColor;
            warehouseIdTextBox.ForeColor = Palette.ForeColor;
            warehouseNameTextBox.ForeColor = Palette.ForeColor;
            compartmentIdTextBox.BackColor = Palette.LightBackColor;
            compartmentNameTextBox.BackColor = Palette.LightBackColor;
            productIdTextBox.BackColor = Palette.LightBackColor;
            productNameTextBox.BackColor = Palette.LightBackColor;
            warehouseIdTextBox.BackColor = Palette.LightBackColor;
            warehouseNameTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["CompartmentId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["Name"].Width = 300;
                dataGridView.Columns["Stock"].Width = 150;
                dataGridView.Columns["Name"].DisplayIndex = 0;
                dataGridView.Columns["Product"].DisplayIndex = 1;
                dataGridView.Columns["Stock"].DisplayIndex = 2;

                Functions.fillDataGrid(dataGridView);
            }
        }

        private void validateDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                exportCSVButton.Enabled = true;
                moveButton.Enabled = true;
            }
            else
            {
                exportCSVButton.Enabled = false;
                moveButton.Enabled = false;
                loadProfile();
            }
        }

        private void refreshTable()
        {
            try
            {
                _warehouse.Compartments = _compartmentsManager.list(_warehouse.WarehouseId);
                dataGridView.DataSource = _warehouse.Compartments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            validateDataGridView();
        }

        private void applyFilter()
        {
            string filter = filterTextBox.Text;
            bool showActive = showActiveCheckBox.Checked;
            bool showInactive = showInactiveCheckBox.Checked;

            if (2 < filter.Length)
            {
                _filteredCompartments = _warehouse.Compartments.FindAll(reg =>
                    (
                        (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                    )
                    &&
                    (
                        reg.Name.ToUpper().Contains(filter.ToUpper()) ||
                        reg.Product.ToString().ToUpper().Contains(filter.ToUpper())
                    )
                );
            }
            else
            {
                _filteredCompartments = _warehouse.Compartments.FindAll(reg =>
                    (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                );
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredCompartments;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Compartment compartment = null)
        {
            if (compartment != null)
            {
                compartmentIdTextBox.Text = "Compartimiento N⁰ " + compartment.CompartmentId.ToString();
                compartmentNameTextBox.Text = compartment.Name;
                productIdTextBox.Text = "Producto N⁰ " + compartment.Product.ProductId.ToString();
                productNameTextBox.Text = compartment.Product.ToString();
                warehouseIdTextBox.Text = "Depósito N⁰ " + _warehouse.WarehouseId.ToString();
                warehouseNameTextBox.Text = _warehouse.Name;
                amountNumericUpDown.Maximum = compartment.Stock;
            }
            else
            {
                compartmentIdTextBox.Text = "No hay compartimientos disponibles";
                compartmentNameTextBox.Text = "";
                productIdTextBox.Text = "";
                productNameTextBox.Text = "";
                warehouseIdTextBox.Text = "";
                warehouseNameTextBox.Text = "";
                amountNumericUpDown.Maximum = 0;
            }
        }

        private void bindComboBoxes()
        {
            warehouseComboBox.DataSource = _warehousesManager.list();
            warehouseComboBox.ValueMember = "WarehouseId";
            warehouseComboBox.DisplayMember = "Name";

            bindCompartmentComboBox();
            compartmentComboBox.ValueMember = "CompartmentId";
            compartmentComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            warehouseComboBox.SelectedIndex = -1;
            compartmentComboBox.SelectedIndex = -1;
        }

        private void bindCompartmentComboBox()
        {
            if (warehouseComboBox.SelectedItem != null)
            {
                Warehouse warehouse = (Warehouse)warehouseComboBox.SelectedItem;
                compartmentComboBox.DataSource = _compartmentsManager.list(warehouse.WarehouseId);
                compartmentComboBox.Enabled = true;
            }
            else
            {
                compartmentComboBox.Enabled = false;
            }
        }

        // EVENTS

        private void StockForm_Load(object sender, EventArgs e)
        {
            dataGridView.SelectionChanged -= dataGridView_SelectionChanged;
            setupStyle();
            refreshTable();
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            applyFilter();
            bindComboBoxes();
            clearComboBoxes();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                _compartment = (Compartment)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_compartment);
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CompartmentRegisterForm registerForm = new CompartmentRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CompartmentRegisterForm registerForm = new CompartmentRegisterForm(_compartment, _warehouse);
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
                    _compartmentsManager.delete(_compartment);
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
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_folder"] + "Stock.csv");
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

        private void moveButton_Click(object sender, EventArgs e)
        {
            if (0 < amountNumericUpDown.Value && compartmentComboBox.SelectedItem != null)
            {
                Warehouse warehouse = (Warehouse)warehouseComboBox.SelectedItem;
                Compartment compartment = (Compartment)compartmentComboBox.SelectedItem;

                if (_compartment.Product.ProductId == compartment.Product.ProductId)
                {
                    _compartment.Stock -= (int)amountNumericUpDown.Value;
                    compartment.Stock += (int)amountNumericUpDown.Value;
                    _compartmentsManager.edit(_compartment, _warehouse.WarehouseId);
                    _compartmentsManager.edit(compartment, warehouse.WarehouseId);

                    refreshTable();
                    applyFilter();

                    MessageBox.Show("Movimiento registrado exitosamente.");
                }
                else
                {
                    Validations.error($"Los compartimientos solo pueden guardar productos de un mismo modelo.\n" +
                        $"\nOrigen:\n" +
                        $"Compartimiento: {_compartment.ToString()}\n" +
                        $"Depósito: {_warehouse.ToString()}\n" +
                        $"Producto: {_compartment.Product.ToString()}\n" +
                        $"\nDestino:\n" +
                        $"Compartimiento: {compartment.ToString()}\n" +
                        $"Depósito: {_warehouse.ToString()}\n" +
                        $"Producto: {compartment.Product.ToString()}");
                }
            }
        }

        private void warehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindCompartmentComboBox();
        }

        private void warehouseComboBox_TextChanged(object sender, EventArgs e)
        {
            bindCompartmentComboBox();
        }
    }
}
