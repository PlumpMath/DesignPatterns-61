using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class ChocolateBoiler
    {
        private static readonly ChocolateBoiler instance = new ChocolateBoiler();

        private readonly object padlock = new object();

        private bool isEmpty;

        private bool isBoiled;

        static ChocolateBoiler() { }

        private ChocolateBoiler()
        {
            isEmpty = true;
            isBoiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                return instance;
            }
        }

        public void Fill()
        {
            lock (padlock)
            {
                if (isEmpty)
                {
                    Console.WriteLine("Filling the boiler");
                    isEmpty = false;
                    isBoiled = false;
                }
            }
        }

        public void Boil()
        {
            lock (padlock)
            {
                if (!isEmpty && !isBoiled)
                {
                    Console.WriteLine("Boiling");
                    isBoiled = true;
                }
            }
        }

        public void Drain()
        {
            lock (padlock)
            {
                if (!isEmpty && isBoiled)
                {
                    Console.WriteLine("Draining the boiler");
                    isEmpty = true;
                }
            }
        }
    }
}
