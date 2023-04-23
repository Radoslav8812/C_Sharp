using System;
using System.Linq;
using System.Collections.Generic;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().ToArray();
            var arr2 = Console.ReadLine().Split().ToArray();

            var resultList = new List<String>();

            for (int i = 0; i < arr2.Length; i++)
            {
                var element = arr2[i];

                for (int j = 0; j < arr1.Length; j++)
                {
                    var element1 = arr1[j];

                    if (element == element1)
                    {
                        resultList.Add(element);
                    }
                }
            }

            foreach (var item in resultList)
            {
                Console.Write(item + " ");
            }
        }
    }
}

