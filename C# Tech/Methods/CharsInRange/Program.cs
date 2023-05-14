using System;
using System.Collections.Generic;

namespace CharsInRange
{
    class Program
    {

        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintCharactersBetweenExceptFirstAndLast(first, second); // Output: "b c"
        }

        public static void PrintCharactersBetweenExceptFirstAndLast(char start, char end)
        {
            // ensure that the start character is less than the end character
            if (start > end)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            // iterate through the characters between the start and end characters and print them,
            // skipping the first and last character
            for (char c = (char)(start + 1); c < end; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine(); // move to the next line after printing all the characters
        }
    }
}

