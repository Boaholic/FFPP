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
                valid = true;
                ErrorBox.Visible = false;
                ErrorBox.Text = "";

                if (NameBox.Text == "")
                {
                    ErrorBox.Visible = true;
                    ErrorBox.Text += "Name cannot be empty\n";
                    valid = false;
                    
                }
                if (IPBox.Text == "")
                {
                    ErrorBox.Visible = true;
                    ErrorBox.Text += "IP Address Cannot be empty\n";
                    valid = false;
                }
                if (PortBox.Text == "")
                {
                    ErrorBox.Visible = true;
                    ErrorBox.Text += "Port Cannot be empty\n";
                    valid = false;
                }
                if(!ValidateIPv4(IPBox.Text))
                {
                    ErrorBox.Visible = true;
                    ErrorBox.Text += "IP address is not valid\n";
                    valid = false;
                }
            }
            else
            {

                Lobby _Lobby = new Lobby();
                _Lobby.Show();

            }
          

        }
    }
}
