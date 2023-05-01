using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commandArgs = Console.ReadLine().Split();

            while (true)
            {
                if (commandArgs.Contains("End"))
                {
                    break;
                }

                var command = commandArgs[0];

                if (command == "Add")
                {
                    var itemToAdd = int.Parse(commandArgs[1]);
                    inputList.Add(itemToAdd);
                }

                if (command == "Insert")
                {
                    var number = int.Parse(commandArgs[1]);
                    var index = int.Parse(commandArgs[2]);
                    if (index <= inputList.Count)
                    {
                        inputList.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                }

                if (command == "Remove")
                {
                    var index = int.Parse(commandArgs[1]);

                    if (index <= inputList.Count)
                    {
                        inputList.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                }

                if (commandArgs.Contains("left"))
                {
                    var times = int.Parse(commandArgs[2]);

                    for (int i = 0; i < times; i++)
                    {
                        var number = inputList[0];
                        inputList.Remove(number);
                        inputList.Add(number);
                    }
                }

                if (commandArgs.Contains("right"))
                {
                    var times = int.Parse(commandArgs[2]);

                    for (int i = 0; i < times; i++)
                    {
                        var number = inputList[inputList.Count - 1];
                        inputList.Remove(number);
                        inputList.Insert(0, number);
                    }
                }

                commandArgs = Console.ReadLine().Split();
            }

            foreach (var item in inputList)
            {
                Console.Write(item + " ");
            }
        }
    }
}

