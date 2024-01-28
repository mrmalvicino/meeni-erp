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
        // CONSTRUCT

        public MainForm()
        {
            InitializeComponent();
        }

        // METHODS

        public void loadNewSessionForm()
        {
            newSessionForm userForm = new newSessionForm();
            userForm.ShowDialog();
        }

        public void loadSettingsForm()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        public void loadOverviewForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(OverviewForm))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.BringToFront();
                    return;
                };
            }

            OverviewForm overviewWin = new OverviewForm(this);
            overviewWin.MdiParent = this;
            overviewWin.Show();
        }

        public void loadQuoteForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(QuoteForm))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.BringToFront();
                    return;
                };
            }

            QuoteForm quoteForm = new QuoteForm();
            quoteForm.MdiParent = this;
            quoteForm.Show();
        }

        public void loadCustomersForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CustomersForm))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.BringToFront();
                    return;
                };
            }

            CustomersForm customersForm = new CustomersForm();
            customersForm.MdiParent = this;
            customersForm.Show();
        }

        public void loadSuppliersForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SuppliersForm))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.BringToFront();
                    return;
                };
            }

            SuppliersForm suppliersForm = new SuppliersForm();
            suppliersForm.MdiParent = this;
            suppliersForm.Show();
        }

        public void loadTransactionsForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TransactionsForm))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.BringToFront();
                    return;
                };
            }

            TransactionsForm transactionsForm = new TransactionsForm();
            transactionsForm.MdiParent = this;
            transactionsForm.Show();
        }

        // EVENTS

        private void MainForm_Load(object sender, EventArgs e)
        {
            Palette.setDefaultSkin();
            loadOverviewForm();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadNewSessionForm();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSettingsForm();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadOverviewForm();
        }

        private void quoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadQuoteForm();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCustomersForm();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSuppliersForm();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTransactionsForm();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mrmalvicino/meeni-erp");
        }
    }
}
