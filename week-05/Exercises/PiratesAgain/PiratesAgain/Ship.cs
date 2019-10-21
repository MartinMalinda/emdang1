using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesAgain
{
    class Ship
    {
        public bool HasCaptain { get; set; } = false;
        public List<Pirate> crew { get;set; }

        public Ship()
        {
            crew = new List<Pirate>();
        }

        public void AddPirate(Pirate pirate)
        {
            if(crew.Count == 0 && pirate.PirateType == Pirate.pirateType.Captain)
            {
                crew.Add(pirate);
                HasCaptain = true;
                
            }
            else if(HasCaptain == true && pirate.PirateType == Pirate.pirateType.Captain)
             {
                Console.WriteLine("This ship can only have ONE captain!");
            }
            else
            {
                crew.Add(pirate);
            }



            //if (crew.Count == 0)
            //{
            //    crew.Add(pirate);
            //}
            //else
            //{
            //    for (int i = 0; i < crew.Count; i++)
            //    {

            //    }

                //foreach (var crewMember in crew)
                //{
                //    if (crewMember.PirateType == Pirate.pirateType.Captain)
                //    {
                //        Console.WriteLine("This ship can only have ONE captain!");
                //    }
                //    else
                //    {
                //        crew.Add(pirate);
                //    }
                //}
              
        }
    }
}
