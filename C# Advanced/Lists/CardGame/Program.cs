using System;
using System.Linq;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstList.Any() && secondList.Any())
            {
                var firstCard = firstList[0];
                var secondCard = secondList[0];

                if (firstCard > secondCard)
                {
                    firstList.Remove(firstCard);
                    firstList.Add(firstCard);
                    firstList.Add(secondCard);
                    secondList.Remove(secondCard);
                }
                else if (secondCard > firstCard)
                {
                    secondList.Remove(secondCard);
                    secondList.Add(secondCard);
                    secondList.Add(firstCard);
                    firstList.Remove(firstCard);
                }
                else if (firstCard == secondCard)
                {
                    firstList.Remove(firstCard);
                    secondList.Remove(secondCard);
                }
            }

            if (firstList.Count > 0)
            {
                var sum = firstList.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                var sum = secondList.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}

