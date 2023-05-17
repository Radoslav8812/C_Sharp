using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ExtractFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("\\");
            var currentItem = input[input.Length - 1];
            var splitedItem = currentItem.Split(".");

            Console.WriteLine($"File name: {splitedItem[0]}");
            Console.WriteLine($"File extension: {splitedItem[1]}");
        }
    }
}

