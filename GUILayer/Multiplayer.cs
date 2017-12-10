using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFPPCommunication;
using System.Threading;

namespace FloatyFloatPewPew
{
    public class Multiplayer : Game
    {
        private static Multiplayer _instance;
        private static readonly object MyLock = new object();

        public DataProcessor Processor { get; set;}
        private Multiplayer()
        {
            Initialize();
        }

        public static Multiplayer Instance
        {
            get
            {
                lock (MyLock)
                {
                    if (_instance == null)
                        _instance = new Multiplayer();
                }
                return _instance;
            }
        }
        public override void Initialize()
        {
            Processor = new DataProcessor();
            playerSwitch = true;
            roundCount = 1;
            gameMode = true;
        }

        public void StartProccessor()
        {
            Thread ProcessorThread = new Thread(new ThreadStart(Processor.Start));
            ProcessorThread.Start();
        }

        public override bool Attack(int cellX, int cellY, Player attacker, Player attacked)
        {
            throw new NotImplementedException();
        }

        public override bool CanPlaceShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet)
        {
            throw new NotImplementedException();
        }

        public override void DeleteShip(int currentShip, int[,] shipSet)
        {
            throw new NotImplementedException();
        }

        public override void DeployShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet)
        {
            throw new NotImplementedException();
        }

    }
}
