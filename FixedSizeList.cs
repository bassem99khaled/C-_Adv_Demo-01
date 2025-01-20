using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; private set; }
        public int Count => count;

        
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException();
            }

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

    
        public void Add(T item)
        {
            if (count >= Capacity)
            {
                throw new InvalidOperationException();
            }

            items[count] = item;
            count++;
        }


        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            return items[index];
        }

     
        public override string ToString()
        {
            return $"FixedSizeList: [{string.Join(", ", items, 0, count)}], Capacity: {Capacity}, Count: {Count}";
        }
    }
}
