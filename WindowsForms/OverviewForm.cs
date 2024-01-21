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

        // EVENTS

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

        }

        private void employeesButton_Click(object sender, EventArgs e)
        {

        }

        private void warehousesButton_Click(object sender, EventArgs e)
        {

        }

        private void productsButton_Click(object sender, EventArgs e)
        {

        }

        private void servicesButton_Click(object sender, EventArgs e)
        {

        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadSettingsForm();
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            _mainForm.loadNewSessionForm();
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Palette.darkBackground();
            userPanel.BackColor = Palette.lightBackground();
            metricsPanel.BackColor = Palette.lightBackground();
            modulesPanel.BackColor = Palette.lightBackground();
        }
    }
}
