﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using Utilities;

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
            _formsManager = new FormsManager();
        }

        // EVENTS

        private void MainForm_Load(object sender, EventArgs e)
        {
            Palette.setDefaultSkin();
            _formsManager.loadParentForm<OverviewForm>(this);
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
            _formsManager.loadParentForm<OverviewForm>(this);
        }

        private void quoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<QuoteForm>(this);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CustomersForm>(this);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<SuppliersForm>(this);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<EmployeesForm>(this);
        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<WarehousesForm>(this);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<StockForm>(this);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ProductsForm>(this);
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<ServicesForm>(this);
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<TransactionsForm>(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mrmalvicino/meeni-erp");
        }
    }
}
