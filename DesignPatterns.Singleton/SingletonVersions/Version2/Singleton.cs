using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonVersions.Version2
{
    /// <summary>
    /// Simple thread-safety, but low performance
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance;

        private static readonly object padlock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }
    }
}
