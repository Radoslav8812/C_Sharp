using System;
using System.Linq;
using System.Collections.Generic;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(NewMethod(num1, num2, num3));
        }

        private static int NewMethod(int a, int b, int c)
        {
            var sum = a + b;
            var result = (a + b) - c;

            return result;
        }
    }
}

