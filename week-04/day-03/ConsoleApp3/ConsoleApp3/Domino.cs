using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Domino : IComparable
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino otherDomino)
        {
            if(this.values[1] == otherDomino.values[0])
            {
                return 0;
            }
        }

        public int[] GetValues()
        {
            return values;
        }
    }
}
