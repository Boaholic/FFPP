using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer
{
    public class lobbyGame
    {
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
                    return; //player is already in game
                }
            }
            associatedPlayers.SetValue(newPlayer, associatedPlayers.GetUpperBound(1) + 1);
        }
    }
}
