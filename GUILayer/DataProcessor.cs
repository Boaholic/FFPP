using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFPPCommunication;
using System.Threading;
using System.Net;

namespace FloatyFloatPewPew
{
    public class DataProcessor
    {
        public LobbyForm Lobby { get; set; }
        private Communicator Communicator { get; set; }

        public IPEndPoint ServerEndPoint { get; set; }
        public IPEndPoint LocalEndPoint { get; set; }
        private bool keepProccessing;
        public string LobbyLog { get; set; }

        public DataProcessor()
        {
            keepProccessing = true;
            Communicator = new Communicator();
            LocalEndPoint = Communicator.LocalEndPoint;
            LobbyLog = "";
        }
        public void Start()
        {
            Lobby = new LobbyForm();
            LocalEndPoint = Communicator.LocalEndPoint;
            Thread LobbyCommunicator = new Thread(new ThreadStart(Communicator.Listen));
            LobbyCommunicator.Start();

            while (keepProccessing)
            {
                ProccessRequests();
            }
        }

        public void Stop()
        {
            keepProccessing = false;
            Communicator.Close();
        }

        private void ProccessRequests()
        {
            Message request = Communicator.Dequeue();

            if (request != null)
            {
                string[] props = ParseBody(request);
                bool success = DoAction(request.fromAddress, props);
            }
        }

        private string[] ParseBody(Message request)
        {
            return request.messageBody.Split('|');
        }

        private bool DoAction(IPEndPoint returnAddress, string[] props)
        {
            string action = props[0];
            bool result = false;
            action = action.ToUpper();
            switch (action)
            {
                //case "LOBBYLOG":
                    //LobbyLog += props[1];
                    //Lobby.UpdateLog();
                    //break;
            }

            return result;
        }

        public bool SendRequest(Message message)
        {
            return Communicator.Send(message, ServerEndPoint);
        }

    }
}
