using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            var dishesQue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var freshnessStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            //var cakeFreshness = 300;
            //var lobsterFreshness = 400;
            //var saladFreshness = 250;
            //var sauceFreshness = 150;

            var cakeCount = 0;
            var sauceCount = 0;
            var saladCount = 0;
            var LobsterCount = 0;

            while (true)
            {
                if (dishesQue.Count == 0)
                {
                    break;
                }

                if (freshnessStack.Count == 0)
                {
                    break;
                }

                var ingredient = dishesQue.Peek();
                var freshness = freshnessStack.Peek();

                if (ingredient == 0)
                {
                    dishesQue.Dequeue();
                    continue;
                }

                if (ingredient * freshness == 150)
                {
                    sauceCount++;
                    dishesQue.Dequeue();
                    freshnessStack.Pop();
                }
                else if (ingredient * freshness == 250)
                {
                    saladCount++;
                    dishesQue.Dequeue();
                    freshnessStack.Pop();
                }
                else if (ingredient * freshness == 300)
                {
                    cakeCount++;
                    dishesQue.Dequeue();
                    freshnessStack.Pop();
                }
                else if (ingredient * freshness == 400)
                {
                    LobsterCount++;
                    dishesQue.Dequeue();
                    freshnessStack.Pop();
                }
                else
                {
                    freshnessStack.Pop();
                    var increased = ingredient += 5;
                    dishesQue.Dequeue();
                    dishesQue.Enqueue(increased);
                }
            }

            if (LobsterCount != 0 && saladCount != 0 && saladCount != 0 && cakeCount != 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($"# Chocolate cake --> {cakeCount}");
                Console.WriteLine($"# Dipping sauce --> {sauceCount}");
                Console.WriteLine($"# Green salad --> {saladCount}");
                Console.WriteLine($"# Lobster --> {LobsterCount}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
        }
    }
}

