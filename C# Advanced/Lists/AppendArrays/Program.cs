using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitedInput = input.Split('|');
        int[][] jaggedArray = new int[splitedInput.Length][];
        int totalLength = 0;

        for (int i = 0; i < splitedInput.Length; i++)
        {
            string[] valueStrings = splitedInput[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] values = new int[valueStrings.Length];

            for (int j = 0; j < valueStrings.Length; j++)
            {
                values[j] = int.Parse(valueStrings[j]);
            }

            jaggedArray[splitedInput.Length - i - 1] = values;
            totalLength += values.Length;
        }

        int[] result = new int[totalLength];
        int startIndex = 0;

        foreach (var item in jaggedArray)
        {
            Array.Copy(item, 0, result, startIndex, item.Length);
            startIndex += item.Length;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}