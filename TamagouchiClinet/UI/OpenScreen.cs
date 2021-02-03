using System;
using System.Collections.Generic;
using System.Text;

namespace TamagouchiClinet
{
    class OpenScreen :Menu
    {
        public OpenScreen():base("TAMAGOCHI")
        {

        }
        public override void Show()
        {    
            AddItem("log in", new LoginIn());
            AddItem("sign up", new SignUp());
            base.Show();
            
        }
    }
}
