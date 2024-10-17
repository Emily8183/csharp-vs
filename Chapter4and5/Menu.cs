using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4and5
{
    public class Menu
    {
        private List<MenuItem> items;

        //instance methods

        public void AddItems(MenuItem item)
        {
            items.Add(item); 
        }

        public void RemoveItems(MenuItem item)
        {
            items.Remove(item);
        }

        


    }
}
