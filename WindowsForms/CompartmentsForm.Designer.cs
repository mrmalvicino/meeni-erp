namespace WindowsForms
{
    partial class CompartmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompartmentsForm));
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.showInactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.showActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.compartmentComboBox = new System.Windows.Forms.ComboBox();
            this.warehouseComboBox = new System.Windows.Forms.ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.moveButton = new System.Windows.Forms.Button();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.compartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.compartmentIdTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.warehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.actionsPanel.Controls.Add(this.amountNumericUpDown);
            this.actionsPanel.Controls.Add(this.showInactiveCheckBox);
            this.actionsPanel.Controls.Add(this.showActiveCheckBox);
            this.actionsPanel.Controls.Add(this.clearButton);
            this.actionsPanel.Controls.Add(this.filterLabel);
            this.actionsPanel.Controls.Add(this.filterTextBox);
            this.actionsPanel.Controls.Add(this.amountLabel);
            this.actionsPanel.Controls.Add(this.deleteButton);
            this.actionsPanel.Controls.Add(this.editButton);
            this.actionsPanel.Controls.Add(this.newButton);
            this.actionsPanel.Controls.Add(this.compartmentComboBox);
            this.actionsPanel.Controls.Add(this.warehouseComboBox);
            this.actionsPanel.Controls.Add(this.toLabel);
            this.actionsPanel.Controls.Add(this.moveButton);
            this.actionsPanel.Controls.Add(this.exportCSVButton);
            this.actionsPanel.Location = new System.Drawing.Point(707, 18);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(953, 222);
            this.actionsPanel.TabIndex = 2;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Location = new System.Drawing.Point(298, 100);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.amountNumericUpDown.TabIndex = 83;
            this.amountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showInactiveCheckBox
            // 
            this.showInactiveCheckBox.AutoSize = true;
            this.showInactiveCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInactiveCheckBox.Location = new System.Drawing.Point(619, 163);
            this.showInactiveCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.showInactiveCheckBox.Name = "showInactiveCheckBox";
            this.showInactiveCheckBox.Size = new System.Drawing.Size(109, 27);
            this.showInactiveCheckBox.TabIndex = 10;
            this.showInactiveCheckBox.Text = "Inactivos";
            this.showInactiveCheckBox.UseVisualStyleBackColor = true;
            this.showInactiveCheckBox.CheckedChanged += new System.EventHandler(this.showInactiveCheckBox_CheckedChanged);
            // 
            // showActiveCheckBox
            // 
            this.showActiveCheckBox.AutoSize = true;
            this.showActiveCheckBox.Checked = true;
            this.showActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showActiveCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showActiveCheckBox.Location = new System.Drawing.Point(499, 163);
            this.showActiveCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.showActiveCheckBox.Name = "showActiveCheckBox";
            this.showActiveCheckBox.Size = new System.Drawing.Size(95, 27);
            this.showActiveCheckBox.TabIndex = 9;
            this.showActiveCheckBox.Text = "Activos";
            this.showActiveCheckBox.UseVisualStyleBackColor = true;
            this.showActiveCheckBox.CheckedChanged += new System.EventHandler(this.showActiveCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(760, 154);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 43);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(29, 164);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(60, 23);
            this.filterLabel.TabIndex = 82;
            this.filterLabel.Text = "Filtro:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(115, 161);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(359, 30);
            this.filterTextBox.TabIndex = 8;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(201, 102);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(90, 23);
            this.amountLabel.TabIndex = 77;
            this.amountLabel.Text = "cantidad:";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(369, 31);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 43);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(201, 31);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(160, 43);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(33, 31);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(160, 43);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // compartmentComboBox
            // 
            this.compartmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.compartmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.compartmentComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compartmentComboBox.FormattingEnabled = true;
            this.compartmentComboBox.Location = new System.Drawing.Point(720, 99);
            this.compartmentComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.compartmentComboBox.Name = "compartmentComboBox";
            this.compartmentComboBox.Size = new System.Drawing.Size(200, 31);
            this.compartmentComboBox.TabIndex = 7;
            // 
            // warehouseComboBox
            // 
            this.warehouseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.warehouseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.warehouseComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseComboBox.FormattingEnabled = true;
            this.warehouseComboBox.Location = new System.Drawing.Point(512, 99);
            this.warehouseComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseComboBox.Name = "warehouseComboBox";
            this.warehouseComboBox.Size = new System.Drawing.Size(200, 31);
            this.warehouseComboBox.TabIndex = 6;
            this.warehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.warehouseComboBox_SelectedIndexChanged);
            this.warehouseComboBox.TextChanged += new System.EventHandler(this.warehouseComboBox_TextChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(425, 102);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(79, 23);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "destino:";
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(33, 92);
            this.moveButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(160, 43);
            this.moveButton.TabIndex = 4;
            this.moveButton.Text = "Mover";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCSVButton.Location = new System.Drawing.Point(760, 31);
            this.exportCSVButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(160, 43);
            this.exportCSVButton.TabIndex = 3;
            this.exportCSVButton.Text = "Exportar CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.compartmentNameTextBox);
            this.mainPanel.Controls.Add(this.compartmentIdTextBox);
            this.mainPanel.Controls.Add(this.productNameTextBox);
            this.mainPanel.Controls.Add(this.warehouseNameTextBox);
            this.mainPanel.Location = new System.Drawing.Point(20, 18);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(667, 222);
            this.mainPanel.TabIndex = 1;
            // 
            // compartmentNameTextBox
            // 
            this.compartmentNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.compartmentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compartmentNameTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compartmentNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.compartmentNameTextBox.Location = new System.Drawing.Point(13, 50);
            this.compartmentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.compartmentNameTextBox.Name = "compartmentNameTextBox";
            this.compartmentNameTextBox.ReadOnly = true;
            this.compartmentNameTextBox.Size = new System.Drawing.Size(392, 29);
            this.compartmentNameTextBox.TabIndex = 1;
            this.compartmentNameTextBox.Text = "CompartmentName";
            // 
            // compartmentIdTextBox
            // 
            this.compartmentIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.compartmentIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compartmentIdTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compartmentIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.compartmentIdTextBox.Location = new System.Drawing.Point(13, 13);
            this.compartmentIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.compartmentIdTextBox.Name = "compartmentIdTextBox";
            this.compartmentIdTextBox.ReadOnly = true;
            this.compartmentIdTextBox.Size = new System.Drawing.Size(392, 29);
            this.compartmentIdTextBox.TabIndex = 0;
            this.compartmentIdTextBox.Text = "CompartmentId";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(13, 118);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(628, 23);
            this.productNameTextBox.TabIndex = 3;
            this.productNameTextBox.Text = "ProductName";
            // 
            // warehouseNameTextBox
            // 
            this.warehouseNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameTextBox.Location = new System.Drawing.Point(13, 87);
            this.warehouseNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseNameTextBox.Name = "warehouseNameTextBox";
            this.warehouseNameTextBox.ReadOnly = true;
            this.warehouseNameTextBox.Size = new System.Drawing.Size(628, 23);
            this.warehouseNameTextBox.TabIndex = 5;
            this.warehouseNameTextBox.Text = "WarehouseName";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(20, 258);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1640, 498);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // CompartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 777);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CompartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compartimientos en depósito";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button exportCSVButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.ComboBox compartmentComboBox;
        private System.Windows.Forms.ComboBox warehouseComboBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox warehouseNameTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox compartmentIdTextBox;
        private System.Windows.Forms.TextBox compartmentNameTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.CheckBox showInactiveCheckBox;
        private System.Windows.Forms.CheckBox showActiveCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}