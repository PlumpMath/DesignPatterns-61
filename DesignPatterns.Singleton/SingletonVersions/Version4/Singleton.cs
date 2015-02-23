using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonVersions.Version4
{
    /// <summary>
    /// Thread-safe, high performance, simple, but not lazy enough.
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        /// <summary>
        ///Explicit static constructor to tell the C# compiler not to mark type as beforefieldinit
        /// </summary>
        static Singleton() { }

        private Singleton() {}

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
