namespace WindowsForms
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.quoteIdTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.addingPanel = new System.Windows.Forms.Panel();
            this.eraseAllButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.serviceCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.serviceCategoryTextBox = new System.Windows.Forms.TextBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.warehouseComboBox = new System.Windows.Forms.ComboBox();
            this.warehouseTextBox = new System.Windows.Forms.TextBox();
            this.productAmountTextBox = new System.Windows.Forms.TextBox();
            this.productAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.descriptionValueTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabelTextBox = new System.Windows.Forms.TextBox();
            this.discountValueTextBox = new System.Windows.Forms.TextBox();
            this.discountLabelTextBox = new System.Windows.Forms.TextBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.serviceAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.serviceAmountTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.versionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eraseButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.addingPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(530, 107);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(715, 508);
            this.listBox.TabIndex = 0;
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(95, 52);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(380, 26);
            this.productCategoryComboBox.TabIndex = 3;
            // 
            // brandComboBox
            // 
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(95, 84);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(380, 26);
            this.brandComboBox.TabIndex = 4;
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(95, 116);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(380, 26);
            this.modelComboBox.TabIndex = 5;
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productCategoryTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryTextBox.Location = new System.Drawing.Point(25, 55);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.ReadOnly = true;
            this.productCategoryTextBox.Size = new System.Drawing.Size(64, 19);
            this.productCategoryTextBox.TabIndex = 7;
            this.productCategoryTextBox.Text = "Rubro:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(25, 87);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(64, 19);
            this.brandTextBox.TabIndex = 8;
            this.brandTextBox.Text = "Marca:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(25, 119);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(64, 19);
            this.modelTextBox.TabIndex = 9;
            this.modelTextBox.Text = "Modelo:";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.customerTextBox);
            this.mainPanel.Controls.Add(this.dateTimePicker);
            this.mainPanel.Controls.Add(this.customerComboBox);
            this.mainPanel.Controls.Add(this.versionNumericUpDown);
            this.mainPanel.Controls.Add(this.versionTextBox);
            this.mainPanel.Controls.Add(this.quoteIdTextBox);
            this.mainPanel.Controls.Add(this.statusComboBox);
            this.mainPanel.Controls.Add(this.statusTextBox);
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 180);
            this.mainPanel.TabIndex = 11;
            // 
            // quoteIdTextBox
            // 
            this.quoteIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.quoteIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quoteIdTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.quoteIdTextBox.Location = new System.Drawing.Point(25, 20);
            this.quoteIdTextBox.Name = "quoteIdTextBox";
            this.quoteIdTextBox.ReadOnly = true;
            this.quoteIdTextBox.Size = new System.Drawing.Size(294, 23);
            this.quoteIdTextBox.TabIndex = 1;
            this.quoteIdTextBox.Text = "Presupuesto N⁰ 0";
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(325, 148);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(150, 35);
            this.addProductButton.TabIndex = 13;
            this.addProductButton.Text = "Agregar producto";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // addingPanel
            // 
            this.addingPanel.Controls.Add(this.serviceAmountNumericUpDown);
            this.addingPanel.Controls.Add(this.serviceAmountTextBox);
            this.addingPanel.Controls.Add(this.nameComboBox);
            this.addingPanel.Controls.Add(this.discountLabelTextBox);
            this.addingPanel.Controls.Add(this.discountValueTextBox);
            this.addingPanel.Controls.Add(this.descriptionLabelTextBox);
            this.addingPanel.Controls.Add(this.descriptionValueTextBox);
            this.addingPanel.Controls.Add(this.addDiscountButton);
            this.addingPanel.Controls.Add(this.productAmountNumericUpDown);
            this.addingPanel.Controls.Add(this.productAmountTextBox);
            this.addingPanel.Controls.Add(this.warehouseComboBox);
            this.addingPanel.Controls.Add(this.warehouseTextBox);
            this.addingPanel.Controls.Add(this.addServiceButton);
            this.addingPanel.Controls.Add(this.serviceCategoryComboBox);
            this.addingPanel.Controls.Add(this.serviceCategoryTextBox);
            this.addingPanel.Controls.Add(this.nameTextBox);
            this.addingPanel.Controls.Add(this.productCategoryComboBox);
            this.addingPanel.Controls.Add(this.addProductButton);
            this.addingPanel.Controls.Add(this.brandComboBox);
            this.addingPanel.Controls.Add(this.modelComboBox);
            this.addingPanel.Controls.Add(this.productCategoryTextBox);
            this.addingPanel.Controls.Add(this.modelTextBox);
            this.addingPanel.Controls.Add(this.brandTextBox);
            this.addingPanel.Location = new System.Drawing.Point(15, 210);
            this.addingPanel.Name = "addingPanel";
            this.addingPanel.Size = new System.Drawing.Size(500, 405);
            this.addingPanel.TabIndex = 14;
            // 
            // eraseAllButton
            // 
            this.eraseAllButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseAllButton.Location = new System.Drawing.Point(233, 20);
            this.eraseAllButton.Name = "eraseAllButton";
            this.eraseAllButton.Size = new System.Drawing.Size(120, 35);
            this.eraseAllButton.TabIndex = 14;
            this.eraseAllButton.Text = "Borrar todo";
            this.eraseAllButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(25, 237);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(64, 19);
            this.nameTextBox.TabIndex = 16;
            this.nameTextBox.Text = "Nombre:";
            // 
            // serviceCategoryComboBox
            // 
            this.serviceCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceCategoryComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCategoryComboBox.FormattingEnabled = true;
            this.serviceCategoryComboBox.Location = new System.Drawing.Point(95, 202);
            this.serviceCategoryComboBox.Name = "serviceCategoryComboBox";
            this.serviceCategoryComboBox.Size = new System.Drawing.Size(380, 26);
            this.serviceCategoryComboBox.TabIndex = 17;
            // 
            // serviceCategoryTextBox
            // 
            this.serviceCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.serviceCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceCategoryTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCategoryTextBox.Location = new System.Drawing.Point(25, 205);
            this.serviceCategoryTextBox.Name = "serviceCategoryTextBox";
            this.serviceCategoryTextBox.ReadOnly = true;
            this.serviceCategoryTextBox.Size = new System.Drawing.Size(64, 19);
            this.serviceCategoryTextBox.TabIndex = 18;
            this.serviceCategoryTextBox.Text = "Rubro:";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceButton.Location = new System.Drawing.Point(325, 266);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(150, 35);
            this.addServiceButton.TabIndex = 19;
            this.addServiceButton.Text = "Agregar servicio";
            this.addServiceButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(25, 20);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(35, 35);
            this.upButton.TabIndex = 20;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(66, 20);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(35, 35);
            this.downButton.TabIndex = 21;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(570, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 35);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.saveButton);
            this.actionsPanel.Controls.Add(this.eraseButton);
            this.actionsPanel.Controls.Add(this.downButton);
            this.actionsPanel.Controls.Add(this.eraseAllButton);
            this.actionsPanel.Controls.Add(this.upButton);
            this.actionsPanel.Location = new System.Drawing.Point(530, 15);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(715, 75);
            this.actionsPanel.TabIndex = 15;
            // 
            // warehouseComboBox
            // 
            this.warehouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warehouseComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseComboBox.FormattingEnabled = true;
            this.warehouseComboBox.Location = new System.Drawing.Point(95, 20);
            this.warehouseComboBox.Name = "warehouseComboBox";
            this.warehouseComboBox.Size = new System.Drawing.Size(380, 26);
            this.warehouseComboBox.TabIndex = 20;
            // 
            // warehouseTextBox
            // 
            this.warehouseTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseTextBox.Location = new System.Drawing.Point(25, 23);
            this.warehouseTextBox.Name = "warehouseTextBox";
            this.warehouseTextBox.ReadOnly = true;
            this.warehouseTextBox.Size = new System.Drawing.Size(64, 19);
            this.warehouseTextBox.TabIndex = 21;
            this.warehouseTextBox.Text = "Depósito:";
            // 
            // productAmountTextBox
            // 
            this.productAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productAmountTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAmountTextBox.Location = new System.Drawing.Point(25, 156);
            this.productAmountTextBox.Name = "productAmountTextBox";
            this.productAmountTextBox.ReadOnly = true;
            this.productAmountTextBox.Size = new System.Drawing.Size(64, 19);
            this.productAmountTextBox.TabIndex = 23;
            this.productAmountTextBox.Text = "Cant.:";
            // 
            // productAmountNumericUpDown
            // 
            this.productAmountNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAmountNumericUpDown.Location = new System.Drawing.Point(95, 154);
            this.productAmountNumericUpDown.Name = "productAmountNumericUpDown";
            this.productAmountNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.productAmountNumericUpDown.TabIndex = 24;
            this.productAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountButton.Location = new System.Drawing.Point(325, 352);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(150, 35);
            this.addDiscountButton.TabIndex = 25;
            this.addDiscountButton.Text = "Agregar descuento";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            // 
            // descriptionValueTextBox
            // 
            this.descriptionValueTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionValueTextBox.Location = new System.Drawing.Point(95, 320);
            this.descriptionValueTextBox.Name = "descriptionValueTextBox";
            this.descriptionValueTextBox.Size = new System.Drawing.Size(380, 26);
            this.descriptionValueTextBox.TabIndex = 26;
            // 
            // descriptionLabelTextBox
            // 
            this.descriptionLabelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionLabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionLabelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabelTextBox.Location = new System.Drawing.Point(25, 323);
            this.descriptionLabelTextBox.Name = "descriptionLabelTextBox";
            this.descriptionLabelTextBox.ReadOnly = true;
            this.descriptionLabelTextBox.Size = new System.Drawing.Size(64, 19);
            this.descriptionLabelTextBox.TabIndex = 27;
            this.descriptionLabelTextBox.Text = "Descrip.:";
            // 
            // discountValueTextBox
            // 
            this.discountValueTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountValueTextBox.Location = new System.Drawing.Point(95, 357);
            this.discountValueTextBox.Name = "discountValueTextBox";
            this.discountValueTextBox.Size = new System.Drawing.Size(120, 26);
            this.discountValueTextBox.TabIndex = 28;
            // 
            // discountLabelTextBox
            // 
            this.discountLabelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.discountLabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountLabelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabelTextBox.Location = new System.Drawing.Point(25, 360);
            this.discountLabelTextBox.Name = "discountLabelTextBox";
            this.discountLabelTextBox.ReadOnly = true;
            this.discountLabelTextBox.Size = new System.Drawing.Size(64, 19);
            this.discountLabelTextBox.TabIndex = 29;
            this.discountLabelTextBox.Text = "Monto: $";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Items.AddRange(new object[] {
            "Cancelado",
            "Cotizado",
            "Señado",
            "Vendido"});
            this.customerComboBox.Location = new System.Drawing.Point(95, 80);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(380, 26);
            this.customerComboBox.TabIndex = 30;
            // 
            // customerTextBox
            // 
            this.customerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.customerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(25, 83);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(64, 19);
            this.customerTextBox.TabIndex = 31;
            this.customerTextBox.Text = "Cliente:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Cancelado",
            "Cotizado",
            "Señado",
            "Vendido"});
            this.statusComboBox.Location = new System.Drawing.Point(355, 112);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(120, 26);
            this.statusComboBox.TabIndex = 32;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(355, 23);
            this.dateTimePicker.MaxDate = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker.TabIndex = 35;
            this.dateTimePicker.Value = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(95, 234);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(380, 26);
            this.nameComboBox.TabIndex = 30;
            // 
            // serviceAmountNumericUpDown
            // 
            this.serviceAmountNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceAmountNumericUpDown.Location = new System.Drawing.Point(95, 272);
            this.serviceAmountNumericUpDown.Name = "serviceAmountNumericUpDown";
            this.serviceAmountNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.serviceAmountNumericUpDown.TabIndex = 32;
            this.serviceAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serviceAmountTextBox
            // 
            this.serviceAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.serviceAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceAmountTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceAmountTextBox.Location = new System.Drawing.Point(25, 274);
            this.serviceAmountTextBox.Name = "serviceAmountTextBox";
            this.serviceAmountTextBox.ReadOnly = true;
            this.serviceAmountTextBox.Size = new System.Drawing.Size(64, 19);
            this.serviceAmountTextBox.TabIndex = 31;
            this.serviceAmountTextBox.Text = "Cant.:";
            // 
            // versionTextBox
            // 
            this.versionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.versionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTextBox.Location = new System.Drawing.Point(25, 114);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(64, 19);
            this.versionTextBox.TabIndex = 36;
            this.versionTextBox.Text = "Versión:";
            // 
            // versionNumericUpDown
            // 
            this.versionNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNumericUpDown.Location = new System.Drawing.Point(95, 112);
            this.versionNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.versionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.versionNumericUpDown.Name = "versionNumericUpDown";
            this.versionNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.versionNumericUpDown.TabIndex = 33;
            this.versionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.versionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // eraseButton
            // 
            this.eraseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseButton.Location = new System.Drawing.Point(107, 20);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(120, 35);
            this.eraseButton.TabIndex = 22;
            this.eraseButton.Text = "Borrar";
            this.eraseButton.UseVisualStyleBackColor = true;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(285, 115);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(64, 19);
            this.statusTextBox.TabIndex = 33;
            this.statusTextBox.Text = "Estado:";
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 631);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.addingPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "QuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.QuoteForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addingPanel.ResumeLayout(false);
            this.addingPanel.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button eraseAllButton;
        private System.Windows.Forms.ComboBox serviceCategoryComboBox;
        private System.Windows.Forms.TextBox serviceCategoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.ComboBox warehouseComboBox;
        private System.Windows.Forms.TextBox warehouseTextBox;
        private System.Windows.Forms.TextBox productAmountTextBox;
        private System.Windows.Forms.NumericUpDown productAmountNumericUpDown;
        private System.Windows.Forms.TextBox discountLabelTextBox;
        private System.Windows.Forms.TextBox discountValueTextBox;
        private System.Windows.Forms.TextBox descriptionLabelTextBox;
        private System.Windows.Forms.TextBox descriptionValueTextBox;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.NumericUpDown serviceAmountNumericUpDown;
        private System.Windows.Forms.TextBox serviceAmountTextBox;
        private System.Windows.Forms.NumericUpDown versionNumericUpDown;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}