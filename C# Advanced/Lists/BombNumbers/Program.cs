using System;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commandArgs = Console.ReadLine().Split().Select(int.Parse).ToList();

            var number = commandArgs[0];
            var power = commandArgs[1];

            while (inputList.Contains(number))
            {
                int index = inputList.IndexOf(number);
                int left = Math.Max(0, index - power);
                int right = Math.Min(inputList.Count - 1, index + power);
                inputList.RemoveRange(left, right - left + 1);
            }

            int sum = inputList.Sum();
            Console.WriteLine(sum);
        }
    }
}

