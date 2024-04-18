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
            this.imagePanel.Location = new System.Drawing.Point(29, 25);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(268, 351);
            this.imagePanel.TabIndex = 43;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(139, 226);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(49, 37);
            this.nextButton.TabIndex = 45;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(84, 226);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(48, 37);
            this.previousButton.TabIndex = 44;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(23, 286);
            this.imageUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(118, 16);
            this.imageUrlLabel.TabIndex = 43;
            this.imageUrlLabel.Text = "URL de la imagen:";
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(25, 305);
            this.imageUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(212, 22);
            this.imageUrlTextBox.TabIndex = 42;
            this.imageUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageUrlTextBox.Leave += new System.EventHandler(this.imageUrlTextBox_Leave);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(25, 20);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(213, 197);
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
            this.valuesPanel.Location = new System.Drawing.Point(323, 244);
            this.valuesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valuesPanel.Name = "valuesPanel";
            this.valuesPanel.Size = new System.Drawing.Size(443, 130);
            this.valuesPanel.TabIndex = 42;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(180, 74);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(151, 22);
            this.costTextBox.TabIndex = 38;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(84, 76);
            this.costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(45, 16);
            this.costLabel.TabIndex = 37;
            this.costLabel.Text = "Costo:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(84, 39);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 16);
            this.priceLabel.TabIndex = 35;
            this.priceLabel.Text = "Precio:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(180, 37);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(151, 22);
            this.priceTextBox.TabIndex = 34;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.detailsComboBox);
            this.mainPanel.Controls.Add(this.detailsLabel);
            this.mainPanel.Controls.Add(this.categoryComboBox);
            this.mainPanel.Controls.Add(this.activeStatusCheckBox);
            this.mainPanel.Controls.Add(this.categoryLabel);
            this.mainPanel.Location = new System.Drawing.Point(323, 25);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(443, 197);
            this.mainPanel.TabIndex = 40;
            // 
            // detailsComboBox
            // 
            this.detailsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.detailsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.detailsComboBox.FormattingEnabled = true;
            this.detailsComboBox.Location = new System.Drawing.Point(121, 95);
            this.detailsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailsComboBox.Name = "detailsComboBox";
            this.detailsComboBox.Size = new System.Drawing.Size(283, 24);
            this.detailsComboBox.TabIndex = 33;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(25, 98);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(60, 16);
            this.detailsLabel.TabIndex = 31;
            this.detailsLabel.Text = "Detalles:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(121, 57);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(283, 24);
            this.categoryComboBox.TabIndex = 14;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            this.categoryComboBox.TextChanged += new System.EventHandler(this.categoryComboBox_TextChanged);
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.AutoSize = true;
            this.activeStatusCheckBox.Checked = true;
            this.activeStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeStatusCheckBox.Location = new System.Drawing.Point(217, 20);
            this.activeStatusCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(66, 20);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(25, 59);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 16);
            this.categoryLabel.TabIndex = 29;
            this.categoryLabel.Text = "Categoría:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(659, 393);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 37);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ServiceRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 454);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.valuesPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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