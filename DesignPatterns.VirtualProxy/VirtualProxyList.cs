using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VirtualProxy
{
    public class VirtualProxyList<T> : IList<T>
    {
        private readonly Func<IList<T>> fetcher;

        private readonly object locker = new object();

        private IList<T> innerList;

        public VirtualProxyList(Func<IList<T>> fetcher)
        {
            this.fetcher = fetcher;
        }

        private IList<T> InnerList
        {
            get
            {
                if (innerList == null)
                {
                    lock (locker)
                    {
                        if (innerList == null)
                        {
                            innerList = fetcher();
                        }
                    }
                }

                return innerList;
            }
        }

        public int IndexOf(T item)
        {
            return InnerList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            InnerList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }

        public T this[int index]
        {
            get
            {
                return InnerList[index];
            }
            set
            {
                InnerList[index] = value;
            }
        }

        public void Add(T item)
        {
            InnerList.Add(item);
        }

        public void Clear()
        {
            InnerList.Clear();
        }

        public bool Contains(T item)
        {
            return InnerList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            InnerList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return InnerList.Count; }
        }

        public bool IsReadOnly
        {
            get { return InnerList.IsReadOnly; }
        }

        public bool Remove(T item)
        {
            return InnerList.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerList.GetEnumerator();
        }
    }
}
