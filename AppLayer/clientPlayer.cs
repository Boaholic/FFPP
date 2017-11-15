﻿using log4net;
using System.Net;
using System.Net.Sockets;

namespace AppLayer
{
    public partial class clientPlayer
    {
        //https://www.codeproject.com/Articles/140911/log-net-Tutorial
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
                typeof(clientPlayer)
            );
        public string playerName { get; set; }
        public static readonly ILog Logger = LogManager.GetLogger(typeof(serverMessage));
        public string A_Number { get; set; }
        public IPAddress _ServerAddress { get; set; }
        public UdpClient MyUdpClient { get; set; }

        public IPEndPoint myEndPoint;
        public IPEndPoint _ServerEndPoint;
        public static System.Timers.Timer Controller;
        public int Port { get; set; }
        // System.Timers.TImer, db heartbeat, in score , s answer 

        public int Score { get; set; }
        public messageReadWrite playerReadWrite = new messageReadWrite();
      
        public clientPlayer(serverMessage initialClientMessage)
        {
            playerName = initialClientMessage.messageBody;
        }
        public bool hasJoinedGame
        {
            get
            {
                return hasJoinedGame;
            }
            set
            {
                hasJoinedGame = value;
            }
        }
        public bool playerHasRequestedJoin
        {
            get
            {
                return playerHasRequestedJoin;
            }
            set
            {
                playerHasRequestedJoin = value;
            }
        }
        public bool playerHasRequestedLeave
        {
            get
            {
                return playerHasRequestedLeave;
            }
            set
            {
                playerHasRequestedLeave = value;
            }
        }
        public serverMessage SendIsReady()
        {
            //create an isReady message
            serverMessage isReadyMessage = new serverMessage(serverMessage.messageType.ACK, "");
            //send an isReady message
            return isReadyMessage;
        }
    }
}