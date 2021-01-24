using System;
using System.Collections.Generic;
using System.Text;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            
            myDictionary.Add(1, "Ali");
            myDictionary.Add(2, "Ahmet");
            myDictionary.Add(3, "Zeynep");
            for (int i = 0; i < myDictionary.keys.Length; i++)
            {
                Console.WriteLine(myDictionary.keys[i]+","+myDictionary.values[i]);
            }


           
            


            
        }
    }
}
