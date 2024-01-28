namespace WindowsForms
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
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.adressCountryTextBox = new System.Windows.Forms.TextBox();
            this.flatLabel = new System.Windows.Forms.Label();
            this.adressProvinceTextBox = new System.Windows.Forms.TextBox();
            this.adressCityTextBox = new System.Windows.Forms.TextBox();
            this.streetNumberLabel = new System.Windows.Forms.Label();
            this.adressStreetTextBox = new System.Windows.Forms.TextBox();
            this.adressStreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.adressFlatTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.activeStatuslabel = new System.Windows.Forms.Label();
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
            this.saveButton = new System.Windows.Forms.Button();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contactPanel.SuspendLayout();
            this.adressPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Controls.Add(this.loadImageButton);
            this.imagePanel.Controls.Add(this.imageUrlLabel);
            this.imagePanel.Controls.Add(this.imageUrlTextBox);
            this.imagePanel.Location = new System.Drawing.Point(20, 20);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(200, 300);
            this.imagePanel.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(20, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(160, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 39;
            this.pictureBox.TabStop = false;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(60, 254);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(80, 30);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Cargar";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(17, 203);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(125, 13);
            this.imageUrlLabel.TabIndex = 41;
            this.imageUrlLabel.Text = "URL o ruta de la imagen:";
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(20, 219);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(160, 20);
            this.imageUrlTextBox.TabIndex = 1;
            this.imageUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageUrlTextBox.Leave += new System.EventHandler(this.imageUrlTextBox_Leave);
            // 
            // contactPanel
            // 
            this.contactPanel.Controls.Add(this.emailTextBox);
            this.contactPanel.Controls.Add(this.phoneCountryTextBox);
            this.contactPanel.Controls.Add(this.phoneNumberTextBox);
            this.contactPanel.Controls.Add(this.phoneAreaTextBox);
            this.contactPanel.Controls.Add(this.emailLabel);
            this.contactPanel.Controls.Add(this.phoneLabel);
            this.contactPanel.Location = new System.Drawing.Point(240, 250);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(364, 70);
            this.contactPanel.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(89, 12);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneCountryTextBox
            // 
            this.phoneCountryTextBox.Location = new System.Drawing.Point(89, 38);
            this.phoneCountryTextBox.Name = "phoneCountryTextBox";
            this.phoneCountryTextBox.Size = new System.Drawing.Size(40, 20);
            this.phoneCountryTextBox.TabIndex = 1;
            this.phoneCountryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneCountryTextBox.TextChanged += new System.EventHandler(this.phoneCountryTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(181, 38);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(158, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // phoneAreaTextBox
            // 
            this.phoneAreaTextBox.Location = new System.Drawing.Point(135, 38);
            this.phoneAreaTextBox.Name = "phoneAreaTextBox";
            this.phoneAreaTextBox.Size = new System.Drawing.Size(40, 20);
            this.phoneAreaTextBox.TabIndex = 2;
            this.phoneAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneAreaTextBox.TextChanged += new System.EventHandler(this.phoneAreaTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 15);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(11, 41);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneLabel.TabIndex = 31;
            this.phoneLabel.Text = "Teléfono:";
            // 
            // adressPanel
            // 
            this.adressPanel.Controls.Add(this.adressZipCodeTextBox);
            this.adressPanel.Controls.Add(this.zipCodeLabel);
            this.adressPanel.Controls.Add(this.adressCountryTextBox);
            this.adressPanel.Controls.Add(this.flatLabel);
            this.adressPanel.Controls.Add(this.adressProvinceTextBox);
            this.adressPanel.Controls.Add(this.adressCityTextBox);
            this.adressPanel.Controls.Add(this.streetNumberLabel);
            this.adressPanel.Controls.Add(this.adressStreetTextBox);
            this.adressPanel.Controls.Add(this.adressStreetNumberTextBox);
            this.adressPanel.Controls.Add(this.streetLabel);
            this.adressPanel.Controls.Add(this.adressFlatTextBox);
            this.adressPanel.Controls.Add(this.countryLabel);
            this.adressPanel.Controls.Add(this.cityLabel);
            this.adressPanel.Controls.Add(this.provinceLabel);
            this.adressPanel.Location = new System.Drawing.Point(240, 340);
            this.adressPanel.Name = "adressPanel";
            this.adressPanel.Size = new System.Drawing.Size(364, 185);
            this.adressPanel.TabIndex = 7;
            // 
            // adressZipCodeTextBox
            // 
            this.adressZipCodeTextBox.Location = new System.Drawing.Point(89, 95);
            this.adressZipCodeTextBox.Name = "adressZipCodeTextBox";
            this.adressZipCodeTextBox.Size = new System.Drawing.Size(250, 20);
            this.adressZipCodeTextBox.TabIndex = 3;
            this.adressZipCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(11, 98);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(63, 13);
            this.zipCodeLabel.TabIndex = 39;
            this.zipCodeLabel.Text = "Cod. postal:";
            // 
            // adressCountryTextBox
            // 
            this.adressCountryTextBox.Location = new System.Drawing.Point(89, 17);
            this.adressCountryTextBox.Name = "adressCountryTextBox";
            this.adressCountryTextBox.Size = new System.Drawing.Size(250, 20);
            this.adressCountryTextBox.TabIndex = 0;
            this.adressCountryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(11, 150);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(42, 13);
            this.flatLabel.TabIndex = 37;
            this.flatLabel.Text = "Depto.:";
            // 
            // adressProvinceTextBox
            // 
            this.adressProvinceTextBox.Location = new System.Drawing.Point(89, 43);
            this.adressProvinceTextBox.Name = "adressProvinceTextBox";
            this.adressProvinceTextBox.Size = new System.Drawing.Size(250, 20);
            this.adressProvinceTextBox.TabIndex = 1;
            this.adressProvinceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressCityTextBox
            // 
            this.adressCityTextBox.Location = new System.Drawing.Point(89, 69);
            this.adressCityTextBox.Name = "adressCityTextBox";
            this.adressCityTextBox.Size = new System.Drawing.Size(250, 20);
            this.adressCityTextBox.TabIndex = 2;
            this.adressCityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetNumberLabel
            // 
            this.streetNumberLabel.AutoSize = true;
            this.streetNumberLabel.Location = new System.Drawing.Point(200, 124);
            this.streetNumberLabel.Name = "streetNumberLabel";
            this.streetNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.streetNumberLabel.TabIndex = 36;
            this.streetNumberLabel.Text = "Núm.:";
            // 
            // adressStreetTextBox
            // 
            this.adressStreetTextBox.Location = new System.Drawing.Point(89, 121);
            this.adressStreetTextBox.Name = "adressStreetTextBox";
            this.adressStreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressStreetTextBox.TabIndex = 4;
            this.adressStreetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressStreetNumberTextBox
            // 
            this.adressStreetNumberTextBox.Location = new System.Drawing.Point(239, 121);
            this.adressStreetNumberTextBox.Name = "adressStreetNumberTextBox";
            this.adressStreetNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressStreetNumberTextBox.TabIndex = 5;
            this.adressStreetNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adressStreetNumberTextBox.TextChanged += new System.EventHandler(this.adressStreetNumberTextBox_TextChanged);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(11, 124);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(33, 13);
            this.streetLabel.TabIndex = 35;
            this.streetLabel.Text = "Calle:";
            // 
            // adressFlatTextBox
            // 
            this.adressFlatTextBox.Location = new System.Drawing.Point(89, 147);
            this.adressFlatTextBox.Name = "adressFlatTextBox";
            this.adressFlatTextBox.Size = new System.Drawing.Size(250, 20);
            this.adressFlatTextBox.TabIndex = 6;
            this.adressFlatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(11, 20);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(32, 13);
            this.countryLabel.TabIndex = 32;
            this.countryLabel.Text = "País:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(11, 72);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 13);
            this.cityLabel.TabIndex = 34;
            this.cityLabel.Text = "Ciudad:";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(11, 46);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(54, 13);
            this.provinceLabel.TabIndex = 33;
            this.provinceLabel.Text = "Provincia:";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.activeStatuslabel);
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
            this.mainPanel.Location = new System.Drawing.Point(240, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(364, 210);
            this.mainPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Destildar si es una organización o empresa:";
            // 
            // activeStatuslabel
            // 
            this.activeStatuslabel.AutoSize = true;
            this.activeStatuslabel.Location = new System.Drawing.Point(11, 19);
            this.activeStatuslabel.Name = "activeStatuslabel";
            this.activeStatuslabel.Size = new System.Drawing.Size(149, 13);
            this.activeStatuslabel.TabIndex = 45;
            this.activeStatuslabel.Text = "Destildar si está dado de baja:";
            // 
            // isPersonCheckBox
            // 
            this.isPersonCheckBox.AutoSize = true;
            this.isPersonCheckBox.Location = new System.Drawing.Point(245, 41);
            this.isPersonCheckBox.Name = "isPersonCheckBox";
            this.isPersonCheckBox.Size = new System.Drawing.Size(94, 17);
            this.isPersonCheckBox.TabIndex = 1;
            this.isPersonCheckBox.Text = "Persona física";
            this.isPersonCheckBox.UseVisualStyleBackColor = true;
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
            this.activeStatusCheckBox.Location = new System.Drawing.Point(245, 18);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(56, 17);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.Location = new System.Drawing.Point(89, 146);
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.businessNameTextBox.TabIndex = 7;
            this.businessNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // businessDescriptionTextBox
            // 
            this.businessDescriptionTextBox.Location = new System.Drawing.Point(89, 172);
            this.businessDescriptionTextBox.Name = "businessDescriptionTextBox";
            this.businessDescriptionTextBox.Size = new System.Drawing.Size(250, 20);
            this.businessDescriptionTextBox.TabIndex = 8;
            this.businessDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // legalIdXXTextBox
            // 
            this.legalIdXXTextBox.Location = new System.Drawing.Point(89, 68);
            this.legalIdXXTextBox.Name = "legalIdXXTextBox";
            this.legalIdXXTextBox.Size = new System.Drawing.Size(40, 20);
            this.legalIdXXTextBox.TabIndex = 2;
            this.legalIdXXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Location = new System.Drawing.Point(11, 149);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(72, 13);
            this.businessNameLabel.TabIndex = 28;
            this.businessNameLabel.Text = "Organización:";
            // 
            // legalIdLabel
            // 
            this.legalIdLabel.AutoSize = true;
            this.legalIdLabel.Location = new System.Drawing.Point(11, 71);
            this.legalIdLabel.Name = "legalIdLabel";
            this.legalIdLabel.Size = new System.Drawing.Size(64, 13);
            this.legalIdLabel.TabIndex = 42;
            this.legalIdLabel.Text = "CUIL/CUIT:";
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
            // legalIdDNITextBox
            // 
            this.legalIdDNITextBox.Location = new System.Drawing.Point(135, 68);
            this.legalIdDNITextBox.Name = "legalIdDNITextBox";
            this.legalIdDNITextBox.Size = new System.Drawing.Size(158, 20);
            this.legalIdDNITextBox.TabIndex = 3;
            this.legalIdDNITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.legalIdDNITextBox.TextChanged += new System.EventHandler(this.legalIdDNITextBox_TextChanged);
            // 
            // businessDescriptionLabel
            // 
            this.businessDescriptionLabel.AutoSize = true;
            this.businessDescriptionLabel.Location = new System.Drawing.Point(11, 175);
            this.businessDescriptionLabel.Name = "businessDescriptionLabel";
            this.businessDescriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.businessDescriptionLabel.TabIndex = 29;
            this.businessDescriptionLabel.Text = "Descripción:";
            // 
            // legalIdYTextBox
            // 
            this.legalIdYTextBox.Location = new System.Drawing.Point(299, 68);
            this.legalIdYTextBox.Name = "legalIdYTextBox";
            this.legalIdYTextBox.Size = new System.Drawing.Size(40, 20);
            this.legalIdYTextBox.TabIndex = 4;
            this.legalIdYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(524, 550);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SupplierRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
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
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contactPanel.ResumeLayout(false);
            this.contactPanel.PerformLayout();
            this.adressPanel.ResumeLayout(false);
            this.adressPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox adressCountryTextBox;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.TextBox adressProvinceTextBox;
        private System.Windows.Forms.TextBox adressCityTextBox;
        private System.Windows.Forms.Label streetNumberLabel;
        private System.Windows.Forms.TextBox adressStreetTextBox;
        private System.Windows.Forms.TextBox adressStreetNumberTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox adressFlatTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activeStatuslabel;
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
        private System.Windows.Forms.Button saveButton;
    }
}