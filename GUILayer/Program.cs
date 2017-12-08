using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Threading;

namespace FloatyFloatPewPew
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Start to play the main menu sound in loop.
            Sound.menuSoundPlayer.PlayLooping();

            // Initialize the main menu and run the application.
            MainMenuForm mainMenuForm = new MainMenuForm();
            GlobalState.MainMenuForm = mainMenuForm;
            Application.Run(mainMenuForm);
        }
    }
}
