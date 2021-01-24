using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<K, V>
    {
        public K[] keys;
        public V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }
        public void Add(K key, V value)
        {
            K[] tempArray1 = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
                
            }

            keys[keys.Length - 1] = key;
            //Console.WriteLine(keys[0]);

            V[] tempArray2 = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i];
            }

            values[values.Length - 1] = value;
        }
       
    }
}
