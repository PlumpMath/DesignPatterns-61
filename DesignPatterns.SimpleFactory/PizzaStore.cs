using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(string pizzaName)
        {
            var pizza = factory.CreatePizza(pizzaName);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
