using DesignPatterns.ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    /// <summary>
    /// The chain of responsibility pattern gives more than one object a chance to handle a request.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var vicePresident = new VicePresident();
            var president = new President();

            director.Successor = vicePresident;
            vicePresident.Successor = president;

            var purchase = new Purchase(1, 2000);
            director.ProcessRequest(purchase);

            purchase = new Purchase(2, 20000);
            director.ProcessRequest(purchase);

            purchase = new Purchase(3, 100000);
            director.ProcessRequest(purchase);

            Console.ReadLine();
        }
    }
}
