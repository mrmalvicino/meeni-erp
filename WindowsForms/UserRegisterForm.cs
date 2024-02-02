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
    public partial class UserRegisterForm : Form
    {
        // ATTRIBUTES

        User _user = null;
        Employee _employee = null;
        UsersManager _usersManager = new UsersManager();
        RolesManager _rolesManager = new RolesManager();

        //CONSTRUCT

        public UserRegisterForm()
        {
            InitializeComponent();
        }

        public UserRegisterForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public UserRegisterForm(Employee selectedEmployee)
        {
            InitializeComponent();
            _employee = selectedEmployee;
        }

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            mainPanel.BackColor = Palette.LightBackColor;
        }

        private bool validateRegister()
        {
            if (repeatTextBox.Text != userPasswordTextBox.Text)
            {
                return false;
            }

            return true;
        }

        // EVENTS

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {
            setupStyle();

            try
            {
                roleNameComboBox.DataSource = _rolesManager.list();
                roleNameComboBox.ValueMember = "Id";
                roleNameComboBox.DisplayMember = "Name";

                if (_user == null) // Se está agregando un registro
                {
                    _user = new User();
                    roleNameComboBox.SelectedIndex = -1;
                    userNameTextBox.Text = _employee.LastName + _employee.EmployeeId;
                }
                else // Se está editando un registro
                {
                    userNameTextBox.Text = _user.UserName;
                    userPasswordTextBox.Text = _user.UserPassword;
                    repeatTextBox.Text = userPasswordTextBox.Text;
                    roleNameComboBox.SelectedValue = _user.Role.Id;
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
                _user.UserName = userNameTextBox.Text;
                _user.UserPassword = userPasswordTextBox.Text;              
                _user.Role = (Role)roleNameComboBox.SelectedItem;

                if (0 < _user.UserId)
                    _usersManager.edit(_user); // Se está editando un registro
                else
                {
                    _usersManager.add(_user); // Se está agregando un registro
                    _employee.IsUser = true;
                }

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Esta acción no puede deshacerse. ¿Está seguro que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    _usersManager.delete(_selectedUser.UserId);
                    refreshTable();
                    applyFilter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
