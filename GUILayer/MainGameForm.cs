using System;
using System.Threading;
using System.Windows.Forms;

namespace FloatyFloatPewPew
{
    public partial class MainGameForm : Form
    {
        int mouseCellX;
        int mouseCellY;

        Player yourPlayer;
        Player opponentPlayer;

        public MainGameForm()
        {
            InitializeComponent();
            // Disable maximalization button on the title bar.
            MaximizeBox = false;
            // Set the location of the form to the center of the screen.
            CenterToScreen();

            // Set random deck images, but two different.
            int deck1Number = GlobalState.RandomNumber(4);
            int deck2Number = GlobalState.RandomNumber(4);
            while (deck1Number == deck2Number)
            {
                deck2Number = GlobalState.RandomNumber(4);
            }

            TargetFleetBox.Image = Graphics.deckImages[deck1Number];
            PlayerFleetBox.Image = Graphics.deckImages[deck2Number];

            // Set the title of the form for better player orientation.
            if (Game.playerSwitch)
            {
                Text = "Battleships: " + Game.player1.Name + "’s turn";
                yourPlayer = Game.player1;
                opponentPlayer = Game.player2;
            }
            else
            {
                Text = "Battleships: " + Game.player2.Name + "’s turn";
                yourPlayer = Game.player2;
                opponentPlayer = Game.player1;
            }

            mouseCellX = -1;
            mouseCellY = -1;

            if (Game.roundCount == 1)
            {
                //Sound.drumSoundPlayer.Play();
            }

            RedrawStatistics();
        }

        private void RedrawStatistics() 
        {
            roundTextBox.Text = Game.roundCount.ToString();
            roundTextBox.Refresh();

            battleLogRichTextBox.Text = yourPlayer.BattleLog;
            battleLogRichTextBox.Refresh();

            yourHitsTextBox.Text = yourPlayer.Hits.ToString();
            yourHitsTextBox.Refresh();
            yourMissesTextBox.Text = yourPlayer.Misses.ToString();
            yourMissesTextBox.Refresh();

            if (opponentPlayer.UnrevealedCells != 100)
            {
                yourHitRatioTextBox.Text = String.Format("{0:0.##}", yourPlayer.HitRatio * 100) + " %"; 
            }
            else
            {
                yourHitRatioTextBox.Text = "-";
            }
            yourHitRatioTextBox.Refresh();

            
            
            opponentHitsTextBox.Text = opponentPlayer.Hits.ToString();
            opponentHitsTextBox.Refresh();

            opponentMissesTextBox.Text = opponentPlayer.Misses.ToString();
            opponentMissesTextBox.Refresh();
            
            if (yourPlayer.UnrevealedCells != 100)
            {
                opponentHitRatioTextBox.Text = String.Format("{0:0.##}", opponentPlayer.HitRatio * 100) + " %"; 
            }
            else
            {
                opponentHitRatioTextBox.Text = "-"; 
            }
            opponentHitRatioTextBox.Refresh();

         
        }

        private void deckPictureBoxClick(object sender, EventArgs e)
        {
            if (mouseCellX != -1 && mouseCellY != -1 && !opponentPlayer.RevealedCells[mouseCellX, mouseCellY])
            {
                // Is the game over?
                if (Game.Attack(mouseCellX, mouseCellY, yourPlayer, opponentPlayer))
                {
                    // End of game, actual player wins redraw final state.
                    TargetFleetBox.Refresh();

                    // Reset side statistics.
                    RedrawStatistics();

                    // Wait few seconds.
                    Thread.Sleep(4000);

                    // Play the winning sound.
                    Sound.vicotrySoundPlayer.Play();

                    // Show the informational message box.
                    MessageBox.Show("Congratulations " + yourPlayer.Name + "! You have won against " + opponentPlayer.Name + " in " + Game.roundCount + " rounds!", "Battleships: Game Over!");

                    // Dispose the form and return to the main menu.
                    Dispose();

                    // Play the menu music in loop.
                    Sound.menuSoundPlayer.PlayLooping();

                    GlobalState.MainMenuForm.Location = Location;
                    GlobalState.MainMenuForm.Show();
                }
                else
                {
                    // The game is not over yet.
                    // Redraw the deck.
                    TargetFleetBox.Refresh();

                    // Scroll the battle log to the end.
                    battleLogRichTextBox.ScrollToCaret();

                    // Reset the side statistics.
                    RedrawStatistics();

                    // Wait few seconds.
                    Thread.Sleep(4000);

                    // Is the game a singleplayer?
                    if (Game.gameMode)
                    {
                        int[] aiMove = Game.AIChooseCellToHit(yourPlayer);
                        if (Game.Attack(aiMove[0], aiMove[1], opponentPlayer, yourPlayer))
                        {
                            // End of game, the computer has won.
                            // Scroll the battle log to the end.
                            battleLogRichTextBox.ScrollToCaret();

                            // Reset the side statistics.
                            RedrawStatistics();

                            // Reveal all the other ships.
                            for (int currentShip = 0; currentShip < 5; currentShip++)
                            {
                                opponentPlayer.ShipLeftCells[currentShip] = 0;
                            }

                            // Computer has won.
                            PlayerFleetBox.Refresh();

                            // Wait few seconds.
                            Thread.Sleep(4000);

                            // Play the menu music in loop.
                            Sound.menuSoundPlayer.PlayLooping();

                            // Show the informational message box.
                            MessageBox.Show("You were beaten, " + yourPlayer.Name + "! You have lost against " + opponentPlayer.Name + " in " + Game.roundCount + " rounds!", "Battleships: Game Over!");

                            // Dispose the form and return to the main menu.
                            Dispose();

                            GlobalState.MainMenuForm.Location = Location;
                            GlobalState.MainMenuForm.Show();
                        }
                        else
                        {
                            // Computer has not won yet.
                            // Increase the round count.
                            Game.roundCount++;

                            // Scroll the battle log to the end.
                            battleLogRichTextBox.ScrollToCaret();

                            // Computer has not won yet.
                            PlayerFleetBox.Refresh();

                            // Reset the side statistics.
                            RedrawStatistics(); 
                            
                            // Wait few seconds.
                            Thread.Sleep(4000);
                        }
                    }
                    
                }                
            }
            
        }

        private void deck1PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            // Are we on the grid of the first deck?
            if (Graphics.GetCoorX(this, TargetFleetBox) != -1 && Graphics.GetCoorY(this, TargetFleetBox) != -1)
            {
                // Have the cell selected by mouse changed?
                if (Graphics.GetCell(Graphics.GetCoorX(this, TargetFleetBox)) != mouseCellX || Graphics.GetCell(Graphics.GetCoorY(this, TargetFleetBox)) != mouseCellY)
                {
                    // Update the cell selected by mouse.
                    mouseCellX = Graphics.GetCell(Graphics.GetCoorX(this, TargetFleetBox));
                    mouseCellY = Graphics.GetCell(Graphics.GetCoorY(this, TargetFleetBox));

                    // Repaint the first deck.
                    TargetFleetBox.Refresh();

                    // Draw the outer frame of the selected cell.
                    Graphics.DrawOuterFrameCell(mouseCellX, mouseCellY, 5, this, TargetFleetBox);
                }
            }
            else
            {
                // Unselect the cell in the first deck.
                mouseCellX = -1;
                mouseCellY = -1;

                // Repaint the first deck.
                TargetFleetBox.Refresh();  
            }
        }
        
        private void deck1PictureBoxPaint(object sender, PaintEventArgs e)
        {
            Graphics.DrawSunkenShips(opponentPlayer.ShipSet, opponentPlayer.ShipLeftCells, e);
            Graphics.DrawDeckStatus(opponentPlayer.RevealedCells, opponentPlayer.ShipSet, e);

            if (opponentPlayer.LastRevieledCells[0] != -1 && opponentPlayer.LastRevieledCells[1] != -1)
            {
                Graphics.DrawOuterFrameCell(opponentPlayer.LastRevieledCells[0], opponentPlayer.LastRevieledCells[1], 6, e);
            }
        }

        private void deck2PictureBoxPaint(object sender, PaintEventArgs e)
        {
            Graphics.DrawShipSet(yourPlayer.ShipSet, e);
            Graphics.DrawDeckStatus(yourPlayer.RevealedCells, yourPlayer.ShipSet, e);

            if (yourPlayer.LastRevieledCells[0] != -1 && yourPlayer.LastRevieledCells[1] != -1)
            {
                Graphics.DrawOuterFrameCell(yourPlayer.LastRevieledCells[0], yourPlayer.LastRevieledCells[1], 7, e);
            }
        }

        private void BattleLogRichTextBoxTextChanged(object sender, EventArgs e)
        {
            battleLogRichTextBox.SelectionStart = battleLogRichTextBox.TextLength;
        }

        private void MainMenuFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitToMainMenu = MessageBox.Show("Do you really want to quit game to Main menu?", "Battleships: Quitting game...", MessageBoxButtons.YesNo);
            if (quitToMainMenu == DialogResult.Yes)
            {
                // Play the menu music in loop.
                Sound.menuSoundPlayer.PlayLooping();

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
