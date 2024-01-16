namespace WindowsForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.currencyLabel = new System.Windows.Forms.Label();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.organizationCoverLabel = new System.Windows.Forms.Label();
            this.organizationLogoLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.organizationTabPage = new System.Windows.Forms.TabPage();
            this.rolesTabPage = new System.Windows.Forms.TabPage();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabControl.SuspendLayout();
            this.organizationTabPage.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(15, 15);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(102, 13);
            this.currencyLabel.TabIndex = 0;
            this.currencyLabel.Text = "Cotización del dólar:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(123, 12);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 1;
            this.currencyTextBox.Text = "1000";
            // 
            // organizationCoverLabel
            // 
            this.organizationCoverLabel.AutoSize = true;
            this.organizationCoverLabel.Location = new System.Drawing.Point(15, 15);
            this.organizationCoverLabel.Name = "organizationCoverLabel";
            this.organizationCoverLabel.Size = new System.Drawing.Size(125, 13);
            this.organizationCoverLabel.TabIndex = 2;
            this.organizationCoverLabel.Text = "Portada de organización:";
            // 
            // organizationLogoLabel
            // 
            this.organizationLogoLabel.AutoSize = true;
            this.organizationLogoLabel.Location = new System.Drawing.Point(15, 45);
            this.organizationLogoLabel.Name = "organizationLogoLabel";
            this.organizationLogoLabel.Size = new System.Drawing.Size(112, 13);
            this.organizationLogoLabel.TabIndex = 3;
            this.organizationLogoLabel.Text = "Logo de organización:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(528, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.organizationTabPage);
            this.settingsTabControl.Controls.Add(this.rolesTabPage);
            this.settingsTabControl.Controls.Add(this.generalTabPage);
            this.settingsTabControl.Location = new System.Drawing.Point(12, 12);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(600, 261);
            this.settingsTabControl.TabIndex = 6;
            // 
            // organizationTabPage
            // 
            this.organizationTabPage.Controls.Add(this.organizationCoverLabel);
            this.organizationTabPage.Controls.Add(this.organizationLogoLabel);
            this.organizationTabPage.Location = new System.Drawing.Point(4, 22);
            this.organizationTabPage.Name = "organizationTabPage";
            this.organizationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.organizationTabPage.Size = new System.Drawing.Size(592, 235);
            this.organizationTabPage.TabIndex = 0;
            this.organizationTabPage.Text = "Organización";
            this.organizationTabPage.UseVisualStyleBackColor = true;
            // 
            // rolesTabPage
            // 
            this.rolesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rolesTabPage.Name = "rolesTabPage";
            this.rolesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rolesTabPage.Size = new System.Drawing.Size(592, 235);
            this.rolesTabPage.TabIndex = 1;
            this.rolesTabPage.Text = "Roles";
            this.rolesTabPage.UseVisualStyleBackColor = true;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.currencyLabel);
            this.generalTabPage.Controls.Add(this.currencyTextBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(592, 235);
            this.generalTabPage.TabIndex = 2;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.settingsTabControl.ResumeLayout(false);
            this.organizationTabPage.ResumeLayout(false);
            this.organizationTabPage.PerformLayout();
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.Label organizationCoverLabel;
        private System.Windows.Forms.Label organizationLogoLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage organizationTabPage;
        private System.Windows.Forms.TabPage rolesTabPage;
        private System.Windows.Forms.TabPage generalTabPage;
    }
}