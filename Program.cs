using System;
using System.Collections.Generic;

namespace Fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sequence 
            WriteOutFibonacciSequence(length: 10);

            Console.WriteLine();

            // Specific number
            var number = GetFibonacciNumber(index: 7);
            Console.WriteLine(number);
        }

        static void WriteOutFibonacciSequence(int length)
        {          
            if (length >= 0) Console.Write("0 ");
            if (length >= 1) Console.Write("1 ");

            int n2 = 0, // f(n-2)
                n1 = 1; // f(n-1)
            
            for (var i = 2; i < length; i++)
            {
                var n = n1 + n2; // f(n) = f(n-1) + f(n-2)
                Console.Write($"{n} ");

                n2 = n1;
                n1 = n;
            }
        }

        static int GetFibonacciNumber(int index)
        {
            int n2 = 0, // f(n-2)
            n1 = 1; // f(n-1)

            if (index == 0) return n2;
            if (index == 1) return n1;

            var sequence = new int[index + 1];
            sequence[0] = n2;
            sequence[1] = n1;

            for (var i = 2; i <= index; i++)
            {
                var n = n1 + n2; // f(n) = f(n-1) + f(n-2)
                sequence[i] = n;

                n2 = n1;
                n1 = n;
            }

            return sequence[index];
        }}
}