using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloatyFloatPewPew
{
    public abstract class Game
    {
        // Difficulty of the game, 1 for low, 10 for high
        public int Difficulty = 8;

        // Ship lengths.
        public int[] shipLengths = new int[5] { 2, 3, 3, 4, 5 };

        //Stuff for logging
        public char[] letterLabels = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        public string[] numberLables = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public string[] shipLabels = new string[5] { "Patrol Boat,", "Submarine,", "Destroyer,", "Battleship,", "Aircraft Carrier," };

        //true if using this game mode
        public bool gameMode { get; set; }
        // true == player-one's move/ false == player-two's move.
        public bool playerSwitch { get; set; }
        public int roundCount { get; set; }
        public Player player1 { get; set; }
        public Player player2 { get; set; }

        public abstract void Initialize();
        public abstract bool CanPlaceShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet);
        public abstract void DeployShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet);
        public abstract void DeleteShip(int currentShip, int[,] shipSet);
        public abstract bool Attack(int cellX, int cellY, Player attacker, Player attacked);

    }
}
