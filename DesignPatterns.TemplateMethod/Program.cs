using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// The template method pattern defineds the skeleton of an algorithm in a method, deffering some steps to subclasses.
    /// Template method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            coffee.PrepareRecipe();
            Console.WriteLine();
            var tea = new Tea();
            tea.PrepareRecipe();
            Console.ReadLine();
        }
    }
}
