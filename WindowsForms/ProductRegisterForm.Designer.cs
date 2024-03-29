namespace WindowsForms
{
    partial class ProductRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegisterForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.activeStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.valuesPanel = new System.Windows.Forms.Panel();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.imageUrlTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.valuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.modelComboBox);
            this.mainPanel.Controls.Add(this.modelLabel);
            this.mainPanel.Controls.Add(this.brandComboBox);
            this.mainPanel.Controls.Add(this.brandLabel);
            this.mainPanel.Controls.Add(this.categoryComboBox);
            this.mainPanel.Controls.Add(this.activeStatusCheckBox);
            this.mainPanel.Controls.Add(this.categoryLabel);
            this.mainPanel.Location = new System.Drawing.Point(363, 30);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(498, 246);
            this.mainPanel.TabIndex = 12;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(137, 170);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(318, 28);
            this.modelComboBox.TabIndex = 32;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(29, 173);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(65, 20);
            this.modelLabel.TabIndex = 33;
            this.modelLabel.Text = "Modelo:";
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(137, 120);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(318, 28);
            this.brandComboBox.TabIndex = 30;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(29, 123);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(57, 20);
            this.brandLabel.TabIndex = 31;
            this.brandLabel.Text = "Marca:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(137, 71);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(318, 28);
            this.categoryComboBox.TabIndex = 14;
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.AutoSize = true;
            this.activeStatusCheckBox.Checked = true;
            this.activeStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeStatusCheckBox.Location = new System.Drawing.Point(245, 25);
            this.activeStatusCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(78, 24);
            this.activeStatusCheckBox.TabIndex = 0;
            this.activeStatusCheckBox.Text = "Activo";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(29, 74);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(82, 20);
            this.categoryLabel.TabIndex = 29;
            this.categoryLabel.Text = "Categoría:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(741, 491);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 46);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(202, 46);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(169, 26);
            this.priceTextBox.TabIndex = 34;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(94, 49);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 20);
            this.priceLabel.TabIndex = 35;
            this.priceLabel.Text = "Precio:";
            // 
            // valuesPanel
            // 
            this.valuesPanel.Controls.Add(this.costTextBox);
            this.valuesPanel.Controls.Add(this.costLabel);
            this.valuesPanel.Controls.Add(this.priceLabel);
            this.valuesPanel.Controls.Add(this.priceTextBox);
            this.valuesPanel.Location = new System.Drawing.Point(363, 305);
            this.valuesPanel.Name = "valuesPanel";
            this.valuesPanel.Size = new System.Drawing.Size(498, 163);
            this.valuesPanel.TabIndex = 36;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(202, 93);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(169, 26);
            this.costTextBox.TabIndex = 38;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(94, 96);
            this.costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(55, 20);
            this.costLabel.TabIndex = 37;
            this.costLabel.Text = "Costo:";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(29, 25);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(240, 246);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 37;
            this.profilePictureBox.TabStop = false;
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.nextButton);
            this.imagePanel.Controls.Add(this.previousButton);
            this.imagePanel.Controls.Add(this.imageUrlLabel);
            this.imagePanel.Controls.Add(this.imageUrlTextBox);
            this.imagePanel.Controls.Add(this.profilePictureBox);
            this.imagePanel.Location = new System.Drawing.Point(33, 30);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(302, 438);
            this.imagePanel.TabIndex = 39;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(156, 283);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(55, 46);
            this.nextButton.TabIndex = 45;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(94, 283);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(54, 46);
            this.previousButton.TabIndex = 44;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(25, 357);
            this.imageUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(140, 20);
            this.imageUrlLabel.TabIndex = 43;
            this.imageUrlLabel.Text = "URL de la imagen:";
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(29, 382);
            this.imageUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(238, 26);
            this.imageUrlTextBox.TabIndex = 42;
            this.imageUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageUrlTextBox.Leave += new System.EventHandler(this.imageUrlTextBox_Leave);
            // 
            // ProductRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.valuesPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProductRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de producto";
            this.Load += new System.EventHandler(this.ProductRegisterForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.valuesPanel.ResumeLayout(false);
            this.valuesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox activeStatusCheckBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Panel valuesPanel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label imageUrlLabel;
        private System.Windows.Forms.TextBox imageUrlTextBox;
    }
}