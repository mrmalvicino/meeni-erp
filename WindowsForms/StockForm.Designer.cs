namespace WindowsForms
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.productFilterTextBox = new System.Windows.Forms.TextBox();
            this.productFilterLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.warehouseFilterLabel = new System.Windows.Forms.Label();
            this.warehouseFilterTextBox = new System.Windows.Forms.TextBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.moveTextBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.warehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.warehouseIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.compartmentIdTextBox = new System.Windows.Forms.TextBox();
            this.compartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.actionsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.actionsPanel.Controls.Add(this.productFilterTextBox);
            this.actionsPanel.Controls.Add(this.productFilterLabel);
            this.actionsPanel.Controls.Add(this.filterButton);
            this.actionsPanel.Controls.Add(this.warehouseFilterLabel);
            this.actionsPanel.Controls.Add(this.warehouseFilterTextBox);
            this.actionsPanel.Controls.Add(this.toComboBox);
            this.actionsPanel.Controls.Add(this.fromComboBox);
            this.actionsPanel.Controls.Add(this.toLabel);
            this.actionsPanel.Controls.Add(this.fromLabel);
            this.actionsPanel.Controls.Add(this.moveTextBox);
            this.actionsPanel.Controls.Add(this.moveButton);
            this.actionsPanel.Controls.Add(this.stockTextBox);
            this.actionsPanel.Controls.Add(this.exportCSVButton);
            this.actionsPanel.Controls.Add(this.stockButton);
            this.actionsPanel.Location = new System.Drawing.Point(707, 18);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(953, 222);
            this.actionsPanel.TabIndex = 5;
            // 
            // productFilterTextBox
            // 
            this.productFilterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFilterTextBox.Location = new System.Drawing.Point(760, 160);
            this.productFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productFilterTextBox.Name = "productFilterTextBox";
            this.productFilterTextBox.Size = new System.Drawing.Size(159, 30);
            this.productFilterTextBox.TabIndex = 75;
            // 
            // productFilterLabel
            // 
            this.productFilterLabel.AutoSize = true;
            this.productFilterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFilterLabel.Location = new System.Drawing.Point(567, 164);
            this.productFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productFilterLabel.Name = "productFilterLabel";
            this.productFilterLabel.Size = new System.Drawing.Size(182, 23);
            this.productFilterLabel.TabIndex = 74;
            this.productFilterLabel.Text = "por N⁰ de producto:";
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(33, 154);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(160, 43);
            this.filterButton.TabIndex = 73;
            this.filterButton.Text = "Filtrar";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // warehouseFilterLabel
            // 
            this.warehouseFilterLabel.AutoSize = true;
            this.warehouseFilterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseFilterLabel.Location = new System.Drawing.Point(201, 164);
            this.warehouseFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseFilterLabel.Name = "warehouseFilterLabel";
            this.warehouseFilterLabel.Size = new System.Drawing.Size(180, 23);
            this.warehouseFilterLabel.TabIndex = 72;
            this.warehouseFilterLabel.Text = "por N⁰ de depósito:";
            // 
            // warehouseFilterTextBox
            // 
            this.warehouseFilterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseFilterTextBox.Location = new System.Drawing.Point(399, 160);
            this.warehouseFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseFilterTextBox.Name = "warehouseFilterTextBox";
            this.warehouseFilterTextBox.Size = new System.Drawing.Size(159, 30);
            this.warehouseFilterTextBox.TabIndex = 71;
            // 
            // toComboBox
            // 
            this.toComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(687, 98);
            this.toComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(232, 31);
            this.toComboBox.TabIndex = 14;
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(412, 98);
            this.fromComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(232, 31);
            this.fromComboBox.TabIndex = 13;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(656, 102);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(21, 23);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "a";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(369, 102);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(32, 23);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "de";
            // 
            // moveTextBox
            // 
            this.moveTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveTextBox.Location = new System.Drawing.Point(201, 98);
            this.moveTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.moveTextBox.Name = "moveTextBox";
            this.moveTextBox.Size = new System.Drawing.Size(159, 30);
            this.moveTextBox.TabIndex = 10;
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(33, 92);
            this.moveButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(160, 43);
            this.moveButton.TabIndex = 9;
            this.moveButton.Text = "Mover";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(201, 37);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(159, 30);
            this.stockTextBox.TabIndex = 4;
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
            // stockButton
            // 
            this.stockButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.Location = new System.Drawing.Point(33, 31);
            this.stockButton.Margin = new System.Windows.Forms.Padding(4);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(160, 43);
            this.stockButton.TabIndex = 0;
            this.stockButton.Text = "Ajustar stock";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.compartmentNameTextBox);
            this.mainPanel.Controls.Add(this.compartmentIdTextBox);
            this.mainPanel.Controls.Add(this.productNameTextBox);
            this.mainPanel.Controls.Add(this.productIdTextBox);
            this.mainPanel.Controls.Add(this.warehouseNameTextBox);
            this.mainPanel.Controls.Add(this.warehouseIdTextBox);
            this.mainPanel.Location = new System.Drawing.Point(20, 18);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(667, 222);
            this.mainPanel.TabIndex = 4;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(13, 123);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(628, 23);
            this.productNameTextBox.TabIndex = 7;
            this.productNameTextBox.Text = "ProductName";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productIdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.Location = new System.Drawing.Point(13, 92);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(628, 23);
            this.productIdTextBox.TabIndex = 6;
            this.productIdTextBox.Text = "ProductId";
            // 
            // warehouseNameTextBox
            // 
            this.warehouseNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameTextBox.Location = new System.Drawing.Point(13, 185);
            this.warehouseNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseNameTextBox.Name = "warehouseNameTextBox";
            this.warehouseNameTextBox.ReadOnly = true;
            this.warehouseNameTextBox.Size = new System.Drawing.Size(628, 23);
            this.warehouseNameTextBox.TabIndex = 5;
            this.warehouseNameTextBox.Text = "WarehouseName";
            // 
            // warehouseIdTextBox
            // 
            this.warehouseIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseIdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseIdTextBox.Location = new System.Drawing.Point(13, 154);
            this.warehouseIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseIdTextBox.Name = "warehouseIdTextBox";
            this.warehouseIdTextBox.ReadOnly = true;
            this.warehouseIdTextBox.Size = new System.Drawing.Size(628, 23);
            this.warehouseIdTextBox.TabIndex = 3;
            this.warehouseIdTextBox.Text = "WarehouseId";
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
            this.dataGridView.TabIndex = 3;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
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
            this.compartmentIdTextBox.TabIndex = 10;
            this.compartmentIdTextBox.Text = "CompartmentId";
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
            this.compartmentNameTextBox.TabIndex = 11;
            this.compartmentNameTextBox.Text = "CompartmentName";
            // 
            // StockForm
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
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button exportCSVButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TextBox moveTextBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox warehouseNameTextBox;
        private System.Windows.Forms.Label warehouseFilterLabel;
        private System.Windows.Forms.TextBox warehouseFilterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label productFilterLabel;
        private System.Windows.Forms.TextBox productFilterTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox warehouseIdTextBox;
        private System.Windows.Forms.TextBox compartmentIdTextBox;
        private System.Windows.Forms.TextBox compartmentNameTextBox;
    }
}