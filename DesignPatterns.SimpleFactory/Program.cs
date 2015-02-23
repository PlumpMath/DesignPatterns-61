using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    /// <summary>
    /// The simple factory isn't actually a design pattern, it's programming idiom.
    /// It defines a class that encapsulates the object creation for different kinds of objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(factory);
            pizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            pizzaStore.OrderPizza("pepperony");
            Console.WriteLine();

            var prepackPizzaStore = new PrepackPizzaStore(factory);
            prepackPizzaStore.OrderPrepackPizza("cheese");
            Console.WriteLine();
            prepackPizzaStore.OrderPrepackPizza("pepperony");
            Console.ReadLine();
        }
    }
}
