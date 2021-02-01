using System;
using System.Collections.Generic;
using System.Text;
using TamagouchiClinet.DataTransferObjects;
using TamagouchiClinet.WebServices;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace TamagouchiClinet
{
    class SignUp:screen
    {
        public SignUp():base("Sign Up")
        {

        }
        public override void Show()
        {
            base.Show();
           Console.Clear();
            while  (UIMain.CurrentPlayer == null)
            {
                Console.WriteLine("Enter your firstname!");
                    string firstName = Console.ReadLine();
                Console.WriteLine("\nEnter your lastname!");
                    string lastName = Console.ReadLine();
                Console.WriteLine("\nEnter your username!");
                    string userName = Console.ReadLine();
                Console.WriteLine("\nEnter your email!");
                    string email = Console.ReadLine();
                Console.WriteLine("\nEnter your gender!");
                    string gender = Console.ReadLine();
                Console.WriteLine("\nEnter passsword!");
                    string password = Console.ReadLine();
                Console.WriteLine("plese enter your birthady date");
                Console.WriteLine("year:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("month:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("day:");
                int day = int.Parse(Console.ReadLine());
                if(!((year>1&&year<9999)||(month>1&&month<12)||(day>1&&day<DateTime.DaysInMonth(year,month))))
                {
                    Console.WriteLine("plese insert actual date");
                }
                else
                { 
                DateTime BDay = new DateTime(year, month, day);  
                    Task<PlayerDTO> player = UIMain.WebAPI.SignUpAsync(firstName, lastName, email, userName,password, gender, BDay);
                    player.Wait();
                    UIMain.CurrentPlayer = player.Result;
                    
                    
                }
            }
          Console.WriteLine("sucses");
            AddPet addPet = new AddPet();
            addPet.Show();
               
        }
        
    }
}
