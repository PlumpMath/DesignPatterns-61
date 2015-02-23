using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngridientFactory pizzaIngridientFactory, string name) : base(pizzaIngridientFactory, name) { }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            this.dough = pizzaIngridientFactory.CreateDough();
            this.sauce = pizzaIngridientFactory.CreateSauce();
            this.cheese = pizzaIngridientFactory.CreateCheese();
            Console.WriteLine("{0}, {1}, {2}", dough.DoughName, sauce.SauceName, cheese.CheeseName);
        }
    }
}
