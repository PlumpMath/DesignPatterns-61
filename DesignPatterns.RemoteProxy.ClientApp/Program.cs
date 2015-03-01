using DesignPatterns.RemoteProxy.ClientApp.ActualPrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RemoteProxy.ClientApp
{
    /// <summary>
    /// The proxy pattern provides a surrogate for another object to control access to it.
    /// A remote proxy controls access to a remote object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var actualPricesProxy = new ActualPricesClient();
            Console.WriteLine("USD to UAH: {0}", actualPricesProxy.GetUsdToUah());
            Console.WriteLine("Euro to UAH: {0}", actualPricesProxy.GetEuroToUah());
            Console.ReadLine();
        }
    }
}
