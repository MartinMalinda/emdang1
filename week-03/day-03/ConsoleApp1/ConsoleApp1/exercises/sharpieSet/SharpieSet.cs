using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SharpieSet
    {
        // the list of all sharpies
        public List<Sharpie> sharpieList { get; set; }          // what if private? - use() how???

        // when sharpieset is created, new list of sharpie is initialized
        public SharpieSet()
        {
            sharpieList = new List<Sharpie>();  
        }

        // method for adding sharpies to the SharpieSet aka sharpieList
        public void addSharpie(Sharpie sharpie) 
        {
            // adding given sharpie to the sharpie list
            sharpieList.Add(sharpie);       
        }


        //method for geting number of usable sharpies
        public int CountUsable()            
        {
            int counter = 0;
            foreach (var sharpie in sharpieList)
            {
                if (sharpie.InkAmount > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void RemoveTrash()
        {
            foreach (var sharpie in sharpieList)
            {
                if(sharpie.InkAmount < 0)
                {
                    sharpieList.Remove(sharpie);
                }
            }
        }
    }
}
