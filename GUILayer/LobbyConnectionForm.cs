using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FloatyFloatPewPew
{
    public partial class LobbyConnectionForm : Form
    {
        public LobbyConnectionForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Check the length of the name.
            if (handleTextBox.Text.Length >= 3 && handleTextBox.Text.Length <= 12)
            {
                // Set player's name.
                SinglePlayer.Instance.player1.Name = handleTextBox.Text;

                //connect to server and send lobby connect message
                
                //Once Connection confirmed close this form and open the lobby form.

                // Dispose does not trigger FormClosing event.
                //Dispose();
            }
            else
            {
                // Show a warning message box.
                MessageBox.Show("Your name must be from 3 to 12 characters long, try again please.", "Battleships: Try another name!");
                handleTextBox.Text = "";
            }
        }
        // Only with a focus on the button continue when enter pressed.
        private void LobbyConnectionFormEnter(object sender, EventArgs e)
        {
            connectButton_Click(sender, e);
        }

        private void LobbyConnectionFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitToMainMenu = MessageBox.Show("Do you really want to quit game to Main menu?", "Battleships: Quitting game...", MessageBoxButtons.YesNo);
            if (quitToMainMenu == DialogResult.Yes)
            {
                // In case someone presses close button, show the dialog box.
                GlobalState.MainMenuForm.Location = Location;
                GlobalState.MainMenuForm.Show();
            }
            else
            {
                // Prevent form from closing.
                e.Cancel = true;
            }
        }
    }
}
