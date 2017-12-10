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
            this.chatMessages = new System.Windows.Forms.RichTextBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.openGames = new System.Windows.Forms.ListBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.createGame = new System.Windows.Forms.Button();
            this.joinedGamesGroupBox = new System.Windows.Forms.GroupBox();
            this.joinedGames = new System.Windows.Forms.ListBox();
            this.LobbyLog = new System.Windows.Forms.GroupBox();
            this.lobbyLogTextBox = new System.Windows.Forms.RichTextBox();
            this.leaveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createGameTextBox = new System.Windows.Forms.TextBox();
            this.chatGroupBox.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.joinedGamesGroupBox.SuspendLayout();
            this.LobbyLog.SuspendLayout();
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
            // chatMessages
            // 
            this.chatMessages.Location = new System.Drawing.Point(6, 21);
            this.chatMessages.Name = "chatMessages";
            this.chatMessages.Size = new System.Drawing.Size(469, 244);
            this.chatMessages.TabIndex = 0;
            this.chatMessages.Text = "";
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
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.openGames);
            this.gameGroupBox.Location = new System.Drawing.Point(499, 12);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(225, 232);
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
            this.openGames.Size = new System.Drawing.Size(208, 196);
            this.openGames.TabIndex = 0;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(742, 33);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(106, 23);
            this.joinButton.TabIndex = 3;
            this.joinButton.Text = "Join Game";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(742, 145);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(106, 23);
            this.createGame.TabIndex = 4;
            this.createGame.Text = "Create Game";
            this.createGame.UseVisualStyleBackColor = true;
            this.createGame.Click += new System.EventHandler(this.createGame_Click);
            // 
            // joinedGamesGroupBox
            // 
            this.joinedGamesGroupBox.Controls.Add(this.textBox1);
            this.joinedGamesGroupBox.Controls.Add(this.joinedGames);
            this.joinedGamesGroupBox.Location = new System.Drawing.Point(867, 12);
            this.joinedGamesGroupBox.Name = "joinedGamesGroupBox";
            this.joinedGamesGroupBox.Size = new System.Drawing.Size(225, 232);
            this.joinedGamesGroupBox.TabIndex = 3;
            this.joinedGamesGroupBox.TabStop = false;
            this.joinedGamesGroupBox.Text = "Joined Games";
            // 
            // joinedGames
            // 
            this.joinedGames.FormattingEnabled = true;
            this.joinedGames.ItemHeight = 16;
            this.joinedGames.Location = new System.Drawing.Point(11, 21);
            this.joinedGames.Name = "joinedGames";
            this.joinedGames.Size = new System.Drawing.Size(208, 196);
            this.joinedGames.TabIndex = 0;
            // 
            // LobbyLog
            // 
            this.LobbyLog.Controls.Add(this.lobbyLogTextBox);
            this.LobbyLog.Location = new System.Drawing.Point(499, 250);
            this.LobbyLog.Name = "LobbyLog";
            this.LobbyLog.Size = new System.Drawing.Size(593, 72);
            this.LobbyLog.TabIndex = 1;
            this.LobbyLog.TabStop = false;
            this.LobbyLog.Text = "Log";
            // 
            // lobbyLogTextBox
            // 
            this.lobbyLogTextBox.Location = new System.Drawing.Point(6, 21);
            this.lobbyLogTextBox.Name = "lobbyLogTextBox";
            this.lobbyLogTextBox.Size = new System.Drawing.Size(581, 47);
            this.lobbyLogTextBox.TabIndex = 0;
            this.lobbyLogTextBox.Text = "";
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(742, 62);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(106, 23);
            this.leaveButton.TabIndex = 5;
            this.leaveButton.Text = "Leave Game";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-125, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 6;
            // 
            // createGameTextBox
            // 
            this.createGameTextBox.Location = new System.Drawing.Point(742, 117);
            this.createGameTextBox.Name = "createGameTextBox";
            this.createGameTextBox.Size = new System.Drawing.Size(105, 22);
            this.createGameTextBox.TabIndex = 6;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 334);
            this.Controls.Add(this.createGameTextBox);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.LobbyLog);
            this.Controls.Add(this.joinedGamesGroupBox);
            this.Controls.Add(this.createGame);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.chatGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LobbyForm";
            this.Text = "Floaty Floaty PEW PEW: Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LobbyFormClosing);
            this.chatGroupBox.ResumeLayout(false);
            this.gameGroupBox.ResumeLayout(false);
            this.joinedGamesGroupBox.ResumeLayout(false);
            this.joinedGamesGroupBox.PerformLayout();
            this.LobbyLog.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox joinedGamesGroupBox;
        private System.Windows.Forms.ListBox joinedGames;
        private System.Windows.Forms.GroupBox LobbyLog;
        private System.Windows.Forms.RichTextBox lobbyLogTextBox;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox createGameTextBox;
    }
}