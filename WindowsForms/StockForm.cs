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

        private int _warehouseIdFilter;
        private int _stockIdFilter;
        private Stock _stock;
        private StockManager _stockManager = new StockManager();
        private List<Stock> _stockList;

        // CONSTRUCT

        public StockForm()
        {
            InitializeComponent();
        }

        public StockForm(int warehouseIdFilter = 0, int stockIdFilter = 0)
        {
            if (warehouseIdFilter != 0)
            {
                _warehouseIdFilter = warehouseIdFilter;
            }

            if (stockIdFilter != 0)
            {
                _stockIdFilter = stockIdFilter;
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
            productIdTextBox.ForeColor = Palette.ForeColor;
            productNameTextBox.ForeColor = Palette.ForeColor;
            warehouseIdTextBox.ForeColor = Palette.ForeColor;
            warehouseNameTextBox.ForeColor = Palette.ForeColor;
            productIdTextBox.BackColor = Palette.LightBackColor;
            productNameTextBox.BackColor = Palette.LightBackColor;
            warehouseIdTextBox.BackColor = Palette.LightBackColor;
            warehouseNameTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["Product"].Width = 500;
                dataGridView.Columns["Warehouse"].DisplayIndex = 0;
                dataGridView.Columns["Product"].DisplayIndex = 1;
                dataGridView.Columns["Amount"].DisplayIndex = 2;

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
                _stockList = _stockManager.list();
                dataGridView.DataSource = _stockList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            validateDataGridView();
        }

        private void loadProfile(Stock stock = null)
        {
            if (_stock != null)
            {
                productIdTextBox.Text = "Producto N⁰ " + stock.Product.ProductId.ToString();
                productNameTextBox.Text = stock.Product.ToString();
                warehouseIdTextBox.Text = "Depósito N⁰ " + stock.Warehouse.WarehouseId.ToString();
                warehouseNameTextBox.Text = stock.Warehouse.ToString();
            }
            else
            {
                productIdTextBox.Text = "No hay productos disponibles";
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
                _stock = (Stock)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_stock);
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
