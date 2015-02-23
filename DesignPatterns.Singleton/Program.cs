using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// The singleton pattern ensures a class has only one instance, and provides a global point of access to it
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    var boiler = ChocolateBoiler.Instance;
                    boiler.Fill();
                });
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    var boiler = ChocolateBoiler.Instance;
                    boiler.Boil();
                });
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    var boiler = ChocolateBoiler.Instance;
                    boiler.Drain();
                });
            }

            Console.ReadLine();
        }
    }
}
