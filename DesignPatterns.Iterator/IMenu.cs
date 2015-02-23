using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IMenu
    {
        string Name { get; }

        IIterator CreateIterator();

        void AddItem(string name, string description, bool isVegetarian, double price);
    }
}
