using System;
using System.Collections.Generic;
using System.Text;

namespace TamagouchiClinet
{
    class LoginIn : screen
    {
        public LoginIn():base("Log In")
        {

        }
        public override void Show()
        {
            base.Show();

            if(UIMain.CurrentPlayer!=null)
            {
               
            }
            else
            {
                while(UIMain.CurrentPlayer==null)
                { 
                Console.WriteLine($"Please enter your email: ");
                string email = Console.ReadLine();
                Console.WriteLine($"Please enter your password: ");
                string password = Console.ReadLine();
                    UIMain.CurrentPlayer = UIMain.db.LogIn(email,password);
                    if(UIMain.CurrentPlayer==null)
                    {
                        Console.WriteLine("Login fail!! Press any key to try again!");
                        Console.ReadKey();
                    }
                }
                UIMain.CurrentAnimal = UIMain.CurrentPlayer.FindPet();
                if (!(UIMain.CurrentAnimal==null))
                {
                    UIMain.db.SaveChanges();
                    UIMain.CurrentAnimal.Changes();
                    UIMain.db.SaveChanges();
                    UIMain.CurrentAnimal.UptadeHealthCondition();
                    UIMain.db.SaveChanges();
                }
                UIMain.db.SaveChanges();

            }
             MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
           
        }

    }
}
