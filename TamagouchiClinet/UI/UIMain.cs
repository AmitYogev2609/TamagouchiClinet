using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using DataTransferObjects;


namespace TamagouchiClinet
{
    class UIMain
    {
        //UI Main object is perfect for storing all UI state as it is initialized first and detroyed last.

        public static PlayerDTO CurrentPlayer { get; set; }
        public static TamagochiContext db { get; private set; }
        public static AnimalDTO CurrentAnimal { get; set;}

        private screen initialScreen;
        public UIMain(screen initial)
        {
            this.initialScreen = initial;
        }
        public void ApplicationStart()
        {
            //Initialize db context and current player
            db = new TamagochiContext();
            CurrentPlayer = null;
            CurrentAnimal = null;
            //Show Screen and start app!
            initialScreen.Show();
           
        }
    }
}
