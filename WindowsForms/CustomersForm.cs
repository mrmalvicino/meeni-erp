using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;

namespace WindowsForms
{
    public partial class CustomersForm : Form
    {
        // ATTRIBUTES

        private Individual _individual;
        private List<Customer> _customersTable;
        private CustomersManager _customersManager = new CustomersManager();

        // CONSTRUCT

        public CustomersForm()
        {
            InitializeComponent();
        }

        // METHODS

        private void setupStyle()
        {
            filterComboBox.SelectedIndex = 0;
            this.BackColor = Palette.darkBackground();
            mainPanel.BackColor = Palette.lightBackground();
            actionsPanel.BackColor = Palette.lightBackground();
            dataGridView.BackgroundColor = Palette.lightBackground();
            idTextBox.ForeColor = Palette.font();
            nameTextBox.ForeColor = Palette.font();
            descriptionTextBox.ForeColor = Palette.font();
            phoneTextBox.ForeColor = Palette.font();
            emailTextBox.ForeColor = Palette.font();
            adressTextBox.ForeColor = Palette.font();
            idTextBox.BackColor = Palette.lightBackground();
            nameTextBox.BackColor = Palette.lightBackground();
            descriptionTextBox.BackColor = Palette.lightBackground();
            emailTextBox.BackColor = Palette.lightBackground();
            phoneTextBox.BackColor = Palette.lightBackground();
            adressTextBox.BackColor = Palette.lightBackground();
        }

        private void setupDataGridView()
        {
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["ActiveStatus"].Visible = false;
            dataGridView.Columns["ImageUrl"].Visible = false;
            dataGridView.Columns["SalesAmount"].DisplayIndex = dataGridView.ColumnCount - 1;
            dataGridView.Columns["PaymentMethod"].DisplayIndex = dataGridView.ColumnCount - 2;
            dataGridView.Columns["InvoiceCategory"].DisplayIndex = dataGridView.ColumnCount - 3;
            dataGridView.Columns["IsPerson"].Width = 50;
            dataGridView.Columns["InvoiceCategory"].Width = 50;
        }

        private void loadProfile(int id, string name, string description, string phone, string email, string adress)
        {
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            descriptionTextBox.Text = description;
            phoneTextBox.Text = phone;
            emailTextBox.Text = email;
            adressTextBox.Text = adress;
        }

        private void refreshTable()
        {
            try
            {
                _customersTable = _customersManager.list();
                dataGridView.DataSource = _customersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // EVENTS

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            refreshTable();
            setupDataGridView();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)dataGridView.CurrentRow.DataBoundItem;
            Functions.loadImage(pictureBox, customer.ImageUrl);
            loadProfile(customer.Id, customer.ToString(), customer.BusinessDescription, customer.Phone.ToString(), customer.Email.ToString(), customer.Adress.ToString());
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            refreshTable();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            _individual = (Individual)dataGridView.CurrentRow.DataBoundItem;
            RegisterForm registerForm = new RegisterForm(_individual);
            registerForm.ShowDialog();
            refreshTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void exportCSVButton_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Text = "";
            filterComboBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
