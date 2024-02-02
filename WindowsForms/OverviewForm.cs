using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class OverviewForm : Form
    {
        // ATTRIBUTES

        FormsManager _formsManager = null;

        // CONSTRUCT

        public OverviewForm()
        {
            InitializeComponent();
            _formsManager = new FormsManager(this.MdiParent);
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            userPanel.BackColor = Palette.LightBackColor;
            metricsPanel.BackColor = Palette.LightBackColor;
            modulesPanel.BackColor = Palette.LightBackColor;
        }

        // EVENTS

        private void OverviewForm_Load(object sender, EventArgs e)
        {
            setupStyle();
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<QuoteForm>();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CustomersForm>();
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<SuppliersForm>();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<EmployeesForm>();
        }

        private void warehousesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<WarehousesForm>();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ProductsForm>();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ServicesForm>();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<TransactionsForm>();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadDialogForm<SettingsForm>();
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadDialogForm<NewSessionForm>();
        }
    }
}
