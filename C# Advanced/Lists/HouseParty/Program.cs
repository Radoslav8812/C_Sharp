using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var splitedInput = Console.ReadLine().Split();

                if (splitedInput.Contains("not"))
                {
                    if (list.Any(x => x == splitedInput[0]))
                    {
                        list.Remove(splitedInput[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{splitedInput[0]} is not in the list!");
                    }
                }
                else if (splitedInput.Contains("going!"))
                {
                    if (!list.Any(x => x == splitedInput[0]))
                    {
                        list.Add(splitedInput[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{splitedInput[0]} is already in the list!");
                    }
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

