using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Garden
    {
        public List<Plant> plants { get; set; }

        public Garden()
        {
            plants = new List<Plant>();
        }

        public void AddPlant(Plant plant)
        {
            plants.Add(plant);
        }

        public void ShowGarden()
        {
            foreach (var item in plants)
            {
                Console.WriteLine($"The {item.Color} {item.ToString()} {item.NeedsWaterStringStatus()} [{item.CurrentWaterLevel}].");
            }
            Console.WriteLine();
        }

        public void WaterPlants(int waterAmount)
        {
            int plantsToBeWatered = 0;
            foreach (var item in plants)
            {
                if ((item is Flower) && item.CurrentWaterLevel < 5)
                {
                    plantsToBeWatered++;
                    item.SetNeedsWater(true);
                }
                if ((item is Tree) && item.CurrentWaterLevel < 10)
                {
                    plantsToBeWatered++;
                    item.SetNeedsWater(true);
                }
            }

            int oneWatering = waterAmount / plantsToBeWatered;

            foreach (var item in plants)
            {
                if (item is Flower && item.NeedsWater == true)
                {
                    item.SetCurrentWaterLevel(oneWatering);
                }
                if (item is Tree && item.NeedsWater == true)
                {
                    item.SetCurrentWaterLevel(oneWatering);
                }
            }
            this.ShowGarden();
        }
    }

}
