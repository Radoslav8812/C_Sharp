using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                }

                dict[name].Add(grade);
            }

            foreach (var kvp in dict.OrderByDescending(x => dict.Values).ThenByDescending(x => dict.Keys))
            {
                if (kvp.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average()}");
                }
                
            }
        }
    }
}

