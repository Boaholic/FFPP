namespace FloatyFloatPewPew
{
    partial class LobbyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyForm));
            this.chatGroupBox = new System.Windows.Forms.GroupBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.chatMessages = new System.Windows.Forms.RichTextBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.openGames = new System.Windows.Forms.ListBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.createGame = new System.Windows.Forms.Button();
            this.chatGroupBox.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatGroupBox
            // 
            this.chatGroupBox.Controls.Add(this.chatMessages);
            this.chatGroupBox.Location = new System.Drawing.Point(12, 12);
            this.chatGroupBox.Name = "chatGroupBox";
            this.chatGroupBox.Size = new System.Drawing.Size(481, 277);
            this.chatGroupBox.TabIndex = 0;
            this.chatGroupBox.TabStop = false;
            this.chatGroupBox.Text = "Chat";
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(12, 295);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(393, 22);
            this.chatTextBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(411, 295);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(82, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // chatMessages
            // 
            this.chatMessages.Location = new System.Drawing.Point(6, 21);
            this.chatMessages.Name = "chatMessages";
            this.chatMessages.Size = new System.Drawing.Size(469, 244);
            this.chatMessages.TabIndex = 0;
            this.chatMessages.Text = "";
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.openGames);
            this.gameGroupBox.Location = new System.Drawing.Point(499, 12);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(225, 277);
            this.gameGroupBox.TabIndex = 2;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Open Games";
            // 
            // openGames
            // 
            this.openGames.FormattingEnabled = true;
            this.openGames.ItemHeight = 16;
            this.openGames.Location = new System.Drawing.Point(11, 21);
            this.openGames.Name = "openGames";
            this.openGames.Size = new System.Drawing.Size(208, 244);
            this.openGames.TabIndex = 0;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(499, 294);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(106, 23);
            this.joinButton.TabIndex = 3;
            this.joinButton.Text = "Join Game";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(611, 294);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(113, 23);
            this.createGame.TabIndex = 4;
            this.createGame.Text = "Create Game";
            this.createGame.UseVisualStyleBackColor = true;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 334);
            this.Controls.Add(this.createGame);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.chatGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LobbyForm";
            this.Text = "Floaty Floaty PEW PEW: Lobby";
            this.chatGroupBox.ResumeLayout(false);
            this.gameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chatGroupBox;
        private System.Windows.Forms.RichTextBox chatMessages;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.ListBox openGames;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button createGame;
    }
}