using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpie1 = new Sharpie("Black", 5);
            Sharpie sharpie2 = new Sharpie("Red", 3);

            Console.WriteLine($"Sharpie1 Ink amount: {sharpie1.InkAmount}");
            Console.WriteLine($"Sharpie2 Ink amount: {sharpie2.InkAmount}");

            sharpie1.Use(10.5);
            sharpie2.Use(50.5);

            Console.WriteLine();

            Console.WriteLine($"Sharpie1 Ink amount: {sharpie1.InkAmount}");
            Console.WriteLine($"Sharpie2 Ink amount: {sharpie2.InkAmount}");

            Console.WriteLine();

            // creation of new sharpie set - should also create a list of sharpies
            SharpieSet setOne = new SharpieSet(); 
            setOne.addSharpie(new Sharpie("Gold", 10));
            setOne.addSharpie(new Sharpie("Silver", 20));
            setOne.addSharpie(new Sharpie("OceanBlue", 30));

            Console.WriteLine("The number of usable sharpies before USING ANY: " + setOne.CountUsable());


            setOne.sharpieList[0].Use(100);


            Console.WriteLine("The number of usable sharpies after USING: " + setOne.CountUsable());
            Console.Read();
        }
    }

}
