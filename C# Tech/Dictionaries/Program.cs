using System;
using System.Linq;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var splitedInput = Console.ReadLine().Split();
                var key = splitedInput[0];
                var value = int.Parse(splitedInput[1]);

                dict.Add(key, value);
            }


            Console.WriteLine();
            foreach (var item in dict.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}

