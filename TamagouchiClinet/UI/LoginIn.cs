using TamagouchiClinet.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


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
                    Task<PlayerDTO> t = UIMain.WebAPI.LoginAsync(email, password);
                    Console.WriteLine("Wait while logging in.....");
                    t.Wait();
                    UIMain.CurrentPlayer = t.Result;
                    
                    if(UIMain.CurrentPlayer==null)
                    {
                        Console.WriteLine("Login fail!! Press any key to try again!");
                        Console.ReadKey();
                    }
                }
                Task<AnimalDTO> animalDTO = UIMain.WebAPI.GetPlayerAnimalsAsync();
                animalDTO.Wait();
                UIMain.CurrentAnimal = animalDTO.Result;
                if (!(UIMain.CurrentAnimal==null))
                {
                    Task<AnimalDTO> dTO = UIMain.WebAPI.ChangesAsync();
                    dTO.Wait();
                    UIMain.CurrentAnimal = dTO.Result;
                   
                }
               

            }
             MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
           
        }

    }
}
