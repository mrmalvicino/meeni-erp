namespace WindowsForms
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.showInactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.showActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.actionsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.actionsPanel.Controls.Add(this.showInactiveCheckBox);
            this.actionsPanel.Controls.Add(this.showActiveCheckBox);
            this.actionsPanel.Controls.Add(this.filterButton);
            this.actionsPanel.Controls.Add(this.filterLabel);
            this.actionsPanel.Controls.Add(this.filterTextBox);
            this.actionsPanel.Controls.Add(this.exportCSVButton);
            this.actionsPanel.Controls.Add(this.deleteButton);
            this.actionsPanel.Controls.Add(this.editButton);
            this.actionsPanel.Controls.Add(this.newButton);
            this.actionsPanel.Location = new System.Drawing.Point(530, 15);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(715, 180);
            this.actionsPanel.TabIndex = 5;
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
            // exportCSVButton
            // 
            this.exportCSVButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCSVButton.Location = new System.Drawing.Point(570, 40);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(120, 35);
            this.exportCSVButton.TabIndex = 3;
            this.exportCSVButton.Text = "Exportar CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click);
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
            this.mainPanel.Controls.Add(this.userIdTextBox);
            this.mainPanel.Controls.Add(this.userNameTextBox);
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 180);
            this.mainPanel.TabIndex = 4;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.userIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIdTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(197, 10);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(300, 23);
            this.userIdTextBox.TabIndex = 0;
            this.userIdTextBox.Text = "1";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userNameTextBox.Location = new System.Drawing.Point(197, 39);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(300, 23);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = "Nombre";
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
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1230, 405);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 631);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UsersForm_Load);
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
        private System.Windows.Forms.Button exportCSVButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}