using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Delete")
                {
                    var elementToRemove = int.Parse(command[1]);
                    inputList.RemoveAll(x => x == elementToRemove);
                }

                if (command[0] == "Insert")
                {
                    var elementToInsert = int.Parse(command[1]);
                    var position = int.Parse(command[2]);

                    inputList.Insert(position, elementToInsert);
                }

                command = Console.ReadLine().Split();
            }

            foreach (var item in inputList)
            {
                Console.Write(item + " ");
            }
        }
    }
}

