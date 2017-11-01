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
    public partial class clientPlayer : Form
    {
        bool valid = false;

        public clientPlayer()
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
          

        }
    }
}
