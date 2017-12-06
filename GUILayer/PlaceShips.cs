using System;
using System.Windows.Forms;

namespace FloatyFloatPewPew
{
    public partial class PlaceShips : Form
    {
        // Mouse selected cell. [-1, -1] for none.
        int mouseCellX;
        int mouseCellY;

        // Index of a selected ship.
        // [-1] none / [0] patrol boat / ... / [4] aircraft carrier.
        int currentShip;
        // Ship deploy rotation.
        // [true] horizontal / [false] vertical.
        bool shipRotation;
        // Which ship is alredy deployed.
        bool[] shipDeployed = new bool[5];

        // Changable player.
        Player player;

        public PlaceShips()
        {
            InitializeComponent();
            MaximizeBox = false;            
            CenterToParent();
            deckPictureBox.Image = Graphics.deckImages[GlobalState.RandomNumber(4)];

            mouseCellX = -1;
            mouseCellY = -1;
            currentShip = -1;
            shipRotation = true;

            // Set the title text for better player orientation.
            if (Game.playerSwitch)
            {
                Text = "Battleships: " + Game.player1.Name + "’s deployment";
                player = Game.player1;
            }
            else
            {
                Text = "Battleships: " + Game.player2.Name + "’s deployment";
                player = Game.player2;
            }
            
        }
        
        private void DeckPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            // Is there any ship selected?
            if (currentShip != -1)
            {
                // Are we on the grid of the deck?
                if (Graphics.GetCoorX(this, deckPictureBox) != -1 && Graphics.GetCoorY(this, deckPictureBox) != -1)
                {
                    // Has the mouse selected cell changed?
                    if (Graphics.GetCell(Graphics.GetCoorX(this, deckPictureBox)) != mouseCellX || Graphics.GetCell(Graphics.GetCoorY(this, deckPictureBox)) != mouseCellY)
                    {
                        // Rewrite Mouse cell information.
                        mouseCellX = Graphics.GetCell(Graphics.GetCoorX(this, deckPictureBox));
                        mouseCellY = Graphics.GetCell(Graphics.GetCoorY(this, deckPictureBox));
                        
                        // Reraw the deck.
                        deckPictureBox.Refresh();

                        // Is the horizontal rotation on?
                        if (shipRotation)
                        {
                            // Deploy current ship with its color into the deck.
                            for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                            {
                                // Do not cross the boundaries.
                                if (mouseCellX + i <= 9)
                                {
                                    Graphics.DrawInnerFrameCell(mouseCellX + i, mouseCellY, currentShip, this, deckPictureBox);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            // Vertical rotation is on.
                            for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                            {
                                if (mouseCellY + i <= 9)
                                {
                                    Graphics.DrawInnerFrameCell(mouseCellX, mouseCellY + i, currentShip, this, deckPictureBox);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Out of the boundaries of the deck.
                    if (mouseCellX != -1 || mouseCellY != -1)
                    {
                        mouseCellX = -1;
                        mouseCellY = -1;

                        // Reraw the deck.
                        deckPictureBox.Refresh();
                    }

                }
            }
        }
      
        private void DeckPictureBoxClick(object sender, EventArgs e)
        {
            if (currentShip != -1 && mouseCellX != -1 && mouseCellY != -1)
            {
                if (Game.CanPlaceShip(currentShip, mouseCellX, mouseCellY, shipRotation, player.ShipSet))
                {
                    // Allow rotation via the button.
                    shipRotateButton.Enabled = false;
                    // The current ship is being deployed.
                    shipDeployed[currentShip] = true;

                    // Changing buttons' aspects.
                    switch (currentShip)
                    {
                        case 0:
                            {
                                deployShip0Button.Enabled = false;
                                deleteShip0Button.Enabled = true;
                                break;
                            }
                        case 1:
                            {
                                deployShip1Button.Enabled = false;
                                deleteShip1Button.Enabled = true;
                                break;
                            }
                        case 2:
                            {
                                deployShip2Button.Enabled = false;
                                deleteShip2Button.Enabled = true;
                                break;
                            }
                        case 3:
                            {
                                deployShip3Button.Enabled = false;
                                deleteShip3Button.Enabled = true;
                                break;
                            }
                        case 4:
                            {
                                deployShip4Button.Enabled = false;
                                deleteShip4Button.Enabled = true;
                                break;
                            }
                    }

                    // Deploy the current ship into the ship set.
                    Game.DeployShip(currentShip, mouseCellX, mouseCellY, shipRotation, player.ShipSet);

                    // Redraw the deck.
                    deckPictureBox.Refresh();

                    // Unselect the ship.
                    currentShip = -1;

                    // Are all the ships already deployed?
                    bool areAllShipsDeployed = true;
                    foreach (bool isDeployed in shipDeployed)
                    {
                        if (!isDeployed)
                        {
                            // At least one ship is not deployed.
                            areAllShipsDeployed = false;
                        }
                    }

                    // If all the ships are deployed, enable the done button.
                    if (areAllShipsDeployed)
                    {
                        doneButton.Enabled = true;
                    }
                }
            }
        }

        // Theese methods are all the same for all the ship buttons.
        private void Ship0ButtonClick(object sender, EventArgs e)
        {
            currentShip = 0;
            shipRotateButton.Enabled = true;
        }

        private void Ship1ButtonClick(object sender, EventArgs e)
        {
            currentShip = 1;
            shipRotateButton.Enabled = true;
        }

        private void Ship2ButtonClick(object sender, EventArgs e)
        {
            currentShip = 2;
            shipRotateButton.Enabled = true;
        }

        private void Ship3ButtonClick(object sender, EventArgs e)
        {
            currentShip = 3;
            shipRotateButton.Enabled = true;
        }

        private void Ship4ButtonClick(object sender, EventArgs e)
        {
            currentShip = 4;
            shipRotateButton.Enabled = true;
        }

        // Theese methods are all the same for all the delete buttons.
        private void DeleteShip0ButtonClick(object sender, EventArgs e)
        {
            // Delete the given ship from the deck.
            Game.DeleteShip(0, player.ShipSet);
            // Redraw the deck.
            deckPictureBox.Refresh();
            deployShip0Button.Enabled = true;
            deleteShip0Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip1ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(1, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip1Button.Enabled = true;
            deleteShip1Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip2ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(2, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip2Button.Enabled = true;
            deleteShip2Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip3ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(3, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip3Button.Enabled = true;
            deleteShip3Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip4ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(4, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip4Button.Enabled = true;
            deleteShip4Button.Enabled = false;
            doneButton.Enabled = false;
        }
        
        private void ShipRotateButtonClick(object sender, EventArgs e)
        {
            shipRotation = !shipRotation;
        }

        private void DoneButtonClick(object sender, EventArgs e)
        {
            if (Game.gameMode)
            {
                Game.AIDeployShips();
                MainGameForm mainGame = new MainGameForm();
                mainGame.Location = Location;
                mainGame.Show();

                // Dispose does not trigger FormClosing event.
                Dispose();
            }
            
        }

        private void DeckPictureBoxPaint(object sender, PaintEventArgs e)
        {
            Graphics.DrawShipSet(player.ShipSet, e);
        }

        private void ShipDeploymentFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitToMainMenu = MessageBox.Show("Quit to Main menu?", "Quitting game", MessageBoxButtons.YesNo);
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
