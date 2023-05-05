using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    if (!dict.ContainsKey(text[i]))
                    {
                        dict.Add(text[i], 0);
                    }

                    dict[text[i]]++;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

