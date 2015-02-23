using DesignPatterns.AbstractFactory.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public abstract class Pizza
    {
        protected Dough dough;

        protected Sauce sauce;

        protected Cheese cheese;

        protected Clams clams;

        protected string name;

        protected IPizzaIngridientFactory pizzaIngridientFactory;

        public Pizza(IPizzaIngridientFactory pizzaIngridientFactory, string name)
        {
            this.pizzaIngridientFactory = pizzaIngridientFactory;
            this.name = name;
        }

        public abstract void Prepare();

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
