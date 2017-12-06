using System;
using System.Collections.Generic;
using System.Threading;


namespace GUILayer
{
    //This class contains all the necessary Logic for the game
    public static class Game
    {
        // Difficulty of the game, 1 for low, 10 for high
        static int Difficulty = 8;

        // Ship lengths.
        public static int[] shipLengths = new int[5] { 2, 3, 3, 4, 5 };

        //Stuff for logging
        public static char[] letterLabels = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        public static string[] numberLables = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public static string[] shipLabels = new string[5] { "Patrol Boat,", "Submarine,", "Destroyer,", "Battleship,", "Aircraft Carrier," };

        // true ==singleplayer / false==multiplayer.
        public static bool gameMode;
        // true == player-one's move/ false == player-two's move.
        public static bool playerSwitch;
        public static int roundCount;
        public static GamePlayer player1;
        public static GamePlayer player2;

       
        static public void Initialize()
        {
            playerSwitch = true;
            roundCount = 1;
        }
      
        static public bool CanPlaceShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet)
        {
            // index of the most upper-left cell
            if (cellX < 0 || cellY < 0)
            {
                return false;
            }

            if (isHorizontal)
            {
                if (cellX + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + Game.shipLengths[currentShip]); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + 1); j++)
                        {
                            if (shipSet[i, j] != -1)
                            {
                                // Invalid layout found.
                                return false;
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
            else
            {
                // Vertical validation.
                if (cellY + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + 1); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + Game.shipLengths[currentShip]); j++)
                        {
                            if (shipSet[i, j] != -1)
                            {
                                // Invalid layout found.
                                return false;
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
        }

        //Returns whether a cell can contain a ship. For AI
        
        static public bool CanPlaceShipAI(int currentShip, int cellX, int cellY, bool isHorizontal, GamePlayer player)
        {
            // Is the index of the most upper-left cell within the bounds.
            if (cellX < 0 || cellY < 0)
            {
                return false;
            }

            if (isHorizontal)
            {
                if (cellX + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + Game.shipLengths[currentShip]); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + 1); j++)
                        {
                            // Ship position cells.
                            if (i >= cellX && i < cellX + shipLengths[currentShip] && j == cellY)
                            {
                                // If the cell is revealed and there is water or a sunken ship.
                                if ((player.RevealedCells[i, j] && player.ShipSet[i, j] == -1) || (player.ShipSet[i, j] != -1 && player.ShipLeftCells[player.ShipSet[i, j]] == 0))
                                {
                                    // Invalid layout found.
                                    return false;
                                }

                            }
                            // Neighbouring cells.
                            else
                            {
                                // If there is a neighbouring revealed ship cell.
                                if (player.RevealedCells[i, j] && player.ShipSet[i, j] != -1)
                                {
                                    // Invalid layout found.
                                    return false;
                                }
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
            else
            {
                // Vertical validation.
                if (cellY + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + 1); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + Game.shipLengths[currentShip]); j++)
                        {
                            // Ship position cells.
                            if (j >= cellY && j < cellY + shipLengths[currentShip] && i == cellX)
                            {
                                // If the cell is revealed and there is water or a sunken ship.
                                if (player.RevealedCells[i, j] && (player.ShipSet[i, j] == -1) || (player.ShipSet[i, j] != -1 && player.ShipLeftCells[player.ShipSet[i, j]] == 0))
                                {
                                    // Invalid layout found.
                                    return false;
                                }

                            }
                            // Neighbouring cells.
                            else
                            {
                                // If there is a neighbouring revealed ship cell.
                                if (player.RevealedCells[i, j] && player.ShipSet[i, j] != -1)
                                {
                                    // Invalid layout found.
                                    return false;
                                }
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
        }

        // Add ship to shipset
        static public void DeployShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet)
        {
            if (isHorizontal)
            {
                for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                {
                    // Deploy into a ship set.
                    shipSet[cellX + i, cellY] = currentShip;
                }
            }
            else
            {
                for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                {
                    // Deploy into a ship set.
                    shipSet[cellX, cellY + i] = currentShip;
                }
            }

        }

        // Delete a ship from the ship set
        static public void DeleteShip(int currentShip, int[,] shipSet)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (shipSet[x, y] == currentShip)
                    {
                        shipSet[x, y] = -1;
                    }
                }
            }
        }

        // Random ship deployment for AI
        static public void AIDeployShips()
        {
            // Stepwise through all ships.
            for (int currentShip = 0; currentShip < 5; currentShip++)
            {
                // Inicializating the list of possibilities.
                List<int[]> possibilities = new List<int[]>();
                List<bool> rotationAspects = new List<bool>();

                // For all cells in grid 10 x 10.
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        // Is there a valid horizontal layout at [x,y] in the current grid?
                        if (CanPlaceShip(currentShip, x, y, true, player2.ShipSet))
                        {
                            // Add into possibilities, [x, y].
                            possibilities.Add(new int[2] { x, y });
                            // At this index, add the horizontal rotation aspect.
                            rotationAspects.Add(true);
                        }

                        // Is there a valid vertical layout at [x,y] in the current grid?
                        if (CanPlaceShip(currentShip, x, y, false, player2.ShipSet))
                        {
                            // Add into possibilities, [x, y].
                            possibilities.Add(new int[2] { x, y });
                            // At this index, add the vertical rotation aspect.
                            rotationAspects.Add(false);
                        }
                    }
                }

                // Choosing possibility.
                int numberOfChosen = GlobalState.RandomNumber(possibilities.Count);

                // Deploy the ship into the ship set.
                DeployShip(currentShip, possibilities[numberOfChosen][0], possibilities[numberOfChosen][1], rotationAspects[numberOfChosen], Game.player2.ShipSet);
            }
        }

        // Adds probability to all the spots the ship can be deployed.
        static private void probabilitySetAddShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] probabilitySet)
        {
            for (int i = 0; i < shipLengths[currentShip]; i++)
            {
                if (isHorizontal)
                {
                    probabilitySet[cellX + i, cellY]++;
                }
                else
                {
                    probabilitySet[cellX, cellY + i]++;
                }
            }
        }

        // AI method for choosing a cell to hit.
        static public int[] AIChooseCellToHit(GamePlayer player)
        {
            // Prepared array of ship cell probabilities
            int[,] probabilitySet = new int[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    probabilitySet[x, y] = 0;
                }
            }

            // Cells of successful attacks for AI
            List<int[]> SuccessfulHits = new List<int[]>();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (player.RevealedCells[x, y] && player.ShipSet[x, y] != -1 && player.ShipLeftCells[player.ShipSet[x, y]] != 0)
                    {
                        // Hit!  Add [X,Y].
                        SuccessfulHits.Add(new int[2] { x, y });
                    }
                }
            }

            // Are there any hits?  If so, we search these instead of random
            if (SuccessfulHits.Count != 0)
            {
                // For every revealed cell of a partially revealed ship.
                foreach (int[] hit in SuccessfulHits)
                {
                    // Calculate the cross probability.
                    for (int currentShip = 0; currentShip < 5; currentShip++)
                    {
                        // For all the available ships left.
                        if (player.ShipLeftCells[currentShip] != 0)
                        {
                            // Apply cross search for each parial revealation cell.
                            for (int coorOffset = 0; coorOffset < shipLengths[currentShip]; coorOffset++)
                            {
                                if (CanPlaceShipAI(currentShip, hit[0] - coorOffset, hit[1], true, player))
                                {
                                    probabilitySetAddShip(currentShip, hit[0] - coorOffset, hit[1], true, probabilitySet);
                                }
                                if (CanPlaceShipAI(currentShip, hit[0], hit[1] - coorOffset, false, player))
                                {
                                    probabilitySetAddShip(currentShip, hit[0], hit[1] - coorOffset, false, probabilitySet);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // No partially revealed ship found.
                for (int currentShip = 0; currentShip < 5; currentShip++)
                {
                    // For all the available ships left.
                    if (player.ShipLeftCells[currentShip] != 0)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                // Validate the possible deployment and add it to the probabilities if valid.
                                if (CanPlaceShipAI(currentShip, x, y, true, player))
                                {
                                    probabilitySetAddShip(currentShip, x, y, true, probabilitySet);
                                }
                                if (CanPlaceShipAI(currentShip, x, y, false, player))
                                {
                                    probabilitySetAddShip(currentShip, x, y, false, probabilitySet);
                                }
                            }
                        }
                    }
                }
            }

           

            // Find the maximum possibility of a cell to contain a ship.
            int maxPossibility = -1;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (probabilitySet[x, y] > maxPossibility && !player.RevealedCells[x, y])
                    {
                        maxPossibility = probabilitySet[x, y];
                    }
                }
            }

            // Collect all the cells with a favourable probability to contain a ship.
            List<int[]> LikelyTargets = new List<int[]>();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    // Is there any partially revealed cell?
                    if (SuccessfulHits.Count != 0)
                    {
                        // Collect the cell that have the best possibility of being a ship cell.
                        if (probabilitySet[x, y] == maxPossibility && !player.RevealedCells[x, y])
                        {
                            LikelyTargets.Add(new int[] { x, y });
                        }
                    }
                    else
                    {
                        // Collect the cells that have favourable possibility of being a ship cell.
                        if (probabilitySet[x, y] >= Math.Max((maxPossibility / 10 * Difficulty), 1) && !player.RevealedCells[x, y])
                        {
                            LikelyTargets.Add(new int[] { x, y });
                        }
                    }
                }
            }

            // Return a random cell out of all fabourable cells.
            return LikelyTargets[GlobalState.RandomNumber(LikelyTargets.Count)];
        }

        // Perform an attack of a player on a player at a given cell.
        // [true] if game is over and the attacker won / [false] if not.
        static public bool Attack(int cellX, int cellY, GamePlayer attacker, GamePlayer attacked)
        {
            string attackerLogNote = "--> " + String.Format("{0:000}", roundCount) + ".round:" + attacker.Name + ", Firing "
                + attacked.Name + " at [ " + letterLabels[cellX] + "," + numberLables[cellY] + " ]. ";
            string attackedLogNote = "<-- " + String.Format("{0:000}", roundCount) + ".round:  You, have been fired upon by: " + attacker.Name + 
                " at [ " + letterLabels[cellX] + "," + numberLables[cellY] + " ]. ";

            // Play a shot sound and wait a second for dramatic effect.
            Sound.PlayShot();
            Thread.Sleep(1000);

            // Mark the cell as revealed and update counts
            attacked.RevealedCells[cellX, cellY] = true;
            attacked.UnrevealedCells--;

            attacked.LastRevieledCells[0] = cellX;
            attacked.LastRevieledCells[1] = cellY;

            // Attack hit
            if (attacked.ShipSet[cellX, cellY] != -1)
            {
                //Play hit sound
                Sound.PlayHit();
                // Decrease the amount of ship cells left.
                attacked.ShipCells--;
                // Increase the count of attacker's hits.
                attacker.Hits++;
                // Recalculate the attacker's hit ratio.
                attacker.HitRatio = Convert.ToDouble(attacker.Hits) / Convert.ToDouble(Game.roundCount);

                // Decrease the amount of cells left for the ship that has been hit.
                attacked.ShipLeftCells[attacked.ShipSet[cellX, cellY]]--;

                attackedLogNote = attackedLogNote  + shipLabels[attacked.ShipSet[cellX, cellY]] + " has been hit! "
                    + attacked.ShipLeftCells[attacked.ShipSet[cellX, cellY]].ToString() + " hits remaining. ";
                attackerLogNote = attackerLogNote + "You've hit " + attacked.Name + "'s ship! ";
                // sunken ship
                if (attacked.ShipLeftCells[attacked.ShipSet[cellX, cellY]] == 0)
                {
                   
                    attacked.ShipsLeft--;

                    attackedLogNote = attackedLogNote + "Ship SUNK!. You have " + attacked.ShipsLeft.ToString() + " more ships left. ";
                    attackerLogNote = attackerLogNote + "You have sunk: " + attacked.Name +"'s" +
                        shipLabels[attacked.ShipSet[cellX, cellY]] + ". They have " + attacked.ShipsLeft.ToString() + " ships remaining. ";

                   
                    int extraRevealedCells = 0;

                    // Reveal neighbouring cells of the sunken ship.
                    for (int x = 0; x < 10; x++)
                    {
                        for (int y = 0; y < 10; y++)
                        {
                            if (attacked.ShipSet[x, y] == attacked.ShipSet[cellX, cellY])
                            {
                                try
                                {
                                    if (!attacked.RevealedCells[x - 1, y - 1])
                                    {
                                        attacked.RevealedCells[x - 1, y - 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x - 1, y])
                                    {
                                        attacked.RevealedCells[x - 1, y] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x - 1, y + 1])
                                    {
                                        attacked.RevealedCells[x - 1, y + 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x, y - 1])
                                    {
                                        attacked.RevealedCells[x, y - 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x, y + 1])
                                    {
                                        attacked.RevealedCells[x, y + 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x + 1, y - 1])
                                    {
                                        attacked.RevealedCells[x + 1, y - 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x + 1, y])
                                    {
                                        attacked.RevealedCells[x + 1, y] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x + 1, y + 1])
                                    {
                                        attacked.RevealedCells[x + 1, y + 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };
                            }
                        }
                    }

                    // Decrease the number of unrevealed cells.
                    attacked.UnrevealedCells -= extraRevealedCells;

                    // Is the game over?
                    if (attacked.ShipsLeft == 0)
                    {
                        attackerLogNote = attackerLogNote + attacker.Name.ToString() + " won the battle!";
                        attacked.BattleLog = attacked.BattleLog + attackedLogNote + "\n";
                        attacker.BattleLog = attacker.BattleLog + attackerLogNote + "\n";
                        return true;
                    }
                    else
                    {
                        // Else return a false, some ships are left
                        attacked.BattleLog = attacked.BattleLog + attackedLogNote + "\n";
                        attacker.BattleLog = attacker.BattleLog + attackerLogNote + "\n";
                        return false;
                    }
                }
                else
                {
                    //There are some ship cells left in this ship, so that Game dont end
                    attacked.BattleLog = attacked.BattleLog + attackedLogNote + "\n";
                    attacker.BattleLog = attacker.BattleLog + attackerLogNote + "\n";
                    return false;
                }
            }
            else
            {
                // The attack is not a hit.
                attackedLogNote = attackedLogNote + " MISS!.";
                attackerLogNote = attackerLogNote + " MISS!.";
                attacker.Misses++;
                attacker.HitRatio = Convert.ToDouble(attacker.Hits) / Convert.ToDouble(Game.roundCount);

                Sound.PlaySplash();
                attacked.BattleLog = attacked.BattleLog + attackedLogNote + "\n";
                attacker.BattleLog = attacker.BattleLog + attackerLogNote + "\n";
                return false;
            }

        }
    }
}
