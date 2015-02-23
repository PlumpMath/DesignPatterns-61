using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.name = "Chicago Style Cheese Pizza";
            this.toppings.Add("Mozarella Cheese");
        }
    }
}
