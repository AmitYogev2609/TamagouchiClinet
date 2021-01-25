using System;
using System.Collections.Generic;
using System.Text;

namespace TamagouchiClinet
{
    class DoAction:screen
    {
        public DoAction():base("choose action to do on your pet")
        {

        }
        public override void Show()
        {
            base.Show();
           
            Console.WriteLine($"1.Clean {UIMain.CurrentAnimal.AnimalName} - add 20 to the clean index ");
            Console.WriteLine($"2.Feed {UIMain.CurrentAnimal.AnimalName} - add 20 to the hunger index ");
            Console.WriteLine($"3.Play with {UIMain.CurrentAnimal.AnimalName} - add 20 to the happy index ");
            Console.Write($"Please choose (1 - 3):");
              
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                        UIMain.CurrentAnimal.CleanFunction();
                        UIMain.db.SaveChanges();
                        UIMain.CurrentAnimal.UptadeHealthCondition();
                        UIMain.db.SaveChanges();
                        
                } break;
                case 2:
                {
                        UIMain.CurrentAnimal.FeedFunction();
                        UIMain.db.SaveChanges();
                        UIMain.CurrentAnimal.UptadeHealthCondition();
                        UIMain.db.SaveChanges();
                    } break;
                case 3:
                {
                        UIMain.CurrentAnimal.PlayFunction();
                        UIMain.db.SaveChanges();
                        UIMain.CurrentAnimal.UptadeHealthCondition();
                        UIMain.db.SaveChanges();
                    } break;

            }
                
        }
    }
}
