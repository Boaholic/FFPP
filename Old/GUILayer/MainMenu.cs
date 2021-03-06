﻿using System;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            MaximizeBox = false;            
            CenterToScreen();
        }

        private void QuitButtonClick(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void SingleplayerButtonClick(object sender, EventArgs e)
        {
            // Set game to a Singleplayer.
            Game.gameMode = true;
            Game.Initialize();

            // Initialize players.
            Game.player1 = new GamePlayer();
            Game.player2 = new GamePlayer();

            // Temporarily hide MainMenuForm and store its pointer.
            SingleplayerSettingsForm singleplayerSettingsForm = new SingleplayerSettingsForm();
            singleplayerSettingsForm.Location = Location;
            singleplayerSettingsForm.Show();
            Hide();
        }
            //Multiplayer Game
            //TO DO.  Connect to server and start sending messages
        private void MultiplayerButtonClick(object sender, EventArgs e)
        {
            
            Game.gameMode = false;
            Game.Initialize();

           

            
        }

        private void AboutButtonClick(object sender, EventArgs e)
        {
            // Open default web browser with the Wiki link.
            System.Diagnostics.Process.Start(@"http://en.wikipedia.org/wiki/Battleship_%28game%29");
        }

       
        private void MainMenuFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
