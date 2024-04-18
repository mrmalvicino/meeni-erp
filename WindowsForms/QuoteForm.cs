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

        private Quote _quote = null;
        private QuoteRow _quoteRow = new QuoteRow();
        private Product _product = null;
        private Service _service = null;
        private QuotesManager _quotesManager = new QuotesManager();
        private CustomersManager _customersManager = new CustomersManager();
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
            productCategoryTextBox.ForeColor = Palette.ForeColor;
            brandTextBox.ForeColor = Palette.ForeColor;
            modelTextBox.ForeColor = Palette.ForeColor;
            productAmountTextBox.ForeColor = Palette.ForeColor;
            serviceCategoryTextBox.ForeColor = Palette.ForeColor;
            detailsTextBox.ForeColor = Palette.ForeColor;
            serviceAmountTextBox.ForeColor = Palette.ForeColor;
            descriptionLabelTextBox.ForeColor = Palette.ForeColor;
            adjustmentLabelTextBox.ForeColor = Palette.ForeColor;

            quoteIdTextBox.BackColor = Palette.LightBackColor;
            customerTextBox.BackColor = Palette.LightBackColor;
            versionTextBox.BackColor = Palette.LightBackColor;
            statusTextBox.BackColor = Palette.LightBackColor;
            productCategoryTextBox.BackColor = Palette.LightBackColor;
            brandTextBox.BackColor = Palette.LightBackColor;
            modelTextBox.BackColor = Palette.LightBackColor;
            productAmountTextBox.BackColor = Palette.LightBackColor;
            serviceCategoryTextBox.BackColor = Palette.LightBackColor;
            detailsTextBox.BackColor = Palette.LightBackColor;
            serviceAmountTextBox.BackColor = Palette.LightBackColor;
            descriptionLabelTextBox.BackColor = Palette.LightBackColor;
            adjustmentLabelTextBox.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            customerComboBox.DataSource = _customersManager.list();

            productCategoryComboBox.DataSource = _categoriesManager.list(true, false);
            productCategoryComboBox.ValueMember = "CategoryId";
            productCategoryComboBox.DisplayMember = "Name";

            bindBrandComboBox();
            brandComboBox.ValueMember = "BrandId";
            brandComboBox.DisplayMember = "Name";

            bindModelComboBox();
            modelComboBox.ValueMember = "ModelId";
            modelComboBox.DisplayMember = "Name";

            serviceCategoryComboBox.DataSource = _categoriesManager.list(false, true);
            serviceCategoryComboBox.ValueMember = "CategoryId";
            serviceCategoryComboBox.DisplayMember = "Name";

            bindDetailsComboBox();
            detailsComboBox.ValueMember = "ServiceId";
            detailsComboBox.DisplayMember = "Details";
        }

        private void clearComboBoxes()
        {
            customerComboBox.SelectedIndex = -1;
            productCategoryComboBox.SelectedIndex = -1;
            brandComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            serviceCategoryComboBox.SelectedIndex = -1;
            detailsComboBox.SelectedIndex = -1;
        }

        private void bindBrandComboBox()
        {
            if (productCategoryComboBox.SelectedItem != null)
            {
                Category category = (Category)productCategoryComboBox.SelectedItem;
                brandComboBox.DataSource = _brandsManager.list(category.CategoryId);
                brandComboBox.Enabled = true;
            }
            else
            {
                brandComboBox.SelectedIndex = -1;
                brandComboBox.Enabled = false;
                modelComboBox.SelectedIndex = -1;
                modelComboBox.Enabled = false;
            }
        }

        private void bindModelComboBox()
        {
            if (brandComboBox.SelectedItem != null)
            {
                Brand brand = (Brand)brandComboBox.SelectedItem;
                modelComboBox.DataSource = _modelsManager.list(brand.BrandId);
                modelComboBox.Enabled = true;
            }
            else
            {
                modelComboBox.SelectedIndex = -1;
                modelComboBox.Enabled = false;
            }
        }

        private void bindDetailsComboBox()
        {
            if (serviceCategoryComboBox.SelectedItem != null)
            {
                Category category = (Category)serviceCategoryComboBox.SelectedItem;
                detailsComboBox.DataSource = _servicesManager.list(category.CategoryId);
                detailsComboBox.Enabled = true;
            }
            else
            {
                detailsComboBox.SelectedIndex = -1;
                detailsComboBox.Enabled = false;
            }
        }

        private void setProduct()
        {
            if (modelComboBox.SelectedItem != null)
            {
                _product = new Product();
                _product.Model = (Model)modelComboBox.SelectedItem;
                _product.ProductId = _productsManager.getId(_product);
                _product = _productsManager.read(_product.ProductId);
            }
            else
            {
                _product = null;
            }
        }

        private void setService()
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
                    _quote.QuoteRows = _quotesManager.read(_quote);
                    listBox.Items.Clear();
                    listBox.Items.AddRange(_quote.QuoteRows.ToArray());
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
            if (0 < listBox.SelectedIndex)
            {
                int index = listBox.SelectedIndex;
                object row = listBox.SelectedItem;

                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index - 1, row);
                listBox.SelectedIndex = index - 1;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < listBox.Items.Count - 1 && listBox.SelectedIndex != -1)
            {
                int index = listBox.SelectedIndex;
                object row = listBox.SelectedItem;

                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index + 1, row);
                listBox.SelectedIndex = index + 1;
            }
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
                _quoteRow.Description = _product.ToString();
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

        private void addAdjustmentButton_Click(object sender, EventArgs e)
        {
            if (Validations.isNumber(adjustmentTextBox.Text))
            {
                _quoteRow.Amount = 1;
                _quoteRow.Description = descriptionTextBox.Text;
                _quoteRow.Price = Convert.ToDecimal(adjustmentTextBox.Text);
                _quoteRow.Product = null;
                _quoteRow.Service = null;

                listBox.Items.Add(_quoteRow);
            }
        }

        private void productCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBrandComboBox();
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindModelComboBox();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProduct();
        }

        private void serviceCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindDetailsComboBox();
        }

        private void detailsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setService();
        }

        private void productCategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            bindBrandComboBox();
        }

        private void brandComboBox_TextChanged(object sender, EventArgs e)
        {
            bindModelComboBox();
        }

        private void modelComboBox_TextChanged(object sender, EventArgs e)
        {
            setProduct();
        }

        private void serviceCategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            bindDetailsComboBox();
        }

        private void detailsComboBox_TextChanged(object sender, EventArgs e)
        {
            setService();
        }
    }
}
