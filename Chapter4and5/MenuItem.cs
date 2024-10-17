using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4and5
{
    public class MenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime TimeAdded { get; }


        public MenuItem(string name, int price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            TimeAdded = DateTime.Now;
        }

        public override string ToString()
        {
            string newLine = Environment.NewLine;
            return newLine + Name + "," + Description + "," + TimeAdded.ToString();
        }

        public override bool Equals(object? toBeCompared)
        {
            // Reference check
            if (this == toBeCompared)
            {
                return true;
            }

            // Null check
            if (toBeCompared == null)
            {
                return false;
            }

            // Class check
            if (GetType() != toBeCompared.GetType())
            {
                return false;
            }

            // Cast to class
            MenuItem otherItem = (MenuItem)toBeCompared;

            // Compare
            return Name == otherItem.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
        public bool IsNew()
        {
            TimeSpan age = DateTime.Now.Subtract(TimeAdded);
            int daysOld = age.Days;
            return daysOld < 120;
        }



    }


}
