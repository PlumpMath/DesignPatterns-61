using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonVersions.Version6
{
    /// <summary>
    /// Thread-safe, fully lazy, high performance, simple, works for .NET 4 and higher
    /// </summary>
    public sealed class Singleton
    {
        private static Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
