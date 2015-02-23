using DesignPatterns.FactoryMethod.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.PizzaStores
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaName)
        {
            if (pizzaName == "cheese")
            {
                return new NYStyleCheesePizza();
            }

            if (pizzaName == "pepperony")
            {
                return new NYStylePepperonyPizza();
            }

            return null;
        }
    }
}
