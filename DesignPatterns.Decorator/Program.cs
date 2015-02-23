using DesignPatterns.Decorator.Beverages;
using DesignPatterns.Decorator.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// The decorator pattern attaches additional responsibilities to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var decafWithMilk = new Milk(new Decaf());
            Console.WriteLine("Description: {0}\nCost={1}", decafWithMilk.Description, decafWithMilk.Cost);

            var espressoWithMilkAndWhip = new Whip(new Milk(new Expresso()));
            Console.WriteLine("Description: {0}\nCost={1}", espressoWithMilkAndWhip.Description, espressoWithMilkAndWhip.Cost);
            Console.ReadLine();
        }
    }
}
