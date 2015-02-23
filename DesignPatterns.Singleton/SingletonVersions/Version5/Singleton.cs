using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonVersions.Version5
{
    /// <summary>
    /// Thread-safe, fully lazy, high performance
    /// </summary>
    public sealed class Singleton
    {
        private Singleton() { }

        private class Nested
        {
            /// <summary>
            /// Explicit static constructor to tell the C# compiler not to mark type as beforefieldinit
            /// </summary>
            static Nested() { }

            internal static readonly Singleton instance = new Singleton();
        }

        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }
    }
}
