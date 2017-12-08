using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using FFPPCommunication;
using System.Threading;

namespace FloatyFloatPewPew
{
    public partial class LobbyConnectionForm : Form
    {
        public LobbyConnectionForm()
        {
            InitializeComponent();
            // Disable maximalization button on the title bar.
            MaximizeBox = false;
            // Set location of the form to the top left corner of the parent.
            CenterToParent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            List<string> errors = new List<string>();
            // Check the length of the name.
            if (handleTextBox.Text.Length >= 3 && handleTextBox.Text.Length <= 12)
            {
                // Set player's name.
                Multiplayer.Instance.player1.Name = handleTextBox.Text;

               
            }
            else
            {
                errors.Add("Your name must be from 3 to 12 characters long, try again please.");
                handleTextBox.Text = "";
                valid = false;
            }
            if(ipAddressTextBox.Text.Length != 0 && portTextBox.Text.Length != 0)
            {
                IPAddress ServerIPAddress = IPAddress.Parse(ipAddressTextBox.Text);
                int ServerPort = Int32.Parse(portTextBox.Text);
                Multiplayer.Instance.Processor.ServerEndPoint = new IPEndPoint(ServerIPAddress, ServerPort);
            }
            else
            {
                errors.Add("You must specify both an IPAddress and a Port in order to connect to the Lobby, try again please.");
                valid = false;
            }

            if(!valid)
            {
                // Show a warning message box.
                MessageBox.Show(OutputErrors(errors), "FFPP: Errors!");
            }
            else
            {
                Multiplayer.Instance.StartProccessor();
                FFPPCommunication.Message request = CreateConnectMessage();
                bool requestSent = Multiplayer.Instance.Processor.SendRequest(request);
                if(requestSent)
                {
                    int attempts = 0;
                    string response = null;
                    while (attempts < 3 && response == null)
                    {
                        response = Multiplayer.Instance.Processor.GetConnectResponse();
                        Thread.Sleep(100);
                    }

                    if (response == null || response == "Failed")
                    {
                        MessageBox.Show("Unable to Connect to the server at this time", "FFPP: Errors!");
                    }
                    else
                    {
                        //show lobby form
                        LobbyForm lobbyForm = new LobbyForm();
                        lobbyForm.Location = Location;
                        lobbyForm.Show();
                        // Dispose does not trigger FormClosing event.
                        Dispose();
                    }
                    
                   
                } else
                {
                    MessageBox.Show("Unable to Connect to the server at this time", "FFPP: Errors!");
                }
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

        private string OutputErrors(List<string> errors)
        {
            string errorMessage = "";
            foreach (string error in errors)
            {
                errorMessage += error + Environment.NewLine;
            }
            return errorMessage;
        }

        private FFPPCommunication.Message CreateConnectMessage()
        {
            FFPPCommunication.Message message = new FFPPCommunication.Message(FFPPCommunication.Message.messageType.JOIN, $"Connect|{Multiplayer.Instance.player1.Name}");
            return message;
        }
    }
}
