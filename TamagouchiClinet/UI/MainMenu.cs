using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace TamagouchiClinet
{ 
    class MainMenu:Menu
    {
        public MainMenu() : base("tamagochi")
        {
         
        }
        public override void Show()
        {
            Console.WriteLine($"hello{UIMain.CurrentPlayer.PfirstName+UIMain.CurrentPlayer.PlastName}");
            AddItem("player infomtion", new PlayerInfo());
            
            if(UIMain.CurrentAnimal== null||UIMain.CurrentAnimal.AnimalCycleId == 6 || UIMain.CurrentAnimal.HealthconditionId == 4 )
            {   
                UIMain.CurrentAnimal = null;
                Console.WriteLine("Your pet has died when you were gone. Please create a new one" );
                AddItem("create pet", new AddPet());
                base.Show();
            }
            else
            {
                AddItem("pet information", new PetInfo());
                AddItem("history of the pet", new PetHistory());
                base.Show();

            }
        }
    }
}
