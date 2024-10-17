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
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        //above can also set up as public with getter and setter
        //public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); // or new() or []
        //public DateTime LastUpdated { get; set; } = DateTime.Now;

        //public void AddItem(MenuItem item)
        //{
        //    items.Add(item); 
        //}

        public void AddItem(MenuItem newItem)
        {
            if (items.Contains(newItem))
            {
                Console.WriteLine("Item can't be added due to the duplication");

            }
            else
            {
                items.Add(newItem);
                LastUpdated = DateTime.Now;
                newItem.TimeAdded = DateTime.Now;
            }
        }
        public void RemoveItem(MenuItem item)
        {
            items.Remove(item);
            LastUpdated = DateTime.Now;
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


        //find if the item already exists in the menu
        public int findItem (string name)
        {
            foreach (MenuItem item in items)
            {
                if (Equals(item.Name, name))
                {
                    return items.IndexOf(item);
                } 
            }

            return -1;
        }

        public override bool Equals(object? toBeCompared)
        {
            //reference check
            if (this == toBeCompared) return true;

            //null check
            if (toBeCompared == null) return false;

            //class check
            if (GetType() != toBeCompared.GetType()) return false;

            //cast
            Menu otherMenu = (Menu) toBeCompared;

            //custom comparison of contents
            if (items.Count != otherMenu.items.Count) return false;

            foreach (MenuItem item in items)
            {
                int index = otherMenu.findItem(item.Name);
                if (index != -1) return false;
            }

            //otherwise return true
            return true;
        }

    }
}
