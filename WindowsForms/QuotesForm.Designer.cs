namespace WindowsForms
{
    partial class QuotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotesForm));
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.quoteIdTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.actionsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.SystemColors.Control;
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
            this.actionsPanel.TabIndex = 5;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(369, 135);
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
            this.filterTextBox.Location = new System.Drawing.Point(100, 142);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(260, 30);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(760, 49);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(160, 43);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Exportar PDF";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
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
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.quoteIdTextBox);
            this.mainPanel.Controls.Add(this.customerTextBox);
            this.mainPanel.Controls.Add(this.profilePictureBox);
            this.mainPanel.Location = new System.Drawing.Point(20, 18);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(667, 222);
            this.mainPanel.TabIndex = 4;
            // 
            // quoteIdTextBox
            // 
            this.quoteIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.quoteIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quoteIdTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteIdTextBox.Location = new System.Drawing.Point(263, 12);
            this.quoteIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quoteIdTextBox.Name = "quoteIdTextBox";
            this.quoteIdTextBox.ReadOnly = true;
            this.quoteIdTextBox.Size = new System.Drawing.Size(400, 29);
            this.quoteIdTextBox.TabIndex = 0;
            this.quoteIdTextBox.Text = "Presupuesto N⁰ 0";
            // 
            // customerTextBox
            // 
            this.customerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.customerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(263, 48);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(400, 23);
            this.customerTextBox.TabIndex = 2;
            this.customerTextBox.Text = "Cliente";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(13, 12);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(213, 197);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 22;
            this.profilePictureBox.TabStop = false;
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
            this.dataGridView.TabIndex = 3;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // QuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 777);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.QuotesForm_Load);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox quoteIdTextBox;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}