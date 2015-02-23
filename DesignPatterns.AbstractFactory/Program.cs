using DesignPatterns.AbstractFactory.PizzaStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// The abstract factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var newYorkStylePizzaStore = new NYStylePizzaStore();
            newYorkStylePizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            newYorkStylePizzaStore.OrderPizza("clam");
            Console.WriteLine();

            var chicagoStylePizzaStore = new ChicagoStylePizzaStore();
            chicagoStylePizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            chicagoStylePizzaStore.OrderPizza("clam");
            Console.ReadLine();
        }
    }
}
