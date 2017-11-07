using System;

namespace AppLayer
{
    public class lobbyServer
    {
        //https://www.codeproject.com/Articles/140911/log-net-Tutorial
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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
