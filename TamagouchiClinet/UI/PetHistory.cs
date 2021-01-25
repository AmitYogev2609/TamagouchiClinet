using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TamagouchiClinet
{
    class PetHistory:screen
    {
        public PetHistory():base("your pet history")
        {
            
        }
        public override void Show()
        {
            base.Show();
            ObjectsList historyOfFunction = new ObjectsList("History of the pet action", UIMain.CurrentAnimal.GetHistoryOfFunctionList().ToList<object>());
            historyOfFunction.Show();

            Console.ReadKey();                                  
                                         

            


        }
    }
    
}
