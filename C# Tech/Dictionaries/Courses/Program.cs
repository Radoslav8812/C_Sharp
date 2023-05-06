using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var splitedInput = Console.ReadLine().Split(" : ");

                if (splitedInput[0] == "end")
                {
                    break;
                }

                var course = splitedInput[0];
                var name = splitedInput[1];

                if (!dict.ContainsKey(course))
                {
                    dict.Add(course, new HashSet<string>());     
                }

                dict[course].Add(name);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");

                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}

