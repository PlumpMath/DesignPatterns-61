using DesignPatterns.Composite.MenuComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Iterators
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();

        public CompositeIterator(IEnumerator<MenuComponent> iterator) 
        {
            stack.Push(iterator);
        }

        public MenuComponent Current
        {
            get 
            {
                var iterator = stack.Peek();
                var component = iterator.Current;
                if (component is Menu)
                {
                    stack.Push(component.GetEnumerator());
                }

                return component;
            }
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }

            var iterator = stack.Peek();
            if (!iterator.MoveNext())
            {
                stack.Pop();
                return this.MoveNext();
            }

            return true;
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            stack.Clear();
        }

        public void Reset()
        {
            throw new InvalidOperationException();
        }
    }
}
