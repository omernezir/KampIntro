using System;

namespace ternanyOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            if (a>=b)
            {
                Console.WriteLine("a b den büyük eşit");
            }
            else
            {
                Console.WriteLine("a b den küçük");
            }

            Console.WriteLine("if else bloku bitti");

            var result = a >= b ? "a b den büyük eşit" : "a b den küçük";
            Console.WriteLine(result);
        }
    }
}
