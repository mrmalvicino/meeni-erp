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
        public MainForm()
        {
            InitializeComponent();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(OverviewForm)) return;
            }

            OverviewForm overviewWin = new OverviewForm();
            overviewWin.MdiParent = this;
            overviewWin.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(OverviewForm)) return;
            }

            OverviewForm overviewWin = new OverviewForm();
            overviewWin.MdiParent = this;
            overviewWin.Show();
        }

        private void quoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(QuoteForm)) return;
            }

            QuoteForm quoteForm = new QuoteForm();
            quoteForm.MdiParent = this;
            quoteForm.Show();
        }
    }
}
