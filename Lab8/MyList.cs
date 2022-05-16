using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class MyList<T> : IDisposable where T : class
    {
        public List<T> Items { get; set; }
        public int Count { get; set; }
        public MyList()
        {
            Items = new List<T>();
            Count = 0;
        }
        public void Add(T item)
        {
            Items.Add(item);
        }
        public void Delete(int index)
        {
            Items.RemoveAt(index);
        }
        public void Dispose()
        {
            Items.Clear();
        }
        ~MyList()
        {
            Items.Clear();
        }
    }
}
