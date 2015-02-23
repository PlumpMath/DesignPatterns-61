using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Iterators
{
    public class NullIterator : IEnumerator<MenuComponent>
    {
        public MenuComponent Current
        {
            get
            {
                return null;
            }
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Dispose()
        {
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
