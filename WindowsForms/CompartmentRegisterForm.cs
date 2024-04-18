using System;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class CompartmentRegisterForm : Form
    {
        // ATTRIBUTES

        private Warehouse _warehouse;
        private Compartment _compartment;
        private CompartmentsManager _compartmentsManager = new CompartmentsManager();
        private ProductsManager _productsManager = new ProductsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();
        private WarehousesManager _warehousesManager = new WarehousesManager();

        //CONSTRUCT

        public CompartmentRegisterForm()
        {
            InitializeComponent();
        }

        public CompartmentRegisterForm(Compartment compartment, Warehouse warehouse)
        {
            InitializeComponent();
            _compartment = compartment;
            _warehouse = warehouse;
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
            productPanel.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            warehouseComboBox.DataSource = _warehousesManager.list();
            warehouseComboBox.ValueMember = "WarehouseId";
            warehouseComboBox.DisplayMember = "Name";

            categoryComboBox.DataSource = _categoriesManager.list(true, false);
            categoryComboBox.ValueMember = "CategoryId";
            categoryComboBox.DisplayMember = "Name";

            bindBrandComboBox();
            brandComboBox.ValueMember = "BrandId";
            brandComboBox.DisplayMember = "Name";

            bindModelComboBox();
            modelComboBox.ValueMember = "ModelId";
            modelComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            warehouseComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;
            brandComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
        }

        private void bindBrandComboBox()
        {
            if (categoryComboBox.SelectedItem != null)
            {
                Category category = (Category)categoryComboBox.SelectedItem;
                brandComboBox.DataSource = _brandsManager.list(category.CategoryId);
                brandComboBox.Enabled = true;
            }
            else
            {
                brandComboBox.Enabled = false;
            }
        }

        private void bindModelComboBox()
        {
            if (brandComboBox.SelectedItem != null)
            {
                Brand brand = (Brand)brandComboBox.SelectedItem;
                modelComboBox.DataSource = _modelsManager.list(brand.BrandId);
                modelComboBox.Enabled = true;
            }
            else
            {
                modelComboBox.Enabled = false;
            }
        }

        private void mapCompartment()
        {
            activeStatusCheckBox.Checked = _compartment.ActiveStatus;
            nameTextBox.Text = _compartment.Name;
            warehouseComboBox.SelectedValue = _warehouse.WarehouseId;
            categoryComboBox.SelectedValue = _compartment.Product.Category.CategoryId;
            brandComboBox.SelectedValue = _compartment.Product.Brand.BrandId;
            modelComboBox.SelectedValue = _compartment.Product.Model.ModelId;
            stockNumericUpDown.Value = _compartment.Stock;
        }

        private void setCompartment()
        {
            _compartment.ActiveStatus = activeStatusCheckBox.Checked;
            _compartment.Name = nameTextBox.Text;
            _warehouse = (Warehouse)warehouseComboBox.SelectedItem;
            _compartment.Product.Category = (Category)categoryComboBox.SelectedItem;
            _compartment.Product.Brand = (Brand)brandComboBox.SelectedItem;
            _compartment.Product.Model = (Model)modelComboBox.SelectedItem;
            _compartment.Stock = (int)stockNumericUpDown.Value;
        }

        // EVENTS

        private void CompartmentRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            bindComboBoxes();

            try
            {
                if (_compartment == null)
                {
                    _compartment = new Compartment();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else
                {
                    mapCompartment();
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
                setCompartment();

                if (0 < _compartment.CompartmentId)
                {
                    _compartmentsManager.edit(_compartment, _warehouse.WarehouseId);
                }
                else
                {
                    _compartmentsManager.add(_compartment, _warehouse.WarehouseId);
                }

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBrandComboBox();
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindModelComboBox();
        }
    }
}
