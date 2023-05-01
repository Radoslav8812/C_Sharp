using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var capacity = int.Parse(Console.ReadLine());
            var list = new List<int>();
            
            foreach (var item in people)
            {
                list.Add(item);
            }

            while (true)
            {
                var splitedInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splitedInput[0] == "end")
                {
                    break;
                }

                if (splitedInput[0] == "Add")
                {
                    list.Add(int.Parse(splitedInput[1]));
                }
                else
                {
                    var element = int.Parse(splitedInput[0]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + element <= capacity)
                        {
                            list[i] += element;
                            break;
                        }
                    }
                } 
            }

            Console.WriteLine(string.Join(" ", list).TrimEnd());
        }
    }
}

