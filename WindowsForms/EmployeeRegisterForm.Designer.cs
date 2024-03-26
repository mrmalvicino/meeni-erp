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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.imageUrlTextBox = new System.Windows.Forms.TextBox();
            this.contactPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneCountryTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneAreaTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.adressPanel = new System.Windows.Forms.Panel();
            this.adressZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.adressZipCodeLabel = new System.Windows.Forms.Label();
            this.adressCountryTextBox = new System.Windows.Forms.TextBox();
            this.adressFlatLabel = new System.Windows.Forms.Label();
            this.adressProvinceTextBox = new System.Windows.Forms.TextBox();
            this.adressCityTextBox = new System.Windows.Forms.TextBox();
            this.adressStreetNumberLabel = new System.Windows.Forms.Label();
            this.adressStreetTextBox = new System.Windows.Forms.TextBox();
            this.adressStreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.adressStreetLabel = new System.Windows.Forms.Label();
            this.adressFlatTextBox = new System.Windows.Forms.TextBox();
            this.adressCountryLabel = new System.Windows.Forms.Label();
            this.adressCityLabel = new System.Windows.Forms.Label();
            this.adressProvinceLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.isPersonLabel = new System.Windows.Forms.Label();
            this.activeStatusLabel = new System.Windows.Forms.Label();
            this.isPersonCheckBox = new System.Windows.Forms.CheckBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.activeStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.businessNameTextBox = new System.Windows.Forms.TextBox();
            this.businessDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.legalIdXXTextBox = new System.Windows.Forms.TextBox();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.legalIdLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.legalIdDNITextBox = new System.Windows.Forms.TextBox();
            this.businessDescriptionLabel = new System.Windows.Forms.Label();
            this.legalIdYTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.specialPanel = new System.Windows.Forms.Panel();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.seniorityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.categorySeniorityComboBox = new System.Windows.Forms.ComboBox();
            this.categoryTitleComboBox = new System.Windows.Forms.ComboBox();
            this.categoryAreaComboBox = new System.Windows.Forms.ComboBox();
            this.userButton = new System.Windows.Forms.Button();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contactPanel.SuspendLayout();
            this.adressPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.specialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Controls.Add(this.loadImageButton);
            this.imagePanel.Controls.Add(this.imageUrlLabel);
            this.imagePanel.Controls.Add(this.imageUrlTextBox);
            this.imagePanel.Location = new System.Drawing.Point(30, 31);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(300, 462);
            this.imagePanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(30, 31);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 246);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 39;
            this.pictureBox.TabStop = false;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(75, 400);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(150, 46);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Cargar localmente";
            this.loadImageButton.UseVisualStyleBackColor = true;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(26, 312);
            this.imageUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(185, 20);
            this.imageUrlLabel.TabIndex = 41;
            this.imageUrlLabel.Text = "URL o ruta de la imagen:";
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(30, 337);
            this.imageUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(238, 26);
            this.imageUrlTextBox.TabIndex = 1;
            this.imageUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contactPanel
            // 
            this.contactPanel.Controls.Add(this.emailTextBox);
            this.contactPanel.Controls.Add(this.phoneCountryTextBox);
            this.contactPanel.Controls.Add(this.phoneNumberTextBox);
            this.contactPanel.Controls.Add(this.phoneAreaTextBox);
            this.contactPanel.Controls.Add(this.emailLabel);
            this.contactPanel.Controls.Add(this.phoneLabel);
            this.contactPanel.Location = new System.Drawing.Point(360, 385);
            this.contactPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(546, 108);
            this.contactPanel.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(134, 18);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(373, 26);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneCountryTextBox
            // 
            this.phoneCountryTextBox.Location = new System.Drawing.Point(134, 58);
            this.phoneCountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneCountryTextBox.Name = "phoneCountryTextBox";
            this.phoneCountryTextBox.Size = new System.Drawing.Size(58, 26);
            this.phoneCountryTextBox.TabIndex = 1;
            this.phoneCountryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(272, 58);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(235, 26);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneAreaTextBox
            // 
            this.phoneAreaTextBox.Location = new System.Drawing.Point(202, 58);
            this.phoneAreaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneAreaTextBox.Name = "phoneAreaTextBox";
            this.phoneAreaTextBox.Size = new System.Drawing.Size(58, 26);
            this.phoneAreaTextBox.TabIndex = 2;
            this.phoneAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(16, 23);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(16, 63);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(75, 20);
            this.phoneLabel.TabIndex = 31;
            this.phoneLabel.Text = "Teléfono:";
            // 
            // adressPanel
            // 
            this.adressPanel.Controls.Add(this.adressZipCodeTextBox);
            this.adressPanel.Controls.Add(this.adressZipCodeLabel);
            this.adressPanel.Controls.Add(this.adressCountryTextBox);
            this.adressPanel.Controls.Add(this.adressFlatLabel);
            this.adressPanel.Controls.Add(this.adressProvinceTextBox);
            this.adressPanel.Controls.Add(this.adressCityTextBox);
            this.adressPanel.Controls.Add(this.adressStreetNumberLabel);
            this.adressPanel.Controls.Add(this.adressStreetTextBox);
            this.adressPanel.Controls.Add(this.adressStreetNumberTextBox);
            this.adressPanel.Controls.Add(this.adressStreetLabel);
            this.adressPanel.Controls.Add(this.adressFlatTextBox);
            this.adressPanel.Controls.Add(this.adressCountryLabel);
            this.adressPanel.Controls.Add(this.adressCityLabel);
            this.adressPanel.Controls.Add(this.adressProvinceLabel);
            this.adressPanel.Location = new System.Drawing.Point(360, 523);
            this.adressPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressPanel.Name = "adressPanel";
            this.adressPanel.Size = new System.Drawing.Size(546, 285);
            this.adressPanel.TabIndex = 2;
            // 
            // adressZipCodeTextBox
            // 
            this.adressZipCodeTextBox.Location = new System.Drawing.Point(134, 146);
            this.adressZipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressZipCodeTextBox.Name = "adressZipCodeTextBox";
            this.adressZipCodeTextBox.Size = new System.Drawing.Size(373, 26);
            this.adressZipCodeTextBox.TabIndex = 3;
            this.adressZipCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressZipCodeLabel
            // 
            this.adressZipCodeLabel.AutoSize = true;
            this.adressZipCodeLabel.Location = new System.Drawing.Point(16, 151);
            this.adressZipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressZipCodeLabel.Name = "adressZipCodeLabel";
            this.adressZipCodeLabel.Size = new System.Drawing.Size(93, 20);
            this.adressZipCodeLabel.TabIndex = 39;
            this.adressZipCodeLabel.Text = "Cod. postal:";
            // 
            // adressCountryTextBox
            // 
            this.adressCountryTextBox.Location = new System.Drawing.Point(134, 26);
            this.adressCountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressCountryTextBox.Name = "adressCountryTextBox";
            this.adressCountryTextBox.Size = new System.Drawing.Size(373, 26);
            this.adressCountryTextBox.TabIndex = 0;
            this.adressCountryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressFlatLabel
            // 
            this.adressFlatLabel.AutoSize = true;
            this.adressFlatLabel.Location = new System.Drawing.Point(16, 231);
            this.adressFlatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressFlatLabel.Name = "adressFlatLabel";
            this.adressFlatLabel.Size = new System.Drawing.Size(61, 20);
            this.adressFlatLabel.TabIndex = 37;
            this.adressFlatLabel.Text = "Depto.:";
            // 
            // adressProvinceTextBox
            // 
            this.adressProvinceTextBox.Location = new System.Drawing.Point(134, 66);
            this.adressProvinceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressProvinceTextBox.Name = "adressProvinceTextBox";
            this.adressProvinceTextBox.Size = new System.Drawing.Size(373, 26);
            this.adressProvinceTextBox.TabIndex = 1;
            this.adressProvinceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressCityTextBox
            // 
            this.adressCityTextBox.Location = new System.Drawing.Point(134, 106);
            this.adressCityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressCityTextBox.Name = "adressCityTextBox";
            this.adressCityTextBox.Size = new System.Drawing.Size(373, 26);
            this.adressCityTextBox.TabIndex = 2;
            this.adressCityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressStreetNumberLabel
            // 
            this.adressStreetNumberLabel.AutoSize = true;
            this.adressStreetNumberLabel.Location = new System.Drawing.Point(300, 191);
            this.adressStreetNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressStreetNumberLabel.Name = "adressStreetNumberLabel";
            this.adressStreetNumberLabel.Size = new System.Drawing.Size(50, 20);
            this.adressStreetNumberLabel.TabIndex = 36;
            this.adressStreetNumberLabel.Text = "Núm.:";
            // 
            // adressStreetTextBox
            // 
            this.adressStreetTextBox.Location = new System.Drawing.Point(134, 186);
            this.adressStreetTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressStreetTextBox.Name = "adressStreetTextBox";
            this.adressStreetTextBox.Size = new System.Drawing.Size(148, 26);
            this.adressStreetTextBox.TabIndex = 4;
            this.adressStreetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressStreetNumberTextBox
            // 
            this.adressStreetNumberTextBox.Location = new System.Drawing.Point(358, 186);
            this.adressStreetNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressStreetNumberTextBox.Name = "adressStreetNumberTextBox";
            this.adressStreetNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.adressStreetNumberTextBox.TabIndex = 5;
            this.adressStreetNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressStreetLabel
            // 
            this.adressStreetLabel.AutoSize = true;
            this.adressStreetLabel.Location = new System.Drawing.Point(16, 191);
            this.adressStreetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressStreetLabel.Name = "adressStreetLabel";
            this.adressStreetLabel.Size = new System.Drawing.Size(48, 20);
            this.adressStreetLabel.TabIndex = 35;
            this.adressStreetLabel.Text = "Calle:";
            // 
            // adressFlatTextBox
            // 
            this.adressFlatTextBox.Location = new System.Drawing.Point(134, 226);
            this.adressFlatTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressFlatTextBox.Name = "adressFlatTextBox";
            this.adressFlatTextBox.Size = new System.Drawing.Size(373, 26);
            this.adressFlatTextBox.TabIndex = 6;
            this.adressFlatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressCountryLabel
            // 
            this.adressCountryLabel.AutoSize = true;
            this.adressCountryLabel.Location = new System.Drawing.Point(16, 31);
            this.adressCountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressCountryLabel.Name = "adressCountryLabel";
            this.adressCountryLabel.Size = new System.Drawing.Size(43, 20);
            this.adressCountryLabel.TabIndex = 32;
            this.adressCountryLabel.Text = "País:";
            // 
            // adressCityLabel
            // 
            this.adressCityLabel.AutoSize = true;
            this.adressCityLabel.Location = new System.Drawing.Point(16, 111);
            this.adressCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressCityLabel.Name = "adressCityLabel";
            this.adressCityLabel.Size = new System.Drawing.Size(63, 20);
            this.adressCityLabel.TabIndex = 34;
            this.adressCityLabel.Text = "Ciudad:";
            // 
            // adressProvinceLabel
            // 
            this.adressProvinceLabel.AutoSize = true;
            this.adressProvinceLabel.Location = new System.Drawing.Point(16, 71);
            this.adressProvinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressProvinceLabel.Name = "adressProvinceLabel";
            this.adressProvinceLabel.Size = new System.Drawing.Size(76, 20);
            this.adressProvinceLabel.TabIndex = 33;
            this.adressProvinceLabel.Text = "Provincia:";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.isPersonLabel);
            this.mainPanel.Controls.Add(this.activeStatusLabel);
            this.mainPanel.Controls.Add(this.isPersonCheckBox);
            this.mainPanel.Controls.Add(this.firstNameTextBox);
            this.mainPanel.Controls.Add(this.lastNameTextBox);
            this.mainPanel.Controls.Add(this.activeStatusCheckBox);
            this.mainPanel.Controls.Add(this.businessNameTextBox);
            this.mainPanel.Controls.Add(this.businessDescriptionTextBox);
            this.mainPanel.Controls.Add(this.lastNameLabel);
            this.mainPanel.Controls.Add(this.legalIdXXTextBox);
            this.mainPanel.Controls.Add(this.businessNameLabel);
            this.mainPanel.Controls.Add(this.legalIdLabel);
            this.mainPanel.Controls.Add(this.firstNameLabel);
            this.mainPanel.Controls.Add(this.legalIdDNITextBox);
            this.mainPanel.Controls.Add(this.businessDescriptionLabel);
            this.mainPanel.Controls.Add(this.legalIdYTextBox);
            this.mainPanel.Location = new System.Drawing.Point(360, 31);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(546, 323);
            this.mainPanel.TabIndex = 0;
            // 
            // isPersonLabel
            // 
            this.isPersonLabel.AutoSize = true;
            this.isPersonLabel.Location = new System.Drawing.Point(16, 65);
            this.isPersonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isPersonLabel.Name = "isPersonLabel";
            this.isPersonLabel.Size = new System.Drawing.Size(316, 20);
            this.isPersonLabel.TabIndex = 46;
            this.isPersonLabel.Text = "Destildar si es una organización o empresa:";
            // 
            // activeStatusLabel
            // 
            this.activeStatusLabel.AutoSize = true;
            this.activeStatusLabel.Location = new System.Drawing.Point(16, 29);
            this.activeStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeStatusLabel.Name = "activeStatusLabel";
            this.activeStatusLabel.Size = new System.Drawing.Size(222, 20);
            this.activeStatusLabel.TabIndex = 45;
            this.activeStatusLabel.Text = "Destildar si está dado de baja:";
            // 
            // isPersonCheckBox
            // 
            this.isPersonCheckBox.AutoSize = true;
            this.isPersonCheckBox.Checked = true;
            this.isPersonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isPersonCheckBox.Enabled = false;
            this.isPersonCheckBox.Location = new System.Drawing.Point(368, 63);
            this.isPersonCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isPersonCheckBox.Name = "isPersonCheckBox";
            this.isPersonCheckBox.Size = new System.Drawing.Size(134, 24);
            this.isPersonCheckBox.TabIndex = 1;
            this.isPersonCheckBox.Text = "Persona física";
            this.isPersonCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(134, 145);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(373, 26);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(134, 185);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(373, 26);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.AutoSize = true;
            this.activeStatusCheckBox.Checked = true;
            this.activeStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeStatusCheckBox.Location = new System.Drawing.Point(368, 28);
            this.activeStatusCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(78, 24);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.Location = new System.Drawing.Point(134, 225);
            this.businessNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.Size = new System.Drawing.Size(373, 26);
            this.businessNameTextBox.TabIndex = 7;
            this.businessNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // businessDescriptionTextBox
            // 
            this.businessDescriptionTextBox.Location = new System.Drawing.Point(134, 265);
            this.businessDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.businessDescriptionTextBox.Name = "businessDescriptionTextBox";
            this.businessDescriptionTextBox.Size = new System.Drawing.Size(373, 26);
            this.businessDescriptionTextBox.TabIndex = 8;
            this.businessDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 189);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(69, 20);
            this.lastNameLabel.TabIndex = 27;
            this.lastNameLabel.Text = "Apellido:";
            // 
            // legalIdXXTextBox
            // 
            this.legalIdXXTextBox.Location = new System.Drawing.Point(134, 105);
            this.legalIdXXTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.legalIdXXTextBox.Name = "legalIdXXTextBox";
            this.legalIdXXTextBox.Size = new System.Drawing.Size(58, 26);
            this.legalIdXXTextBox.TabIndex = 2;
            this.legalIdXXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Location = new System.Drawing.Point(16, 229);
            this.businessNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(106, 20);
            this.businessNameLabel.TabIndex = 28;
            this.businessNameLabel.Text = "Organización:";
            // 
            // legalIdLabel
            // 
            this.legalIdLabel.AutoSize = true;
            this.legalIdLabel.Location = new System.Drawing.Point(16, 109);
            this.legalIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.legalIdLabel.Name = "legalIdLabel";
            this.legalIdLabel.Size = new System.Drawing.Size(91, 20);
            this.legalIdLabel.TabIndex = 42;
            this.legalIdLabel.Text = "CUIL/CUIT:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 149);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(69, 20);
            this.firstNameLabel.TabIndex = 26;
            this.firstNameLabel.Text = "Nombre:";
            // 
            // legalIdDNITextBox
            // 
            this.legalIdDNITextBox.Location = new System.Drawing.Point(202, 105);
            this.legalIdDNITextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.legalIdDNITextBox.Name = "legalIdDNITextBox";
            this.legalIdDNITextBox.Size = new System.Drawing.Size(235, 26);
            this.legalIdDNITextBox.TabIndex = 3;
            this.legalIdDNITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // businessDescriptionLabel
            // 
            this.businessDescriptionLabel.AutoSize = true;
            this.businessDescriptionLabel.Location = new System.Drawing.Point(16, 269);
            this.businessDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.businessDescriptionLabel.Name = "businessDescriptionLabel";
            this.businessDescriptionLabel.Size = new System.Drawing.Size(96, 20);
            this.businessDescriptionLabel.TabIndex = 29;
            this.businessDescriptionLabel.Text = "Descripción:";
            // 
            // legalIdYTextBox
            // 
            this.legalIdYTextBox.Location = new System.Drawing.Point(448, 105);
            this.legalIdYTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.legalIdYTextBox.Name = "legalIdYTextBox";
            this.legalIdYTextBox.Size = new System.Drawing.Size(58, 26);
            this.legalIdYTextBox.TabIndex = 4;
            this.legalIdYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(786, 846);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(120, 46);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Aceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // specialPanel
            // 
            this.specialPanel.Controls.Add(this.addCategoryButton);
            this.specialPanel.Controls.Add(this.seniorityLabel);
            this.specialPanel.Controls.Add(this.titleLabel);
            this.specialPanel.Controls.Add(this.deleteCategoryButton);
            this.specialPanel.Controls.Add(this.areaLabel);
            this.specialPanel.Controls.Add(this.categorySeniorityComboBox);
            this.specialPanel.Controls.Add(this.categoryTitleComboBox);
            this.specialPanel.Controls.Add(this.categoryAreaComboBox);
            this.specialPanel.Location = new System.Drawing.Point(30, 523);
            this.specialPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.specialPanel.Name = "specialPanel";
            this.specialPanel.Size = new System.Drawing.Size(300, 285);
            this.specialPanel.TabIndex = 4;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(60, 160);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(180, 46);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Text = "Agregar categoría";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            // 
            // seniorityLabel
            // 
            this.seniorityLabel.AutoSize = true;
            this.seniorityLabel.Location = new System.Drawing.Point(16, 111);
            this.seniorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seniorityLabel.Name = "seniorityLabel";
            this.seniorityLabel.Size = new System.Drawing.Size(95, 20);
            this.seniorityLabel.TabIndex = 35;
            this.seniorityLabel.Text = "Experiencia:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(16, 71);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(51, 20);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "Título:";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(60, 215);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(180, 46);
            this.deleteCategoryButton.TabIndex = 4;
            this.deleteCategoryButton.Text = "Eliminar categoría";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(16, 31);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(47, 20);
            this.areaLabel.TabIndex = 33;
            this.areaLabel.Text = "Área:";
            // 
            // categorySeniorityComboBox
            // 
            this.categorySeniorityComboBox.FormattingEnabled = true;
            this.categorySeniorityComboBox.Location = new System.Drawing.Point(123, 106);
            this.categorySeniorityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categorySeniorityComboBox.Name = "categorySeniorityComboBox";
            this.categorySeniorityComboBox.Size = new System.Drawing.Size(145, 28);
            this.categorySeniorityComboBox.TabIndex = 2;
            // 
            // categoryTitleComboBox
            // 
            this.categoryTitleComboBox.FormattingEnabled = true;
            this.categoryTitleComboBox.Location = new System.Drawing.Point(123, 66);
            this.categoryTitleComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryTitleComboBox.Name = "categoryTitleComboBox";
            this.categoryTitleComboBox.Size = new System.Drawing.Size(145, 28);
            this.categoryTitleComboBox.TabIndex = 1;
            // 
            // categoryAreaComboBox
            // 
            this.categoryAreaComboBox.FormattingEnabled = true;
            this.categoryAreaComboBox.Location = new System.Drawing.Point(123, 26);
            this.categoryAreaComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryAreaComboBox.Name = "categoryAreaComboBox";
            this.categoryAreaComboBox.Size = new System.Drawing.Size(145, 28);
            this.categoryAreaComboBox.TabIndex = 0;
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(90, 846);
            this.userButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(180, 46);
            this.userButton.TabIndex = 6;
            this.userButton.Text = "Registro de usuario";
            this.userButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 925);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.specialPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.contactPanel);
            this.Controls.Add(this.adressPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmployeeRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de empleado";
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Label imageUrlLabel;
        private System.Windows.Forms.TextBox imageUrlTextBox;
        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneCountryTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox phoneAreaTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Panel adressPanel;
        private System.Windows.Forms.TextBox adressZipCodeTextBox;
        private System.Windows.Forms.Label adressZipCodeLabel;
        private System.Windows.Forms.TextBox adressCountryTextBox;
        private System.Windows.Forms.Label adressFlatLabel;
        private System.Windows.Forms.TextBox adressProvinceTextBox;
        private System.Windows.Forms.TextBox adressCityTextBox;
        private System.Windows.Forms.Label adressStreetNumberLabel;
        private System.Windows.Forms.TextBox adressStreetTextBox;
        private System.Windows.Forms.TextBox adressStreetNumberTextBox;
        private System.Windows.Forms.Label adressStreetLabel;
        private System.Windows.Forms.TextBox adressFlatTextBox;
        private System.Windows.Forms.Label adressCountryLabel;
        private System.Windows.Forms.Label adressCityLabel;
        private System.Windows.Forms.Label adressProvinceLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label isPersonLabel;
        private System.Windows.Forms.Label activeStatusLabel;
        private System.Windows.Forms.CheckBox isPersonCheckBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox activeStatusCheckBox;
        private System.Windows.Forms.TextBox businessNameTextBox;
        private System.Windows.Forms.TextBox businessDescriptionTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox legalIdXXTextBox;
        private System.Windows.Forms.Label businessNameLabel;
        private System.Windows.Forms.Label legalIdLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox legalIdDNITextBox;
        private System.Windows.Forms.Label businessDescriptionLabel;
        private System.Windows.Forms.TextBox legalIdYTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel specialPanel;
        private System.Windows.Forms.ComboBox categoryAreaComboBox;
        private System.Windows.Forms.Label seniorityLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.ComboBox categorySeniorityComboBox;
        private System.Windows.Forms.ComboBox categoryTitleComboBox;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button userButton;
    }
}