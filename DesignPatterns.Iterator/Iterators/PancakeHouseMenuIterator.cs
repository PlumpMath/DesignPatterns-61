using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Iterators
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<MenuItem> items;

        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Count;
        }

        public object Next()
        {
            var result = items[position];
            position++;
            return result;
        }
    }
}
