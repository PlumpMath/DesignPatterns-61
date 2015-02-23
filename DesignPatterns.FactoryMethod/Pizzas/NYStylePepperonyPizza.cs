using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Pizzas
{
    public class NYStylePepperonyPizza : Pizza
    {
        public NYStylePepperonyPizza()
        {
            this.name = "NY Style Pepperony Pizza";
            this.toppings.Add("Pepperony");
            this.toppings.Add("Regiano");
            this.toppings.Add("Mushrooms");
        }
    }
}
