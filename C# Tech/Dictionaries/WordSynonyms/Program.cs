using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                }

                dict[word].Add(synonym);                                  
            }

            foreach (var item in dict)
            {
                var word = item.Key;
                var synonym = item.Value;

                Console.WriteLine($"{word} -> {String.Join(", ", synonym)}");
            }
        }
    }
}

