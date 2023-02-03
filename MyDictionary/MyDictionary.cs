using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T, V>
    {
        T[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new V[0];
        }

        public void Add(T key, V value)
        {
            T[] tempArrayK = keys;
            V[] tempArrayV = values;

            keys = new T[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                keys[i] = tempArrayK[i];
                values[i] = tempArrayV[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"Key: {keys[i]}" + $" Value: {values[i]}");
            }
        }

    }
}
