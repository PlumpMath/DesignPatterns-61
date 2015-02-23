using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class MenuComponent : IEnumerable<MenuComponent>
    {
        #region comosite methods

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new InvalidOperationException();
        }

        #endregion

        #region operation methods

        public virtual string Name
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        public virtual string Description
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        public virtual double Price
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        public virtual bool IsVegetarian
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        #endregion

        public virtual void Print()
        {
            throw new InvalidOperationException();
        }

        #region ienumerable methods

        public virtual IEnumerator<MenuComponent> GetEnumerator()
        {
            throw new InvalidOperationException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}
