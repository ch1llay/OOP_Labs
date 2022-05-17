using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class MyList<T> : IDisposable, IEnumerable, ICollection<T> where T : class
    {
        public List<T> Items { get; set; }

        public int Count { get => Items.Count; }

        public bool IsReadOnly { get; set; }
        public T this[int index]
        {
            get => Items[index];
            set => Items[index] = value;
        }


        // public int Count { get; set; }
        public MyList()
        {
            Items = new List<T>();
        }
        public void Add(T item)
        {
            Items.Add(item);
        }
        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }
        public void Dispose()
        {
            Items.Clear();
        }

        public void Clear()
        {
            Items.Clear();
        }

        public bool Contains(T item)
        {
            return Items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return Items.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }



        ~MyList()
        {
            Items.Clear();
        }
    }
}
