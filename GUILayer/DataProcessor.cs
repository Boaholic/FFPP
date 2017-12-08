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
        private Communicator Communicator = new Communicator();

        public IPEndPoint ServerEndPoint { get; set; }

        public void Start()
        {
            Thread CommunicatorThread = new Thread(new ThreadStart(Communicator.Listen));
            CommunicatorThread.Start();
        }

        public bool SendRequest(Message message)
        {
            return Communicator.Send(message, ServerEndPoint);
        }

        public string GetConnectResponse()
        {
            Message response = Communicator.Dequeue();
            if(response != null)
            {
                string[] props = response.messageBody.Split('|');
                if(props[0] == "Connect")
                {
                    return props[1];
                }
            }
            return null;
        }
    }
}
