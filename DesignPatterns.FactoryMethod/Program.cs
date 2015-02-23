using DesignPatterns.FactoryMethod.PizzaStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    /// The factory method pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate.
    /// Factory method lets a class defer instantiation to subclasses.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NYStylePizzaStore();
            store.OrderPizza("cheese");
            Console.WriteLine();
            store.OrderPizza("pepperony");
            Console.WriteLine();

            store = new ChicagoStylePizzaStore();
            store.OrderPizza("cheese");
            Console.WriteLine();
            store.OrderPizza("pepperony");
            Console.ReadLine();
        }
    }
}
