﻿namespace WindowsForms
{
    partial class QuoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteForm));
            this.listBox = new System.Windows.Forms.ListBox();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.jobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.variantVersionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.quoteIdTextBox = new System.Windows.Forms.TextBox();
            this.activeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.addingPanel = new System.Windows.Forms.Panel();
            this.serviceAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.serviceAmountTextBox = new System.Windows.Forms.TextBox();
            this.detailsComboBox = new System.Windows.Forms.ComboBox();
            this.adjustmentLabelTextBox = new System.Windows.Forms.TextBox();
            this.adjustmentTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabelTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addAdjustmentButton = new System.Windows.Forms.Button();
            this.productAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productAmountTextBox = new System.Windows.Forms.TextBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.serviceCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.serviceCategoryTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.eraseButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variantVersionNumericUpDown)).BeginInit();
            this.addingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmountNumericUpDown)).BeginInit();
            this.actionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(707, 132);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(952, 624);
            this.listBox.TabIndex = 0;
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productCategoryComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(127, 22);
            this.productCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(505, 31);
            this.productCategoryComboBox.TabIndex = 3;
            this.productCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.productCategoryComboBox_SelectedIndexChanged);
            this.productCategoryComboBox.TextChanged += new System.EventHandler(this.productCategoryComboBox_TextChanged);
            // 
            // brandComboBox
            // 
            this.brandComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(127, 61);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(505, 31);
            this.brandComboBox.TabIndex = 4;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            this.brandComboBox.TextChanged += new System.EventHandler(this.brandComboBox_TextChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(127, 101);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(505, 31);
            this.modelComboBox.TabIndex = 5;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            this.modelComboBox.TextChanged += new System.EventHandler(this.modelComboBox_TextChanged);
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productCategoryTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryTextBox.Location = new System.Drawing.Point(33, 26);
            this.productCategoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.ReadOnly = true;
            this.productCategoryTextBox.Size = new System.Drawing.Size(85, 23);
            this.productCategoryTextBox.TabIndex = 7;
            this.productCategoryTextBox.Text = "Rubro:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(33, 65);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(85, 23);
            this.brandTextBox.TabIndex = 8;
            this.brandTextBox.Text = "Marca:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(33, 104);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(85, 23);
            this.modelTextBox.TabIndex = 9;
            this.modelTextBox.Text = "Modelo:";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.customerTextBox);
            this.mainPanel.Controls.Add(this.jobDateTimePicker);
            this.mainPanel.Controls.Add(this.customerComboBox);
            this.mainPanel.Controls.Add(this.variantVersionNumericUpDown);
            this.mainPanel.Controls.Add(this.versionTextBox);
            this.mainPanel.Controls.Add(this.quoteIdTextBox);
            this.mainPanel.Controls.Add(this.activeStatusComboBox);
            this.mainPanel.Controls.Add(this.statusTextBox);
            this.mainPanel.Location = new System.Drawing.Point(20, 18);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(667, 222);
            this.mainPanel.TabIndex = 11;
            // 
            // customerTextBox
            // 
            this.customerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.customerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(33, 102);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(85, 23);
            this.customerTextBox.TabIndex = 31;
            this.customerTextBox.Text = "Cliente:";
            // 
            // jobDateTimePicker
            // 
            this.jobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobDateTimePicker.Location = new System.Drawing.Point(473, 32);
            this.jobDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.jobDateTimePicker.MaxDate = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            this.jobDateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.jobDateTimePicker.Name = "jobDateTimePicker";
            this.jobDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.jobDateTimePicker.TabIndex = 35;
            this.jobDateTimePicker.Value = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Items.AddRange(new object[] {
            "Rechazado",
            "Cotizado",
            "Señado",
            "Vendido"});
            this.customerComboBox.Location = new System.Drawing.Point(127, 98);
            this.customerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(505, 31);
            this.customerComboBox.TabIndex = 30;
            // 
            // variantVersionNumericUpDown
            // 
            this.variantVersionNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantVersionNumericUpDown.Location = new System.Drawing.Point(127, 138);
            this.variantVersionNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.variantVersionNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.variantVersionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.variantVersionNumericUpDown.Name = "variantVersionNumericUpDown";
            this.variantVersionNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.variantVersionNumericUpDown.TabIndex = 33;
            this.variantVersionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.variantVersionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // versionTextBox
            // 
            this.versionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.versionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTextBox.Location = new System.Drawing.Point(33, 140);
            this.versionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(85, 23);
            this.versionTextBox.TabIndex = 36;
            this.versionTextBox.Text = "Versión:";
            // 
            // quoteIdTextBox
            // 
            this.quoteIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.quoteIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quoteIdTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.quoteIdTextBox.Location = new System.Drawing.Point(33, 31);
            this.quoteIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quoteIdTextBox.Name = "quoteIdTextBox";
            this.quoteIdTextBox.ReadOnly = true;
            this.quoteIdTextBox.Size = new System.Drawing.Size(392, 29);
            this.quoteIdTextBox.TabIndex = 1;
            this.quoteIdTextBox.Text = "Cotización";
            // 
            // activeStatusComboBox
            // 
            this.activeStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeStatusComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatusComboBox.FormattingEnabled = true;
            this.activeStatusComboBox.Items.AddRange(new object[] {
            "Rechazado",
            "Cotizado",
            "Señado",
            "Vendido"});
            this.activeStatusComboBox.Location = new System.Drawing.Point(473, 138);
            this.activeStatusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.activeStatusComboBox.Name = "activeStatusComboBox";
            this.activeStatusComboBox.Size = new System.Drawing.Size(159, 31);
            this.activeStatusComboBox.TabIndex = 32;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(380, 142);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(85, 23);
            this.statusTextBox.TabIndex = 33;
            this.statusTextBox.Text = "Estado:";
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(433, 140);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(200, 43);
            this.addProductButton.TabIndex = 13;
            this.addProductButton.Text = "Agregar producto";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // addingPanel
            // 
            this.addingPanel.Controls.Add(this.serviceAmountNumericUpDown);
            this.addingPanel.Controls.Add(this.serviceAmountTextBox);
            this.addingPanel.Controls.Add(this.detailsComboBox);
            this.addingPanel.Controls.Add(this.adjustmentLabelTextBox);
            this.addingPanel.Controls.Add(this.adjustmentTextBox);
            this.addingPanel.Controls.Add(this.descriptionLabelTextBox);
            this.addingPanel.Controls.Add(this.descriptionTextBox);
            this.addingPanel.Controls.Add(this.addAdjustmentButton);
            this.addingPanel.Controls.Add(this.productAmountNumericUpDown);
            this.addingPanel.Controls.Add(this.productAmountTextBox);
            this.addingPanel.Controls.Add(this.addServiceButton);
            this.addingPanel.Controls.Add(this.serviceCategoryComboBox);
            this.addingPanel.Controls.Add(this.serviceCategoryTextBox);
            this.addingPanel.Controls.Add(this.detailsTextBox);
            this.addingPanel.Controls.Add(this.productCategoryComboBox);
            this.addingPanel.Controls.Add(this.addProductButton);
            this.addingPanel.Controls.Add(this.brandComboBox);
            this.addingPanel.Controls.Add(this.modelComboBox);
            this.addingPanel.Controls.Add(this.productCategoryTextBox);
            this.addingPanel.Controls.Add(this.modelTextBox);
            this.addingPanel.Controls.Add(this.brandTextBox);
            this.addingPanel.Location = new System.Drawing.Point(20, 258);
            this.addingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addingPanel.Name = "addingPanel";
            this.addingPanel.Size = new System.Drawing.Size(667, 498);
            this.addingPanel.TabIndex = 14;
            // 
            // serviceAmountNumericUpDown
            // 
            this.serviceAmountNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceAmountNumericUpDown.Location = new System.Drawing.Point(127, 308);
            this.serviceAmountNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.serviceAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.serviceAmountNumericUpDown.Name = "serviceAmountNumericUpDown";
            this.serviceAmountNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.serviceAmountNumericUpDown.TabIndex = 32;
            this.serviceAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serviceAmountTextBox
            // 
            this.serviceAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.serviceAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceAmountTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceAmountTextBox.Location = new System.Drawing.Point(33, 310);
            this.serviceAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceAmountTextBox.Name = "serviceAmountTextBox";
            this.serviceAmountTextBox.ReadOnly = true;
            this.serviceAmountTextBox.Size = new System.Drawing.Size(85, 23);
            this.serviceAmountTextBox.TabIndex = 31;
            this.serviceAmountTextBox.Text = "Cant.:";
            // 
            // detailsComboBox
            // 
            this.detailsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.detailsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.detailsComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsComboBox.FormattingEnabled = true;
            this.detailsComboBox.Location = new System.Drawing.Point(127, 261);
            this.detailsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailsComboBox.Name = "detailsComboBox";
            this.detailsComboBox.Size = new System.Drawing.Size(505, 31);
            this.detailsComboBox.TabIndex = 30;
            this.detailsComboBox.SelectedIndexChanged += new System.EventHandler(this.detailsComboBox_SelectedIndexChanged);
            this.detailsComboBox.TextChanged += new System.EventHandler(this.detailsComboBox_TextChanged);
            // 
            // adjustmentLabelTextBox
            // 
            this.adjustmentLabelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.adjustmentLabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adjustmentLabelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustmentLabelTextBox.Location = new System.Drawing.Point(33, 443);
            this.adjustmentLabelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adjustmentLabelTextBox.Name = "adjustmentLabelTextBox";
            this.adjustmentLabelTextBox.ReadOnly = true;
            this.adjustmentLabelTextBox.Size = new System.Drawing.Size(85, 23);
            this.adjustmentLabelTextBox.TabIndex = 29;
            this.adjustmentLabelTextBox.Text = "Monto: $";
            // 
            // adjustmentTextBox
            // 
            this.adjustmentTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustmentTextBox.Location = new System.Drawing.Point(127, 439);
            this.adjustmentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adjustmentTextBox.Name = "adjustmentTextBox";
            this.adjustmentTextBox.Size = new System.Drawing.Size(159, 30);
            this.adjustmentTextBox.TabIndex = 28;
            // 
            // descriptionLabelTextBox
            // 
            this.descriptionLabelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionLabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionLabelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabelTextBox.Location = new System.Drawing.Point(33, 398);
            this.descriptionLabelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionLabelTextBox.Name = "descriptionLabelTextBox";
            this.descriptionLabelTextBox.ReadOnly = true;
            this.descriptionLabelTextBox.Size = new System.Drawing.Size(85, 23);
            this.descriptionLabelTextBox.TabIndex = 27;
            this.descriptionLabelTextBox.Text = "Descrip.:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 394);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(505, 30);
            this.descriptionTextBox.TabIndex = 26;
            // 
            // addAdjustmentButton
            // 
            this.addAdjustmentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdjustmentButton.Location = new System.Drawing.Point(433, 433);
            this.addAdjustmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAdjustmentButton.Name = "addAdjustmentButton";
            this.addAdjustmentButton.Size = new System.Drawing.Size(200, 43);
            this.addAdjustmentButton.TabIndex = 25;
            this.addAdjustmentButton.Text = "Agregar ajuste";
            this.addAdjustmentButton.UseVisualStyleBackColor = true;
            this.addAdjustmentButton.Click += new System.EventHandler(this.addAdjustmentButton_Click);
            // 
            // productAmountNumericUpDown
            // 
            this.productAmountNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAmountNumericUpDown.Location = new System.Drawing.Point(127, 148);
            this.productAmountNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.productAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.productAmountNumericUpDown.Name = "productAmountNumericUpDown";
            this.productAmountNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.productAmountNumericUpDown.TabIndex = 24;
            this.productAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productAmountTextBox
            // 
            this.productAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productAmountTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAmountTextBox.Location = new System.Drawing.Point(33, 150);
            this.productAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productAmountTextBox.Name = "productAmountTextBox";
            this.productAmountTextBox.ReadOnly = true;
            this.productAmountTextBox.Size = new System.Drawing.Size(85, 23);
            this.productAmountTextBox.TabIndex = 23;
            this.productAmountTextBox.Text = "Cant.:";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceButton.Location = new System.Drawing.Point(433, 300);
            this.addServiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(200, 43);
            this.addServiceButton.TabIndex = 19;
            this.addServiceButton.Text = "Agregar servicio";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // serviceCategoryComboBox
            // 
            this.serviceCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.serviceCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serviceCategoryComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCategoryComboBox.FormattingEnabled = true;
            this.serviceCategoryComboBox.Location = new System.Drawing.Point(127, 222);
            this.serviceCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceCategoryComboBox.Name = "serviceCategoryComboBox";
            this.serviceCategoryComboBox.Size = new System.Drawing.Size(505, 31);
            this.serviceCategoryComboBox.TabIndex = 17;
            this.serviceCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceCategoryComboBox_SelectedIndexChanged);
            this.serviceCategoryComboBox.TextChanged += new System.EventHandler(this.serviceCategoryComboBox_TextChanged);
            // 
            // serviceCategoryTextBox
            // 
            this.serviceCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.serviceCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceCategoryTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCategoryTextBox.Location = new System.Drawing.Point(33, 225);
            this.serviceCategoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceCategoryTextBox.Name = "serviceCategoryTextBox";
            this.serviceCategoryTextBox.ReadOnly = true;
            this.serviceCategoryTextBox.Size = new System.Drawing.Size(85, 23);
            this.serviceCategoryTextBox.TabIndex = 18;
            this.serviceCategoryTextBox.Text = "Rubro:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.detailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTextBox.Location = new System.Drawing.Point(33, 265);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.Size = new System.Drawing.Size(85, 23);
            this.detailsTextBox.TabIndex = 16;
            this.detailsTextBox.Text = "Detalles:";
            // 
            // cleanButton
            // 
            this.cleanButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanButton.Location = new System.Drawing.Point(311, 25);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(4);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(160, 43);
            this.cleanButton.TabIndex = 14;
            this.cleanButton.Text = "Limpiar";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(33, 25);
            this.upButton.Margin = new System.Windows.Forms.Padding(4);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(47, 43);
            this.upButton.TabIndex = 20;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(88, 25);
            this.downButton.Margin = new System.Windows.Forms.Padding(4);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(47, 43);
            this.downButton.TabIndex = 21;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(760, 25);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 43);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.saveButton);
            this.actionsPanel.Controls.Add(this.eraseButton);
            this.actionsPanel.Controls.Add(this.downButton);
            this.actionsPanel.Controls.Add(this.cleanButton);
            this.actionsPanel.Controls.Add(this.upButton);
            this.actionsPanel.Location = new System.Drawing.Point(707, 18);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(953, 92);
            this.actionsPanel.TabIndex = 15;
            // 
            // eraseButton
            // 
            this.eraseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseButton.Location = new System.Drawing.Point(143, 25);
            this.eraseButton.Margin = new System.Windows.Forms.Padding(4);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(160, 43);
            this.eraseButton.TabIndex = 22;
            this.eraseButton.Text = "Borrar";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 777);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.addingPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotización";
            this.Load += new System.EventHandler(this.QuoteForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variantVersionNumericUpDown)).EndInit();
            this.addingPanel.ResumeLayout(false);
            this.addingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmountNumericUpDown)).EndInit();
            this.actionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox quoteIdTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Panel addingPanel;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.ComboBox serviceCategoryComboBox;
        private System.Windows.Forms.TextBox serviceCategoryTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.TextBox productAmountTextBox;
        private System.Windows.Forms.NumericUpDown productAmountNumericUpDown;
        private System.Windows.Forms.TextBox adjustmentLabelTextBox;
        private System.Windows.Forms.TextBox adjustmentTextBox;
        private System.Windows.Forms.TextBox descriptionLabelTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addAdjustmentButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox activeStatusComboBox;
        private System.Windows.Forms.DateTimePicker jobDateTimePicker;
        private System.Windows.Forms.ComboBox detailsComboBox;
        private System.Windows.Forms.NumericUpDown serviceAmountNumericUpDown;
        private System.Windows.Forms.TextBox serviceAmountTextBox;
        private System.Windows.Forms.NumericUpDown variantVersionNumericUpDown;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}