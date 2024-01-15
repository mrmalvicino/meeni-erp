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
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(37, 37);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(102, 13);
            this.currencyLabel.TabIndex = 0;
            this.currencyLabel.Text = "Cotización del dólar:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(145, 34);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 1;
            this.currencyTextBox.Text = "1000";
            // 
            // organizationCoverLabel
            // 
            this.organizationCoverLabel.AutoSize = true;
            this.organizationCoverLabel.Location = new System.Drawing.Point(37, 70);
            this.organizationCoverLabel.Name = "organizationCoverLabel";
            this.organizationCoverLabel.Size = new System.Drawing.Size(125, 13);
            this.organizationCoverLabel.TabIndex = 2;
            this.organizationCoverLabel.Text = "Portada de organización:";
            // 
            // organizationLogoLabel
            // 
            this.organizationLogoLabel.AutoSize = true;
            this.organizationLogoLabel.Location = new System.Drawing.Point(37, 102);
            this.organizationLogoLabel.Name = "organizationLogoLabel";
            this.organizationLogoLabel.Size = new System.Drawing.Size(112, 13);
            this.organizationLogoLabel.TabIndex = 3;
            this.organizationLogoLabel.Text = "Logo de organización:";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(507, 269);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(80, 30);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Aplicar";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.organizationLogoLabel);
            this.Controls.Add(this.organizationCoverLabel);
            this.Controls.Add(this.currencyTextBox);
            this.Controls.Add(this.currencyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.Label organizationCoverLabel;
        private System.Windows.Forms.Label organizationLogoLabel;
        private System.Windows.Forms.Button applyButton;
    }
}