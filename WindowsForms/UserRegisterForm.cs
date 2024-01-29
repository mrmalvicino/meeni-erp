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
        OpenFileDialog _file = null;
        UsersManager _usersManager = new UsersManager();

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

        // METHODS

        private void setupStyle()
        {
            this.BackColor = Palette.DarkBackColor;
            userPanel.BackColor = Palette.LightBackColor;
            rolePanel.BackColor = Palette.LightBackColor;
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

            if (_user == null) // Se está agregando un registro
            {
                _user = new User();
            }
            else // Se está editando un registro
            {
                userNameTextBox.Text = _user.UserName;
                userPasswordTextBox.Text = _user.UserPassword;
                repeatTextBox.Text = userPasswordTextBox.Text;
                roleNameComboBox.SelectedItem = _user.Role.RoleName;
                permissionLevelNumericUpDown.Value = _user.Role.PermissionLevel;
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
                _user.Role.RoleName = roleNameComboBox.SelectedItem.ToString();
                _user.Role.PermissionLevel = (int)permissionLevelNumericUpDown.Value;

                if (0 < _user.UserId)
                    _usersManager.edit(_user); // Se está agregando un registro
                else
                    _usersManager.add(_user); // Se está editando un registro

                MessageBox.Show("Registro guardado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void newRoleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
