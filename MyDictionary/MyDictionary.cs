using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;

            items = new T[items.Length + 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            
            items[items.Length - 1] = item;
            Console.WriteLine(item + " ismi eklendi" );
        }
    }
}
