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
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Overview overviewWin = new Overview();
            overviewWin.MdiParent = this;
            overviewWin.Show();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Overview)) return;
            }

            Overview overviewWin = new Overview();
            overviewWin.MdiParent = this;
            overviewWin.Show();
        }
    }
}
