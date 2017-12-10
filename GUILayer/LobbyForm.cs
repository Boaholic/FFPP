using FFPPCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatyFloatPewPew
{
    public partial class LobbyForm : Form
    {
        List<string> GameHandles;
        List<string> JoinedGameHandles;
        private bool keepUpdating;
        public LobbyForm()
        {
            InitializeComponent();
           
        }

        public void UpdateLog()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(UpdateLog));    
            }
            lobbyLogTextBox.Text = Multiplayer.Instance.Processor.LobbyLog;
            lobbyLogTextBox.Refresh();
        }

        public void PopulateGames(string GameIDs)
        {
            GameHandles =  GameIDs.Split(',').ToList();
            foreach (string handle in GameHandles)
            {
                openGames.DataSource = GameHandles;

            }
        }

        public void PopulateJoinedGames(string GameIDs)
        {
            JoinedGameHandles = GameIDs.Split(',').ToList();
            foreach (string handle in GameHandles)
            {
                joinedGames.DataSource = JoinedGameHandles;

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

        private FFPPCommunication.Message CreateJoinGameMessage(string Game)
        {
            string[] GameInfo = Game.Split('-');
            FFPPCommunication.Message message = new FFPPCommunication.Message(FFPPCommunication.Message.messageType.JOIN, $"JoinGame|{Multiplayer.Instance.player1.Name}|{GameInfo[0].Trim()}");
            return message;
        }
        private FFPPCommunication.Message CreateLeaveGameMessage(string Game)
        {
            string[] GameInfo = Game.Split('-');
            FFPPCommunication.Message message = new FFPPCommunication.Message(FFPPCommunication.Message.messageType.JOIN, $"LeaveGame|{Multiplayer.Instance.player1.Name}|{GameInfo[0].Trim()}");
            return message;
        }
        private FFPPCommunication.Message CreateCreateGameMessage(string Game)
        {
            FFPPCommunication.Message message = new FFPPCommunication.Message(FFPPCommunication.Message.messageType.JOIN, $"CreateGame|{Multiplayer.Instance.player1.Name}|{Game}");
            return message;
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = openGames.SelectedIndex;
            
            FFPPCommunication.Message request = CreateJoinGameMessage(GameHandles[selectedIndex]);
            Communicator JoinGameCommunicator = new Communicator();
            bool requestSent = JoinGameCommunicator.Send(request, Multiplayer.Instance.Processor.ServerEndPoint);
            if (requestSent)
            {
                FFPPCommunication.Message response = JoinGameCommunicator.Receive(1000);
                string[] props = response?.messageBody.Split('|');
                if (response == null || props[1] == "False")
                {
                    MessageBox.Show("Unable to Connect to requested game at this time", "FFPP: Errors!");
                }
                else
                {
                   
                    PopulateGames(props[3]);
                    PopulateJoinedGames(props[5]);
                }

                JoinGameCommunicator.Close();
            }
            else
            {
                MessageBox.Show("Unable to Connect to the requested game at this time", "FFPP: Errors!");
            }
        }

        private void LobbyFormClosing(object sender, FormClosingEventArgs e)
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

        private void leaveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = joinedGames.SelectedIndex;

            FFPPCommunication.Message request = CreateLeaveGameMessage(JoinedGameHandles[selectedIndex]);
            Communicator LeaveGameCommunicator = new Communicator();
            bool requestSent = LeaveGameCommunicator.Send(request, Multiplayer.Instance.Processor.ServerEndPoint);
            if (requestSent)
            {
                FFPPCommunication.Message response = LeaveGameCommunicator.Receive(1000);
                string[] props = response?.messageBody.Split('|');
                if (response == null || props[1] == "False")
                {
                    MessageBox.Show("Unable to Leave requested game at this time", "FFPP: Errors!");
                }
                else
                {
                    PopulateGames(props[3]);
                    PopulateJoinedGames(props[5]);
                }


            }
            else
            {
                MessageBox.Show("Unable to Leave the requested game at this time", "FFPP: Errors!");
            }

        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void createGame_Click(object sender, EventArgs e)
        {
            string gameHandle = createGameTextBox.Text;
            if(gameHandle == null || gameHandle == "")
            {
                MessageBox.Show("A game name is required to create a game", "FFPP: Errors!");
                return;
            }

            FFPPCommunication.Message request = CreateCreateGameMessage(gameHandle);
            Communicator LeaveGameCommunicator = new Communicator();

            bool requestSent = LeaveGameCommunicator.Send(request, Multiplayer.Instance.Processor.ServerEndPoint);
            if (requestSent)
            {
                FFPPCommunication.Message response = LeaveGameCommunicator.Receive(1000);
                string[] props = response?.messageBody.Split('|');
                if (response == null || props[1] == "False")
                {
                    MessageBox.Show("Unable to Create to requested game at this time", "FFPP: Errors!");
                }
                else
                {
                    PopulateGames(props[3]);
                    PopulateJoinedGames(props[5]);
                }

                createGameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Unable to Create to the requested game at this time", "FFPP: Errors!");
            }
        }
    }
}
