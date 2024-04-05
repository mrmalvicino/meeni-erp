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
        private List<QuoteRow> _quoteRowsList;
        private Product _product;
        private Service _service;
        private QuotesManager _quotesManager = new QuotesManager();
        private CustomersManager _customersManager = new CustomersManager();
        private WarehousesManager _warehousesManager = new WarehousesManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();
        private ProductsManager _productsManager = new ProductsManager();
        private ServicesManager _servicesManager = new ServicesManager();

        // CONSTRUCT

        public QuoteForm()
        {
            InitializeComponent();
        }

        public QuoteForm(Quote quote)
        {
            _quote = quote;
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
            detailsTextBox.ForeColor = Palette.ForeColor;
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
            detailsTextBox.BackColor = Palette.LightBackColor;
            serviceAmountTextBox.BackColor = Palette.LightBackColor;
            descriptionLabelTextBox.BackColor = Palette.LightBackColor;
            discountLabelTextBox.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            customerComboBox.DataSource = _customersManager.list();

            warehouseComboBox.DataSource = _warehousesManager.list();

            warehouseComboBox.ValueMember = "WarehouseId";
            warehouseComboBox.DisplayMember = "Name";

            productCategoryComboBox.DataSource = _categoriesManager.list(true, false);

            productCategoryComboBox.ValueMember = "CategoryId";
            productCategoryComboBox.DisplayMember = "Name";

            brandComboBox.ValueMember = "BrandId";
            brandComboBox.DisplayMember = "Name";

            modelComboBox.ValueMember = "ModelId";
            modelComboBox.DisplayMember = "Name";

            serviceCategoryComboBox.DataSource = _categoriesManager.list(false, true);

            serviceCategoryComboBox.ValueMember = "CategoryId";
            serviceCategoryComboBox.DisplayMember = "Name";

            detailsComboBox.ValueMember = "ServiceId";
            detailsComboBox.DisplayMember = "Details";
        }

        private void clearComboBoxes()
        {
            customerComboBox.SelectedIndex = -1;
            warehouseComboBox.SelectedIndex = -1;
            productCategoryComboBox.SelectedIndex = -1;
            brandComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            serviceCategoryComboBox.SelectedIndex = -1;
            detailsComboBox.SelectedIndex = -1;
        }

        private void mapQuote()
        {
            quoteIdTextBox.Text = "Cotización N⁰ " + _quote.QuoteId.ToString();
            jobDateTimePicker.Value = _quote.JobDate;
            customerComboBox.Text = _quote.Customer.ToString();
            variantVersionNumericUpDown.Value = _quote.VariantVersion;
            activeStatusComboBox.Text = _quote.ActiveStatus;
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
                clearComboBoxes();

                if (_quote == null)
                {
                    _quote = new Quote();
                    activeStatusComboBox.SelectedIndex = 1;
                    activeStatusComboBox.Enabled = false;
                }
                else
                {
                    mapQuote();
                    _quoteRowsList = _quotesManager.read(_quote);
                    listBox.Items.Clear();
                    listBox.Items.AddRange(_quoteRowsList.ToArray());
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

        private void cleanButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (0 < productAmountNumericUpDown.Value && _product != null)
            {
                _quoteRow.Amount = (int)productAmountNumericUpDown.Value;
                _quoteRow.Description = _product.Category + " " + _product.Brand + " " + _product.Model;
                _quoteRow.Price = _product.Price;
                _quoteRow.Product = _product;
                _quoteRow.Service = null;

                listBox.Items.Add(_quoteRow);
            }
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (0 < serviceAmountNumericUpDown.Value && _service != null)
            {
                _quoteRow.Amount = (int)serviceAmountNumericUpDown.Value;
                _quoteRow.Description = _service.Category + " " + _service.Details;
                _quoteRow.Price = _service.Price;
                _quoteRow.Product = null;
                _quoteRow.Service = _service;

                listBox.Items.Add(_quoteRow);
            }
        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {

        }

        private void productCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = _categoriesManager.getId((Category)productCategoryComboBox.SelectedItem);
            //brandComboBox.DataSource = _productsManager.list(categoryId);
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (brandComboBox.SelectedItem != null)
            {
                _product.Brand = (Brand)brandComboBox.SelectedItem;
            }*/
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (modelComboBox.SelectedItem != null)
            {
                _product.Model = (Model)modelComboBox.SelectedItem;
            }
            else
            {
                _product = null;
            }*/
        }

        private void serviceCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = _categoriesManager.getId((Category)serviceCategoryComboBox.SelectedItem);
            detailsComboBox.DataSource = _servicesManager.list(categoryId);
        }

        private void detailsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detailsComboBox.SelectedItem != null)
            {
                _service = (Service)detailsComboBox.SelectedItem;
            }
            else
            {
                _service = null;
            }
        }
    }
}
