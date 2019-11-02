using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RedColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("---------------------RED COLOR---------------------");
        }
    }
}
