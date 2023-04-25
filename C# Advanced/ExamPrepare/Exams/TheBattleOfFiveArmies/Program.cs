using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBattleOfFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
             
            var matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                matrix[i] = currentRow;
            }


            var heroRow = 0;
            var heroCol = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'A')
                    {
                        heroRow = i;
                        heroCol = j;
                    }
                }
            }

            while (true)
            {
                var commandLine = Console.ReadLine().Split(' ');
                var command = commandLine[0];
                var orcRow = int.Parse(commandLine[1]);
                var orcCol = int.Parse(commandLine[2]);


                matrix[orcRow][orcCol] = 'O';
                matrix[heroRow][heroCol] = '-';

                if (command == "up" && heroRow - 1 >= 0)
                {
                    heroRow--;
                }
                else if (command == "down" && heroRow + 1 < matrix[heroCol].Length)
                {
                    heroRow++;
                }
                else if (command == "left" && heroCol - 1 >= 0)
                {
                    heroCol--;
                }
                else if (command == "right" && heroCol + 1 < matrix[heroRow].Length)
                {
                    heroCol++;
                }

                if (matrix[heroRow][heroCol] == 'M')
                {
                    matrix[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle world! Armor left: {armor}");
                    break;
                }

                if (matrix[heroRow][heroCol] == 'O')
                {
                    armor -= 2;
                    matrix[heroRow][heroCol] = 'A';
                }

                if (armor <= 0)
                {
                    matrix[heroRow][heroCol] = 'X';
                    Console.WriteLine($"The army was defeated at {heroRow};{heroCol}");
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

