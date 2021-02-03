using System;
using System.Collections.Generic;
using System.Text;
using TamagouchiClinet.DataTransferObjects;

using System.Net.Http;

using System.Text.Json;
using System.Threading.Tasks;


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
            Console.WriteLine("4.exit");
           
            int option = 0;
            bool a = false;
            while(!a)
            {
                Console.Write($"Please choose (1 - 4):");
                a = int.TryParse(Console.ReadLine(), out option);
                if (option < 1 || option > 4)
                    a = false;
                if(a==false)
                    Console.WriteLine("you need to choose a number between 1-4");
            }
           
            if(option==4)
            { }
            else
            { 
            Task<AnimalDTO> animalDTO = UIMain.WebAPI.DoAction(option);
            animalDTO.Wait();
            UIMain.CurrentAnimal = animalDTO.Result;
                PetInfo pet = new PetInfo();
                pet.Show();
             }

        }
    }
}
