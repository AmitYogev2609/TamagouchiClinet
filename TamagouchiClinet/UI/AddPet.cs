using System;
using System.Collections.Generic;
using System.Text;


namespace TamagouchiClinet
{
    class AddPet : screen
    {
        public AddPet():base("add pet")
        {

        }
        public override void Show()
        {
            base.Show();
            while  (UIMain.CurrentAnimal == null)
            {
                base.Show();
                Console.WriteLine("Enter your pet's name!!!");
                    string petName = Console.ReadLine();
                    UIMain.CurrentAnimal = UIMain.db.AddAnimal(petName, UIMain.CurrentPlayer);
                if(UIMain.CurrentAnimal == null)
                {
                    Console.WriteLine("Something went wrong. Please try again");
                }
            }
            UIMain.db.SaveChanges();
            UIMain.CurrentPlayer.ChangeActiveAnimal( UIMain.CurrentAnimal);
            UIMain.db.SaveChanges();
           
           LoginIn signUpFirst = new LoginIn();
            signUpFirst.Show();
        }
    }
}
