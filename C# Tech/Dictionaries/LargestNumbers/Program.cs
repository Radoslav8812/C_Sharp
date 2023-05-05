using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            //var times = 0;

            //if (input.Count >= 3)
            //{
            //    foreach (var item in input.OrderByDescending(x => x))
            //    {
            //        if (times == 3)
            //        {
            //            break;
            //        }

            //        Console.Write(item + " ");
            //        times++;
            //    }
            //}
            //else
            //{
            //    foreach (var item in input.OrderByDescending(x => x))
            //    {
            //        Console.Write(item + " ");
            //    }
            //}


            Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList().ForEach(Console.WriteLine);
        }
    }
}

