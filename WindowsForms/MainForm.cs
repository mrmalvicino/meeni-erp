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
    public partial class MainForm : Form
    {
        // CONSTRUCT

        public MainForm()
        {
            InitializeComponent();
            loadOverviewForm();
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
                    setFileToOverview();
                    return;
                };
            }

            OverviewForm overviewWin = new OverviewForm(this);
            overviewWin.MdiParent = this;
            overviewWin.Show();
            setFileToOverview();
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
                    setFileToQuote();
                    return;
                };
            }

            QuoteForm quoteForm = new QuoteForm();
            quoteForm.MdiParent = this;
            quoteForm.Show();
            setFileToQuote();
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
                    setFileToCustomers();
                    return;
                };
            }

            CustomersForm customersForm = new CustomersForm();
            customersForm.MdiParent = this;
            customersForm.Show();
            setFileToCustomers();
        }

        private void setFileToOverview()
        {
            newToolStripMenuItem.Text = "Nuevo";
            openToolStripMenuItem.Text = "Abrir";
            saveToolStripMenuItem.Text = "Guardar";
            newToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
        }

        private void setFileToQuote()
        {
            newToolStripMenuItem.Text = "Nueva cotización";
            openToolStripMenuItem.Text = "Abrir cotización";
            saveToolStripMenuItem.Text = "Guardar cotización";
            newToolStripMenuItem.Enabled = true;
            openToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void setFileToCustomers()
        {
            newToolStripMenuItem.Text = "Nuevo cliente";
            openToolStripMenuItem.Text = "Abrir";
            saveToolStripMenuItem.Text = "Guardar cliente";
            newToolStripMenuItem.Enabled = true;
            openToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = true;
        }

        // AUTO GENERATED

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
