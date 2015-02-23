using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonVersions.Version1
{
    /// <summary>
    /// Standart singleton implementation, not thread-safe. Don't use it!
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
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
