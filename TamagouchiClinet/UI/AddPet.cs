using TamagouchiClinet.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



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

                Task<AnimalDTO> t = UIMain.WebAPI.AddPetAsync(petName);
                t.Wait();
                UIMain.CurrentAnimal = t.Result;
                if(UIMain.CurrentAnimal == null)
                {
                    Console.WriteLine("Something went wrong. Please try again");
                }
            }
            
           
            
           
           LoginIn signUpFirst = new LoginIn();
            signUpFirst.Show();
        }
    }
}
