using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            garden.AddPlant(new Flower("yellow"));
            garden.AddPlant(new Flower("blue"));
            garden.AddPlant(new Tree("purple"));
            garden.AddPlant(new Tree("orange"));

            garden.ShowGarden();
            garden.WaterPlants(40);
            garden.WaterPlants(70);
            

            Console.ReadLine();
        }

        
    }
}
