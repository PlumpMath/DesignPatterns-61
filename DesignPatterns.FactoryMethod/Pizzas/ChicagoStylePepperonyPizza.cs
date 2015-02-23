using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Pizzas
{
    public class ChicagoStylePepperonyPizza : Pizza
    {
        public ChicagoStylePepperonyPizza()
        {
            this.name = "Chicago Style Pepperony Pizza";
            this.toppings.Add("Pepperony");
            this.toppings.Add("Mozarella");
            this.toppings.Add("Parmesan");
        }
    }
}
