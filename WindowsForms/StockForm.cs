using System.Collections.Generic;
using System.Windows.Forms;
using Entities;
using System;
using Utilities;
using BLL;
using System.Collections;
using System.Configuration;

namespace WindowsForms
{
    public partial class StockForm : Form
    {
        // ATTRIBUTES

        private Warehouse _warehouse;
        private Compartment _compartment;
        private CompartmentsManager _compartmentsManager = new CompartmentsManager();

        // CONSTRUCT

        public StockForm()
        {
            InitializeComponent();
        }

        public StockForm(Warehouse warehouse = null)
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
                stockButton.Enabled = true;
                moveButton.Enabled = true;
            }
            else
            {
                exportCSVButton.Enabled = false;
                stockButton.Enabled = false;
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
            }
            else
            {
                compartmentIdTextBox.Text = "No hay compartimientos disponibles";
                compartmentNameTextBox.Text = "";
                productIdTextBox.Text = "";
                productNameTextBox.Text = "";
                warehouseIdTextBox.Text = "";
                warehouseNameTextBox.Text = "";
            }
        }

        // EVENTS

        private void StockForm_Load(object sender, EventArgs e)
        {
            dataGridView.SelectionChanged -= dataGridView_SelectionChanged;
            setupStyle();
            refreshTable();
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
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

        private void exportCSVButton_Click(object sender, EventArgs e)
        {
            Functions.exportCSV(dataGridView, ConfigurationManager.AppSettings["csv_folder"] + "Stock.csv");
        }

        private void stockButton_Click(object sender, EventArgs e)
        {

        }

        private void moveButton_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
