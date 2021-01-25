using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace TamagouchiClinet
{
    class PlayerInfo:screen
    {
        public PlayerInfo():base("account informtion")
        {

        }
        public override void Show()
        {
            base.Show();
     
         
            ObjectView showPlayer = new ObjectView("",UIMain.CurrentPlayer);
            showPlayer.Show();
            Console.ReadKey();
            
        }
    }
}
