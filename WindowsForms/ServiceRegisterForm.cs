using System;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class ServiceRegisterForm : Form
    {
        // ATTRIBUTES

        private Service _service = null;
        private ServicesManager _servicesManager = new ServicesManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();

        //CONSTRUCT

        public ServiceRegisterForm()
        {
            InitializeComponent();
        }

        public ServiceRegisterForm(Service service)
        {
            InitializeComponent();
            _service = service;
        }

        // METHODS

        private bool validateRegister()
        {
            return true;
        }

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            imagePanel.BackColor = Palette.LightBackColor;
            valuesPanel.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            categoryComboBox.DataSource = _categoriesManager.list();
            categoryComboBox.ValueMember = "CategoryId";
            categoryComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            categoryComboBox.SelectedIndex = -1;
        }

        private void mapItem()
        {
            activeStatusCheckBox.Checked = _service.ActiveStatus;
            priceTextBox.Text = _service.Price.ToString();
            costTextBox.Text = _service.Cost.ToString();
            categoryComboBox.SelectedValue = _service.Category.CategoryId;
        }

        private void mapService()
        {
            mapItem();
            descriptionTextBox.Text = _service.Description;
        }

        private void setItem()
        {
            _service.ActiveStatus = activeStatusCheckBox.Checked;
            _service.Price = Decimal.Parse(priceTextBox.Text);
            _service.Cost = Decimal.Parse(costTextBox.Text);
            _service.Category.Name = categoryComboBox.Text;
        }

        private void setService()
        {
            setItem();
            _service.Description = descriptionTextBox.Text;
        }

        // EVENTS

        private void ServiceRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                bindComboBoxes();

                if (_service == null)
                {
                    _service = new Service();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else
                {
                    mapService();
                    Functions.loadImage(profilePictureBox, imageUrlTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
                return;

            try
            {
                setService();

                if (0 < _service.ServiceId)
                {
                    _servicesManager.edit(_service);
                }
                else
                {
                    _servicesManager.add(_service);
                }

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imageUrlTextBox_Leave(object sender, EventArgs e)
        {
            Functions.loadImage(profilePictureBox, imageUrlTextBox.Text);
        }
    }
}
