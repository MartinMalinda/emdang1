using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples
{
    public class Apple
    {
        private List<int> list = new List<int>() { 1, 2, 3, 4 };
        public List<int> List { get; private set; }

        public Apple()
        {
            List = list;
        }

        public string GetApple()
        {
            return "apple";
        }

        public int SumList(List<int> list)
        {
            return list.Sum();
        }
    }
}
