namespace WindowsForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.currencyLabel = new System.Windows.Forms.Label();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.coverLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.organizationTabPage = new System.Windows.Forms.TabPage();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.streetNumberTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.legalIdTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.flatLabel = new System.Windows.Forms.Label();
            this.streetNumberLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.LegalIdLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rolesTabPage = new System.Windows.Forms.TabPage();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabControl.SuspendLayout();
            this.organizationTabPage.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(15, 15);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(102, 13);
            this.currencyLabel.TabIndex = 0;
            this.currencyLabel.Text = "Cotización del dólar:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(123, 12);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 1;
            this.currencyTextBox.Text = "1000";
            // 
            // coverLabel
            // 
            this.coverLabel.AutoSize = true;
            this.coverLabel.Location = new System.Drawing.Point(15, 15);
            this.coverLabel.Name = "coverLabel";
            this.coverLabel.Size = new System.Drawing.Size(47, 13);
            this.coverLabel.TabIndex = 2;
            this.coverLabel.Text = "Portada:";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Location = new System.Drawing.Point(15, 45);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(34, 13);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "Logo:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(528, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.organizationTabPage);
            this.settingsTabControl.Controls.Add(this.rolesTabPage);
            this.settingsTabControl.Controls.Add(this.generalTabPage);
            this.settingsTabControl.Location = new System.Drawing.Point(12, 12);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(600, 261);
            this.settingsTabControl.TabIndex = 6;
            // 
            // organizationTabPage
            // 
            this.organizationTabPage.Controls.Add(this.zipTextBox);
            this.organizationTabPage.Controls.Add(this.flatTextBox);
            this.organizationTabPage.Controls.Add(this.streetNumberTextBox);
            this.organizationTabPage.Controls.Add(this.streetTextBox);
            this.organizationTabPage.Controls.Add(this.cityTextBox);
            this.organizationTabPage.Controls.Add(this.provinceTextBox);
            this.organizationTabPage.Controls.Add(this.countryTextBox);
            this.organizationTabPage.Controls.Add(this.emailTextBox);
            this.organizationTabPage.Controls.Add(this.phoneTextBox);
            this.organizationTabPage.Controls.Add(this.legalIdTextBox);
            this.organizationTabPage.Controls.Add(this.descriptionTextBox);
            this.organizationTabPage.Controls.Add(this.nameTextBox);
            this.organizationTabPage.Controls.Add(this.zipLabel);
            this.organizationTabPage.Controls.Add(this.flatLabel);
            this.organizationTabPage.Controls.Add(this.streetNumberLabel);
            this.organizationTabPage.Controls.Add(this.streetLabel);
            this.organizationTabPage.Controls.Add(this.cityLabel);
            this.organizationTabPage.Controls.Add(this.emailLabel);
            this.organizationTabPage.Controls.Add(this.countryLabel);
            this.organizationTabPage.Controls.Add(this.phoneLabel);
            this.organizationTabPage.Controls.Add(this.provinceLabel);
            this.organizationTabPage.Controls.Add(this.LegalIdLabel);
            this.organizationTabPage.Controls.Add(this.descriptionLabel);
            this.organizationTabPage.Controls.Add(this.nameLabel);
            this.organizationTabPage.Controls.Add(this.coverLabel);
            this.organizationTabPage.Controls.Add(this.logoLabel);
            this.organizationTabPage.Location = new System.Drawing.Point(4, 22);
            this.organizationTabPage.Name = "organizationTabPage";
            this.organizationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.organizationTabPage.Size = new System.Drawing.Size(592, 235);
            this.organizationTabPage.TabIndex = 0;
            this.organizationTabPage.Text = "Organización";
            this.organizationTabPage.UseVisualStyleBackColor = true;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(396, 192);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(150, 20);
            this.zipTextBox.TabIndex = 28;
            // 
            // flatTextBox
            // 
            this.flatTextBox.Location = new System.Drawing.Point(396, 162);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(150, 20);
            this.flatTextBox.TabIndex = 27;
            // 
            // streetNumberTextBox
            // 
            this.streetNumberTextBox.Location = new System.Drawing.Point(396, 132);
            this.streetNumberTextBox.Name = "streetNumberTextBox";
            this.streetNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.streetNumberTextBox.TabIndex = 26;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(396, 102);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(150, 20);
            this.streetTextBox.TabIndex = 25;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(396, 72);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 20);
            this.cityTextBox.TabIndex = 24;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Location = new System.Drawing.Point(396, 42);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(150, 20);
            this.provinceTextBox.TabIndex = 23;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(396, 12);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(150, 20);
            this.countryTextBox.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(100, 192);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 21;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(100, 162);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(150, 20);
            this.phoneTextBox.TabIndex = 20;
            // 
            // legalIdTextBox
            // 
            this.legalIdTextBox.Location = new System.Drawing.Point(100, 132);
            this.legalIdTextBox.Name = "legalIdTextBox";
            this.legalIdTextBox.Size = new System.Drawing.Size(150, 20);
            this.legalIdTextBox.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(100, 102);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(150, 20);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(311, 195);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(74, 13);
            this.zipLabel.TabIndex = 16;
            this.zipLabel.Text = "Código postal:";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(311, 165);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(77, 13);
            this.flatLabel.TabIndex = 15;
            this.flatLabel.Text = "Departamento:";
            // 
            // streetNumberLabel
            // 
            this.streetNumberLabel.AutoSize = true;
            this.streetNumberLabel.Location = new System.Drawing.Point(311, 135);
            this.streetNumberLabel.Name = "streetNumberLabel";
            this.streetNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.streetNumberLabel.TabIndex = 14;
            this.streetNumberLabel.Text = "Número:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(311, 105);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(33, 13);
            this.streetLabel.TabIndex = 13;
            this.streetLabel.Text = "Calle:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(311, 75);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 13);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "Ciudad:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(15, 195);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(311, 15);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(32, 13);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "País:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(15, 165);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Teléfono:";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(311, 45);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(54, 13);
            this.provinceLabel.TabIndex = 8;
            this.provinceLabel.Text = "Provincia:";
            // 
            // LegalIdLabel
            // 
            this.LegalIdLabel.AutoSize = true;
            this.LegalIdLabel.Location = new System.Drawing.Point(15, 135);
            this.LegalIdLabel.Name = "LegalIdLabel";
            this.LegalIdLabel.Size = new System.Drawing.Size(64, 13);
            this.LegalIdLabel.TabIndex = 7;
            this.LegalIdLabel.Text = "CUIL/CUIT:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(15, 105);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Descripción:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre:";
            // 
            // rolesTabPage
            // 
            this.rolesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rolesTabPage.Name = "rolesTabPage";
            this.rolesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rolesTabPage.Size = new System.Drawing.Size(592, 235);
            this.rolesTabPage.TabIndex = 1;
            this.rolesTabPage.Text = "Roles";
            this.rolesTabPage.UseVisualStyleBackColor = true;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.currencyLabel);
            this.generalTabPage.Controls.Add(this.currencyTextBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(592, 235);
            this.generalTabPage.TabIndex = 2;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.settingsTabControl.ResumeLayout(false);
            this.organizationTabPage.ResumeLayout(false);
            this.organizationTabPage.PerformLayout();
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.Label coverLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage organizationTabPage;
        private System.Windows.Forms.TabPage rolesTabPage;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label LegalIdLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.Label streetNumberLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox legalIdTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.TextBox streetNumberTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
    }
}