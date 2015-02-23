using DesignPatterns.Composite.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.MenuComponents
{
    public class MenuItem : MenuComponent
    {
        private string name;

        private string description;

        private double price;

        private bool isVegetarian;

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.isVegetarian = isVegetarian;
        }

        public override string Name
        {
            get
            {
                return name;
            }
        }

        public override string Description
        {
            get
            {
                return description;
            }
        }

        public override double Price
        {
            get
            {
                return price;
            }
        }

        public override bool IsVegetarian
        {
            get
            {
                return isVegetarian;
            }
        }

        public override void Print()
        {
            Console.WriteLine("{0}{1}, {2} \n    -- {3}", this.Name, this.IsVegetarian ? " (v)" : "", this.Price, this.Description);
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            return new NullIterator();
        }
    }
}
