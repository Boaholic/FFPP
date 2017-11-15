using System;

namespace AppLayer
{
    public class LobbyServer
    {
        //https://www.codeproject.com/Articles/140911/log-net-Tutorial
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
                typeof(LobbyServer)
            );
        public Player[] totalAssociatedPlayers;
        public LobbyGame[] gamesInLobby;
        public void newLobbyPlayer(Player newPlayer)
        {
            foreach (Player p in totalAssociatedPlayers)
            {
                if (newPlayer == p)
                {
                    return; //The player already exists
                }
            }
            totalAssociatedPlayers.SetValue(newPlayer, totalAssociatedPlayers.GetUpperBound(1) + 1);
        }

        public LobbyServer()
        {
            totalAssociatedPlayers = null;
            //Create two new instances of lobbygame
            LobbyGame firstGame = new LobbyGame();
            LobbyGame secondGame = new LobbyGame();
            gamesInLobby.SetValue(firstGame, gamesInLobby.GetUpperBound(1) + 1);
            gamesInLobby.SetValue(secondGame, gamesInLobby.GetUpperBound(1) + 1);
        }
    }
}
