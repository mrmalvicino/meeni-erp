namespace WindowsForms
{
    partial class ServiceRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRegisterForm));
            this.imagePanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.imageUrlTextBox = new System.Windows.Forms.TextBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.valuesPanel = new System.Windows.Forms.Panel();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.detailsComboBox = new System.Windows.Forms.ComboBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.activeStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.valuesPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.nextButton);
            this.imagePanel.Controls.Add(this.previousButton);
            this.imagePanel.Controls.Add(this.imageUrlLabel);
            this.imagePanel.Controls.Add(this.imageUrlTextBox);
            this.imagePanel.Controls.Add(this.profilePictureBox);
            this.imagePanel.Location = new System.Drawing.Point(22, 20);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(201, 285);
            this.imagePanel.TabIndex = 43;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(104, 184);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(37, 30);
            this.nextButton.TabIndex = 45;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(63, 184);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(36, 30);
            this.previousButton.TabIndex = 44;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(17, 232);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(95, 13);
            this.imageUrlLabel.TabIndex = 43;
            this.imageUrlLabel.Text = "URL de la imagen:";
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(19, 248);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(160, 20);
            this.imageUrlTextBox.TabIndex = 42;
            this.imageUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageUrlTextBox.Leave += new System.EventHandler(this.imageUrlTextBox_Leave);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(19, 16);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(160, 160);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 37;
            this.profilePictureBox.TabStop = false;
            // 
            // valuesPanel
            // 
            this.valuesPanel.Controls.Add(this.costTextBox);
            this.valuesPanel.Controls.Add(this.costLabel);
            this.valuesPanel.Controls.Add(this.priceLabel);
            this.valuesPanel.Controls.Add(this.priceTextBox);
            this.valuesPanel.Location = new System.Drawing.Point(242, 198);
            this.valuesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.valuesPanel.Name = "valuesPanel";
            this.valuesPanel.Size = new System.Drawing.Size(332, 106);
            this.valuesPanel.TabIndex = 42;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(135, 60);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(114, 20);
            this.costTextBox.TabIndex = 38;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(63, 62);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(37, 13);
            this.costLabel.TabIndex = 37;
            this.costLabel.Text = "Costo:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(63, 32);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 35;
            this.priceLabel.Text = "Precio:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(135, 30);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(114, 20);
            this.priceTextBox.TabIndex = 34;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.detailsComboBox);
            this.mainPanel.Controls.Add(this.detailsLabel);
            this.mainPanel.Controls.Add(this.categoryComboBox);
            this.mainPanel.Controls.Add(this.activeStatusCheckBox);
            this.mainPanel.Controls.Add(this.categoryLabel);
            this.mainPanel.Location = new System.Drawing.Point(242, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(332, 160);
            this.mainPanel.TabIndex = 40;
            // 
            // detailsComboBox
            // 
            this.detailsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.detailsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.detailsComboBox.FormattingEnabled = true;
            this.detailsComboBox.Location = new System.Drawing.Point(91, 77);
            this.detailsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.detailsComboBox.Name = "detailsComboBox";
            this.detailsComboBox.Size = new System.Drawing.Size(213, 21);
            this.detailsComboBox.TabIndex = 33;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(19, 80);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(48, 13);
            this.detailsLabel.TabIndex = 31;
            this.detailsLabel.Text = "Detalles:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(91, 46);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(213, 21);
            this.categoryComboBox.TabIndex = 14;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.AutoSize = true;
            this.activeStatusCheckBox.Checked = true;
            this.activeStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeStatusCheckBox.Location = new System.Drawing.Point(163, 16);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(56, 17);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(19, 48);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 13);
            this.categoryLabel.TabIndex = 29;
            this.categoryLabel.Text = "Categoría:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(494, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ServiceRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.valuesPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de servicio";
            this.Load += new System.EventHandler(this.ServiceRegisterForm_Load);
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.valuesPanel.ResumeLayout(false);
            this.valuesPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label imageUrlLabel;
        private System.Windows.Forms.TextBox imageUrlTextBox;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Panel valuesPanel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckBox activeStatusCheckBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox detailsComboBox;
    }
}