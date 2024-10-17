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


    }


}
