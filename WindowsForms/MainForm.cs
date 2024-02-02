using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BLL;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        // ATTRIBUTES

        FormsManager _formsManager = null;

        // CONSTRUCT

        public MainForm()
        {
            InitializeComponent();
            _formsManager = new FormsManager(this);
        }

        // EVENTS

        private void MainForm_Load(object sender, EventArgs e)
        {
            Palette.setDefaultSkin();
            _formsManager.loadParentForm<OverviewForm>();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadDialogForm<NewSessionForm>();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadDialogForm<SettingsForm>();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<OverviewForm>();
        }

        private void quoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<QuoteForm>();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CustomersForm>();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<SuppliersForm>();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<EmployeesForm>();
        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<WarehousesForm>();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ProductsForm>();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ServicesForm>();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<TransactionsForm>();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mrmalvicino/meeni-erp");
        }
    }
}
