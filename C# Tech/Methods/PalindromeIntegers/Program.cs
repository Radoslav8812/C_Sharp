using System;
using System.Linq;
using System.Collections.Generic;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input = NewMethod(input);
        }

        private static string NewMethod(string input)
        {
            while (true)
            {
                if (input == "END")
                {
                    break;
                }

                if (input.Length == 1)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    var first = input[0];
                    var last = input[input.Length - 1];

                    if (first == last)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }

                input = Console.ReadLine();
            }

            return input;
        }
    }
}

