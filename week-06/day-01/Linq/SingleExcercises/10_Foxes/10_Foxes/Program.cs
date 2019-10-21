using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Foxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxList = new List<Fox>();

            foxList.Add(new Fox("liska1", "lesni", "orange"));
            foxList.Add(new Fox("liska2", "polni", "Green"));
            foxList.Add(new Fox("liska3", "polarni", "white"));
            foxList.Add(new Fox("liska4", "Pallida", "green"));
            foxList.Add(new Fox("liska5", "pallida", "gold"));


            Console.WriteLine("Green Foxes: ");
            var greenFoxesList = foxList.Where(f => f.Color.ToLower() == "green").ToList();
            greenFoxesList.ForEach(gf => Console.WriteLine(gf.Name));

            Console.WriteLine();

            Console.WriteLine("Green Pallida Foxes: ");
            var pallidaFoxesList = foxList.Where(f => f.Type.ToLower() == "pallida" && f.Color.ToLower() == "green").ToList();
            pallidaFoxesList.ForEach(pf => Console.WriteLine(pf.Name));


            Console.ReadLine();
        }
    }
}
