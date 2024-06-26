﻿namespace WindowsForms
{
    partial class SupplierRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierRegisterForm));
            this.specialPanel = new System.Windows.Forms.Panel();
            this.invoiceCategoryLabel = new System.Windows.Forms.Label();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.invoiceCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.imageUrlTextBox = new System.Windows.Forms.TextBox();
            this.contactPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
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
            this.adressCountryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.adressProvinceLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.organizationNameComboBox = new System.Windows.Forms.ComboBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.activeStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.organizationDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.taxCodePrefixTextBox = new System.Windows.Forms.TextBox();
            this.organizationNameLabel = new System.Windows.Forms.Label();
            this.taxCodeLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.taxCodeNumberTextBox = new System.Windows.Forms.TextBox();
            this.organizationDescriptionLabel = new System.Windows.Forms.Label();
            this.taxCodeSuffixTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.specialPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.contactPanel.SuspendLayout();
            this.adressPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // specialPanel
            // 
            this.specialPanel.Controls.Add(this.invoiceCategoryLabel);
            this.specialPanel.Controls.Add(this.paymentMethodLabel);
            this.specialPanel.Controls.Add(this.invoiceCategoryComboBox);
            this.specialPanel.Controls.Add(this.paymentMethodComboBox);
            this.specialPanel.Location = new System.Drawing.Point(20, 340);
            this.specialPanel.Name = "specialPanel";
            this.specialPanel.Size = new System.Drawing.Size(200, 185);
            this.specialPanel.TabIndex = 10;
            // 
            // invoiceCategoryLabel
            // 
            this.invoiceCategoryLabel.AutoSize = true;
            this.invoiceCategoryLabel.Location = new System.Drawing.Point(17, 99);
            this.invoiceCategoryLabel.Name = "invoiceCategoryLabel";
            this.invoiceCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.invoiceCategoryLabel.TabIndex = 34;
            this.invoiceCategoryLabel.Text = "Tipo de factura:";
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(17, 21);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(88, 13);
            this.paymentMethodLabel.TabIndex = 33;
            this.paymentMethodLabel.Text = "Método de pago:";
            // 
            // invoiceCategoryComboBox
            // 
            this.invoiceCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoiceCategoryComboBox.FormattingEnabled = true;
            this.invoiceCategoryComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.invoiceCategoryComboBox.Location = new System.Drawing.Point(20, 122);
            this.invoiceCategoryComboBox.Name = "invoiceCategoryComboBox";
            this.invoiceCategoryComboBox.Size = new System.Drawing.Size(160, 21);
            this.invoiceCategoryComboBox.TabIndex = 1;
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Cheque",
            "Crédito",
            "Débito",
            "Efectivo",
            "Transferencia"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(20, 44);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(160, 21);
            this.paymentMethodComboBox.TabIndex = 0;
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.profilePictureBox);
            this.imagePanel.Controls.Add(this.imageUrlLabel);
            this.imagePanel.Controls.Add(this.imageUrlTextBox);
            this.imagePanel.Location = new System.Drawing.Point(20, 20);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(200, 300);
            this.imagePanel.TabIndex = 9;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(20, 20);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(160, 160);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 39;
            this.profilePictureBox.TabStop = false;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(17, 221);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(95, 13);
            this.imageUrlLabel.TabIndex = 41;
            this.imageUrlLabel.Text = "URL de la imagen:";
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(20, 244);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(160, 20);
            this.imageUrlTextBox.TabIndex = 0;
            this.imageUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageUrlTextBox.Leave += new System.EventHandler(this.imageUrlTextBox_Leave);
            // 
            // contactPanel
            // 
            this.contactPanel.Controls.Add(this.emailTextBox);
            this.contactPanel.Controls.Add(this.phoneTextBox);
            this.contactPanel.Controls.Add(this.emailLabel);
            this.contactPanel.Controls.Add(this.phoneLabel);
            this.contactPanel.Location = new System.Drawing.Point(240, 250);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(364, 70);
            this.contactPanel.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(89, 40);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(89, 14);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(250, 20);
            this.phoneTextBox.TabIndex = 0;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 42);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(11, 16);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneLabel.TabIndex = 31;
            this.phoneLabel.Text = "Teléfono:";
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
            this.adressPanel.Controls.Add(this.adressCountryLabel);
            this.adressPanel.Controls.Add(this.cityLabel);
            this.adressPanel.Controls.Add(this.adressProvinceLabel);
            this.adressPanel.Location = new System.Drawing.Point(240, 340);
            this.adressPanel.Name = "adressPanel";
            this.adressPanel.Size = new System.Drawing.Size(364, 185);
            this.adressPanel.TabIndex = 8;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(11, 151);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(48, 13);
            this.detailsLabel.TabIndex = 43;
            this.detailsLabel.Text = "Detalles:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(89, 148);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(250, 20);
            this.detailsTextBox.TabIndex = 7;
            this.detailsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressCityComboBox
            // 
            this.adressCityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adressCityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adressCityComboBox.FormattingEnabled = true;
            this.adressCityComboBox.Location = new System.Drawing.Point(89, 70);
            this.adressCityComboBox.Name = "adressCityComboBox";
            this.adressCityComboBox.Size = new System.Drawing.Size(250, 21);
            this.adressCityComboBox.TabIndex = 2;
            // 
            // adressProvinceComboBox
            // 
            this.adressProvinceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adressProvinceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adressProvinceComboBox.FormattingEnabled = true;
            this.adressProvinceComboBox.Location = new System.Drawing.Point(89, 44);
            this.adressProvinceComboBox.Name = "adressProvinceComboBox";
            this.adressProvinceComboBox.Size = new System.Drawing.Size(250, 21);
            this.adressProvinceComboBox.TabIndex = 1;
            // 
            // adressCountryComboBox
            // 
            this.adressCountryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adressCountryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adressCountryComboBox.FormattingEnabled = true;
            this.adressCountryComboBox.Location = new System.Drawing.Point(89, 18);
            this.adressCountryComboBox.Name = "adressCountryComboBox";
            this.adressCountryComboBox.Size = new System.Drawing.Size(250, 21);
            this.adressCountryComboBox.TabIndex = 0;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(89, 96);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTextBox.TabIndex = 3;
            this.zipCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(11, 99);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(63, 13);
            this.zipCodeLabel.TabIndex = 39;
            this.zipCodeLabel.Text = "Cod. postal:";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(193, 99);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(42, 13);
            this.flatLabel.TabIndex = 37;
            this.flatLabel.Text = "Depto.:";
            // 
            // streetNumberLabel
            // 
            this.streetNumberLabel.AutoSize = true;
            this.streetNumberLabel.Location = new System.Drawing.Point(200, 125);
            this.streetNumberLabel.Name = "streetNumberLabel";
            this.streetNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.streetNumberLabel.TabIndex = 36;
            this.streetNumberLabel.Text = "Núm.:";
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Location = new System.Drawing.Point(89, 122);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetNameTextBox.TabIndex = 5;
            this.streetNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetNumberTextBox
            // 
            this.streetNumberTextBox.Location = new System.Drawing.Point(239, 122);
            this.streetNumberTextBox.Name = "streetNumberTextBox";
            this.streetNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetNumberTextBox.TabIndex = 6;
            this.streetNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetNameLabel
            // 
            this.streetNameLabel.AutoSize = true;
            this.streetNameLabel.Location = new System.Drawing.Point(11, 125);
            this.streetNameLabel.Name = "streetNameLabel";
            this.streetNameLabel.Size = new System.Drawing.Size(33, 13);
            this.streetNameLabel.TabIndex = 35;
            this.streetNameLabel.Text = "Calle:";
            // 
            // flatTextBox
            // 
            this.flatTextBox.Location = new System.Drawing.Point(239, 96);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(100, 20);
            this.flatTextBox.TabIndex = 4;
            this.flatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressCountryLabel
            // 
            this.adressCountryLabel.AutoSize = true;
            this.adressCountryLabel.Location = new System.Drawing.Point(11, 21);
            this.adressCountryLabel.Name = "adressCountryLabel";
            this.adressCountryLabel.Size = new System.Drawing.Size(32, 13);
            this.adressCountryLabel.TabIndex = 32;
            this.adressCountryLabel.Text = "País:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(11, 73);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 13);
            this.cityLabel.TabIndex = 34;
            this.cityLabel.Text = "Ciudad:";
            // 
            // adressProvinceLabel
            // 
            this.adressProvinceLabel.AutoSize = true;
            this.adressProvinceLabel.Location = new System.Drawing.Point(11, 47);
            this.adressProvinceLabel.Name = "adressProvinceLabel";
            this.adressProvinceLabel.Size = new System.Drawing.Size(54, 13);
            this.adressProvinceLabel.TabIndex = 33;
            this.adressProvinceLabel.Text = "Provincia:";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.organizationNameComboBox);
            this.mainPanel.Controls.Add(this.birthLabel);
            this.mainPanel.Controls.Add(this.birthDateTimePicker);
            this.mainPanel.Controls.Add(this.firstNameTextBox);
            this.mainPanel.Controls.Add(this.lastNameTextBox);
            this.mainPanel.Controls.Add(this.activeStatusCheckBox);
            this.mainPanel.Controls.Add(this.organizationDescriptionTextBox);
            this.mainPanel.Controls.Add(this.lastNameLabel);
            this.mainPanel.Controls.Add(this.taxCodePrefixTextBox);
            this.mainPanel.Controls.Add(this.organizationNameLabel);
            this.mainPanel.Controls.Add(this.taxCodeLabel);
            this.mainPanel.Controls.Add(this.firstNameLabel);
            this.mainPanel.Controls.Add(this.taxCodeNumberTextBox);
            this.mainPanel.Controls.Add(this.organizationDescriptionLabel);
            this.mainPanel.Controls.Add(this.taxCodeSuffixTextBox);
            this.mainPanel.Location = new System.Drawing.Point(240, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(364, 210);
            this.mainPanel.TabIndex = 6;
            // 
            // organizationNameComboBox
            // 
            this.organizationNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.organizationNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.organizationNameComboBox.FormattingEnabled = true;
            this.organizationNameComboBox.Location = new System.Drawing.Point(89, 146);
            this.organizationNameComboBox.Name = "organizationNameComboBox";
            this.organizationNameComboBox.Size = new System.Drawing.Size(250, 21);
            this.organizationNameComboBox.TabIndex = 7;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(11, 45);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(63, 13);
            this.birthLabel.TabIndex = 44;
            this.birthLabel.Text = "Nacimiento:";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(89, 42);
            this.birthDateTimePicker.MaxDate = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.birthDateTimePicker.TabIndex = 1;
            this.birthDateTimePicker.Value = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 94);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(89, 120);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.AutoSize = true;
            this.activeStatusCheckBox.Checked = true;
            this.activeStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeStatusCheckBox.Location = new System.Drawing.Point(164, 19);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(56, 17);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // organizationDescriptionTextBox
            // 
            this.organizationDescriptionTextBox.Location = new System.Drawing.Point(89, 172);
            this.organizationDescriptionTextBox.Name = "organizationDescriptionTextBox";
            this.organizationDescriptionTextBox.Size = new System.Drawing.Size(250, 20);
            this.organizationDescriptionTextBox.TabIndex = 8;
            this.organizationDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 123);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(47, 13);
            this.lastNameLabel.TabIndex = 27;
            this.lastNameLabel.Text = "Apellido:";
            // 
            // taxCodePrefixTextBox
            // 
            this.taxCodePrefixTextBox.Location = new System.Drawing.Point(89, 68);
            this.taxCodePrefixTextBox.Name = "taxCodePrefixTextBox";
            this.taxCodePrefixTextBox.Size = new System.Drawing.Size(60, 20);
            this.taxCodePrefixTextBox.TabIndex = 2;
            this.taxCodePrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // organizationNameLabel
            // 
            this.organizationNameLabel.AutoSize = true;
            this.organizationNameLabel.Location = new System.Drawing.Point(11, 149);
            this.organizationNameLabel.Name = "organizationNameLabel";
            this.organizationNameLabel.Size = new System.Drawing.Size(72, 13);
            this.organizationNameLabel.TabIndex = 28;
            this.organizationNameLabel.Text = "Organización:";
            // 
            // taxCodeLabel
            // 
            this.taxCodeLabel.AutoSize = true;
            this.taxCodeLabel.Location = new System.Drawing.Point(11, 71);
            this.taxCodeLabel.Name = "taxCodeLabel";
            this.taxCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.taxCodeLabel.TabIndex = 42;
            this.taxCodeLabel.Text = "CUIL/CUIT:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(11, 97);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(47, 13);
            this.firstNameLabel.TabIndex = 26;
            this.firstNameLabel.Text = "Nombre:";
            // 
            // taxCodeNumberTextBox
            // 
            this.taxCodeNumberTextBox.Location = new System.Drawing.Point(155, 68);
            this.taxCodeNumberTextBox.Name = "taxCodeNumberTextBox";
            this.taxCodeNumberTextBox.Size = new System.Drawing.Size(118, 20);
            this.taxCodeNumberTextBox.TabIndex = 3;
            this.taxCodeNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // organizationDescriptionLabel
            // 
            this.organizationDescriptionLabel.AutoSize = true;
            this.organizationDescriptionLabel.Location = new System.Drawing.Point(11, 175);
            this.organizationDescriptionLabel.Name = "organizationDescriptionLabel";
            this.organizationDescriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.organizationDescriptionLabel.TabIndex = 29;
            this.organizationDescriptionLabel.Text = "Descripción:";
            // 
            // taxCodeSuffixTextBox
            // 
            this.taxCodeSuffixTextBox.Location = new System.Drawing.Point(279, 68);
            this.taxCodeSuffixTextBox.Name = "taxCodeSuffixTextBox";
            this.taxCodeSuffixTextBox.Size = new System.Drawing.Size(60, 20);
            this.taxCodeSuffixTextBox.TabIndex = 4;
            this.taxCodeSuffixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(524, 550);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SupplierRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.specialPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.contactPanel);
            this.Controls.Add(this.adressPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SupplierRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de proveedor";
            this.Load += new System.EventHandler(this.SupplierRegisterForm_Load);
            this.specialPanel.ResumeLayout(false);
            this.specialPanel.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.contactPanel.ResumeLayout(false);
            this.contactPanel.PerformLayout();
            this.adressPanel.ResumeLayout(false);
            this.adressPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel specialPanel;
        private System.Windows.Forms.Label invoiceCategoryLabel;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.ComboBox invoiceCategoryComboBox;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label imageUrlLabel;
        private System.Windows.Forms.TextBox imageUrlTextBox;
        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
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
        private System.Windows.Forms.Label adressCountryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label adressProvinceLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox organizationNameComboBox;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox activeStatusCheckBox;
        private System.Windows.Forms.TextBox organizationDescriptionTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox taxCodePrefixTextBox;
        private System.Windows.Forms.Label organizationNameLabel;
        private System.Windows.Forms.Label taxCodeLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox taxCodeNumberTextBox;
        private System.Windows.Forms.Label organizationDescriptionLabel;
        private System.Windows.Forms.TextBox taxCodeSuffixTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}