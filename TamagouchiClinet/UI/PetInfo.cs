using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TamagouchiClinet.DataTransferObjects;


namespace TamagouchiClinet
{
    class PetInfo:screen
    {
        public PetInfo():base("pet informatin")
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
            List<AnimalDTO> pet = new List<AnimalDTO>();
            pet.Add(UIMain.CurrentAnimal);
          
            object p = (from a in pet
                        select new
                        {

                            Name = a.AnimalName,
                            BirthDate = a.AnimalBd.ToShortDateString(),
                            Weight = a.AnimalWegight,
                            HealthCondition = a.Healthcondition,
                            LifeCycle = a.AnimalCycle,
                            Happiness = a.AnimalHappy,
                            Clean = a.AnimalClean,
                            Hunger = a.AnimalHunger,
                           
                            
                           

                        }
                                      ).FirstOrDefault();
            ObjectView petView = new ObjectView("pet information", p);
           
            petView.Show();
            Console.WriteLine();
            Console.WriteLine("Press a to go to actions");
            char c = Console.ReadKey().KeyChar;
            if (c == 'a' || c == 'A')
            {
                DoAction doAction = new DoAction();
                doAction.Show();
            }


        }
    }
}
