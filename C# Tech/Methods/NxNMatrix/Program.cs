using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            PrintMatrix(input);
        }

        public static void PrintMatrix(int n)
        {
            // iterate through the rows
            for (int i = 0; i < n; i++)
            {
                // iterate through the columns
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine(); // move to the next line after printing a row
            }
        }
    }
}

