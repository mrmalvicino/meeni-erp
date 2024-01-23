﻿using System;
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

        private Customer _selectedCustomer;
        private List<Customer> _customersTable;
        private List<Customer> _filteredCustomers;
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

        private void applyFilter()
        {
            string filter = filterTextBox.Text;
            bool showActive = true;
            bool showInactive = false;

            if (filterComboBox.SelectedItem.ToString() == "Mostrar solo activos")
            {
                showActive = true;
                showInactive = false;
            }
            else if (filterComboBox.SelectedItem.ToString() == "Mostrar solo inactivos")
            {
                showActive = false;
                showInactive = true;
            }
            else if (filterComboBox.SelectedItem.ToString() == "Mostrar activos e inactivos")
            {
                showActive = true;
                showInactive = true;
            }

            if (2 < filter.Length)
                _filteredCustomers = _customersTable.FindAll(reg => ((reg.ActiveStatus && showActive) || (!reg.ActiveStatus && showInactive)) && (reg.FirstName.ToUpper().Contains(filter.ToUpper()) || reg.LastName.ToUpper().Contains(filter.ToUpper()) || reg.BusinessName.ToUpper().Contains(filter.ToUpper()) || reg.BusinessDescription.ToUpper().Contains(filter.ToUpper())));
            else
                _filteredCustomers = _customersTable;

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredCustomers;
            setupDataGridView();
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
            if (dataGridView.CurrentRow != null)
            {
                _selectedCustomer = (Customer)dataGridView.CurrentRow.DataBoundItem;
                Functions.loadImage(pictureBox, _selectedCustomer.ImageUrl);
                loadProfile(_selectedCustomer.Id, _selectedCustomer.ToString(), _selectedCustomer.BusinessDescription, _selectedCustomer.Phone.ToString(), _selectedCustomer.Email.ToString(), _selectedCustomer.Adress.ToString());
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            refreshTable();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_selectedCustomer);
            registerForm.ShowDialog();
            refreshTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Esta acción no puede deshacerse. ¿Está seguro que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (answer == DialogResult.Yes)
                {
                    _customersManager.delete(_selectedCustomer.Id);
                    refreshTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void filterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            applyFilter();
        }
    }
}
