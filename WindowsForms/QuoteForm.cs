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

        private Customer _customer;
        private CustomersManager _customersManager = new CustomersManager();
        private List<Customer> _customersTable;
        private WarehousesManager _warehousesManager = new WarehousesManager();
        private List<Warehouse> _warehousesTable;

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

        private void loadProfile(Quote quote = null)
        {
            if (quote != null)
            {
                quoteIdTextBox.Text = "Cotización N⁰ " + quote.QuoteId.ToString();
                dateTimePicker.Value = quote.Date;
                customerTextBox.Text = quote.Customer.ToString();
                versionTextBox.Text = quote.Version.ToString();
                statusTextBox.Text = quote.Status;
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

        // EVENTS

        private void QuoteForm_Load(object sender, EventArgs e)
        {
            setupStyle();
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

        }

        private void eraseAllButton_Click(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {

        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
