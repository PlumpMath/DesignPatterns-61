using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] items;

        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Length && items[position] != null;
        }

        public object Next()
        {
            var result = items[position];
            position++;
            return result;
        }
    }
}
