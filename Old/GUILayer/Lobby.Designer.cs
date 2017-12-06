namespace GUILayer
{
    partial class Lobby
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
            this.ChatWindow = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.GamesList = new System.Windows.Forms.ListBox();
            this.GamesLabel = new System.Windows.Forms.Label();
            this.JoinButton = new System.Windows.Forms.Button();
            this.ServerLog = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChatWindow
            // 
            this.ChatWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChatWindow.Location = new System.Drawing.Point(28, 24);
            this.ChatWindow.Multiline = true;
            this.ChatWindow.Name = "ChatWindow";
            this.ChatWindow.ReadOnly = true;
            this.ChatWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatWindow.Size = new System.Drawing.Size(1019, 649);
            this.ChatWindow.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 698);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(927, 22);
            this.textBox1.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(28, 698);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Chat!";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // GamesList
            // 
            this.GamesList.FormattingEnabled = true;
            this.GamesList.ItemHeight = 16;
            this.GamesList.Location = new System.Drawing.Point(1070, 47);
            this.GamesList.Name = "GamesList";
            this.GamesList.Size = new System.Drawing.Size(259, 228);
            this.GamesList.TabIndex = 3;
            // 
            // GamesLabel
            // 
            this.GamesLabel.AutoSize = true;
            this.GamesLabel.Location = new System.Drawing.Point(1129, 27);
            this.GamesLabel.Name = "GamesLabel";
            this.GamesLabel.Size = new System.Drawing.Size(114, 17);
            this.GamesLabel.TabIndex = 4;
            this.GamesLabel.Text = "Available Games";
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(1140, 281);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(103, 23);
            this.JoinButton.TabIndex = 5;
            this.JoinButton.Text = "Join Game";
            this.JoinButton.UseVisualStyleBackColor = true;
            // 
            // ServerLog
            // 
            this.ServerLog.Location = new System.Drawing.Point(1070, 336);
            this.ServerLog.Multiline = true;
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.ReadOnly = true;
            this.ServerLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServerLog.Size = new System.Drawing.Size(259, 340);
            this.ServerLog.TabIndex = 6;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(1150, 316);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(82, 17);
            this.LogLabel.TabIndex = 7;
            this.LogLabel.Text = "Server Log:";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1271, 767);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.ServerLog);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.GamesLabel);
            this.Controls.Add(this.GamesList);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChatWindow);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatWindow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox GamesList;
        private System.Windows.Forms.Label GamesLabel;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.TextBox ServerLog;
        private System.Windows.Forms.Label LogLabel;
    }
}