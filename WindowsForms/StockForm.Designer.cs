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
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.warehouseIdTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.moveTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.warehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.warehouseFilterLabel = new System.Windows.Forms.Label();
            this.warehouseFilterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.productFilterLabel = new System.Windows.Forms.Label();
            this.productFilterTextBox = new System.Windows.Forms.TextBox();
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
            this.actionsPanel.Location = new System.Drawing.Point(530, 15);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(715, 180);
            this.actionsPanel.TabIndex = 5;
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCSVButton.Location = new System.Drawing.Point(570, 25);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(120, 35);
            this.exportCSVButton.TabIndex = 3;
            this.exportCSVButton.Text = "Exportar CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            // 
            // stockButton
            // 
            this.stockButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.Location = new System.Drawing.Point(25, 25);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(120, 35);
            this.stockButton.TabIndex = 0;
            this.stockButton.Text = "Ajustar stock";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.warehouseNameTextBox);
            this.mainPanel.Controls.Add(this.productNameTextBox);
            this.mainPanel.Controls.Add(this.warehouseIdTextBox);
            this.mainPanel.Controls.Add(this.productIdTextBox);
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 180);
            this.mainPanel.TabIndex = 4;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productIdTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productIdTextBox.Location = new System.Drawing.Point(10, 10);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(471, 23);
            this.productIdTextBox.TabIndex = 1;
            this.productIdTextBox.Text = "ProductId";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(15, 210);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1230, 405);
            this.dataGridView.TabIndex = 3;
            // 
            // warehouseIdTextBox
            // 
            this.warehouseIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseIdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseIdTextBox.Location = new System.Drawing.Point(10, 68);
            this.warehouseIdTextBox.Name = "warehouseIdTextBox";
            this.warehouseIdTextBox.ReadOnly = true;
            this.warehouseIdTextBox.Size = new System.Drawing.Size(471, 19);
            this.warehouseIdTextBox.TabIndex = 3;
            this.warehouseIdTextBox.Text = "WarehouseId";
            // 
            // stockTextBox
            // 
            this.stockTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(151, 30);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(120, 26);
            this.stockTextBox.TabIndex = 4;
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(25, 75);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(120, 35);
            this.moveButton.TabIndex = 9;
            this.moveButton.Text = "Mover";
            this.moveButton.UseVisualStyleBackColor = true;
            // 
            // moveTextBox
            // 
            this.moveTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveTextBox.Location = new System.Drawing.Point(151, 80);
            this.moveTextBox.Name = "moveTextBox";
            this.moveTextBox.Size = new System.Drawing.Size(120, 26);
            this.moveTextBox.TabIndex = 10;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(277, 83);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(26, 18);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "de";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(492, 83);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(17, 18);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "a";
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(309, 80);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(175, 26);
            this.fromComboBox.TabIndex = 13;
            // 
            // toComboBox
            // 
            this.toComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(515, 80);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(175, 26);
            this.toComboBox.TabIndex = 14;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productNameTextBox.Location = new System.Drawing.Point(10, 39);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(471, 23);
            this.productNameTextBox.TabIndex = 4;
            this.productNameTextBox.Text = "ProductName";
            // 
            // warehouseNameTextBox
            // 
            this.warehouseNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameTextBox.Location = new System.Drawing.Point(10, 93);
            this.warehouseNameTextBox.Name = "warehouseNameTextBox";
            this.warehouseNameTextBox.ReadOnly = true;
            this.warehouseNameTextBox.Size = new System.Drawing.Size(471, 19);
            this.warehouseNameTextBox.TabIndex = 5;
            this.warehouseNameTextBox.Text = "WarehouseName";
            // 
            // warehouseFilterLabel
            // 
            this.warehouseFilterLabel.AutoSize = true;
            this.warehouseFilterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseFilterLabel.Location = new System.Drawing.Point(151, 133);
            this.warehouseFilterLabel.Name = "warehouseFilterLabel";
            this.warehouseFilterLabel.Size = new System.Drawing.Size(142, 18);
            this.warehouseFilterLabel.TabIndex = 72;
            this.warehouseFilterLabel.Text = "por N⁰ de depósito:";
            // 
            // warehouseFilterTextBox
            // 
            this.warehouseFilterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseFilterTextBox.Location = new System.Drawing.Point(299, 130);
            this.warehouseFilterTextBox.Name = "warehouseFilterTextBox";
            this.warehouseFilterTextBox.Size = new System.Drawing.Size(120, 26);
            this.warehouseFilterTextBox.TabIndex = 71;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(25, 125);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 35);
            this.filterButton.TabIndex = 73;
            this.filterButton.Text = "Filtrar";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // productFilterLabel
            // 
            this.productFilterLabel.AutoSize = true;
            this.productFilterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFilterLabel.Location = new System.Drawing.Point(425, 133);
            this.productFilterLabel.Name = "productFilterLabel";
            this.productFilterLabel.Size = new System.Drawing.Size(142, 18);
            this.productFilterLabel.TabIndex = 74;
            this.productFilterLabel.Text = "por N⁰ de producto:";
            // 
            // productFilterTextBox
            // 
            this.productFilterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFilterTextBox.Location = new System.Drawing.Point(570, 130);
            this.productFilterTextBox.Name = "productFilterTextBox";
            this.productFilterTextBox.Size = new System.Drawing.Size(120, 26);
            this.productFilterTextBox.TabIndex = 75;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 631);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox warehouseIdTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TextBox moveTextBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox warehouseNameTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label warehouseFilterLabel;
        private System.Windows.Forms.TextBox warehouseFilterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label productFilterLabel;
        private System.Windows.Forms.TextBox productFilterTextBox;
    }
}