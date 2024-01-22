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
            this.coverLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.coverTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(12, 76);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(72, 13);
            this.currencyLabel.TabIndex = 0;
            this.currencyLabel.Text = "Cot. del dólar:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(112, 73);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(180, 20);
            this.currencyTextBox.TabIndex = 1;
            this.currencyTextBox.Text = "1200";
            // 
            // coverLabel
            // 
            this.coverLabel.AutoSize = true;
            this.coverLabel.Location = new System.Drawing.Point(12, 28);
            this.coverLabel.Name = "coverLabel";
            this.coverLabel.Size = new System.Drawing.Size(47, 13);
            this.coverLabel.TabIndex = 2;
            this.coverLabel.Text = "Portada:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(112, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // coverTextBox
            // 
            this.coverTextBox.Location = new System.Drawing.Point(112, 25);
            this.coverTextBox.Name = "coverTextBox";
            this.coverTextBox.Size = new System.Drawing.Size(180, 20);
            this.coverTextBox.TabIndex = 6;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 321);
            this.Controls.Add(this.coverTextBox);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.currencyTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.coverLabel);
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
        private System.Windows.Forms.Label coverLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox coverTextBox;
    }
}