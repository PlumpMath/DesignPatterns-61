using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaName)
        {
            var pizza = this.CreatePizza(pizzaName);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaName);
    }
}
