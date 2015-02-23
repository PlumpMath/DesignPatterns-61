using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonVersions.Version3
{
    /// <summary>
    /// Thread-safe, but not simple enough, performance is still not good enough
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
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
