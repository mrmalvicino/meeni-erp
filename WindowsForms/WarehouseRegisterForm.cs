using BLL;
using System;
using System.Windows.Forms;
using Entities;
using Utilities;

namespace WindowsForms
{
    public partial class WarehouseRegisterForm : Form
    {
        // ATTRIBUTES

        private Warehouse _warehouse = null;
        private WarehousesManager _warehousesManager = new WarehousesManager();
        private CountriesManager _countriesManager = new CountriesManager();
        private ProvincesManager _provincesManager = new ProvincesManager();
        private CitiesManager _citiesManager = new CitiesManager();

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

        private bool validateRegister()
        {
            // Name

            if (nameTextBox.Text == "")
            {
                Validations.error("Ingresar el nombre del depósito.");
                return false;
            }

            // Adress

            if (!Validations.isNumber(streetNumberTextBox.Text))
            {
                Validations.error("El número de calle solo admite caracteres numéricos.");
                return false;
            }

            return true;
        }

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
            adressPanel.BackColor = Palette.LightBackColor;
        }

        private void bindComboBoxes()
        {
            adressCountryComboBox.DataSource = _countriesManager.list();
            adressCountryComboBox.ValueMember = "CountryId";
            adressCountryComboBox.DisplayMember = "Name";

            adressProvinceComboBox.DataSource = _provincesManager.list();
            adressProvinceComboBox.ValueMember = "ProvinceId";
            adressProvinceComboBox.DisplayMember = "Name";

            adressCityComboBox.DataSource = _citiesManager.list();
            adressCityComboBox.ValueMember = "CityId";
            adressCityComboBox.DisplayMember = "Name";
        }

        private void clearComboBoxes()
        {
            adressCountryComboBox.SelectedIndex = -1;
            adressProvinceComboBox.SelectedIndex = -1;
            adressCityComboBox.SelectedIndex = -1;
        }

        private void mapWarehouse()
        {
            activeStatusCheckBox.Checked = _warehouse.ActiveStatus;
            nameTextBox.Text = _warehouse.Name;

            streetNameTextBox.Text = _warehouse.Adress.StreetName;
            streetNumberTextBox.Text = _warehouse.Adress.StreetNumber;
            flatTextBox.Text = _warehouse.Adress.Flat;
            detailsTextBox.Text = _warehouse.Adress.Details;
            adressCityComboBox.SelectedValue = _warehouse.Adress.City.CityId;
            zipCodeTextBox.Text = _warehouse.Adress.City.ZipCode;
            adressProvinceComboBox.SelectedValue = _warehouse.Adress.Province.ProvinceId;
            adressCountryComboBox.SelectedValue = _warehouse.Adress.Country.CountryId;
        }

        private void setWarehouse()
        {
            _warehouse.ActiveStatus = activeStatusCheckBox.Checked;
            _warehouse.Name = nameTextBox.Text;

            _warehouse.Adress.StreetName = streetNameTextBox.Text;
            _warehouse.Adress.StreetNumber = streetNumberTextBox.Text;
            _warehouse.Adress.Flat = flatTextBox.Text;
            _warehouse.Adress.Details = detailsTextBox.Text;
            _warehouse.Adress.City.Name = adressCityComboBox.Text;
            _warehouse.Adress.City.ZipCode = zipCodeTextBox.Text;
            _warehouse.Adress.Province.Name = adressProvinceComboBox.Text;
            _warehouse.Adress.Country.Name = adressCountryComboBox.Text;
        }

        // EVENTS

        private void WarehouseRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                bindComboBoxes();

                if (_warehouse == null)
                {
                    _warehouse = new Warehouse();
                    activeStatusCheckBox.Enabled = false;
                    clearComboBoxes();
                }
                else
                {
                    mapWarehouse();
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
                setWarehouse();

                if (0 < _warehouse.WarehouseId)
                {
                    _warehousesManager.edit(_warehouse);
                }
                else
                {
                    _warehousesManager.add(_warehouse);
                }

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
