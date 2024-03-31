using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class QuoteForm : Form
    {
        // ATTRIBUTES

        private Quote _quote;
        private QuoteRow _quoteRow = new QuoteRow();
        private CustomersManager _customersManager = new CustomersManager();
        private WarehousesManager _warehousesManager = new WarehousesManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();

        // CONSTRUCT

        public QuoteForm()
        {
            InitializeComponent();
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            actionsPanel.BackColor = Palette.LightBackColor;
            addingPanel.BackColor = Palette.LightBackColor;

            quoteIdTextBox.ForeColor = Palette.ForeColor;
            customerTextBox.ForeColor = Palette.ForeColor;
            versionTextBox.ForeColor = Palette.ForeColor;
            statusTextBox.ForeColor = Palette.ForeColor;
            warehouseTextBox.ForeColor = Palette.ForeColor;
            productCategoryTextBox.ForeColor = Palette.ForeColor;
            brandTextBox.ForeColor = Palette.ForeColor;
            modelTextBox.ForeColor = Palette.ForeColor;
            productAmountTextBox.ForeColor = Palette.ForeColor;
            serviceCategoryTextBox.ForeColor = Palette.ForeColor;
            nameTextBox.ForeColor = Palette.ForeColor;
            serviceAmountTextBox.ForeColor = Palette.ForeColor;
            descriptionLabelTextBox.ForeColor = Palette.ForeColor;
            discountLabelTextBox.ForeColor = Palette.ForeColor;

            quoteIdTextBox.BackColor = Palette.LightBackColor;
            customerTextBox.BackColor = Palette.LightBackColor;
            versionTextBox.BackColor = Palette.LightBackColor;
            statusTextBox.BackColor = Palette.LightBackColor;
            warehouseTextBox.BackColor = Palette.LightBackColor;
            productCategoryTextBox.BackColor = Palette.LightBackColor;
            brandTextBox.BackColor = Palette.LightBackColor;
            modelTextBox.BackColor = Palette.LightBackColor;
            productAmountTextBox.BackColor = Palette.LightBackColor;
            serviceCategoryTextBox.BackColor = Palette.LightBackColor;
            nameTextBox.BackColor = Palette.LightBackColor;
            serviceAmountTextBox.BackColor = Palette.LightBackColor;
            descriptionLabelTextBox.BackColor = Palette.LightBackColor;
            discountLabelTextBox.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            customerComboBox.DataSource = _customersManager.list();
            //customerComboBox.ValueMember = "CustomerId";
            //customerComboBox.DisplayMember = "Name";

            warehouseComboBox.DataSource = _warehousesManager.list();
            //warehouseComboBox.ValueMember = "WarehouseId";
            //warehouseComboBox.DisplayMember = "Name";

            productCategoryComboBox.DataSource = _categoriesManager.list();
            //productCategoryComboBox.ValueMember = "CategoryId";
            //productCategoryComboBox.DisplayMember = "Name";

            brandComboBox.DataSource = _brandsManager.list();
            //brandComboBox.ValueMember = "BrandId";
            //brandComboBox.DisplayMember = "Name";

            modelComboBox.DataSource = _modelsManager.list();
            //modelComboBox.ValueMember = "ModelId";
            //modelComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            customerComboBox.SelectedIndex = -1;
            warehouseComboBox.SelectedIndex = -1;
            productCategoryComboBox.SelectedIndex = -1;
            brandComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
        }

        private void loadProfile(Quote quote = null)
        {
            if (quote != null)
            {
                quoteIdTextBox.Text = "Cotización N⁰ " + quote.QuoteId.ToString();
                dateTimePicker.Value = quote.JobDate;
                customerTextBox.Text = quote.Customer.ToString();
                versionTextBox.Text = quote.VariantVersion.ToString();
                statusTextBox.Text = quote.ActiveStatus;
            }
            else
            {
                quoteIdTextBox.Text = "No hay clientes disponibles";
                dateTimePicker.Value = DateTime.Today;
                customerTextBox.Text = "";
                versionTextBox.Text = "";
                statusTextBox.Text = "";
            }
        }

        private void mapQuote()
        {

        }

        private void setQuote()
        {

        }

        // EVENTS

        private void QuoteForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                bindComboBoxes();

                if (_quote == null)
                {
                    _quote = new Quote();
                    statusComboBox.SelectedIndex = 1;
                    statusComboBox.Enabled = false;
                    clearComboBoxes();
                }
                else
                {
                    mapQuote();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void upButton_Click(object sender, EventArgs e)
        {

        }

        private void downButton_Click(object sender, EventArgs e)
        {

        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            if (0 <= listBox.SelectedIndex)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void eraseAllButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            _quoteRow.Amount = (int)productAmountNumericUpDown.Value;

            listBox.Items.Add(_quoteRow);
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
