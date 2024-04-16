using System;
using System.Windows.Forms;
using Utilities;

namespace WindowsForms
{
    public partial class OverviewForm : Form
    {
        // ATTRIBUTES

        private FormsManager _formsManager = new FormsManager();

        // CONSTRUCT

        public OverviewForm()
        {
            InitializeComponent();
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

        private void quotesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<QuotesForm>(this.MdiParent);
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CustomersForm>(this.MdiParent);
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<SuppliersForm>(this.MdiParent);
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<EmployeesForm>(this.MdiParent);
        }

        private void warehousesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<WarehousesForm>(this.MdiParent);
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ProductsForm>(this.MdiParent);
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ServicesForm>(this.MdiParent);
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<TransactionsForm>(this.MdiParent);
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
