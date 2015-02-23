using DesignPatterns.FactoryMethod.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.PizzaStores
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaName)
        {
            if (pizzaName == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }

            if (pizzaName == "pepperony")
            {
                return new ChicagoStylePepperonyPizza();
            }

            return null;
        }
    }
}
