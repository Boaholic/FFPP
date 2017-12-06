namespace GUILayer
{
    partial class MainMenuForm
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
            System.Windows.Forms.PictureBox menuPictureBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.QuitButton = new System.Windows.Forms.Button();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.SingleButton = new System.Windows.Forms.Button();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            menuPictureBox = new System.Windows.Forms.PictureBox();
            this.menuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(menuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(8, 103);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(597, 49);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButtonClick);
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.Location = new System.Drawing.Point(311, 15);
            this.MultiplayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.Size = new System.Drawing.Size(295, 53);
            this.MultiplayerButton.TabIndex = 9;
            this.MultiplayerButton.Text = "Multiplayer Game";
            this.MultiplayerButton.UseVisualStyleBackColor = true;
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButtonClick);
            // 
            // SingleButton
            // 
            this.SingleButton.Location = new System.Drawing.Point(8, 15);
            this.SingleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(295, 53);
            this.SingleButton.TabIndex = 8;
            this.SingleButton.Text = "Single-player Game";
            this.SingleButton.UseVisualStyleBackColor = true;
            this.SingleButton.Click += new System.EventHandler(this.SingleplayerButtonClick);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.SingleButton);
            this.menuGroupBox.Controls.Add(this.MultiplayerButton);
            this.menuGroupBox.Controls.Add(this.QuitButton);
            this.menuGroupBox.Location = new System.Drawing.Point(16, 423);
            this.menuGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.menuGroupBox.Size = new System.Drawing.Size(613, 187);
            this.menuGroupBox.TabIndex = 14;
            this.menuGroupBox.TabStop = false;
            // 
            // menuPictureBox
            // 
            menuPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            menuPictureBox.Image = global::FloatyFloatyPewPew.Properties.Resources.menuImage;
            menuPictureBox.Location = new System.Drawing.Point(16, 22);
            menuPictureBox.Margin = new System.Windows.Forms.Padding(4);
            menuPictureBox.Name = "menuPictureBox";
            menuPictureBox.Size = new System.Drawing.Size(612, 408);
            menuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            menuPictureBox.TabIndex = 7;
            menuPictureBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 635);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(menuPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuForm";
            this.Text = "Floaty Floaty PEW PEW!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuFormClosing);
            this.menuGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(menuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MultiplayerButton;
        private System.Windows.Forms.Button SingleButton;
        private System.Windows.Forms.GroupBox menuGroupBox;
    }
}

