using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            this.name = "NY Style Cheese Pizza";
            this.toppings.Add("Regiano Cheese");
        }
    }
}
