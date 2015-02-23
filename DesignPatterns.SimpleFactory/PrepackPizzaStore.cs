using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    public class PrepackPizzaStore
    {
        private SimplePizzaFactory factory;

        public PrepackPizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPrepackPizza(string pizzaName)
        {
            var pizza = factory.CreatePizza(pizzaName);
            pizza.Prepare();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
