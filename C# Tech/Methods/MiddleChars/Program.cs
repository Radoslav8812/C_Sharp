using System;
using System.Linq;
using System.Collections.Generic;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        public static void PrintMiddleCharacter(string str)
        {
            int length = str.Length;

            if (length % 2 != 0)
            {
                int middleIndex = length / 2;
                Console.WriteLine(str[middleIndex].ToString());
            }
            else
            {
                int middleIndex = length / 2;
                Console.WriteLine(str[middleIndex - 1].ToString() + str[middleIndex].ToString());
            }
        }
    }
}

