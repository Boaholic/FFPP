using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer
{
    
    public class lobbyGame
    {
        //https://www.codeproject.com/Articles/140911/log-net-Tutorial
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
                typeof(lobbyGame)
            );
        public clientPlayer[] associatedPlayers;
        public bool isActive;
        public bool isOpen;
        public lobbyGame()
        {
            associatedPlayers = null;
            isActive = false;
            isOpen = true;
        }
        public void playerJoinGame(clientPlayer newPlayer)
        {
            foreach (clientPlayer p in associatedPlayers)
            {
                if (newPlayer == p)
                {
                    log.Info("Player made duplicate request to join server.");
                    return; //player is already in game
                }
            }
            associatedPlayers.SetValue(newPlayer, associatedPlayers.GetUpperBound(1) + 1);
            log.Info("New Player Joined.");
        }
    }
}
