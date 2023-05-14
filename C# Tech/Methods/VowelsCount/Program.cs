using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'u' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}


























            