using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    public abstract class Pizza
    {
        protected string Name { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
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
