﻿using System;
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

        private MainForm _mainForm;

        // CONSTRUCT

        public OverviewForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
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
            _mainForm.loadQuoteForm();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadCustomersForm();
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadSuppliersForm();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadEmployeesForm();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadUsersForm();
        }

        private void warehousesButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadWarehousesForm();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadProductsForm();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadServicesForm();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadTransactionsForm();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadSettingsForm();
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadNewSessionForm();
        }
    }
}
