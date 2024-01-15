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
        public OverviewForm()
        {
            InitializeComponent();
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(QuoteForm)) return;
            }

            QuoteForm quoteForm = new QuoteForm();
            quoteForm.MdiParent = this.MdiParent;
            quoteForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {

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
            SettingsForm settingsWin = new SettingsForm();
            settingsWin.ShowDialog();
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
