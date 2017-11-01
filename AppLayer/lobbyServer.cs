using System;

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
    public class lobbyServer
    {
        public clientPlayer[] totalAssociatedPlayers;
        public lobbyGame[] gamesInLobby;
        public void newLobbyPlayer(clientPlayer newPlayer)
        {
            foreach (clientPlayer p in totalAssociatedPlayers)
            {
                if (newPlayer == p)
                {
                    return; //The player already exists
                }
            }
            totalAssociatedPlayers.SetValue(newPlayer, totalAssociatedPlayers.GetUpperBound(1) + 1);
        }

        public lobbyServer()
        {
            totalAssociatedPlayers = null;
            //Create two new instances of lobbygame
            lobbyGame firstGame = new lobbyGame();
            lobbyGame secondGame = new lobbyGame();
            gamesInLobby.SetValue(firstGame, gamesInLobby.GetUpperBound(1) + 1);
            gamesInLobby.SetValue(secondGame, gamesInLobby.GetUpperBound(1) + 1);
        }
    }
}
