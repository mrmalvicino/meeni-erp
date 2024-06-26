﻿using System;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class ProductRegisterForm : Form
    {
        // ATTRIBUTES

        private Product _product = null;
        private ProductsManager _productsManager = new ProductsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private BrandsManager _brandsManager = new BrandsManager();
        private ModelsManager _modelsManager = new ModelsManager();

        //CONSTRUCT

        public ProductRegisterForm()
        {
            InitializeComponent();
        }

        public ProductRegisterForm(Product product)
        {
            InitializeComponent();
            _product = product;
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
            categoryComboBox.DataSource = _categoriesManager.list(true, false);
            categoryComboBox.ValueMember = "CategoryId";
            categoryComboBox.DisplayMember = "Name";

            bindBrandComboBox();
            brandComboBox.ValueMember = "BrandId";
            brandComboBox.DisplayMember = "Name";

            bindModelComboBox();
            modelComboBox.DataSource = _modelsManager.list();
            modelComboBox.ValueMember = "ModelId";
            modelComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
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
                brandComboBox.SelectedIndex = -1;
                brandComboBox.Enabled = false;
                modelComboBox.SelectedIndex = -1;
                modelComboBox.Enabled = false;
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
                modelComboBox.SelectedIndex = -1;
                modelComboBox.Enabled = false;
            }
        }

        private void mapItem()
        {
            activeStatusCheckBox.Checked = _product.ActiveStatus;
            priceTextBox.Text = _product.Price.ToString();
            costTextBox.Text = _product.Cost.ToString();
            categoryComboBox.SelectedValue = _product.Category.CategoryId;
        }

        private void mapProduct()
        {
            mapItem();
            brandComboBox.SelectedValue = _product.Brand.BrandId;
            modelComboBox.SelectedValue= _product.Model.ModelId;
        }

        private void setItem()
        {
            _product.ActiveStatus = activeStatusCheckBox.Checked;
            _product.Price = Decimal.Parse(priceTextBox.Text);
            _product.Cost = Decimal.Parse(costTextBox.Text);
            _product.Category.Name = categoryComboBox.Text;
        }

        private void setProduct()
        {
            setItem();
            _product.Brand.Name = brandComboBox.Text;
            _product.Model.Name = modelComboBox.Text;
        }

        // EVENTS

        private void ProductRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();
            clearComboBoxes();

            try
            {
                bindComboBoxes();

                if (_product == null)
                {
                    _product = new Product();
                    activeStatusCheckBox.Enabled = false;
                }
                else
                {
                    mapProduct();
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
            {
                return;
            }

            try
            {
                setProduct();

                if (0 < _product.ProductId)
                {
                    _productsManager.edit(_product);
                }
                else
                {
                    _productsManager.add(_product);
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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBrandComboBox();
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindModelComboBox();
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            bindBrandComboBox();
        }

        private void brandComboBox_TextChanged(object sender, EventArgs e)
        {
            bindModelComboBox();
        }
    }
}
