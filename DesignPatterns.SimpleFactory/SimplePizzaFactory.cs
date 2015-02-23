using DesignPatterns.SimpleFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaName)
        {
            if (pizzaName == "cheese")
            {
                return new CheesePizza();
            }

            if (pizzaName == "pepperony")
            {
                return new PepperonyPizza();
            }

            return null;
        }
    }
}
