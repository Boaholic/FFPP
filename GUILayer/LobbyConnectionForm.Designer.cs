namespace FloatyFloatPewPew
{ 
    partial class LobbyConnectionForm
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
            System.Windows.Forms.GroupBox connectionSettingsGroupBox;
            System.Windows.Forms.Label handleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyConnectionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.handleTextBox = new System.Windows.Forms.TextBox();
            connectionSettingsGroupBox = new System.Windows.Forms.GroupBox();
            handleLabel = new System.Windows.Forms.Label();
            connectionSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionSettingsGroupBox
            // 
            connectionSettingsGroupBox.Controls.Add(this.label1);
            connectionSettingsGroupBox.Controls.Add(this.portTextBox);
            connectionSettingsGroupBox.Controls.Add(this.portLabel);
            connectionSettingsGroupBox.Controls.Add(this.ipAddressTextBox);
            connectionSettingsGroupBox.Controls.Add(this.ipAddressLabel);
            connectionSettingsGroupBox.Controls.Add(handleLabel);
            connectionSettingsGroupBox.Controls.Add(this.connectButton);
            connectionSettingsGroupBox.Controls.Add(this.handleTextBox);
            connectionSettingsGroupBox.Location = new System.Drawing.Point(16, 20);
            connectionSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            connectionSettingsGroupBox.Name = "connectionSettingsGroupBox";
            connectionSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            connectionSettingsGroupBox.Size = new System.Drawing.Size(347, 294);
            connectionSettingsGroupBox.TabIndex = 16;
            connectionSettingsGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Connection Info:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(95, 157);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(243, 22);
            this.portTextBox.TabIndex = 20;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(8, 162);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 17);
            this.portLabel.TabIndex = 19;
            this.portLabel.Text = "Port:";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(95, 113);
            this.ipAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(243, 22);
            this.ipAddressTextBox.TabIndex = 18;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(8, 113);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(80, 17);
            this.ipAddressLabel.TabIndex = 17;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // handleLabel
            // 
            handleLabel.AutoSize = true;
            handleLabel.Location = new System.Drawing.Point(8, 27);
            handleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            handleLabel.Name = "handleLabel";
            handleLabel.Size = new System.Drawing.Size(49, 17);
            handleLabel.TabIndex = 2;
            handleLabel.Text = "Name:";
            // 
            // connectButton
            // 
            this.connectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectButton.BackgroundImage")));
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectButton.Location = new System.Drawing.Point(8, 233);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(331, 53);
            this.connectButton.TabIndex = 0;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // handleTextBox
            // 
            this.handleTextBox.Location = new System.Drawing.Point(67, 23);
            this.handleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.handleTextBox.Name = "handleTextBox";
            this.handleTextBox.Size = new System.Drawing.Size(271, 22);
            this.handleTextBox.TabIndex = 0;
            // 
            // LobbyConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 327);
            this.Controls.Add(connectionSettingsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LobbyConnectionForm";
            this.Text = "FFPP: Lobby Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LobbyConnectionFormClosing);
            connectionSettingsGroupBox.ResumeLayout(false);
            connectionSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox handleTextBox;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
    }
}