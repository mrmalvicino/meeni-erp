using Entities;
using BLL;
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
    public partial class CustomersForm : Form
    {
        // ATTRIBUTES

        private List<Customer> customersTable;

        // CONSTRUCT

        public CustomersForm()
        {
            InitializeComponent();
        }

        //METHODS

        private void applyStyle()
        {
            this.BackColor = Palette.darkBackground();
            dataPanel.BackColor = Palette.lightBackground();
            actionsPanel.BackColor = Palette.lightBackground();
            dataGridView.BackgroundColor = Palette.lightBackground();
            idTextBox.ForeColor = Palette.font();
            nameTextBox.ForeColor = Palette.font();
            descriptionTextBox.ForeColor = Palette.font();
            phoneTextBox.ForeColor = Palette.font();
            emailTextBox.ForeColor = Palette.font();
            adressTextBox.ForeColor = Palette.font();
        }

        private void loadImage(string imageUrl)
        {
            try
            {
                pictureBox.Load(imageUrl);
            }
            catch (Exception)
            {
                pictureBox.Load(".\\..\\..\\..\\images\\profile.png");
            }
        }

        //AUTO GENERATED

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            applyStyle();

            CustomersManager customersManager = new CustomersManager();
            customersTable = customersManager.list();
            dataGridView.DataSource = customersTable;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)dataGridView.CurrentRow.DataBoundItem;
            loadImage(customer.ImageUrl);
        }
    }
}
