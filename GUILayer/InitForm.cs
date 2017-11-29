using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFPPCommunication;

namespace GUILayer
{
    public partial class Player : Form
    {
        bool valid = false;

        public Player()
        {
           
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(!valid)
            {
                if (NameBox.Text == "")
                {

                }
                if (IPBox.Text == "")
                {

                }
                if (PortBox.Text == "")
                {

                }
            }

            FFPPCommunication.Message _local_join_message = new FFPPCommunication.Message(FFPPCommunication.Message.messageType.JOIN, NameBox.Text);
            FFPPCommunication.Communicator _client_communicator = new Communicator();
            _client_communicator.Enqueue(_local_join_message);
            IPAddress _remote_address = new IPAddress( Int64.Parse(IPBox.Text) );
            int _remote_port = (int)Int64.Parse( PortBox.Text );
            IPEndPoint _target_endpoint = new IPEndPoint(_remote_address, _remote_port);
            if (_client_communicator.Send(_local_join_message, _target_endpoint)) 
            {
                _client_communicator.Close();
            }
        }
    }
}
