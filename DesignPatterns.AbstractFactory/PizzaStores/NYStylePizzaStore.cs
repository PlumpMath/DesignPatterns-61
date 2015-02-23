using DesignPatterns.AbstractFactory.IngridientFactories;
using DesignPatterns.AbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.PizzaStores
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaName)
        {
            var pizzaIngridientFactory = new NYPizzaIngridientFactory();
            if (pizzaName == "cheese")
            {
                return new CheesePizza(pizzaIngridientFactory, "NY Style Cheese Pizza");
            }

            if (pizzaName == "clam")
            {
                return new ClamsPizza(pizzaIngridientFactory, "NY Style Clam Pizza");
            }

            return null;
        }
    }
}
