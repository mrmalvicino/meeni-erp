using BLL;
using Entities;
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
    public partial class WarehouseRegisterForm : Form
    {
        // ATTRIBUTES

        Warehouse _warehouse = null;
        OpenFileDialog _file = null;
        WarehousesManager _warehousesManager = new WarehousesManager();

        //CONSTRUCT

        public WarehouseRegisterForm()
        {
            InitializeComponent();
        }

        public WarehouseRegisterForm(Warehouse warehouse)
        {
            InitializeComponent();
            _warehouse = warehouse;
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            adressPanel.BackColor = Palette.LightBackColor;
        }

        private bool validateRegister()
        {
            if (Validations.isNumber(adressStreetNumberTextBox.Text) == false)
            {
                MessageBox.Show("El número de calle solo admite caracteres numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // EVENTS

        private void WarehouseRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            if (_warehouse == null) // Se está agregando un registro
            {
                _warehouse = new Warehouse();
                activeStatusCheckBox.Enabled = false;
            }
            else // Se está editando un registro
            {
                activeStatusCheckBox.Checked = _warehouse.ActiveStatus;
                nameTextBox.Text = _warehouse.Name;

                adressCountryTextBox.Text = _warehouse.Adress.Country;
                adressProvinceTextBox.Text = _warehouse.Adress.Province;
                adressCityTextBox.Text = _warehouse.Adress.City;
                adressZipCodeTextBox.Text = _warehouse.Adress.ZipCode;
                adressStreetTextBox.Text = _warehouse.Adress.Street;
                adressStreetNumberTextBox.Text = _warehouse.Adress.StreetNumber.ToString();
                adressFlatTextBox.Text = _warehouse.Adress.Flat;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
                return;

            try
            {
                _warehouse.ActiveStatus = activeStatusCheckBox.Checked;
                _warehouse.Name = nameTextBox.Text;

                _warehouse.Adress.Country = adressCountryTextBox.Text;
                _warehouse.Adress.Province = adressProvinceTextBox.Text;
                _warehouse.Adress.City = adressCityTextBox.Text;
                _warehouse.Adress.ZipCode = adressZipCodeTextBox.Text;
                _warehouse.Adress.Street = adressStreetTextBox.Text;
                if (adressStreetNumberTextBox.Text != "") _warehouse.Adress.StreetNumber = int.Parse(adressStreetNumberTextBox.Text);
                _warehouse.Adress.Flat = adressFlatTextBox.Text;

                if (0 < _warehouse.Id)
                    _warehousesManager.edit(_warehouse); // Se está editando un registro
                else
                    _warehousesManager.add(_warehouse); // Se está agregando un registro

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void adressStreetNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isNumber(adressStreetNumberTextBox.Text))
                adressStreetNumberTextBox.ForeColor = Palette.DefaultBlack;
            else
                adressStreetNumberTextBox.ForeColor = Palette.ValidationColor;
        }
    }
}
