using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Pizza
    {
        protected string name;

        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            foreach (var topping in this.toppings)
            {
                Console.WriteLine("Adding " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}
