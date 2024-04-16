namespace WindowsForms
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.showInactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.showActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(13, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(213, 197);
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
            this.dataGridView.Location = new System.Drawing.Point(20, 258);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1640, 498);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameTextBox.Location = new System.Drawing.Point(263, 48);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(400, 29);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "Nombre";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(263, 84);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(400, 23);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Text = "Descripción";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(263, 145);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(400, 23);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.Text = "1512345678";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(263, 114);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(400, 23);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "mail@gmail.com";
            // 
            // adressTextBox
            // 
            this.adressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.adressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(263, 176);
            this.adressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.ReadOnly = true;
            this.adressTextBox.Size = new System.Drawing.Size(400, 23);
            this.adressTextBox.TabIndex = 5;
            this.adressTextBox.Text = "Calle 1234, Ciudad";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(201, 49);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(160, 43);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(369, 49);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 43);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(263, 12);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(400, 29);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.Text = "1";
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(33, 49);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(160, 43);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(760, 49);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(160, 43);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Exportar CSV";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.idTextBox);
            this.mainPanel.Controls.Add(this.adressTextBox);
            this.mainPanel.Controls.Add(this.emailTextBox);
            this.mainPanel.Controls.Add(this.phoneTextBox);
            this.mainPanel.Controls.Add(this.descriptionTextBox);
            this.mainPanel.Controls.Add(this.nameTextBox);
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.Location = new System.Drawing.Point(20, 18);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(667, 222);
            this.mainPanel.TabIndex = 1;
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.actionsPanel.Controls.Add(this.showInactiveCheckBox);
            this.actionsPanel.Controls.Add(this.showActiveCheckBox);
            this.actionsPanel.Controls.Add(this.clearButton);
            this.actionsPanel.Controls.Add(this.filterLabel);
            this.actionsPanel.Controls.Add(this.filterTextBox);
            this.actionsPanel.Controls.Add(this.exportButton);
            this.actionsPanel.Controls.Add(this.deleteButton);
            this.actionsPanel.Controls.Add(this.editButton);
            this.actionsPanel.Controls.Add(this.newButton);
            this.actionsPanel.Location = new System.Drawing.Point(707, 18);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(953, 222);
            this.actionsPanel.TabIndex = 2;
            // 
            // showInactiveCheckBox
            // 
            this.showInactiveCheckBox.AutoSize = true;
            this.showInactiveCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInactiveCheckBox.Location = new System.Drawing.Point(619, 144);
            this.showInactiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showInactiveCheckBox.Name = "showInactiveCheckBox";
            this.showInactiveCheckBox.Size = new System.Drawing.Size(109, 27);
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
            this.showActiveCheckBox.Location = new System.Drawing.Point(499, 144);
            this.showActiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showActiveCheckBox.Name = "showActiveCheckBox";
            this.showActiveCheckBox.Size = new System.Drawing.Size(95, 27);
            this.showActiveCheckBox.TabIndex = 5;
            this.showActiveCheckBox.Text = "Activos";
            this.showActiveCheckBox.UseVisualStyleBackColor = true;
            this.showActiveCheckBox.CheckedChanged += new System.EventHandler(this.showActiveCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(760, 135);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 43);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(29, 145);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(60, 23);
            this.filterLabel.TabIndex = 70;
            this.filterLabel.Text = "Filtro:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(115, 142);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(359, 30);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1680, 777);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox showInactiveCheckBox;
        private System.Windows.Forms.CheckBox showActiveCheckBox;
    }
}