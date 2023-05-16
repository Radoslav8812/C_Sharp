using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();
            var list = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var word = input[i];

                if (word.Length >= 3 && word.Length <= 16 && Regex.IsMatch(word ,@"^[a-zA-Z0-9_-]+$"))
                {
                    list.Add(word);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

