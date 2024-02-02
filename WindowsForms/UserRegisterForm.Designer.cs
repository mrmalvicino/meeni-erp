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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.roleNameComboBox = new System.Windows.Forms.ComboBox();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.repeatTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.roleNameComboBox);
            this.mainPanel.Controls.Add(this.roleNameLabel);
            this.mainPanel.Controls.Add(this.repeatLabel);
            this.mainPanel.Controls.Add(this.repeatTextBox);
            this.mainPanel.Controls.Add(this.userPasswordTextBox);
            this.mainPanel.Controls.Add(this.userNameTextBox);
            this.mainPanel.Controls.Add(this.userPasswordLabel);
            this.mainPanel.Controls.Add(this.userNameLabel);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(280, 250);
            this.mainPanel.TabIndex = 0;
            // 
            // roleNameComboBox
            // 
            this.roleNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleNameComboBox.FormattingEnabled = true;
            this.roleNameComboBox.Location = new System.Drawing.Point(23, 217);
            this.roleNameComboBox.Name = "roleNameComboBox";
            this.roleNameComboBox.Size = new System.Drawing.Size(236, 21);
            this.roleNameComboBox.TabIndex = 3;
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.Location = new System.Drawing.Point(20, 190);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(26, 13);
            this.roleNameLabel.TabIndex = 0;
            this.roleNameLabel.Text = "Rol:";
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Location = new System.Drawing.Point(20, 130);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(100, 13);
            this.repeatLabel.TabIndex = 5;
            this.repeatLabel.Text = "Repetir contraseña:";
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.Location = new System.Drawing.Point(23, 157);
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.PasswordChar = '*';
            this.repeatTextBox.Size = new System.Drawing.Size(236, 20);
            this.repeatTextBox.TabIndex = 2;
            this.repeatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(23, 97);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(236, 20);
            this.userPasswordTextBox.TabIndex = 1;
            this.userPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(23, 37);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(20, 70);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(64, 13);
            this.userPasswordLabel.TabIndex = 1;
            this.userPasswordLabel.Text = "Contraseña:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(20, 10);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(99, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Nombre de usuario:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(171, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 30);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Guardar usuario";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(35, 275);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar usuario";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 321);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.UserRegisterForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.ComboBox roleNameComboBox;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.TextBox repeatTextBox;
        private System.Windows.Forms.Button deleteButton;
    }
}