using System;
using System.Collections.Generic;

namespace Fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(GetFibonacciNumber(i));
            }

            WriteOutFinbonacciSeries(10);
        }

        static int GetFibonacciNumber(int index)
        {
            var n2 = 0;
            var n1 = 1;

            if (index == 0) return n2;
            if (index == 1) return n1;

            var sequence = new int[index + 1];
            sequence[0] = n2;
            sequence[1] = n1;

            for (var i = 2; i <= index; i++)
            {
                var n = n1 + n2;
                sequence[i] = n;

                n2 = n1;
                n1 = n;
            }

            return sequence[index];
        }

        static void WriteOutFinbonacciSeries(int length)
        {
            Console.Write("0 ");
            Console.Write("1 ");

            int n2 = 0, n1 = 1;

            for (var i = 2; i < length; i++)
            {
                var n = n1 + n2;
                Console.Write($"{n} ");

                n2 = n1;
                n1 = n;
            }
        }
    }
}