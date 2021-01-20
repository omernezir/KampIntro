using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // array = dizi
            string[] kurslar = new string[] {"yazlım yetiştirici kampı", 
            "temel programlama kursu",
            "java", "python", "c++ " };








            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            //foreach dizi elemanlarını tek tek dolaşıyor
            //for daha genel kullanım olabilir. foreach direkt dizilerde dolaşmak için.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
