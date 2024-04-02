namespace WindowsForms
{
    partial class EmployeeRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegisterForm));
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
            this.userButton = new System.Windows.Forms.Button();
            this.specialPanel = new System.Windows.Forms.Panel();
            this.seniorityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.categorySeniorityComboBox = new System.Windows.Forms.ComboBox();
            this.categoryTitleComboBox = new System.Windows.Forms.ComboBox();
            this.categoryAreaComboBox = new System.Windows.Forms.ComboBox();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.contactPanel.SuspendLayout();
            this.adressPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.specialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.profilePictureBox);
            this.imagePanel.Controls.Add(this.imageUrlLabel);
            this.imagePanel.Controls.Add(this.imageUrlTextBox);
            this.imagePanel.Location = new System.Drawing.Point(20, 20);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(200, 300);
            this.imagePanel.TabIndex = 18;
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
            this.contactPanel.TabIndex = 16;
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
            this.adressPanel.TabIndex = 17;
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
            this.mainPanel.TabIndex = 15;
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
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(60, 550);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(120, 30);
            this.userButton.TabIndex = 14;
            this.userButton.Text = "Registro de usuario";
            this.userButton.UseVisualStyleBackColor = true;
            // 
            // specialPanel
            // 
            this.specialPanel.Controls.Add(this.seniorityLabel);
            this.specialPanel.Controls.Add(this.titleLabel);
            this.specialPanel.Controls.Add(this.areaLabel);
            this.specialPanel.Controls.Add(this.categorySeniorityComboBox);
            this.specialPanel.Controls.Add(this.categoryTitleComboBox);
            this.specialPanel.Controls.Add(this.categoryAreaComboBox);
            this.specialPanel.Location = new System.Drawing.Point(20, 340);
            this.specialPanel.Name = "specialPanel";
            this.specialPanel.Size = new System.Drawing.Size(200, 185);
            this.specialPanel.TabIndex = 13;
            // 
            // seniorityLabel
            // 
            this.seniorityLabel.AutoSize = true;
            this.seniorityLabel.Location = new System.Drawing.Point(11, 125);
            this.seniorityLabel.Name = "seniorityLabel";
            this.seniorityLabel.Size = new System.Drawing.Size(65, 13);
            this.seniorityLabel.TabIndex = 35;
            this.seniorityLabel.Text = "Experiencia:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(11, 73);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 13);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "Título:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(11, 21);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(32, 13);
            this.areaLabel.TabIndex = 33;
            this.areaLabel.Text = "Área:";
            // 
            // categorySeniorityComboBox
            // 
            this.categorySeniorityComboBox.FormattingEnabled = true;
            this.categorySeniorityComboBox.Location = new System.Drawing.Point(82, 122);
            this.categorySeniorityComboBox.Name = "categorySeniorityComboBox";
            this.categorySeniorityComboBox.Size = new System.Drawing.Size(98, 21);
            this.categorySeniorityComboBox.TabIndex = 2;
            // 
            // categoryTitleComboBox
            // 
            this.categoryTitleComboBox.FormattingEnabled = true;
            this.categoryTitleComboBox.Location = new System.Drawing.Point(82, 70);
            this.categoryTitleComboBox.Name = "categoryTitleComboBox";
            this.categoryTitleComboBox.Size = new System.Drawing.Size(98, 21);
            this.categoryTitleComboBox.TabIndex = 1;
            // 
            // categoryAreaComboBox
            // 
            this.categoryAreaComboBox.FormattingEnabled = true;
            this.categoryAreaComboBox.Location = new System.Drawing.Point(82, 18);
            this.categoryAreaComboBox.Name = "categoryAreaComboBox";
            this.categoryAreaComboBox.Size = new System.Drawing.Size(98, 21);
            this.categoryAreaComboBox.TabIndex = 0;
            // 
            // EmployeeRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.contactPanel);
            this.Controls.Add(this.adressPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.specialPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeeRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de empleado";
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.contactPanel.ResumeLayout(false);
            this.contactPanel.PerformLayout();
            this.adressPanel.ResumeLayout(false);
            this.adressPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.specialPanel.ResumeLayout(false);
            this.specialPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel specialPanel;
        private System.Windows.Forms.Label seniorityLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.ComboBox categorySeniorityComboBox;
        private System.Windows.Forms.ComboBox categoryTitleComboBox;
        private System.Windows.Forms.ComboBox categoryAreaComboBox;
    }
}