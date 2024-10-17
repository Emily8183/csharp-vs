using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4and5
{
    public class Menu
    {
        private List<MenuItem> items = new List<MenuItem>();

        //instance methods

        public void AddItems(MenuItem item)
        {
            items.Add(item); 
        }

        public void RemoveItems(MenuItem item)
        {
            items.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();

            foreach (MenuItem item in items)
            {
                stringbuilder.Append(item); // implicit call to .ToString()
                stringbuilder.Append(Constants.DOT_LINE);
            }

            return stringbuilder.ToString();
        }

    }
}
