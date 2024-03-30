using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using System;
using Utilities;

namespace WindowsForms
{
    public partial class StockForm : Form
    {
        // ATTRIBUTES

        private int _warehouseIdFilter;
        private int _stockIdFilter;

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
                dataGridView.Columns["WarehouseId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["Name"].DisplayIndex = 0;
                dataGridView.Columns["Adress"].DisplayIndex = 1;

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
                _warehousesTable = _warehousesManager.list();
                dataGridView.DataSource = _warehousesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void applyFilter()
        {
            string filter = warehouseFilterTextBox.Text;
            bool showActive = showActiveCheckBox.Checked;
            bool showInactive = showInactiveCheckBox.Checked;

            if (2 < filter.Length)
            {
                _filteredWarehouses = _warehousesTable.FindAll(reg =>
                    (
                        (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                    )
                    &&
                    (
                        reg.Name.ToUpper().Contains(filter.ToUpper()) ||
                        reg.Adress.ToString().ToUpper().Contains(filter.ToUpper())
                    )
                );
            }
            else
            {
                _filteredWarehouses = _warehousesTable.FindAll(reg =>
                    (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                );
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredWarehouses;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Warehouse warehouse = null)
        {
            if (warehouse != null)
            {
                idTextBox.Text = "Depósito N⁰ " + warehouse.WarehouseId.ToString();
                productIdTextBox.Text = warehouse.ToString();
                adressTextBox.Text = warehouse.Adress.ToString();
            }
            else
            {
                idTextBox.Text = "No hay depósitos disponibles";
                productIdTextBox.Text = "";
                adressTextBox.Text = "";
            }
        }

        // EVENTS

        private void StockForm_Load(object sender, EventArgs e)
        {

        }

        private void stockButton_Click(object sender, EventArgs e)
        {

        }
    }
}
