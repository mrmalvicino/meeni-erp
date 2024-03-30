﻿namespace WindowsForms
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.showInactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.showActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.stockButton = new System.Windows.Forms.Button();
            this.actionsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.actionsPanel.Controls.Add(this.stockButton);
            this.actionsPanel.Controls.Add(this.showInactiveCheckBox);
            this.actionsPanel.Controls.Add(this.showActiveCheckBox);
            this.actionsPanel.Controls.Add(this.filterButton);
            this.actionsPanel.Controls.Add(this.filterLabel);
            this.actionsPanel.Controls.Add(this.filterTextBox);
            this.actionsPanel.Controls.Add(this.exportButton);
            this.actionsPanel.Controls.Add(this.deleteButton);
            this.actionsPanel.Controls.Add(this.editButton);
            this.actionsPanel.Controls.Add(this.newButton);
            this.actionsPanel.Location = new System.Drawing.Point(530, 15);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(715, 180);
            this.actionsPanel.TabIndex = 8;
            // 
            // showInactiveCheckBox
            // 
            this.showInactiveCheckBox.AutoSize = true;
            this.showInactiveCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInactiveCheckBox.Location = new System.Drawing.Point(464, 117);
            this.showInactiveCheckBox.Name = "showInactiveCheckBox";
            this.showInactiveCheckBox.Size = new System.Drawing.Size(87, 22);
            this.showInactiveCheckBox.TabIndex = 6;
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
            this.showActiveCheckBox.Location = new System.Drawing.Point(374, 117);
            this.showActiveCheckBox.Name = "showActiveCheckBox";
            this.showActiveCheckBox.Size = new System.Drawing.Size(78, 22);
            this.showActiveCheckBox.TabIndex = 5;
            this.showActiveCheckBox.Text = "Activos";
            this.showActiveCheckBox.UseVisualStyleBackColor = true;
            this.showActiveCheckBox.CheckedChanged += new System.EventHandler(this.showActiveCheckBox_CheckedChanged);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(570, 110);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 35);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Restablecer";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(22, 118);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(47, 18);
            this.filterLabel.TabIndex = 70;
            this.filterLabel.Text = "Filtro:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(86, 115);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(270, 26);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(570, 40);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(120, 35);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Exportar CSV";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(277, 40);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(151, 40);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 35);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(25, 40);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(120, 35);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.idTextBox);
            this.mainPanel.Controls.Add(this.categoryTextBox);
            this.mainPanel.Controls.Add(this.brandTextBox);
            this.mainPanel.Controls.Add(this.modelTextBox);
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 180);
            this.mainPanel.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(197, 10);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(300, 23);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.Text = "1";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.categoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(197, 93);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(300, 19);
            this.categoryTextBox.TabIndex = 3;
            this.categoryTextBox.Text = "Categoría";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(197, 68);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(300, 19);
            this.brandTextBox.TabIndex = 2;
            this.brandTextBox.Text = "Marca";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modelTextBox.Location = new System.Drawing.Point(197, 39);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(300, 23);
            this.modelTextBox.TabIndex = 1;
            this.modelTextBox.Text = "Modelo";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(10, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(160, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
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
            this.dataGridView.TabIndex = 6;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // stockButton
            // 
            this.stockButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.Location = new System.Drawing.Point(403, 40);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(120, 35);
            this.stockButton.TabIndex = 72;
            this.stockButton.Text = "Stock";
            this.stockButton.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 631);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.CheckBox showInactiveCheckBox;
        private System.Windows.Forms.CheckBox showActiveCheckBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button stockButton;
    }
}