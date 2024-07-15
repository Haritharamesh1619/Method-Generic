using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Generic
{
     class Program
    {
        static void Main(string[] args)
        {
            // Swap integers

            int a = 5;
            int b = 10;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            // Swap strings

            string x = "Hello";
            string y = "World";
            Console.WriteLine($"\nBefore Swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            // Swap doubles

            double p = 1.23;
            double q = 4.56;
            Console.WriteLine($"\nBefore Swap: p = {p}, q = {q}");
            Swap(ref p, ref q);
            Console.WriteLine($"After Swap: p = {p}, q = {q}");
            Console.ReadKey();
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        

    }
}
