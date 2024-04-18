using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class QuotesForm : Form
    {
        // ATTRIBUTES

        private Quote _quote;
        private QuotesManager _quotesManager = new QuotesManager();
        private List<Quote> _quotesTable;
        private List<Quote> _filteredQuotes;

        // CONSTRUCT

        public QuotesForm()
        {
            InitializeComponent();
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            actionsPanel.BackColor = Palette.LightBackColor;
            dataGridView.BackgroundColor = Palette.LightBackColor;
            quoteIdTextBox.ForeColor = Palette.ForeColor;
            customerTextBox.ForeColor = Palette.ForeColor;
            quoteIdTextBox.BackColor = Palette.LightBackColor;
            customerTextBox.BackColor = Palette.LightBackColor;
        }

        private void setupDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                dataGridView.Columns["QuoteId"].Visible = false;
                dataGridView.Columns["Customer"].DisplayIndex = 0;
                dataGridView.Columns["JobDate"].DisplayIndex = 1;
                dataGridView.Columns["VariantVersion"].DisplayIndex = 2;
                dataGridView.Columns["ActiveStatus"].DisplayIndex = 3;
                Functions.fillDataGrid(dataGridView);
            }
        }

        private void validateDataGridView()
        {
            if (0 < dataGridView.RowCount)
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                exportButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                exportButton.Enabled = false;
                loadProfile();
            }
        }

        private void refreshTable()
        {
            try
            {
                _quotesTable = _quotesManager.list();
                dataGridView.DataSource = _quotesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void applyFilter()
        {
            string filter = filterTextBox.Text;

            if (2 < filter.Length)
            {
                _filteredQuotes = _quotesTable.FindAll(reg =>
                        reg.JobDate.ToString().ToUpper().Contains(filter.ToUpper()) ||
                        reg.Customer.ToString().ToUpper().Contains(filter.ToUpper())
                );
            }
            else
            {
                _filteredQuotes = _quotesTable;
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = _filteredQuotes;
            validateDataGridView();
            dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
        }

        private void loadProfile(Quote quote = null)
        {
            if (quote != null)
            {
                quoteIdTextBox.Text = "Cotización N⁰ " + quote.QuoteId.ToString();
                customerTextBox.Text = "Cliente: " + quote.Customer.ToString();
            }
            else
            {
                quoteIdTextBox.Text = "No hay cotizaciones disponibles";
                customerTextBox.Text = "";
            }
        }

        // EVENTS

        private void QuotesForm_Load(object sender, EventArgs e)
        {
            dataGridView.SelectionChanged -= dataGridView_SelectionChanged;
            setupStyle();
            refreshTable();
            applyFilter();
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                _quote = (Quote)dataGridView.CurrentRow.DataBoundItem;
                loadProfile(_quote);
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            QuoteForm registerForm = new QuoteForm();
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            QuoteForm registerForm = new QuoteForm(_quote);
            registerForm.ShowDialog();
            refreshTable();
            applyFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Esta acción no puede deshacerse. ¿Está seguro que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    _quotesManager.delete(_quote);
                    refreshTable();
                    applyFilter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Functions.exportPDF();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Text = "";
            applyFilter();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            applyFilter();
        }
    }
}
