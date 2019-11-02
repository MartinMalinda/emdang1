using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Printer
    {
        private IColor color;

        public Printer(IColor color)
        {
            this.color = color;
        }
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
            color.PrintColor();
        }
    }
}
