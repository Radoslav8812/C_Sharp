using System;
using System.Linq;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                var value = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, value);
                }
                else
                {
                    dict[resource] += value;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

