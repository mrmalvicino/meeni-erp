using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Utilities;

namespace WindowsForms
{
    public partial class ProductsForm : Form
    {
        // ATTRIBUTES

        private Product _product;
        private ProductsManager _productsManager = new ProductsManager();
        private List<Product> _productsTable;
        private List<Product> _filteredProducts;

        // CONSTRUCT

        public ProductsForm()
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
            modelTextBox.ForeColor = Palette.ForeColor;
            brandTextBox.ForeColor = Palette.ForeColor;
            categoryTextBox.ForeColor = Palette.ForeColor;
            idTextBox.BackColor = Palette.LightBackColor;
            modelTextBox.BackColor = Palette.LightBackColor;
            brandTextBox.BackColor = Palette.LightBackColor;
            categoryTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["ItemId"].Visible = false;
                dataGridView.Columns["ProductId"].Visible = false;
                dataGridView.Columns["ActiveStatus"].Visible = false;
                dataGridView.Columns["image"].Visible = false;
                dataGridView.Columns["Category"].DisplayIndex = 0;
                dataGridView.Columns["Brand"].DisplayIndex = 1;
                dataGridView.Columns["Model"].DisplayIndex = 3;

                Functions.fillDataGrid(dataGridView);
            }
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
                loadProfile();
            }
        }

        private void refreshTable()
        {
            try
            {
                _productsTable = _productsManager.list();
                dataGridView.DataSource = _productsTable;
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
                _filteredProducts = _productsTable.FindAll(reg =>
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
                _filteredProducts = _productsTable.FindAll(reg =>
                    (reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)
                );
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredProducts;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Product product = null)
        {
            if (product != null)
            {
                idTextBox.Text = "Producto N⁰ " + product.ProductId.ToString();
                modelTextBox.Text = product.Model.ToString();
                brandTextBox.Text = product.Brand.ToString();
                categoryTextBox.Text = product.Category.ToString();
            }
            else
            {
                idTextBox.Text = "No hay productos disponibles";
                modelTextBox.Text = "";
                brandTextBox.Text = "";
                categoryTextBox.Text = "";
            }
        }

        // EVENTS

        private void ProductsForm_Load(object sender, EventArgs e)
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
                _product = (Product)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_product);
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ProductRegisterForm registerForm = new ProductRegisterForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ProductRegisterForm registerForm = new ProductRegisterForm(_product);
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
                    _productsManager.delete(_product);
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
