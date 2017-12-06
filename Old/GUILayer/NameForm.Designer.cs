namespace GUILayer
{
    partial class SingleplayerSettingsForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.GroupBox settingsGroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleplayerSettingsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            settingsGroupBox = new System.Windows.Forms.GroupBox();
            settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(8, 27);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.Controls.Add(nameLabel);
            settingsGroupBox.Controls.Add(this.okButton);
            settingsGroupBox.Controls.Add(this.nameTextBox);
            settingsGroupBox.Location = new System.Drawing.Point(16, 15);
            settingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            settingsGroupBox.Size = new System.Drawing.Size(347, 114);
            settingsGroupBox.TabIndex = 15;
            settingsGroupBox.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okButton.BackgroundImage")));
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.okButton.Location = new System.Drawing.Point(8, 55);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(331, 53);
            this.okButton.TabIndex = 0;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(67, 23);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(271, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // SingleplayerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 154);
            this.Controls.Add(settingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SingleplayerSettingsForm";
            this.Text = "Floaty Floaty PEW PEW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleplayerSettingsFormClosing);
            this.Enter += new System.EventHandler(this.SingleplayerSettingsFormEnter);
            settingsGroupBox.ResumeLayout(false);
            settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}