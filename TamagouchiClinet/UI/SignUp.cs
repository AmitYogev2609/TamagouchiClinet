using System;
using System.Collections.Generic;
using System.Text;

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
                UIMain.CurrentPlayer  = UIMain.db.AddPlayer(firstName, lastName, email, userName,password, gender, BDay);
               }
            }
          
            AddPet addPet = new AddPet();
            addPet.Show();
               
        }
        
    }
}
