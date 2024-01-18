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

        private List<Customer> customersList;

        // CONSTRUCT

        public CustomersForm()
        {
            InitializeComponent();
        }

        //METHODS

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

            CustomersManager customersManager = new CustomersManager();
            customersList = customersManager.list();
            dataGridView.DataSource = customersList;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)dataGridView.CurrentRow.DataBoundItem;
            loadImage(customer.ImageUrl);
        }
    }
}
