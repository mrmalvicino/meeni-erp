namespace WindowsForms
{
    partial class UserRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterForm));
            this.userPanel = new System.Windows.Forms.Panel();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.repeatTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.rolePanel = new System.Windows.Forms.Panel();
            this.newRoleButton = new System.Windows.Forms.Button();
            this.permissionLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.roleNameComboBox = new System.Windows.Forms.ComboBox();
            this.permissionLevelLabel = new System.Windows.Forms.Label();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.userPanel.SuspendLayout();
            this.rolePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionLevelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.repeatLabel);
            this.userPanel.Controls.Add(this.repeatTextBox);
            this.userPanel.Controls.Add(this.userPasswordTextBox);
            this.userPanel.Controls.Add(this.userNameTextBox);
            this.userPanel.Controls.Add(this.userPasswordLabel);
            this.userPanel.Controls.Add(this.userNameLabel);
            this.userPanel.Location = new System.Drawing.Point(24, 23);
            this.userPanel.Margin = new System.Windows.Forms.Padding(6);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(560, 231);
            this.userPanel.TabIndex = 0;
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Location = new System.Drawing.Point(40, 160);
            this.repeatLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(200, 25);
            this.repeatLabel.TabIndex = 5;
            this.repeatLabel.Text = "Repetir contraseña:";
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.Location = new System.Drawing.Point(266, 154);
            this.repeatTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.PasswordChar = '*';
            this.repeatTextBox.Size = new System.Drawing.Size(248, 31);
            this.repeatTextBox.TabIndex = 4;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(266, 96);
            this.userPasswordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(248, 31);
            this.userPasswordTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(266, 38);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(248, 31);
            this.userNameTextBox.TabIndex = 2;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(40, 102);
            this.userPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(129, 25);
            this.userPasswordLabel.TabIndex = 1;
            this.userPasswordLabel.Text = "Contraseña:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(40, 44);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(200, 25);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Nombre de usuario:";
            // 
            // rolePanel
            // 
            this.rolePanel.Controls.Add(this.newRoleButton);
            this.rolePanel.Controls.Add(this.permissionLevelNumericUpDown);
            this.rolePanel.Controls.Add(this.roleNameComboBox);
            this.rolePanel.Controls.Add(this.permissionLevelLabel);
            this.rolePanel.Controls.Add(this.roleNameLabel);
            this.rolePanel.Location = new System.Drawing.Point(24, 277);
            this.rolePanel.Margin = new System.Windows.Forms.Padding(6);
            this.rolePanel.Name = "rolePanel";
            this.rolePanel.Size = new System.Drawing.Size(560, 231);
            this.rolePanel.TabIndex = 1;
            // 
            // newRoleButton
            // 
            this.newRoleButton.Location = new System.Drawing.Point(200, 154);
            this.newRoleButton.Margin = new System.Windows.Forms.Padding(6);
            this.newRoleButton.Name = "newRoleButton";
            this.newRoleButton.Size = new System.Drawing.Size(160, 58);
            this.newRoleButton.TabIndex = 6;
            this.newRoleButton.Text = "Nuevo rol";
            this.newRoleButton.UseVisualStyleBackColor = true;
            this.newRoleButton.Click += new System.EventHandler(this.newRoleButton_Click);
            // 
            // permissionLevelNumericUpDown
            // 
            this.permissionLevelNumericUpDown.Location = new System.Drawing.Point(228, 98);
            this.permissionLevelNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.permissionLevelNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.permissionLevelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.permissionLevelNumericUpDown.Name = "permissionLevelNumericUpDown";
            this.permissionLevelNumericUpDown.Size = new System.Drawing.Size(116, 31);
            this.permissionLevelNumericUpDown.TabIndex = 3;
            this.permissionLevelNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.permissionLevelNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // roleNameComboBox
            // 
            this.roleNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleNameComboBox.FormattingEnabled = true;
            this.roleNameComboBox.Location = new System.Drawing.Point(104, 38);
            this.roleNameComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.roleNameComboBox.Name = "roleNameComboBox";
            this.roleNameComboBox.Size = new System.Drawing.Size(410, 33);
            this.roleNameComboBox.TabIndex = 2;
            // 
            // permissionLevelLabel
            // 
            this.permissionLevelLabel.AutoSize = true;
            this.permissionLevelLabel.Location = new System.Drawing.Point(40, 102);
            this.permissionLevelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.permissionLevelLabel.Name = "permissionLevelLabel";
            this.permissionLevelLabel.Size = new System.Drawing.Size(178, 25);
            this.permissionLevelLabel.TabIndex = 1;
            this.permissionLevelLabel.Text = "Nivel de permiso:";
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.Location = new System.Drawing.Point(40, 44);
            this.roleNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(50, 25);
            this.roleNameLabel.TabIndex = 0;
            this.roleNameLabel.Text = "Rol:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(224, 529);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 58);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 617);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rolePanel);
            this.Controls.Add(this.userPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.UserRegisterForm_Load);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.rolePanel.ResumeLayout(false);
            this.rolePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionLevelNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel rolePanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label permissionLevelLabel;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.ComboBox roleNameComboBox;
        private System.Windows.Forms.NumericUpDown permissionLevelNumericUpDown;
        private System.Windows.Forms.Button newRoleButton;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.TextBox repeatTextBox;
    }
}