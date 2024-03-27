namespace WindowsForms
{
    partial class WarehouseRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseRegisterForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.activeStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.adressPanel = new System.Windows.Forms.Panel();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.adressCityComboBox = new System.Windows.Forms.ComboBox();
            this.adressProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.adressCountryComboBox = new System.Windows.Forms.ComboBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.flatLabel = new System.Windows.Forms.Label();
            this.streetNumberLabel = new System.Windows.Forms.Label();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.streetNumberTextBox = new System.Windows.Forms.TextBox();
            this.streetNameLabel = new System.Windows.Forms.Label();
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.adressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.activeStatusCheckBox);
            this.mainPanel.Controls.Add(this.nameTextBox);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Location = new System.Drawing.Point(30, 30);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(546, 110);
            this.mainPanel.TabIndex = 5;
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.AutoSize = true;
            this.activeStatusCheckBox.Checked = true;
            this.activeStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeStatusCheckBox.Location = new System.Drawing.Point(246, 29);
            this.activeStatusCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(78, 24);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 61);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(372, 26);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 64);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 20);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Nombre:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(456, 470);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 46);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // adressPanel
            // 
            this.adressPanel.Controls.Add(this.detailsLabel);
            this.adressPanel.Controls.Add(this.detailsTextBox);
            this.adressPanel.Controls.Add(this.adressCityComboBox);
            this.adressPanel.Controls.Add(this.adressProvinceComboBox);
            this.adressPanel.Controls.Add(this.adressCountryComboBox);
            this.adressPanel.Controls.Add(this.zipCodeTextBox);
            this.adressPanel.Controls.Add(this.zipCodeLabel);
            this.adressPanel.Controls.Add(this.flatLabel);
            this.adressPanel.Controls.Add(this.streetNumberLabel);
            this.adressPanel.Controls.Add(this.streetNameTextBox);
            this.adressPanel.Controls.Add(this.streetNumberTextBox);
            this.adressPanel.Controls.Add(this.streetNameLabel);
            this.adressPanel.Controls.Add(this.flatTextBox);
            this.adressPanel.Controls.Add(this.label1);
            this.adressPanel.Controls.Add(this.cityLabel);
            this.adressPanel.Controls.Add(this.label2);
            this.adressPanel.Location = new System.Drawing.Point(30, 165);
            this.adressPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressPanel.Name = "adressPanel";
            this.adressPanel.Size = new System.Drawing.Size(546, 285);
            this.adressPanel.TabIndex = 11;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(16, 233);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(71, 20);
            this.detailsLabel.TabIndex = 43;
            this.detailsLabel.Text = "Detalles:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(134, 228);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(373, 26);
            this.detailsTextBox.TabIndex = 7;
            this.detailsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressCityComboBox
            // 
            this.adressCityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adressCityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adressCityComboBox.FormattingEnabled = true;
            this.adressCityComboBox.Location = new System.Drawing.Point(134, 108);
            this.adressCityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressCityComboBox.Name = "adressCityComboBox";
            this.adressCityComboBox.Size = new System.Drawing.Size(373, 28);
            this.adressCityComboBox.TabIndex = 2;
            // 
            // adressProvinceComboBox
            // 
            this.adressProvinceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adressProvinceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adressProvinceComboBox.FormattingEnabled = true;
            this.adressProvinceComboBox.Location = new System.Drawing.Point(134, 68);
            this.adressProvinceComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressProvinceComboBox.Name = "adressProvinceComboBox";
            this.adressProvinceComboBox.Size = new System.Drawing.Size(373, 28);
            this.adressProvinceComboBox.TabIndex = 1;
            // 
            // adressCountryComboBox
            // 
            this.adressCountryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adressCountryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adressCountryComboBox.FormattingEnabled = true;
            this.adressCountryComboBox.Location = new System.Drawing.Point(134, 28);
            this.adressCountryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressCountryComboBox.Name = "adressCountryComboBox";
            this.adressCountryComboBox.Size = new System.Drawing.Size(373, 28);
            this.adressCountryComboBox.TabIndex = 0;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(134, 148);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(148, 26);
            this.zipCodeTextBox.TabIndex = 3;
            this.zipCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(16, 153);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(93, 20);
            this.zipCodeLabel.TabIndex = 39;
            this.zipCodeLabel.Text = "Cod. postal:";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(290, 153);
            this.flatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(61, 20);
            this.flatLabel.TabIndex = 37;
            this.flatLabel.Text = "Depto.:";
            // 
            // streetNumberLabel
            // 
            this.streetNumberLabel.AutoSize = true;
            this.streetNumberLabel.Location = new System.Drawing.Point(300, 193);
            this.streetNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetNumberLabel.Name = "streetNumberLabel";
            this.streetNumberLabel.Size = new System.Drawing.Size(50, 20);
            this.streetNumberLabel.TabIndex = 36;
            this.streetNumberLabel.Text = "Núm.:";
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Location = new System.Drawing.Point(134, 188);
            this.streetNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.streetNameTextBox.TabIndex = 5;
            this.streetNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetNumberTextBox
            // 
            this.streetNumberTextBox.Location = new System.Drawing.Point(358, 188);
            this.streetNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.streetNumberTextBox.Name = "streetNumberTextBox";
            this.streetNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.streetNumberTextBox.TabIndex = 6;
            this.streetNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetNameLabel
            // 
            this.streetNameLabel.AutoSize = true;
            this.streetNameLabel.Location = new System.Drawing.Point(16, 193);
            this.streetNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetNameLabel.Name = "streetNameLabel";
            this.streetNameLabel.Size = new System.Drawing.Size(48, 20);
            this.streetNameLabel.TabIndex = 35;
            this.streetNameLabel.Text = "Calle:";
            // 
            // flatTextBox
            // 
            this.flatTextBox.Location = new System.Drawing.Point(358, 148);
            this.flatTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(148, 26);
            this.flatTextBox.TabIndex = 4;
            this.flatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "País:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(16, 113);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(63, 20);
            this.cityLabel.TabIndex = 34;
            this.cityLabel.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Provincia:";
            // 
            // WarehouseRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 542);
            this.Controls.Add(this.adressPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "WarehouseRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de depósito";
            this.Load += new System.EventHandler(this.WarehouseRegisterForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.adressPanel.ResumeLayout(false);
            this.adressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox activeStatusCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel adressPanel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.ComboBox adressCityComboBox;
        private System.Windows.Forms.ComboBox adressProvinceComboBox;
        private System.Windows.Forms.ComboBox adressCountryComboBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.Label streetNumberLabel;
        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.TextBox streetNumberTextBox;
        private System.Windows.Forms.Label streetNameLabel;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label2;
    }
}