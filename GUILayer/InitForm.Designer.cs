using System.Windows.Forms;

namespace GUILayer
{
    partial class clientPlayer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 297);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(57, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 299);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBox1.Location = new System.Drawing.Point(29, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(413, 231);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Welcome to FFPPBMRIS, a multiplayer Battleship game!";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameBox.Location = new System.Drawing.Point(915, 370);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(169, 22);
            this.NameBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NameLabel.Location = new System.Drawing.Point(1110, 370);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(90, 19);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Player Name";
            // 
            // IPBox
            // 
            this.IPBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IPBox.Location = new System.Drawing.Point(915, 423);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(169, 22);
            this.IPBox.TabIndex = 4;
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PortBox.Location = new System.Drawing.Point(915, 475);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(169, 22);
            this.PortBox.TabIndex = 5;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IPLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.ForeColor = System.Drawing.Color.Maroon;
            this.IPLabel.Location = new System.Drawing.Point(1125, 423);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(75, 19);
            this.IPLabel.TabIndex = 6;
            this.IPLabel.Text = "Server IP";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PortLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PortLabel.Location = new System.Drawing.Point(1107, 475);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(93, 19);
            this.PortLabel.TabIndex = 7;
            this.PortLabel.Text = "Port Number";
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConnectButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.Maroon;
            this.ConnectButton.Location = new System.Drawing.Point(962, 520);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(82, 40);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect!";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(765, 225);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(100, 22);
            this.ErrorBox.TabIndex = 9;
            // 
            // clientPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GUILayer.Properties.Resources.OpenScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 624);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "clientPlayer";
            this.Text = "Floaty-Floaty-Pew-Pew:  Boaty McBoatface\'s revenge:  IN SPACE!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private TextBox NameBox;
        private Label NameLabel;
        private TextBox IPBox;
        private TextBox PortBox;
        private Label IPLabel;
        private Label PortLabel;
        private Button ConnectButton;
        private TextBox ErrorBox;
    }
}

